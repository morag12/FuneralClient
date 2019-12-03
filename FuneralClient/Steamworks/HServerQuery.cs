using System;

namespace Steamworks2
{
	// Token: 0x020000AD RID: 173
	[Serializable]
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00002EAB File Offset: 0x000010AB
		public HServerQuery(int value)
		{
			m_HServerQuery = value;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002EB4 File Offset: 0x000010B4
		public override string ToString()
		{
			return m_HServerQuery.ToString();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002EC1 File Offset: 0x000010C1
		public override bool Equals(object other)
		{
			return other is HServerQuery && this == (HServerQuery)other;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002EDE File Offset: 0x000010DE
		public override int GetHashCode()
		{
			return m_HServerQuery.GetHashCode();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002EEB File Offset: 0x000010EB
		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return x.m_HServerQuery == y.m_HServerQuery;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002EFB File Offset: 0x000010FB
		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return !(x == y);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002F07 File Offset: 0x00001107
		public static explicit operator HServerQuery(int value)
		{
			return new HServerQuery(value);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002F0F File Offset: 0x0000110F
		public static explicit operator int(HServerQuery that)
		{
			return that.m_HServerQuery;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002EEB File Offset: 0x000010EB
		public bool Equals(HServerQuery other)
		{
			return m_HServerQuery == other.m_HServerQuery;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002F17 File Offset: 0x00001117
		public int CompareTo(HServerQuery other)
		{
			return m_HServerQuery.CompareTo(other.m_HServerQuery);
		}

		// Token: 0x040005E4 RID: 1508
		public static readonly HServerQuery Invalid = new HServerQuery(-1);

		// Token: 0x040005E5 RID: 1509
		public int m_HServerQuery;
	}
}
