using System;

namespace Steamworks2
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	public struct ControllerHandle_t : IEquatable<ControllerHandle_t>, IComparable<ControllerHandle_t>
	{
		// Token: 0x0600008B RID: 139 RVA: 0x000025E5 File Offset: 0x000007E5
		public ControllerHandle_t(ulong value)
		{
			m_ControllerHandle = value;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000025EE File Offset: 0x000007EE
		public override string ToString()
		{
			return m_ControllerHandle.ToString();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000025FB File Offset: 0x000007FB
		public override bool Equals(object other)
		{
			return other is ControllerHandle_t && this == (ControllerHandle_t)other;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002618 File Offset: 0x00000818
		public override int GetHashCode()
		{
			return m_ControllerHandle.GetHashCode();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002625 File Offset: 0x00000825
		public static bool operator ==(ControllerHandle_t x, ControllerHandle_t y)
		{
			return x.m_ControllerHandle == y.m_ControllerHandle;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002635 File Offset: 0x00000835
		public static bool operator !=(ControllerHandle_t x, ControllerHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002641 File Offset: 0x00000841
		public static explicit operator ControllerHandle_t(ulong value)
		{
			return new ControllerHandle_t(value);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002649 File Offset: 0x00000849
		public static explicit operator ulong(ControllerHandle_t that)
		{
			return that.m_ControllerHandle;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002625 File Offset: 0x00000825
		public bool Equals(ControllerHandle_t other)
		{
			return m_ControllerHandle == other.m_ControllerHandle;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002651 File Offset: 0x00000851
		public int CompareTo(ControllerHandle_t other)
		{
			return m_ControllerHandle.CompareTo(other.m_ControllerHandle);
		}

		// Token: 0x040000F7 RID: 247
		public ulong m_ControllerHandle;
	}
}
