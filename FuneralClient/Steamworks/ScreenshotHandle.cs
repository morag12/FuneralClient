using System;

namespace Steamworks2
{
	// Token: 0x0200013E RID: 318
	[Serializable]
	public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x0000345F File Offset: 0x0000165F
		public ScreenshotHandle(uint value)
		{
			this.m_ScreenshotHandle = value;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00003468 File Offset: 0x00001668
		public override string ToString()
		{
			return this.m_ScreenshotHandle.ToString();
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00003475 File Offset: 0x00001675
		public override bool Equals(object other)
		{
			return other is ScreenshotHandle && this == (ScreenshotHandle)other;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00003492 File Offset: 0x00001692
		public override int GetHashCode()
		{
			return this.m_ScreenshotHandle.GetHashCode();
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000349F File Offset: 0x0000169F
		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			return x.m_ScreenshotHandle == y.m_ScreenshotHandle;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000034AF File Offset: 0x000016AF
		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			return !(x == y);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000034BB File Offset: 0x000016BB
		public static explicit operator ScreenshotHandle(uint value)
		{
			return new ScreenshotHandle(value);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000034C3 File Offset: 0x000016C3
		public static explicit operator uint(ScreenshotHandle that)
		{
			return that.m_ScreenshotHandle;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0000349F File Offset: 0x0000169F
		public bool Equals(ScreenshotHandle other)
		{
			return this.m_ScreenshotHandle == other.m_ScreenshotHandle;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000034CB File Offset: 0x000016CB
		public int CompareTo(ScreenshotHandle other)
		{
			return this.m_ScreenshotHandle.CompareTo(other.m_ScreenshotHandle);
		}

		// Token: 0x040007A2 RID: 1954
		public static readonly ScreenshotHandle Invalid = new ScreenshotHandle(0u);

		// Token: 0x040007A3 RID: 1955
		public uint m_ScreenshotHandle;
	}
}
