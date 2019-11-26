using System;

namespace Steamworks2
{
	// Token: 0x02000188 RID: 392
	[Serializable]
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		// Token: 0x0600090B RID: 2315 RVA: 0x0000709D File Offset: 0x0000529D
		public UGCHandle_t(ulong value)
		{
			this.m_UGCHandle = value;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000070A6 File Offset: 0x000052A6
		public override string ToString()
		{
			return this.m_UGCHandle.ToString();
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000070B3 File Offset: 0x000052B3
		public override bool Equals(object other)
		{
			return other is UGCHandle_t && this == (UGCHandle_t)other;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000070D0 File Offset: 0x000052D0
		public override int GetHashCode()
		{
			return this.m_UGCHandle.GetHashCode();
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000070DD File Offset: 0x000052DD
		public static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			return x.m_UGCHandle == y.m_UGCHandle;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000070ED File Offset: 0x000052ED
		public static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000070F9 File Offset: 0x000052F9
		public static explicit operator UGCHandle_t(ulong value)
		{
			return new UGCHandle_t(value);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00007101 File Offset: 0x00005301
		public static explicit operator ulong(UGCHandle_t that)
		{
			return that.m_UGCHandle;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000070DD File Offset: 0x000052DD
		public bool Equals(UGCHandle_t other)
		{
			return this.m_UGCHandle == other.m_UGCHandle;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00007109 File Offset: 0x00005309
		public int CompareTo(UGCHandle_t other)
		{
			return this.m_UGCHandle.CompareTo(other.m_UGCHandle);
		}

		// Token: 0x0400081E RID: 2078
		public static readonly UGCHandle_t Invalid = new UGCHandle_t(ulong.MaxValue);

		// Token: 0x0400081F RID: 2079
		public ulong m_UGCHandle;
	}
}
