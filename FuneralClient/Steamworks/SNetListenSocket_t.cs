using System;

namespace Steamworks2
{
	// Token: 0x02000145 RID: 325
	[Serializable]
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x000036FB File Offset: 0x000018FB
		public SNetListenSocket_t(uint value)
		{
			this.m_SNetListenSocket = value;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00003704 File Offset: 0x00001904
		public override string ToString()
		{
			return this.m_SNetListenSocket.ToString();
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00003711 File Offset: 0x00001911
		public override bool Equals(object other)
		{
			return other is SNetListenSocket_t && this == (SNetListenSocket_t)other;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000372E File Offset: 0x0000192E
		public override int GetHashCode()
		{
			return this.m_SNetListenSocket.GetHashCode();
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000373B File Offset: 0x0000193B
		public static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return x.m_SNetListenSocket == y.m_SNetListenSocket;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000374B File Offset: 0x0000194B
		public static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00003757 File Offset: 0x00001957
		public static explicit operator SNetListenSocket_t(uint value)
		{
			return new SNetListenSocket_t(value);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000375F File Offset: 0x0000195F
		public static explicit operator uint(SNetListenSocket_t that)
		{
			return that.m_SNetListenSocket;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000373B File Offset: 0x0000193B
		public bool Equals(SNetListenSocket_t other)
		{
			return this.m_SNetListenSocket == other.m_SNetListenSocket;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00003767 File Offset: 0x00001967
		public int CompareTo(SNetListenSocket_t other)
		{
			return this.m_SNetListenSocket.CompareTo(other.m_SNetListenSocket);
		}

		// Token: 0x040007B5 RID: 1973
		public uint m_SNetListenSocket;
	}
}
