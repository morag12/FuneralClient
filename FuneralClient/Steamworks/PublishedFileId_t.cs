using System;

namespace Steamworks2
{
	// Token: 0x0200011D RID: 285
	[Serializable]
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x00003345 File Offset: 0x00001545
		public PublishedFileId_t(ulong value)
		{
			m_PublishedFileId = value;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000334E File Offset: 0x0000154E
		public override string ToString()
		{
			return m_PublishedFileId.ToString();
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000335B File Offset: 0x0000155B
		public override bool Equals(object other)
		{
			return other is PublishedFileId_t && this == (PublishedFileId_t)other;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00003378 File Offset: 0x00001578
		public override int GetHashCode()
		{
			return m_PublishedFileId.GetHashCode();
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00003385 File Offset: 0x00001585
		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			return x.m_PublishedFileId == y.m_PublishedFileId;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00003395 File Offset: 0x00001595
		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			return !(x == y);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000033A1 File Offset: 0x000015A1
		public static explicit operator PublishedFileId_t(ulong value)
		{
			return new PublishedFileId_t(value);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000033A9 File Offset: 0x000015A9
		public static explicit operator ulong(PublishedFileId_t that)
		{
			return that.m_PublishedFileId;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00003385 File Offset: 0x00001585
		public bool Equals(PublishedFileId_t other)
		{
			return m_PublishedFileId == other.m_PublishedFileId;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000033B1 File Offset: 0x000015B1
		public int CompareTo(PublishedFileId_t other)
		{
			return m_PublishedFileId.CompareTo(other.m_PublishedFileId);
		}

		// Token: 0x04000708 RID: 1800
		public static readonly PublishedFileId_t Invalid = new PublishedFileId_t(0UL);

		// Token: 0x04000709 RID: 1801
		public ulong m_PublishedFileId;
	}
}
