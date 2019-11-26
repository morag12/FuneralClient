using System;

namespace Steamworks2
{
	// Token: 0x020000AF RID: 175
	[Serializable]
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00002FB6 File Offset: 0x000011B6
		public HSteamUser(int value)
		{
			m_HSteamUser = value;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002FBF File Offset: 0x000011BF
		public override string ToString()
		{
			return m_HSteamUser.ToString();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002FCC File Offset: 0x000011CC
		public override bool Equals(object other)
		{
			return other is HSteamUser && this == (HSteamUser)other;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002FE9 File Offset: 0x000011E9
		public override int GetHashCode()
		{
			return m_HSteamUser.GetHashCode();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002FF6 File Offset: 0x000011F6
		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return x.m_HSteamUser == y.m_HSteamUser;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00003006 File Offset: 0x00001206
		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return !(x == y);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00003012 File Offset: 0x00001212
		public static explicit operator HSteamUser(int value)
		{
			return new HSteamUser(value);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000301A File Offset: 0x0000121A
		public static explicit operator int(HSteamUser that)
		{
			return that.m_HSteamUser;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002FF6 File Offset: 0x000011F6
		public bool Equals(HSteamUser other)
		{
			return m_HSteamUser == other.m_HSteamUser;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00003022 File Offset: 0x00001222
		public int CompareTo(HSteamUser other)
		{
			return m_HSteamUser.CompareTo(other.m_HSteamUser);
		}

		// Token: 0x040005E7 RID: 1511
		public int m_HSteamUser;
	}
}
