using System;

namespace Steamworks2
{
	// Token: 0x02000088 RID: 136
	[Serializable]
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00002ADD File Offset: 0x00000CDD
		public FriendsGroupID_t(short value)
		{
			m_FriendsGroupID = value;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002AE6 File Offset: 0x00000CE6
		public override string ToString()
		{
			return m_FriendsGroupID.ToString();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002AF3 File Offset: 0x00000CF3
		public override bool Equals(object other)
		{
			return other is FriendsGroupID_t && this == (FriendsGroupID_t)other;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002B10 File Offset: 0x00000D10
		public override int GetHashCode()
		{
			return m_FriendsGroupID.GetHashCode();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002B1D File Offset: 0x00000D1D
		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return x.m_FriendsGroupID == y.m_FriendsGroupID;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002B2D File Offset: 0x00000D2D
		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return !(x == y);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002B39 File Offset: 0x00000D39
		public static explicit operator FriendsGroupID_t(short value)
		{
			return new FriendsGroupID_t(value);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002B41 File Offset: 0x00000D41
		public static explicit operator short(FriendsGroupID_t that)
		{
			return that.m_FriendsGroupID;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002B1D File Offset: 0x00000D1D
		public bool Equals(FriendsGroupID_t other)
		{
			return m_FriendsGroupID == other.m_FriendsGroupID;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002B49 File Offset: 0x00000D49
		public int CompareTo(FriendsGroupID_t other)
		{
			return m_FriendsGroupID.CompareTo(other.m_FriendsGroupID);
		}

		// Token: 0x0400055E RID: 1374
		public static readonly FriendsGroupID_t Invalid = new FriendsGroupID_t(-1);

		// Token: 0x0400055F RID: 1375
		public short m_FriendsGroupID;
	}
}
