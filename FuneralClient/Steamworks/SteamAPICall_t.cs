using System;

namespace Steamworks2
{
	// Token: 0x0200014B RID: 331
	[Serializable]
	public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00003869 File Offset: 0x00001A69
		public SteamAPICall_t(ulong value)
		{
			this.m_SteamAPICall = value;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00003872 File Offset: 0x00001A72
		public override string ToString()
		{
			return this.m_SteamAPICall.ToString();
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0000387F File Offset: 0x00001A7F
		public override bool Equals(object other)
		{
			return other is SteamAPICall_t && this == (SteamAPICall_t)other;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000389C File Offset: 0x00001A9C
		public override int GetHashCode()
		{
			return this.m_SteamAPICall.GetHashCode();
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000038A9 File Offset: 0x00001AA9
		public static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			return x.m_SteamAPICall == y.m_SteamAPICall;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000038B9 File Offset: 0x00001AB9
		public static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000038C5 File Offset: 0x00001AC5
		public static explicit operator SteamAPICall_t(ulong value)
		{
			return new SteamAPICall_t(value);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000038CD File Offset: 0x00001ACD
		public static explicit operator ulong(SteamAPICall_t that)
		{
			return that.m_SteamAPICall;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000038A9 File Offset: 0x00001AA9
		public bool Equals(SteamAPICall_t other)
		{
			return this.m_SteamAPICall == other.m_SteamAPICall;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x000038D5 File Offset: 0x00001AD5
		public int CompareTo(SteamAPICall_t other)
		{
			return this.m_SteamAPICall.CompareTo(other.m_SteamAPICall);
		}

		// Token: 0x040007C2 RID: 1986
		public static readonly SteamAPICall_t Invalid = new SteamAPICall_t(0UL);

		// Token: 0x040007C3 RID: 1987
		public ulong m_SteamAPICall;
	}
}
