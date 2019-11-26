using System;

namespace Steamworks2
{
	// Token: 0x02000003 RID: 3
	[Serializable]
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002071 File Offset: 0x00000271
		public AccountID_t(uint value)
		{
			m_AccountID = value;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			return m_AccountID.ToString();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002087 File Offset: 0x00000287
		public override bool Equals(object other)
		{
			return other is AccountID_t && this == (AccountID_t)other;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020A4 File Offset: 0x000002A4
		public override int GetHashCode()
		{
			return m_AccountID.GetHashCode();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020B1 File Offset: 0x000002B1
		public static bool operator ==(AccountID_t x, AccountID_t y)
		{
			return x.m_AccountID == y.m_AccountID;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020C1 File Offset: 0x000002C1
		public static bool operator !=(AccountID_t x, AccountID_t y)
		{
			return !(x == y);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020CD File Offset: 0x000002CD
		public static explicit operator AccountID_t(uint value)
		{
			return new AccountID_t(value);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020D5 File Offset: 0x000002D5
		public static explicit operator uint(AccountID_t that)
		{
			return that.m_AccountID;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020B1 File Offset: 0x000002B1
		public bool Equals(AccountID_t other)
		{
			return m_AccountID == other.m_AccountID;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020DD File Offset: 0x000002DD
		public int CompareTo(AccountID_t other)
		{
			return m_AccountID.CompareTo(other.m_AccountID);
		}

		// Token: 0x04000002 RID: 2
		public uint m_AccountID;
	}
}
