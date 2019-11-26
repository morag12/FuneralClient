using System;

namespace Steamworks2
{
	// Token: 0x0200002D RID: 45
	[Serializable]
	public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00002A4E File Offset: 0x00000C4E
		public DepotId_t(uint value)
		{
			m_DepotId = value;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002A57 File Offset: 0x00000C57
		public override string ToString()
		{
			return m_DepotId.ToString();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002A64 File Offset: 0x00000C64
		public override bool Equals(object other)
		{
			return other is DepotId_t && this == (DepotId_t)other;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002A81 File Offset: 0x00000C81
		public override int GetHashCode()
		{
			return m_DepotId.GetHashCode();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002A8E File Offset: 0x00000C8E
		public static bool operator ==(DepotId_t x, DepotId_t y)
		{
			return x.m_DepotId == y.m_DepotId;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002A9E File Offset: 0x00000C9E
		public static bool operator !=(DepotId_t x, DepotId_t y)
		{
			return !(x == y);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002AAA File Offset: 0x00000CAA
		public static explicit operator DepotId_t(uint value)
		{
			return new DepotId_t(value);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public static explicit operator uint(DepotId_t that)
		{
			return that.m_DepotId;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002A8E File Offset: 0x00000C8E
		public bool Equals(DepotId_t other)
		{
			return m_DepotId == other.m_DepotId;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002ABA File Offset: 0x00000CBA
		public int CompareTo(DepotId_t other)
		{
			return m_DepotId.CompareTo(other.m_DepotId);
		}

		// Token: 0x0400012D RID: 301
		public static readonly DepotId_t Invalid = new DepotId_t(0u);

		// Token: 0x0400012E RID: 302
		public uint m_DepotId;
	}
}
