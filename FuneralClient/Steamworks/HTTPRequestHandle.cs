using System;

namespace Steamworks2
{
	// Token: 0x020000CA RID: 202
	[Serializable]
	public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		// Token: 0x06000155 RID: 341 RVA: 0x000030C1 File Offset: 0x000012C1
		public HTTPRequestHandle(uint value)
		{
			m_HTTPRequestHandle = value;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000030CA File Offset: 0x000012CA
		public override string ToString()
		{
			return m_HTTPRequestHandle.ToString();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000030D7 File Offset: 0x000012D7
		public override bool Equals(object other)
		{
			return other is HTTPRequestHandle && this == (HTTPRequestHandle)other;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000030F4 File Offset: 0x000012F4
		public override int GetHashCode()
		{
			return m_HTTPRequestHandle.GetHashCode();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00003101 File Offset: 0x00001301
		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return x.m_HTTPRequestHandle == y.m_HTTPRequestHandle;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00003111 File Offset: 0x00001311
		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return !(x == y);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000311D File Offset: 0x0000131D
		public static explicit operator HTTPRequestHandle(uint value)
		{
			return new HTTPRequestHandle(value);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00003125 File Offset: 0x00001325
		public static explicit operator uint(HTTPRequestHandle that)
		{
			return that.m_HTTPRequestHandle;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00003101 File Offset: 0x00001301
		public bool Equals(HTTPRequestHandle other)
		{
			return m_HTTPRequestHandle == other.m_HTTPRequestHandle;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000312D File Offset: 0x0000132D
		public int CompareTo(HTTPRequestHandle other)
		{
			return m_HTTPRequestHandle.CompareTo(other.m_HTTPRequestHandle);
		}

		// Token: 0x0400065D RID: 1629
		public static readonly HTTPRequestHandle Invalid = new HTTPRequestHandle(0u);

		// Token: 0x0400065E RID: 1630
		public uint m_HTTPRequestHandle;
	}
}
