using LZ4;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using SevenZip;
namespace Decompression
{
    // Token: 0x0200003A RID: 58
    public class AssetBundle
    {
        // Token: 0x17000022 RID: 34
        // (get) Token: 0x0600013C RID: 316 RVA: 0x00002ED1 File Offset: 0x000010D1
        public string Signature { get; }

        // Token: 0x17000023 RID: 35
        // (get) Token: 0x0600013D RID: 317 RVA: 0x00002ED9 File Offset: 0x000010D9
        public int FormatVersion { get; }

        // Token: 0x17000024 RID: 36
        // (get) Token: 0x0600013E RID: 318 RVA: 0x00002EE1 File Offset: 0x000010E1
        public string UnityVersion { get; }

        // Token: 0x17000025 RID: 37
        // (get) Token: 0x0600013F RID: 319 RVA: 0x00002EE9 File Offset: 0x000010E9
        public string GeneratorVersion { get; }

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x06000140 RID: 320 RVA: 0x00002EF1 File Offset: 0x000010F1
        public long FileSize { get; }

        // Token: 0x17000027 RID: 39
        // (get) Token: 0x06000141 RID: 321 RVA: 0x00002EF9 File Offset: 0x000010F9
        public uint CompressedBlockSize { get; }

        // Token: 0x17000028 RID: 40
        // (get) Token: 0x06000142 RID: 322 RVA: 0x00002F01 File Offset: 0x00001101
        public uint UncompressedBlockSize { get; }

        // Token: 0x17000029 RID: 41
        // (get) Token: 0x06000143 RID: 323 RVA: 0x00002F09 File Offset: 0x00001109
        public uint Flags { get; }

        // Token: 0x1700002A RID: 42
        // (get) Token: 0x06000144 RID: 324 RVA: 0x00002F11 File Offset: 0x00001111
        public CompressionType Compression
        {
            get
            {
                return (CompressionType)(this.Flags & 63u);
            }
        }

        // Token: 0x1700002B RID: 43
        // (get) Token: 0x06000145 RID: 325 RVA: 0x00002F1C File Offset: 0x0000111C
        public ReadOnlyCollection<AssetBlock> AssetBlocks
        {
            get
            {
                return new ReadOnlyCollection<AssetBlock>(this._assetBlocks);
            }
        }

        // Token: 0x1700002C RID: 44
        // (get) Token: 0x06000146 RID: 326 RVA: 0x00002F29 File Offset: 0x00001129
        public ReadOnlyCollection<AssetNode> AssetNodes
        {
            get
            {
                return new ReadOnlyCollection<AssetNode>(this._assetNodes);
            }
        }

        // Token: 0x1700002D RID: 45
        // (get) Token: 0x06000147 RID: 327 RVA: 0x00002F36 File Offset: 0x00001136
        private byte[] UncompressedBlock { get; }

        // Token: 0x1700002E RID: 46
        // (get) Token: 0x06000148 RID: 328 RVA: 0x00002F3E File Offset: 0x0000113E
        private byte[] DecoderProperties { get; } = new byte[5];

        // Token: 0x1700002F RID: 47
        // (get) Token: 0x06000149 RID: 329 RVA: 0x00002F46 File Offset: 0x00001146
        private byte[] UncompressedBlockNodeHeader { get; }

        // Token: 0x0600014A RID: 330 RVA: 0x00008D74 File Offset: 0x00006F74
        public AssetBundle(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    this.Signature = binaryReader.ReadCString();
                    if (this.Signature != "UnityFS")
                    {
                        throw new NotSupportedException("Unsupported file signature.");
                    }
                    this.FormatVersion = binaryReader.ReadInt32BE();
                    this.UnityVersion = binaryReader.ReadCString();
                    this.GeneratorVersion = binaryReader.ReadCString();
                    this.FileSize = binaryReader.ReadInt64BE();
                    this.CompressedBlockSize = binaryReader.ReadUInt32BE();
                    this.UncompressedBlockSize = binaryReader.ReadUInt32BE();
                    this.Flags = binaryReader.ReadUInt32BE();
                    BinaryReader binaryReader2 = binaryReader;
                    if (this.Compression != CompressionType.None)
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        byte[] array = new byte[this.CompressedBlockSize];
                        byte[] array2 = new byte[this.UncompressedBlockSize];
                        binaryReader.Read(array, 0, array.Length);
                        LZ4Codec.Decode(array, 0, array.Length, array2, 0, array2.Length, true);
                        memoryStream.Write(array2, 0, array2.Length);
                        memoryStream.Position = 0L;
                        binaryReader2 = new BinaryReader(memoryStream);
                    }
                    binaryReader2.ReadBytes(16);
                    int num = binaryReader2.ReadInt32BE();
                    for (int i = 0; i < num; i++)
                    {
                        this._assetBlocks.Add(AssetBlock.FromReader(binaryReader2));
                    }
                    int num2 = binaryReader2.ReadInt32BE();
                    for (int j = 0; j < num2; j++)
                    {
                        this._assetNodes.Add(AssetNode.FromReader(binaryReader2));
                    }
                    if (binaryReader2 != binaryReader)
                    {
                        binaryReader2.Close();
                    }
                    AssetBlock assetBlock = this._assetBlocks.First<AssetBlock>();
                    this.UncompressedBlock = new byte[assetBlock.UncompressedSize];
                    binaryReader.Read(this.DecoderProperties, 0, this.DecoderProperties.Length);
                    if (assetBlock.Compression != CompressionType.None)
                    {
                        if (assetBlock.Compression == CompressionType.LZMA)
                        {
                            byte[] array3 = new byte[assetBlock.CompressedSize];
                            binaryReader.Read(array3, 0, array3.Length);
                            using (MemoryStream memoryStream2 = new MemoryStream(array3))
                            {
                                using (MemoryStream memoryStream3 = new MemoryStream(this.UncompressedBlock))
                                {
                                    SevenZip.Compression.LZMA.Decoder decoder = new SevenZip.Compression.LZMA.Decoder();
                                    decoder.SetDecoderProperties(this.DecoderProperties);
                                    decoder.Code(memoryStream2, memoryStream3, (long)assetBlock.CompressedSize, (long)assetBlock.UncompressedSize, null);
                                    return;
                                }
                            }
                        }
                        throw new NotSupportedException("Compression type not supported.");
                    }
                    binaryReader.Read(this.UncompressedBlock, 0, assetBlock.UncompressedSize);
                }
            }
        }

        // Token: 0x0600014B RID: 331 RVA: 0x00009060 File Offset: 0x00007260
        public void SetAvatarId(string avatarId)
        {
            for (int i = 0; i < this.UncompressedBlock.Length - 41; i++)
            {
                if (this.UncompressedBlock[i] == 97 && this.UncompressedBlock[i + 1] == 118 && this.UncompressedBlock[i + 2] == 116 && this.UncompressedBlock[i + 3] == 114)
                {
                    Array.Copy(Encoding.ASCII.GetBytes(avatarId), 0, this.UncompressedBlock, i, 41);
                    i += 41;
                }
            }
        }

        // Token: 0x0600014C RID: 332 RVA: 0x000090D8 File Offset: 0x000072D8
        public void SaveTo(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                this.SaveTo(fileStream);
            }
        }

        // Token: 0x0600014D RID: 333 RVA: 0x00009114 File Offset: 0x00007314
        public void SaveTo(Stream stream)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(stream))
            {
                uint value = 0u;
                uint value2 = 0u;
                binaryWriter.WriteCString(this.Signature);
                binaryWriter.WriteInt32BE(this.FormatVersion);
                binaryWriter.WriteCString(this.UnityVersion);
                binaryWriter.WriteCString(this.GeneratorVersion);
                long position = binaryWriter.BaseStream.Position;
                binaryWriter.BaseStream.Write(new byte[16], 0, 16);
                binaryWriter.WriteUInt32BE(this.Flags);
                using (MemoryStream memoryStream = new MemoryStream(this.UncompressedBlock))
                {
                    using (MemoryStream memoryStream2 = new MemoryStream())
                    {
                        SevenZip.Compression.LZMA.Encoder encoder = new SevenZip.Compression.LZMA.Encoder();
                        encoder.SetCoderProperties(new CoderPropID[]
                        {
                            (SevenZip.CoderPropID)1,
                            (SevenZip.CoderPropID)5,
                            (SevenZip.CoderPropID)6,
                            (SevenZip.CoderPropID)7,
                            (SevenZip.CoderPropID)12,
                            (SevenZip.CoderPropID)8,
                           (SevenZip.CoderPropID) 9,
                            (SevenZip.CoderPropID)14
                        }, new object[]
                        {
                            BitConverter.ToInt32(this.DecoderProperties, 1),
                            2,
                            3,
                            0,
                            2,
                            128,
                            "bt4",
                            true
                        });
                        encoder.Code(memoryStream, memoryStream2, memoryStream.Length, (long)(this.AssetBlocks.First<AssetBlock>().CompressedSize * 2), null);
                        memoryStream2.Position = 0L;
                        using (MemoryStream memoryStream3 = new MemoryStream())
                        {
                            using (BinaryWriter binaryWriter2 = new BinaryWriter(memoryStream3))
                            {
                                binaryWriter2.Write(new byte[16], 0, 16);
                                binaryWriter2.WriteInt32BE(this._assetBlocks.Count);
                                foreach (AssetBlock assetBlock in this._assetBlocks)
                                {
                                    assetBlock.ToWriter(binaryWriter2, (int)memoryStream.Length, (int)memoryStream2.Length);
                                }
                                binaryWriter2.WriteInt32BE(this._assetNodes.Count);
                                foreach (AssetNode assetNode in this._assetNodes)
                                {
                                    assetNode.ToWriter(binaryWriter2, -1L, 0L);
                                }
                                byte[] array = LZ4Codec.EncodeHC(memoryStream3.ToArray(), 0, (int)memoryStream3.Length);
                                value = (uint)array.Length;
                                value2 = (uint)memoryStream3.Length;
                                binaryWriter.Write(array);
                            }
                        }
                        encoder.WriteCoderProperties(stream);
                        memoryStream2.WriteTo(stream);
                    }
                }
                binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);
                binaryWriter.WriteInt64BE(binaryWriter.BaseStream.Length);
                binaryWriter.WriteUInt32BE(value);
                binaryWriter.WriteUInt32BE(value2);
            }
        }

        // Token: 0x0600014E RID: 334 RVA: 0x0000947C File Offset: 0x0000767C
        public override string ToString()
        {
            return string.Format("Signature: {0}\nFormatVersion: {1}\nUnityVersion: {2}\nGeneratorVersion: {3}\nFileSize: {4}\nCompressedBlockSize: {5}\nUncompressedBlockSize: {6}\nFlags: {7}", new object[]
            {
                this.Signature,
                this.FormatVersion,
                this.UnityVersion,
                this.GeneratorVersion,
                this.FileSize,
                this.CompressedBlockSize,
                this.UncompressedBlockSize,
                this.Flags
            });
        }

        // Token: 0x04000121 RID: 289
        private List<AssetBlock> _assetBlocks = new List<AssetBlock>();

        // Token: 0x04000122 RID: 290
        private List<AssetNode> _assetNodes = new List<AssetNode>();
    }
}
