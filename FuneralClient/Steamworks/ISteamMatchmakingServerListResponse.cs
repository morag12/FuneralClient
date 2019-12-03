using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000E7 RID: 231
	public class ISteamMatchmakingServerListResponse
	{
		// Token: 0x060001BD RID: 445 RVA: 0x0000B320 File Offset: 0x00009520
		public ISteamMatchmakingServerListResponse(ISteamMatchmakingServerListResponse.ServerResponded onServerResponded, ISteamMatchmakingServerListResponse.ServerFailedToRespond onServerFailedToRespond, ISteamMatchmakingServerListResponse.RefreshComplete onRefreshComplete)
		{
			if (onServerResponded == null || onServerFailedToRespond == null || onRefreshComplete == null)
			{
				throw new ArgumentNullException();
			}
			m_ServerResponded = onServerResponded;
			m_ServerFailedToRespond = onServerFailedToRespond;
			m_RefreshComplete = onRefreshComplete;
			m_VTable = new ISteamMatchmakingServerListResponse.VTable
			{
				m_VTServerResponded = new ISteamMatchmakingServerListResponse.InternalServerResponded(InternalOnServerResponded),
				m_VTServerFailedToRespond = new ISteamMatchmakingServerListResponse.InternalServerFailedToRespond(InternalOnServerFailedToRespond),
				m_VTRefreshComplete = new ISteamMatchmakingServerListResponse.InternalRefreshComplete(InternalOnRefreshComplete)
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ISteamMatchmakingServerListResponse.VTable)));
			Marshal.StructureToPtr(m_VTable, m_pVTable, false);
			m_pGCHandle = GCHandle.Alloc(m_pVTable, GCHandleType.Pinned);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000B3DC File Offset: 0x000095DC
		~ISteamMatchmakingServerListResponse()
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

		// Token: 0x060001BF RID: 447 RVA: 0x00003266 File Offset: 0x00001466
		private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
			m_ServerResponded(hRequest, iServer);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00003275 File Offset: 0x00001475
		private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
			m_ServerFailedToRespond(hRequest, iServer);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00003284 File Offset: 0x00001484
		private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
			m_RefreshComplete(hRequest, response);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00003293 File Offset: 0x00001493
		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return that.m_pGCHandle.AddrOfPinnedObject();
		}

		// Token: 0x04000681 RID: 1665
		private readonly ISteamMatchmakingServerListResponse.VTable m_VTable;

		// Token: 0x04000682 RID: 1666
		private readonly IntPtr m_pVTable;

		// Token: 0x04000683 RID: 1667
		private GCHandle m_pGCHandle;

		// Token: 0x04000684 RID: 1668
		private readonly ISteamMatchmakingServerListResponse.ServerResponded m_ServerResponded;

		// Token: 0x04000685 RID: 1669
		private readonly ISteamMatchmakingServerListResponse.ServerFailedToRespond m_ServerFailedToRespond;

		// Token: 0x04000686 RID: 1670
		private readonly ISteamMatchmakingServerListResponse.RefreshComplete m_RefreshComplete;

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060001C4 RID: 452
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x060001C8 RID: 456
		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x060001CC RID: 460
		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060001D0 RID: 464
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x060001D4 RID: 468
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060001D8 RID: 472
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response);

		// Token: 0x020000EE RID: 238
		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			// Token: 0x04000687 RID: 1671
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingServerListResponse.InternalServerResponded m_VTServerResponded;

			// Token: 0x04000688 RID: 1672
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingServerListResponse.InternalServerFailedToRespond m_VTServerFailedToRespond;

			// Token: 0x04000689 RID: 1673
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingServerListResponse.InternalRefreshComplete m_VTRefreshComplete;
		}
	}
}
