using System;
using System.IO;
using System.Text;

namespace Decompression
{
    // Token: 0x0200003C RID: 60
    public static class BinaryReaderExtensions
    {
        // Token: 0x06000157 RID: 343 RVA: 0x000095A0 File Offset: 0x000077A0
        public static string ReadCString(this BinaryReader reader)
        {
            int num = 0;
            char[] array = new char[1024];
            int num2 = 0;
            while (num2 < array.Length && reader.BaseStream.Position != reader.BaseStream.Length)
            {
                char c = reader.ReadChar();
                if (c == '\0')
                {
                    break;
                }
                num++;
                array[num2] = c;
                num2++;
            }
            return new string(array, 0, num);
        }

        // Token: 0x06000158 RID: 344 RVA: 0x000095FC File Offset: 0x000077FC
        public static void WriteCString(this BinaryWriter writer, string str)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(str);
            writer.Write(bytes);
            writer.Write('\0');
        }

        // Token: 0x06000159 RID: 345 RVA: 0x00009624 File Offset: 0x00007824
        public static int ReadInt32BE(this BinaryReader reader)
        {
            byte[] array = reader.ReadBytes(4);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToInt32(array, 0);
        }

        // Token: 0x0600015A RID: 346 RVA: 0x00009650 File Offset: 0x00007850
        public static void WriteInt32BE(this BinaryWriter writer, int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            writer.Write(bytes);
        }

        // Token: 0x0600015B RID: 347 RVA: 0x00009678 File Offset: 0x00007878
        public static short ReadInt16BE(this BinaryReader reader)
        {
            byte[] array = reader.ReadBytes(2);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToInt16(array, 0);
        }

        // Token: 0x0600015C RID: 348 RVA: 0x000096A4 File Offset: 0x000078A4
        public static void WriteInt16BE(this BinaryWriter writer, short value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            writer.Write(bytes);
        }

        // Token: 0x0600015D RID: 349 RVA: 0x000096CC File Offset: 0x000078CC
        public static uint ReadUInt32BE(this BinaryReader reader)
        {
            byte[] array = reader.ReadBytes(4);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToUInt32(array, 0);
        }

        // Token: 0x0600015E RID: 350 RVA: 0x000096F8 File Offset: 0x000078F8
        public static void WriteUInt32BE(this BinaryWriter writer, uint value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            writer.Write(bytes);
        }

        // Token: 0x0600015F RID: 351 RVA: 0x00009720 File Offset: 0x00007920
        public static long ReadInt64BE(this BinaryReader reader)
        {
            byte[] array = reader.ReadBytes(8);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToInt64(array, 0);
        }

        // Token: 0x06000160 RID: 352 RVA: 0x0000974C File Offset: 0x0000794C
        public static void WriteInt64BE(this BinaryWriter writer, long value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            writer.Write(bytes);
        }
    }
}
