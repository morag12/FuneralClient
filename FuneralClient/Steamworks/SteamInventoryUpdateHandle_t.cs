using System;

namespace Steamworks2
{
	// Token: 0x02000168 RID: 360
	[Serializable]
	public struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t>
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x00005799 File Offset: 0x00003999
		public SteamInventoryUpdateHandle_t(ulong value)
		{
			this.m_SteamInventoryUpdateHandle = value;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000057A2 File Offset: 0x000039A2
		public override string ToString()
		{
			return this.m_SteamInventoryUpdateHandle.ToString();
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000057AF File Offset: 0x000039AF
		public override bool Equals(object other)
		{
			return other is SteamInventoryUpdateHandle_t && this == (SteamInventoryUpdateHandle_t)other;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000057CC File Offset: 0x000039CC
		public override int GetHashCode()
		{
			return this.m_SteamInventoryUpdateHandle.GetHashCode();
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000057D9 File Offset: 0x000039D9
		public static bool operator ==(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			return x.m_SteamInventoryUpdateHandle == y.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000057E9 File Offset: 0x000039E9
		public static bool operator !=(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000057F5 File Offset: 0x000039F5
		public static explicit operator SteamInventoryUpdateHandle_t(ulong value)
		{
			return new SteamInventoryUpdateHandle_t(value);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000057FD File Offset: 0x000039FD
		public static explicit operator ulong(SteamInventoryUpdateHandle_t that)
		{
			return that.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000057D9 File Offset: 0x000039D9
		public bool Equals(SteamInventoryUpdateHandle_t other)
		{
			return this.m_SteamInventoryUpdateHandle == other.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00005805 File Offset: 0x00003A05
		public int CompareTo(SteamInventoryUpdateHandle_t other)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(other.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x040007DC RID: 2012
		public static readonly SteamInventoryUpdateHandle_t Invalid = new SteamInventoryUpdateHandle_t(ulong.MaxValue);

		// Token: 0x040007DD RID: 2013
		public ulong m_SteamInventoryUpdateHandle;
	}
}
