using System;

namespace Steamworks2
{
	// Token: 0x02000141 RID: 321
	[Serializable]
	public struct servernetadr_t
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x000034EB File Offset: 0x000016EB
		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
			this.m_unIP = ip;
			this.m_usQueryPort = usQueryPort;
			this.m_usConnectionPort = usConnectionPort;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003502 File Offset: 0x00001702
		public ushort GetQueryPort()
		{
			return this.m_usQueryPort;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000350A File Offset: 0x0000170A
		public void SetQueryPort(ushort usPort)
		{
			this.m_usQueryPort = usPort;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00003513 File Offset: 0x00001713
		public ushort GetConnectionPort()
		{
			return this.m_usConnectionPort;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000351B File Offset: 0x0000171B
		public void SetConnectionPort(ushort usPort)
		{
			this.m_usConnectionPort = usPort;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00003524 File Offset: 0x00001724
		public uint GetIP()
		{
			return this.m_unIP;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000352C File Offset: 0x0000172C
		public void SetIP(uint unIP)
		{
			this.m_unIP = unIP;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00003535 File Offset: 0x00001735
		public string GetConnectionAddressString()
		{
			return servernetadr_t.ToString(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00003548 File Offset: 0x00001748
		public string GetQueryAddressString()
		{
			return servernetadr_t.ToString(this.m_unIP, this.m_usQueryPort);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000B570 File Offset: 0x00009770
		public static string ToString(uint unIP, ushort usPort)
		{
			return string.Format("{0}.{1}.{2}.{3}:{4}", new object[]
			{
				(ulong)(unIP >> 24) & 255UL,
				(ulong)(unIP >> 16) & 255UL,
				(ulong)(unIP >> 8) & 255UL,
				(ulong)unIP & 255UL,
				usPort
			});
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000355B File Offset: 0x0000175B
		public static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			return x.m_unIP < y.m_unIP || (x.m_unIP == y.m_unIP && x.m_usQueryPort < y.m_usQueryPort);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000358B File Offset: 0x0000178B
		public static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			return x.m_unIP > y.m_unIP || (x.m_unIP == y.m_unIP && x.m_usQueryPort > y.m_usQueryPort);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000035BB File Offset: 0x000017BB
		public override bool Equals(object other)
		{
			return other is servernetadr_t && this == (servernetadr_t)other;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000035D8 File Offset: 0x000017D8
		public override int GetHashCode()
		{
			return this.m_unIP.GetHashCode() + this.m_usQueryPort.GetHashCode() + this.m_usConnectionPort.GetHashCode();
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000035FD File Offset: 0x000017FD
		public static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			return x.m_unIP == y.m_unIP && x.m_usQueryPort == y.m_usQueryPort && x.m_usConnectionPort == y.m_usConnectionPort;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000362B File Offset: 0x0000182B
		public static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			return !(x == y);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000035FD File Offset: 0x000017FD
		public bool Equals(servernetadr_t other)
		{
			return this.m_unIP == other.m_unIP && this.m_usQueryPort == other.m_usQueryPort && this.m_usConnectionPort == other.m_usConnectionPort;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00003637 File Offset: 0x00001837
		public int CompareTo(servernetadr_t other)
		{
			return this.m_unIP.CompareTo(other.m_unIP) + this.m_usQueryPort.CompareTo(other.m_usQueryPort) + this.m_usConnectionPort.CompareTo(other.m_usConnectionPort);
		}

		// Token: 0x040007A8 RID: 1960
		private ushort m_usConnectionPort;

		// Token: 0x040007A9 RID: 1961
		private ushort m_usQueryPort;

		// Token: 0x040007AA RID: 1962
		private uint m_unIP;
	}
}
