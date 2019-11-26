using System;

namespace Steamworks2
{
	// Token: 0x0200016C RID: 364
	[Serializable]
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x00005932 File Offset: 0x00003B32
		public SteamLeaderboardEntries_t(ulong value)
		{
			this.m_SteamLeaderboardEntries = value;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0000593B File Offset: 0x00003B3B
		public override string ToString()
		{
			return this.m_SteamLeaderboardEntries.ToString();
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00005948 File Offset: 0x00003B48
		public override bool Equals(object other)
		{
			return other is SteamLeaderboardEntries_t && this == (SteamLeaderboardEntries_t)other;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00005965 File Offset: 0x00003B65
		public override int GetHashCode()
		{
			return this.m_SteamLeaderboardEntries.GetHashCode();
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00005972 File Offset: 0x00003B72
		public static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return x.m_SteamLeaderboardEntries == y.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00005982 File Offset: 0x00003B82
		public static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0000598E File Offset: 0x00003B8E
		public static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return new SteamLeaderboardEntries_t(value);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00005996 File Offset: 0x00003B96
		public static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			return that.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00005972 File Offset: 0x00003B72
		public bool Equals(SteamLeaderboardEntries_t other)
		{
			return this.m_SteamLeaderboardEntries == other.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0000599E File Offset: 0x00003B9E
		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(other.m_SteamLeaderboardEntries);
		}

		// Token: 0x040007E5 RID: 2021
		public ulong m_SteamLeaderboardEntries;
	}
}
