using System;

namespace Steamworks2
{
	// Token: 0x0200011E RID: 286
	[Serializable]
	public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		// Token: 0x060004CE RID: 1230 RVA: 0x000033D2 File Offset: 0x000015D2
		public PublishedFileUpdateHandle_t(ulong value)
		{
			m_PublishedFileUpdateHandle = value;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000033DB File Offset: 0x000015DB
		public override string ToString()
		{
			return m_PublishedFileUpdateHandle.ToString();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000033E8 File Offset: 0x000015E8
		public override bool Equals(object other)
		{
			return other is PublishedFileUpdateHandle_t && this == (PublishedFileUpdateHandle_t)other;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00003405 File Offset: 0x00001605
		public override int GetHashCode()
		{
			return m_PublishedFileUpdateHandle.GetHashCode();
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00003412 File Offset: 0x00001612
		public static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return x.m_PublishedFileUpdateHandle == y.m_PublishedFileUpdateHandle;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00003422 File Offset: 0x00001622
		public static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000342E File Offset: 0x0000162E
		public static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return new PublishedFileUpdateHandle_t(value);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00003436 File Offset: 0x00001636
		public static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			return that.m_PublishedFileUpdateHandle;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00003412 File Offset: 0x00001612
		public bool Equals(PublishedFileUpdateHandle_t other)
		{
			return m_PublishedFileUpdateHandle == other.m_PublishedFileUpdateHandle;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000343E File Offset: 0x0000163E
		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return m_PublishedFileUpdateHandle.CompareTo(other.m_PublishedFileUpdateHandle);
		}

		// Token: 0x0400070A RID: 1802
		public static readonly PublishedFileUpdateHandle_t Invalid = new PublishedFileUpdateHandle_t(ulong.MaxValue);

		// Token: 0x0400070B RID: 1803
		public ulong m_PublishedFileUpdateHandle;
	}
}
