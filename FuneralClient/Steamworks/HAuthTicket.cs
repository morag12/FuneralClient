using System;

namespace Steamworks2
{
	// Token: 0x020000AA RID: 170
	[Serializable]
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00002D13 File Offset: 0x00000F13
		public HAuthTicket(uint value)
		{
			m_HAuthTicket = value;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002D1C File Offset: 0x00000F1C
		public override string ToString()
		{
			return m_HAuthTicket.ToString();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002D29 File Offset: 0x00000F29
		public override bool Equals(object other)
		{
			return other is HAuthTicket && this == (HAuthTicket)other;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002D46 File Offset: 0x00000F46
		public override int GetHashCode()
		{
			return m_HAuthTicket.GetHashCode();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002D53 File Offset: 0x00000F53
		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return x.m_HAuthTicket == y.m_HAuthTicket;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002D63 File Offset: 0x00000F63
		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return !(x == y);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002D6F File Offset: 0x00000F6F
		public static explicit operator HAuthTicket(uint value)
		{
			return new HAuthTicket(value);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002D77 File Offset: 0x00000F77
		public static explicit operator uint(HAuthTicket that)
		{
			return that.m_HAuthTicket;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002D53 File Offset: 0x00000F53
		public bool Equals(HAuthTicket other)
		{
			return m_HAuthTicket == other.m_HAuthTicket;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002D7F File Offset: 0x00000F7F
		public int CompareTo(HAuthTicket other)
		{
			return m_HAuthTicket.CompareTo(other.m_HAuthTicket);
		}

		// Token: 0x040005DE RID: 1502
		public static readonly HAuthTicket Invalid = new HAuthTicket(0u);

		// Token: 0x040005DF RID: 1503
		public uint m_HAuthTicket;
	}
}
