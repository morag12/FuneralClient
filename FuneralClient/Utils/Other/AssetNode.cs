using System;
using System.IO;

namespace Decompression
{
    // Token: 0x0200003B RID: 59
    public class AssetNode
    {
        // Token: 0x17000030 RID: 48
        // (get) Token: 0x0600014F RID: 335 RVA: 0x00002F4E File Offset: 0x0000114E
        public long Offset { get; }

        // Token: 0x17000031 RID: 49
        // (get) Token: 0x06000150 RID: 336 RVA: 0x00002F56 File Offset: 0x00001156
        public long Size { get; }

        // Token: 0x17000032 RID: 50
        // (get) Token: 0x06000151 RID: 337 RVA: 0x00002F5E File Offset: 0x0000115E
        public int Flags { get; }

        // Token: 0x17000033 RID: 51
        // (get) Token: 0x06000152 RID: 338 RVA: 0x00002F66 File Offset: 0x00001166
        public string Name { get; }

        // Token: 0x06000153 RID: 339 RVA: 0x00002F6E File Offset: 0x0000116E
        public AssetNode(long offset, long size, int flags, string name)
        {
            this.Offset = offset;
            this.Size = size;
            this.Flags = flags;
            this.Name = name;
        }

        // Token: 0x06000154 RID: 340 RVA: 0x000094FC File Offset: 0x000076FC
        public override string ToString()
        {
            return string.Format("Offset: {0}, Size: {1}, Flags: {2}, Name: {3}", new object[]
            {
                this.Offset,
                this.Size,
                this.Flags,
                this.Name
            });
        }

        // Token: 0x06000155 RID: 341 RVA: 0x00002F93 File Offset: 0x00001193
        public static AssetNode FromReader(BinaryReader reader)
        {
            return new AssetNode(reader.ReadInt64BE(), reader.ReadInt64BE(), reader.ReadInt32BE(), reader.ReadCString());
        }

        // Token: 0x06000156 RID: 342 RVA: 0x0000954C File Offset: 0x0000774C
        public void ToWriter(BinaryWriter writer, long offset = -1L, long size = 0L)
        {
            size = ((size <= 0L) ? this.Size : size);
            offset = ((offset <= -1L) ? this.Offset : offset);
            writer.WriteInt64BE(offset);
            writer.WriteInt64BE(size);
            writer.WriteInt32BE(this.Flags);
            writer.WriteCString(this.Name);
        }
    }
}