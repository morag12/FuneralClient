using System;

namespace Steamworks2
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public struct ControllerDigitalActionHandle_t : IEquatable<ControllerDigitalActionHandle_t>, IComparable<ControllerDigitalActionHandle_t>
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002566 File Offset: 0x00000766
		public ControllerDigitalActionHandle_t(ulong value)
		{
			m_ControllerDigitalActionHandle = value;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000256F File Offset: 0x0000076F
		public override string ToString()
		{
			return m_ControllerDigitalActionHandle.ToString();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000257C File Offset: 0x0000077C
		public override bool Equals(object other)
		{
			return other is ControllerDigitalActionHandle_t && this == (ControllerDigitalActionHandle_t)other;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002599 File Offset: 0x00000799
		public override int GetHashCode()
		{
			return m_ControllerDigitalActionHandle.GetHashCode();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000025A6 File Offset: 0x000007A6
		public static bool operator ==(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			return x.m_ControllerDigitalActionHandle == y.m_ControllerDigitalActionHandle;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000025B6 File Offset: 0x000007B6
		public static bool operator !=(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000025C2 File Offset: 0x000007C2
		public static explicit operator ControllerDigitalActionHandle_t(ulong value)
		{
			return new ControllerDigitalActionHandle_t(value);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000025CA File Offset: 0x000007CA
		public static explicit operator ulong(ControllerDigitalActionHandle_t that)
		{
			return that.m_ControllerDigitalActionHandle;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000025A6 File Offset: 0x000007A6
		public bool Equals(ControllerDigitalActionHandle_t other)
		{
			return m_ControllerDigitalActionHandle == other.m_ControllerDigitalActionHandle;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000025D2 File Offset: 0x000007D2
		public int CompareTo(ControllerDigitalActionHandle_t other)
		{
			return m_ControllerDigitalActionHandle.CompareTo(other.m_ControllerDigitalActionHandle);
		}

		// Token: 0x040000F6 RID: 246
		public ulong m_ControllerDigitalActionHandle;
	}
}
