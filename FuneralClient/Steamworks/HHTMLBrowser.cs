using System;

namespace Steamworks2
{
	// Token: 0x020000AB RID: 171
	[Serializable]
	public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00002D9F File Offset: 0x00000F9F
		public HHTMLBrowser(uint value)
		{
			m_HHTMLBrowser = value;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public override string ToString()
		{
			return m_HHTMLBrowser.ToString();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002DB5 File Offset: 0x00000FB5
		public override bool Equals(object other)
		{
			return other is HHTMLBrowser && this == (HHTMLBrowser)other;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002DD2 File Offset: 0x00000FD2
		public override int GetHashCode()
		{
			return m_HHTMLBrowser.GetHashCode();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002DDF File Offset: 0x00000FDF
		public static bool operator ==(HHTMLBrowser x, HHTMLBrowser y)
		{
			return x.m_HHTMLBrowser == y.m_HHTMLBrowser;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002DEF File Offset: 0x00000FEF
		public static bool operator !=(HHTMLBrowser x, HHTMLBrowser y)
		{
			return !(x == y);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002DFB File Offset: 0x00000FFB
		public static explicit operator HHTMLBrowser(uint value)
		{
			return new HHTMLBrowser(value);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002E03 File Offset: 0x00001003
		public static explicit operator uint(HHTMLBrowser that)
		{
			return that.m_HHTMLBrowser;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002DDF File Offset: 0x00000FDF
		public bool Equals(HHTMLBrowser other)
		{
			return m_HHTMLBrowser == other.m_HHTMLBrowser;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002E0B File Offset: 0x0000100B
		public int CompareTo(HHTMLBrowser other)
		{
			return m_HHTMLBrowser.CompareTo(other.m_HHTMLBrowser);
		}

		// Token: 0x040005E0 RID: 1504
		public static readonly HHTMLBrowser Invalid = new HHTMLBrowser(0u);

		// Token: 0x040005E1 RID: 1505
		public uint m_HHTMLBrowser;
	}
}
