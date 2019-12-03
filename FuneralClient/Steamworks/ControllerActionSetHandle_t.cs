using System;

namespace Steamworks2
{
	// Token: 0x02000021 RID: 33
	[Serializable]
	public struct ControllerActionSetHandle_t : IEquatable<ControllerActionSetHandle_t>, IComparable<ControllerActionSetHandle_t>
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002468 File Offset: 0x00000668
		public ControllerActionSetHandle_t(ulong value)
		{
			m_ControllerActionSetHandle = value;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002471 File Offset: 0x00000671
		public override string ToString()
		{
			return m_ControllerActionSetHandle.ToString();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000247E File Offset: 0x0000067E
		public override bool Equals(object other)
		{
			return other is ControllerActionSetHandle_t && this == (ControllerActionSetHandle_t)other;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000249B File Offset: 0x0000069B
		public override int GetHashCode()
		{
			return m_ControllerActionSetHandle.GetHashCode();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000024A8 File Offset: 0x000006A8
		public static bool operator ==(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			return x.m_ControllerActionSetHandle == y.m_ControllerActionSetHandle;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000024B8 File Offset: 0x000006B8
		public static bool operator !=(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000024C4 File Offset: 0x000006C4
		public static explicit operator ControllerActionSetHandle_t(ulong value)
		{
			return new ControllerActionSetHandle_t(value);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000024CC File Offset: 0x000006CC
		public static explicit operator ulong(ControllerActionSetHandle_t that)
		{
			return that.m_ControllerActionSetHandle;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000024A8 File Offset: 0x000006A8
		public bool Equals(ControllerActionSetHandle_t other)
		{
			return m_ControllerActionSetHandle == other.m_ControllerActionSetHandle;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000024D4 File Offset: 0x000006D4
		public int CompareTo(ControllerActionSetHandle_t other)
		{
			return m_ControllerActionSetHandle.CompareTo(other.m_ControllerActionSetHandle);
		}

		// Token: 0x040000EE RID: 238
		public ulong m_ControllerActionSetHandle;
	}
}
