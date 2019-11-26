using System;

namespace Steamworks2
{
	// Token: 0x0200016D RID: 365
	[Serializable]
	public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		// Token: 0x06000787 RID: 1927 RVA: 0x000059B1 File Offset: 0x00003BB1
		public SteamLeaderboard_t(ulong value)
		{
			this.m_SteamLeaderboard = value;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000059BA File Offset: 0x00003BBA
		public override string ToString()
		{
			return this.m_SteamLeaderboard.ToString();
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000059C7 File Offset: 0x00003BC7
		public override bool Equals(object other)
		{
			return other is SteamLeaderboard_t && this == (SteamLeaderboard_t)other;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000059E4 File Offset: 0x00003BE4
		public override int GetHashCode()
		{
			return this.m_SteamLeaderboard.GetHashCode();
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000059F1 File Offset: 0x00003BF1
		public static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return x.m_SteamLeaderboard == y.m_SteamLeaderboard;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00005A01 File Offset: 0x00003C01
		public static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return !(x == y);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00005A0D File Offset: 0x00003C0D
		public static explicit operator SteamLeaderboard_t(ulong value)
		{
			return new SteamLeaderboard_t(value);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00005A15 File Offset: 0x00003C15
		public static explicit operator ulong(SteamLeaderboard_t that)
		{
			return that.m_SteamLeaderboard;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000059F1 File Offset: 0x00003BF1
		public bool Equals(SteamLeaderboard_t other)
		{
			return this.m_SteamLeaderboard == other.m_SteamLeaderboard;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00005A1D File Offset: 0x00003C1D
		public int CompareTo(SteamLeaderboard_t other)
		{
			return this.m_SteamLeaderboard.CompareTo(other.m_SteamLeaderboard);
		}

		// Token: 0x040007E6 RID: 2022
		public ulong m_SteamLeaderboard;
	}
}
