using System;

namespace Steamworks2
{
	// Token: 0x02000101 RID: 257
	[Serializable]
	public struct ManifestId_t : IEquatable<ManifestId_t>, IComparable<ManifestId_t>
	{
		// Token: 0x060001DC RID: 476 RVA: 0x000032A0 File Offset: 0x000014A0
		public ManifestId_t(ulong value)
		{
			m_ManifestId = value;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000032A9 File Offset: 0x000014A9
		public override string ToString()
		{
			return m_ManifestId.ToString();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000032B6 File Offset: 0x000014B6
		public override bool Equals(object other)
		{
			return other is ManifestId_t && this == (ManifestId_t)other;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000032D3 File Offset: 0x000014D3
		public override int GetHashCode()
		{
			return m_ManifestId.GetHashCode();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000032E0 File Offset: 0x000014E0
		public static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			return x.m_ManifestId == y.m_ManifestId;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000032F0 File Offset: 0x000014F0
		public static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			return !(x == y);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000032FC File Offset: 0x000014FC
		public static explicit operator ManifestId_t(ulong value)
		{
			return new ManifestId_t(value);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003304 File Offset: 0x00001504
		public static explicit operator ulong(ManifestId_t that)
		{
			return that.m_ManifestId;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000032E0 File Offset: 0x000014E0
		public bool Equals(ManifestId_t other)
		{
			return m_ManifestId == other.m_ManifestId;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000330C File Offset: 0x0000150C
		public int CompareTo(ManifestId_t other)
		{
			return m_ManifestId.CompareTo(other.m_ManifestId);
		}

		// Token: 0x040006CE RID: 1742
		public static readonly ManifestId_t Invalid = new ManifestId_t(0UL);

		// Token: 0x040006CF RID: 1743
		public ulong m_ManifestId;
	}
}
