using System;

namespace Steamworks2
{
	// Token: 0x02000189 RID: 393
	[Serializable]
	public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		// Token: 0x06000916 RID: 2326 RVA: 0x0000712A File Offset: 0x0000532A
		public UGCQueryHandle_t(ulong value)
		{
			this.m_UGCQueryHandle = value;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00007133 File Offset: 0x00005333
		public override string ToString()
		{
			return this.m_UGCQueryHandle.ToString();
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00007140 File Offset: 0x00005340
		public override bool Equals(object other)
		{
			return other is UGCQueryHandle_t && this == (UGCQueryHandle_t)other;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0000715D File Offset: 0x0000535D
		public override int GetHashCode()
		{
			return this.m_UGCQueryHandle.GetHashCode();
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0000716A File Offset: 0x0000536A
		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return x.m_UGCQueryHandle == y.m_UGCQueryHandle;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0000717A File Offset: 0x0000537A
		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00007186 File Offset: 0x00005386
		public static explicit operator UGCQueryHandle_t(ulong value)
		{
			return new UGCQueryHandle_t(value);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0000718E File Offset: 0x0000538E
		public static explicit operator ulong(UGCQueryHandle_t that)
		{
			return that.m_UGCQueryHandle;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0000716A File Offset: 0x0000536A
		public bool Equals(UGCQueryHandle_t other)
		{
			return this.m_UGCQueryHandle == other.m_UGCQueryHandle;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00007196 File Offset: 0x00005396
		public int CompareTo(UGCQueryHandle_t other)
		{
			return this.m_UGCQueryHandle.CompareTo(other.m_UGCQueryHandle);
		}

		// Token: 0x04000820 RID: 2080
		public static readonly UGCQueryHandle_t Invalid = new UGCQueryHandle_t(ulong.MaxValue);

		// Token: 0x04000821 RID: 2081
		public ulong m_UGCQueryHandle;
	}
}
