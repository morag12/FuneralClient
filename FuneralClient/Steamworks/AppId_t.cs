using System;

namespace Steamworks2
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000020F0 File Offset: 0x000002F0
		public AppId_t(uint value)
		{
			m_AppId = value;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020F9 File Offset: 0x000002F9
		public override string ToString()
		{
			return m_AppId.ToString();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002106 File Offset: 0x00000306
		public override bool Equals(object other)
		{
			return other is AppId_t && this == (AppId_t)other;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002123 File Offset: 0x00000323
		public override int GetHashCode()
		{
			return m_AppId.GetHashCode();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002130 File Offset: 0x00000330
		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return x.m_AppId == y.m_AppId;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002140 File Offset: 0x00000340
		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000214C File Offset: 0x0000034C
		public static explicit operator AppId_t(uint value)
		{
			return new AppId_t(value);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002154 File Offset: 0x00000354
		public static explicit operator uint(AppId_t that)
		{
			return that.m_AppId;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002130 File Offset: 0x00000330
		public bool Equals(AppId_t other)
		{
			return m_AppId == other.m_AppId;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000215C File Offset: 0x0000035C
		public int CompareTo(AppId_t other)
		{
			return m_AppId.CompareTo(other.m_AppId);
		}

		// Token: 0x0400000B RID: 11
		public static readonly AppId_t Invalid = new AppId_t(0u);

		// Token: 0x0400000C RID: 12
		public uint m_AppId;
	}
}
