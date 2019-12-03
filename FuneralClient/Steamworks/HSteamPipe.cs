using System;

namespace Steamworks2
{
	// Token: 0x020000AE RID: 174
	[Serializable]
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00002F37 File Offset: 0x00001137
		public HSteamPipe(int value)
		{
			m_HSteamPipe = value;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002F40 File Offset: 0x00001140
		public override string ToString()
		{
			return m_HSteamPipe.ToString();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002F4D File Offset: 0x0000114D
		public override bool Equals(object other)
		{
			return other is HSteamPipe && this == (HSteamPipe)other;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002F6A File Offset: 0x0000116A
		public override int GetHashCode()
		{
			return m_HSteamPipe.GetHashCode();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002F77 File Offset: 0x00001177
		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return x.m_HSteamPipe == y.m_HSteamPipe;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002F87 File Offset: 0x00001187
		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return !(x == y);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002F93 File Offset: 0x00001193
		public static explicit operator HSteamPipe(int value)
		{
			return new HSteamPipe(value);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002F9B File Offset: 0x0000119B
		public static explicit operator int(HSteamPipe that)
		{
			return that.m_HSteamPipe;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002F77 File Offset: 0x00001177
		public bool Equals(HSteamPipe other)
		{
			return m_HSteamPipe == other.m_HSteamPipe;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002FA3 File Offset: 0x000011A3
		public int CompareTo(HSteamPipe other)
		{
			return m_HSteamPipe.CompareTo(other.m_HSteamPipe);
		}

		// Token: 0x040005E6 RID: 1510
		public int m_HSteamPipe;
	}
}
