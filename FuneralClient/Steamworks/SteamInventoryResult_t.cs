using System;

namespace Steamworks2
{
	// Token: 0x02000166 RID: 358
	[Serializable]
	public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x0000570D File Offset: 0x0000390D
		public SteamInventoryResult_t(int value)
		{
			this.m_SteamInventoryResult = value;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00005716 File Offset: 0x00003916
		public override string ToString()
		{
			return this.m_SteamInventoryResult.ToString();
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00005723 File Offset: 0x00003923
		public override bool Equals(object other)
		{
			return other is SteamInventoryResult_t && this == (SteamInventoryResult_t)other;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00005740 File Offset: 0x00003940
		public override int GetHashCode()
		{
			return this.m_SteamInventoryResult.GetHashCode();
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0000574D File Offset: 0x0000394D
		public static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return x.m_SteamInventoryResult == y.m_SteamInventoryResult;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0000575D File Offset: 0x0000395D
		public static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00005769 File Offset: 0x00003969
		public static explicit operator SteamInventoryResult_t(int value)
		{
			return new SteamInventoryResult_t(value);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00005771 File Offset: 0x00003971
		public static explicit operator int(SteamInventoryResult_t that)
		{
			return that.m_SteamInventoryResult;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0000574D File Offset: 0x0000394D
		public bool Equals(SteamInventoryResult_t other)
		{
			return this.m_SteamInventoryResult == other.m_SteamInventoryResult;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00005779 File Offset: 0x00003979
		public int CompareTo(SteamInventoryResult_t other)
		{
			return this.m_SteamInventoryResult.CompareTo(other.m_SteamInventoryResult);
		}

		// Token: 0x040007D6 RID: 2006
		public static readonly SteamInventoryResult_t Invalid = new SteamInventoryResult_t(-1);

		// Token: 0x040007D7 RID: 2007
		public int m_SteamInventoryResult;
	}
}
