using System;

namespace Steamworks2
{
	// Token: 0x020000AC RID: 172
	[Serializable]
	public struct HServerListRequest : IEquatable<HServerListRequest>
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00002E2B File Offset: 0x0000102B
		public HServerListRequest(IntPtr value)
		{
			m_HServerListRequest = value;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002E34 File Offset: 0x00001034
		public override string ToString()
		{
			return m_HServerListRequest.ToString();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002E41 File Offset: 0x00001041
		public override bool Equals(object other)
		{
			return other is HServerListRequest && this == (HServerListRequest)other;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002E5E File Offset: 0x0000105E
		public override int GetHashCode()
		{
			return m_HServerListRequest.GetHashCode();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002E6B File Offset: 0x0000106B
		public static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			return x.m_HServerListRequest == y.m_HServerListRequest;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002E7E File Offset: 0x0000107E
		public static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			return !(x == y);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002E8A File Offset: 0x0000108A
		public static explicit operator HServerListRequest(IntPtr value)
		{
			return new HServerListRequest(value);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002E92 File Offset: 0x00001092
		public static explicit operator IntPtr(HServerListRequest that)
		{
			return that.m_HServerListRequest;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002E6B File Offset: 0x0000106B
		public bool Equals(HServerListRequest other)
		{
			return m_HServerListRequest == other.m_HServerListRequest;
		}

		// Token: 0x040005E2 RID: 1506
		public static readonly HServerListRequest Invalid = new HServerListRequest(IntPtr.Zero);

		// Token: 0x040005E3 RID: 1507
		public IntPtr m_HServerListRequest;
	}
}
