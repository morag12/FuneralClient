using System;

namespace Steamworks2
{
	// Token: 0x02000187 RID: 391
	[Serializable]
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		// Token: 0x06000900 RID: 2304 RVA: 0x00007010 File Offset: 0x00005210
		public UGCFileWriteStreamHandle_t(ulong value)
		{
			this.m_UGCFileWriteStreamHandle = value;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00007019 File Offset: 0x00005219
		public override string ToString()
		{
			return this.m_UGCFileWriteStreamHandle.ToString();
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00007026 File Offset: 0x00005226
		public override bool Equals(object other)
		{
			return other is UGCFileWriteStreamHandle_t && this == (UGCFileWriteStreamHandle_t)other;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00007043 File Offset: 0x00005243
		public override int GetHashCode()
		{
			return this.m_UGCFileWriteStreamHandle.GetHashCode();
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00007050 File Offset: 0x00005250
		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return x.m_UGCFileWriteStreamHandle == y.m_UGCFileWriteStreamHandle;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00007060 File Offset: 0x00005260
		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0000706C File Offset: 0x0000526C
		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return new UGCFileWriteStreamHandle_t(value);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00007074 File Offset: 0x00005274
		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return that.m_UGCFileWriteStreamHandle;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00007050 File Offset: 0x00005250
		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return this.m_UGCFileWriteStreamHandle == other.m_UGCFileWriteStreamHandle;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0000707C File Offset: 0x0000527C
		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return this.m_UGCFileWriteStreamHandle.CompareTo(other.m_UGCFileWriteStreamHandle);
		}

		// Token: 0x0400081C RID: 2076
		public static readonly UGCFileWriteStreamHandle_t Invalid = new UGCFileWriteStreamHandle_t(ulong.MaxValue);

		// Token: 0x0400081D RID: 2077
		public ulong m_UGCFileWriteStreamHandle;
	}
}
