using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000104 RID: 260
	public class MMKVPMarshaller
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x0000B438 File Offset: 0x00009638
		public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters)
		{
			if (filters == null)
			{
				return;
			}
			int num = Marshal.SizeOf(typeof(MatchMakingKeyValuePair_t));
			m_pNativeArray = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * filters.Length);
			m_pArrayEntries = Marshal.AllocHGlobal(num * filters.Length);
			for (int i = 0; i < filters.Length; i++)
			{
				Marshal.StructureToPtr(filters[i], new IntPtr(m_pArrayEntries.ToInt64() + (long)(i * num)), false);
			}
			Marshal.WriteIntPtr(m_pNativeArray, m_pArrayEntries);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000B4D4 File Offset: 0x000096D4
		~MMKVPMarshaller()
		{
			if (m_pArrayEntries != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pArrayEntries);
			}
			if (m_pNativeArray != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pNativeArray);
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000333D File Offset: 0x0000153D
		public static implicit operator IntPtr(MMKVPMarshaller that)
		{
			return that.m_pNativeArray;
		}

		// Token: 0x040006D6 RID: 1750
		private IntPtr m_pNativeArray;

		// Token: 0x040006D7 RID: 1751
		private readonly IntPtr m_pArrayEntries;
	}
}
