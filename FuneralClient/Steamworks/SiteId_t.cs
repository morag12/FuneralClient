using System;

namespace Steamworks2
{
	// Token: 0x02000144 RID: 324
	[Serializable]
	public struct SiteId_t : IEquatable<SiteId_t>, IComparable<SiteId_t>
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x0000366E File Offset: 0x0000186E
		public SiteId_t(ulong value)
		{
			this.m_SiteId = value;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00003677 File Offset: 0x00001877
		public override string ToString()
		{
			return this.m_SiteId.ToString();
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00003684 File Offset: 0x00001884
		public override bool Equals(object other)
		{
			return other is SiteId_t && this == (SiteId_t)other;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000036A1 File Offset: 0x000018A1
		public override int GetHashCode()
		{
			return this.m_SiteId.GetHashCode();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000036AE File Offset: 0x000018AE
		public static bool operator ==(SiteId_t x, SiteId_t y)
		{
			return x.m_SiteId == y.m_SiteId;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000036BE File Offset: 0x000018BE
		public static bool operator !=(SiteId_t x, SiteId_t y)
		{
			return !(x == y);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000036CA File Offset: 0x000018CA
		public static explicit operator SiteId_t(ulong value)
		{
			return new SiteId_t(value);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000036D2 File Offset: 0x000018D2
		public static explicit operator ulong(SiteId_t that)
		{
			return that.m_SiteId;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000036AE File Offset: 0x000018AE
		public bool Equals(SiteId_t other)
		{
			return this.m_SiteId == other.m_SiteId;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000036DA File Offset: 0x000018DA
		public int CompareTo(SiteId_t other)
		{
			return this.m_SiteId.CompareTo(other.m_SiteId);
		}

		// Token: 0x040007B3 RID: 1971
		public static readonly SiteId_t Invalid = new SiteId_t(0UL);

		// Token: 0x040007B4 RID: 1972
		public ulong m_SiteId;
	}
}
