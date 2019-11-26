using System;

namespace Steamworks2
{
	// Token: 0x02000169 RID: 361
	[Serializable]
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x00005826 File Offset: 0x00003A26
		public SteamItemDef_t(int value)
		{
			this.m_SteamItemDef = value;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0000582F File Offset: 0x00003A2F
		public override string ToString()
		{
			return this.m_SteamItemDef.ToString();
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0000583C File Offset: 0x00003A3C
		public override bool Equals(object other)
		{
			return other is SteamItemDef_t && this == (SteamItemDef_t)other;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00005859 File Offset: 0x00003A59
		public override int GetHashCode()
		{
			return this.m_SteamItemDef.GetHashCode();
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00005866 File Offset: 0x00003A66
		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			return x.m_SteamItemDef == y.m_SteamItemDef;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00005876 File Offset: 0x00003A76
		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			return !(x == y);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00005882 File Offset: 0x00003A82
		public static explicit operator SteamItemDef_t(int value)
		{
			return new SteamItemDef_t(value);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000588A File Offset: 0x00003A8A
		public static explicit operator int(SteamItemDef_t that)
		{
			return that.m_SteamItemDef;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00005866 File Offset: 0x00003A66
		public bool Equals(SteamItemDef_t other)
		{
			return this.m_SteamItemDef == other.m_SteamItemDef;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00005892 File Offset: 0x00003A92
		public int CompareTo(SteamItemDef_t other)
		{
			return this.m_SteamItemDef.CompareTo(other.m_SteamItemDef);
		}

		// Token: 0x040007DE RID: 2014
		public int m_SteamItemDef;
	}
}
