using System;
using System.IO;

namespace Decompression
{
    // Token: 0x02000039 RID: 57
    public class AssetBlock
    {
        // Token: 0x1700001E RID: 30
        // (get) Token: 0x06000134 RID: 308 RVA: 0x00002E11 File Offset: 0x00001011
        public int UncompressedSize { get; }

        // Token: 0x1700001F RID: 31
        // (get) Token: 0x06000135 RID: 309 RVA: 0x00002E19 File Offset: 0x00001019
        public int CompressedSize { get; }

        // Token: 0x17000020 RID: 32
        // (get) Token: 0x06000136 RID: 310 RVA: 0x00002E21 File Offset: 0x00001021
        public short Flags { get; }

        // Token: 0x17000021 RID: 33
        // (get) Token: 0x06000137 RID: 311 RVA: 0x00002E29 File Offset: 0x00001029
        public CompressionType Compression
        {
            get
            {
                return (CompressionType)(this.Flags & 63);
            }
        }

        // Token: 0x06000138 RID: 312 RVA: 0x00002E34 File Offset: 0x00001034
        public AssetBlock(int uncompressedSize, int compressedSize, short flags)
        {
            this.UncompressedSize = uncompressedSize;
            this.CompressedSize = compressedSize;
            this.Flags = flags;
        }

        // Token: 0x06000139 RID: 313 RVA: 0x00002E51 File Offset: 0x00001051
        public override string ToString()
        {
            return string.Format("Uncompressed size: {0}, Compressed size: {1}, Flags: {2}", this.UncompressedSize, this.CompressedSize, this.Flags);
        }

        // Token: 0x0600013A RID: 314 RVA: 0x00002E7E File Offset: 0x0000107E
        public static AssetBlock FromReader(BinaryReader reader)
        {
            return new AssetBlock(reader.ReadInt32BE(), reader.ReadInt32BE(), reader.ReadInt16BE());
        }

        // Token: 0x0600013B RID: 315 RVA: 0x00002E97 File Offset: 0x00001097
        public void ToWriter(BinaryWriter writer, int uncompressedSize = 0, int compressedSize = 0)
        {
            uncompressedSize = ((uncompressedSize <= 0) ? this.UncompressedSize : uncompressedSize);
            compressedSize = ((compressedSize <= 0) ? this.CompressedSize : compressedSize);
            writer.WriteInt32BE(uncompressedSize);
            writer.WriteInt32BE(compressedSize);
            writer.WriteInt16BE(this.Flags);
        }
    }
}
