using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000DF RID: 223
	public class ISteamMatchmakingRulesResponse
	{
		// Token: 0x0600019E RID: 414 RVA: 0x0000B208 File Offset: 0x00009408
		public ISteamMatchmakingRulesResponse(ISteamMatchmakingRulesResponse.RulesResponded onRulesResponded, ISteamMatchmakingRulesResponse.RulesFailedToRespond onRulesFailedToRespond, ISteamMatchmakingRulesResponse.RulesRefreshComplete onRulesRefreshComplete)
		{
			if (onRulesResponded == null || onRulesFailedToRespond == null || onRulesRefreshComplete == null)
			{
				throw new ArgumentNullException();
			}
			m_RulesResponded = onRulesResponded;
			m_RulesFailedToRespond = onRulesFailedToRespond;
			m_RulesRefreshComplete = onRulesRefreshComplete;
			m_VTable = new ISteamMatchmakingRulesResponse.VTable
			{
				m_VTRulesResponded = new ISteamMatchmakingRulesResponse.InternalRulesResponded(InternalOnRulesResponded),
				m_VTRulesFailedToRespond = new ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond(InternalOnRulesFailedToRespond),
				m_VTRulesRefreshComplete = new ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete(InternalOnRulesRefreshComplete)
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ISteamMatchmakingRulesResponse.VTable)));
			Marshal.StructureToPtr(m_VTable, m_pVTable, false);
			m_pGCHandle = GCHandle.Alloc(m_pVTable, GCHandleType.Pinned);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000B2C4 File Offset: 0x000094C4
		~ISteamMatchmakingRulesResponse()
		{
			if (m_pVTable != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pVTable);
			}
			if (m_pGCHandle.IsAllocated)
			{
				m_pGCHandle.Free();
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00003226 File Offset: 0x00001426
		private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
			m_RulesResponded(InteropHelp.PtrToStringUTF8(pchRule), InteropHelp.PtrToStringUTF8(pchValue));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000323F File Offset: 0x0000143F
		private void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
			m_RulesFailedToRespond();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000324C File Offset: 0x0000144C
		private void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
			m_RulesRefreshComplete();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00003259 File Offset: 0x00001459
		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return that.m_pGCHandle.AddrOfPinnedObject();
		}

		// Token: 0x04000678 RID: 1656
		private readonly ISteamMatchmakingRulesResponse.VTable m_VTable;

		// Token: 0x04000679 RID: 1657
		private readonly IntPtr m_pVTable;

		// Token: 0x0400067A RID: 1658
		private GCHandle m_pGCHandle;

		// Token: 0x0400067B RID: 1659
		private readonly ISteamMatchmakingRulesResponse.RulesResponded m_RulesResponded;

		// Token: 0x0400067C RID: 1660
		private readonly ISteamMatchmakingRulesResponse.RulesFailedToRespond m_RulesFailedToRespond;

		// Token: 0x0400067D RID: 1661
		private readonly ISteamMatchmakingRulesResponse.RulesRefreshComplete m_RulesRefreshComplete;

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x060001A5 RID: 421
		public delegate void RulesResponded(string pchRule, string pchValue);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x060001A9 RID: 425
		public delegate void RulesFailedToRespond();

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x060001AD RID: 429
		public delegate void RulesRefreshComplete();

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x060001B1 RID: 433
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x060001B5 RID: 437
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesFailedToRespond(IntPtr thisptr);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x060001B9 RID: 441
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesRefreshComplete(IntPtr thisptr);

		// Token: 0x020000E6 RID: 230
		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			// Token: 0x0400067E RID: 1662
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingRulesResponse.InternalRulesResponded m_VTRulesResponded;

			// Token: 0x0400067F RID: 1663
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			// Token: 0x04000680 RID: 1664
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete m_VTRulesRefreshComplete;
		}
	}
}
