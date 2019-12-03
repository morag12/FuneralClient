using System;

namespace Steamworks2
{
	// Token: 0x0200016B RID: 363
	[Serializable]
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x000058A5 File Offset: 0x00003AA5
		public SteamItemInstanceID_t(ulong value)
		{
			this.m_SteamItemInstanceID = value;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000058AE File Offset: 0x00003AAE
		public override string ToString()
		{
			return this.m_SteamItemInstanceID.ToString();
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000058BB File Offset: 0x00003ABB
		public override bool Equals(object other)
		{
			return other is SteamItemInstanceID_t && this == (SteamItemInstanceID_t)other;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000058D8 File Offset: 0x00003AD8
		public override int GetHashCode()
		{
			return this.m_SteamItemInstanceID.GetHashCode();
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000058E5 File Offset: 0x00003AE5
		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return x.m_SteamItemInstanceID == y.m_SteamItemInstanceID;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000058F5 File Offset: 0x00003AF5
		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00005901 File Offset: 0x00003B01
		public static explicit operator SteamItemInstanceID_t(ulong value)
		{
			return new SteamItemInstanceID_t(value);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00005909 File Offset: 0x00003B09
		public static explicit operator ulong(SteamItemInstanceID_t that)
		{
			return that.m_SteamItemInstanceID;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000058E5 File Offset: 0x00003AE5
		public bool Equals(SteamItemInstanceID_t other)
		{
			return this.m_SteamItemInstanceID == other.m_SteamItemInstanceID;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00005911 File Offset: 0x00003B11
		public int CompareTo(SteamItemInstanceID_t other)
		{
			return this.m_SteamItemInstanceID.CompareTo(other.m_SteamItemInstanceID);
		}

		// Token: 0x040007E3 RID: 2019
		public static readonly SteamItemInstanceID_t Invalid = new SteamItemInstanceID_t(ulong.MaxValue);

		// Token: 0x040007E4 RID: 2020
		public ulong m_SteamItemInstanceID;
	}
}
