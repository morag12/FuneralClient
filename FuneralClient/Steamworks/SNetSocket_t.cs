using System;

namespace Steamworks2
{
	// Token: 0x02000146 RID: 326
	[Serializable]
	public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x0000377A File Offset: 0x0000197A
		public SNetSocket_t(uint value)
		{
			this.m_SNetSocket = value;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00003783 File Offset: 0x00001983
		public override string ToString()
		{
			return this.m_SNetSocket.ToString();
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00003790 File Offset: 0x00001990
		public override bool Equals(object other)
		{
			return other is SNetSocket_t && this == (SNetSocket_t)other;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000037AD File Offset: 0x000019AD
		public override int GetHashCode()
		{
			return this.m_SNetSocket.GetHashCode();
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000037BA File Offset: 0x000019BA
		public static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			return x.m_SNetSocket == y.m_SNetSocket;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000037CA File Offset: 0x000019CA
		public static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000037D6 File Offset: 0x000019D6
		public static explicit operator SNetSocket_t(uint value)
		{
			return new SNetSocket_t(value);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000037DE File Offset: 0x000019DE
		public static explicit operator uint(SNetSocket_t that)
		{
			return that.m_SNetSocket;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000037BA File Offset: 0x000019BA
		public bool Equals(SNetSocket_t other)
		{
			return this.m_SNetSocket == other.m_SNetSocket;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000037E6 File Offset: 0x000019E6
		public int CompareTo(SNetSocket_t other)
		{
			return this.m_SNetSocket.CompareTo(other.m_SNetSocket);
		}

		// Token: 0x040007B6 RID: 1974
		public uint m_SNetSocket;
	}
}
