using System;

namespace Steamworks2
{
	// Token: 0x020000C7 RID: 199
	[Serializable]
	public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00003035 File Offset: 0x00001235
		public HTTPCookieContainerHandle(uint value)
		{
			m_HTTPCookieContainerHandle = value;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000303E File Offset: 0x0000123E
		public override string ToString()
		{
			return m_HTTPCookieContainerHandle.ToString();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000304B File Offset: 0x0000124B
		public override bool Equals(object other)
		{
			return other is HTTPCookieContainerHandle && this == (HTTPCookieContainerHandle)other;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003068 File Offset: 0x00001268
		public override int GetHashCode()
		{
			return m_HTTPCookieContainerHandle.GetHashCode();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00003075 File Offset: 0x00001275
		public static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return x.m_HTTPCookieContainerHandle == y.m_HTTPCookieContainerHandle;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00003085 File Offset: 0x00001285
		public static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return !(x == y);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003091 File Offset: 0x00001291
		public static explicit operator HTTPCookieContainerHandle(uint value)
		{
			return new HTTPCookieContainerHandle(value);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003099 File Offset: 0x00001299
		public static explicit operator uint(HTTPCookieContainerHandle that)
		{
			return that.m_HTTPCookieContainerHandle;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003075 File Offset: 0x00001275
		public bool Equals(HTTPCookieContainerHandle other)
		{
			return m_HTTPCookieContainerHandle == other.m_HTTPCookieContainerHandle;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000030A1 File Offset: 0x000012A1
		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return m_HTTPCookieContainerHandle.CompareTo(other.m_HTTPCookieContainerHandle);
		}

		// Token: 0x04000650 RID: 1616
		public static readonly HTTPCookieContainerHandle Invalid = new HTTPCookieContainerHandle(0u);

		// Token: 0x04000651 RID: 1617
		public uint m_HTTPCookieContainerHandle;
	}
}
