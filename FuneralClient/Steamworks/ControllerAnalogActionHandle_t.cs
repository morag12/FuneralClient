using System;

namespace Steamworks2
{
	// Token: 0x02000023 RID: 35
	[Serializable]
	public struct ControllerAnalogActionHandle_t : IEquatable<ControllerAnalogActionHandle_t>, IComparable<ControllerAnalogActionHandle_t>
	{
		// Token: 0x06000077 RID: 119 RVA: 0x000024E7 File Offset: 0x000006E7
		public ControllerAnalogActionHandle_t(ulong value)
		{
			m_ControllerAnalogActionHandle = value;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000024F0 File Offset: 0x000006F0
		public override string ToString()
		{
			return m_ControllerAnalogActionHandle.ToString();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000024FD File Offset: 0x000006FD
		public override bool Equals(object other)
		{
			return other is ControllerAnalogActionHandle_t && this == (ControllerAnalogActionHandle_t)other;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000251A File Offset: 0x0000071A
		public override int GetHashCode()
		{
			return m_ControllerAnalogActionHandle.GetHashCode();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002527 File Offset: 0x00000727
		public static bool operator ==(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			return x.m_ControllerAnalogActionHandle == y.m_ControllerAnalogActionHandle;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002537 File Offset: 0x00000737
		public static bool operator !=(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002543 File Offset: 0x00000743
		public static explicit operator ControllerAnalogActionHandle_t(ulong value)
		{
			return new ControllerAnalogActionHandle_t(value);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000254B File Offset: 0x0000074B
		public static explicit operator ulong(ControllerAnalogActionHandle_t that)
		{
			return that.m_ControllerAnalogActionHandle;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002527 File Offset: 0x00000727
		public bool Equals(ControllerAnalogActionHandle_t other)
		{
			return m_ControllerAnalogActionHandle == other.m_ControllerAnalogActionHandle;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002553 File Offset: 0x00000753
		public int CompareTo(ControllerAnalogActionHandle_t other)
		{
			return m_ControllerAnalogActionHandle.CompareTo(other.m_ControllerAnalogActionHandle);
		}

		// Token: 0x040000F3 RID: 243
		public ulong m_ControllerAnalogActionHandle;
	}
}
