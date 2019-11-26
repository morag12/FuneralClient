using System;

namespace Steamworks2
{
	// Token: 0x0200018A RID: 394
	[Serializable]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		// Token: 0x06000921 RID: 2337 RVA: 0x000071B7 File Offset: 0x000053B7
		public UGCUpdateHandle_t(ulong value)
		{
			this.m_UGCUpdateHandle = value;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000071C0 File Offset: 0x000053C0
		public override string ToString()
		{
			return this.m_UGCUpdateHandle.ToString();
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000071CD File Offset: 0x000053CD
		public override bool Equals(object other)
		{
			return other is UGCUpdateHandle_t && this == (UGCUpdateHandle_t)other;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000071EA File Offset: 0x000053EA
		public override int GetHashCode()
		{
			return this.m_UGCUpdateHandle.GetHashCode();
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000071F7 File Offset: 0x000053F7
		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return x.m_UGCUpdateHandle == y.m_UGCUpdateHandle;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00007207 File Offset: 0x00005407
		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return !(x == y);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00007213 File Offset: 0x00005413
		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return new UGCUpdateHandle_t(value);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0000721B File Offset: 0x0000541B
		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return that.m_UGCUpdateHandle;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000071F7 File Offset: 0x000053F7
		public bool Equals(UGCUpdateHandle_t other)
		{
			return this.m_UGCUpdateHandle == other.m_UGCUpdateHandle;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00007223 File Offset: 0x00005423
		public int CompareTo(UGCUpdateHandle_t other)
		{
			return this.m_UGCUpdateHandle.CompareTo(other.m_UGCUpdateHandle);
		}

		// Token: 0x04000822 RID: 2082
		public static readonly UGCUpdateHandle_t Invalid = new UGCUpdateHandle_t(ulong.MaxValue);

		// Token: 0x04000823 RID: 2083
		public ulong m_UGCUpdateHandle;
	}
}
