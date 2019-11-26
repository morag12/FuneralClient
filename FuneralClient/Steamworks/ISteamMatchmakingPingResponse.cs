using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000D1 RID: 209
	public class ISteamMatchmakingPingResponse
	{
		// Token: 0x06000169 RID: 361 RVA: 0x0000AFF4 File Offset: 0x000091F4
		public ISteamMatchmakingPingResponse(ISteamMatchmakingPingResponse.ServerResponded onServerResponded, ISteamMatchmakingPingResponse.ServerFailedToRespond onServerFailedToRespond)
		{
			if (onServerResponded == null || onServerFailedToRespond == null)
			{
				throw new ArgumentNullException();
			}
			m_ServerResponded = onServerResponded;
			m_ServerFailedToRespond = onServerFailedToRespond;
			m_VTable = new ISteamMatchmakingPingResponse.VTable
			{
				m_VTServerResponded = new ISteamMatchmakingPingResponse.InternalServerResponded(InternalOnServerResponded),
				m_VTServerFailedToRespond = new ISteamMatchmakingPingResponse.InternalServerFailedToRespond(InternalOnServerFailedToRespond)
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ISteamMatchmakingPingResponse.VTable)));
			Marshal.StructureToPtr(m_VTable, m_pVTable, false);
			m_pGCHandle = GCHandle.Alloc(m_pVTable, GCHandleType.Pinned);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000B094 File Offset: 0x00009294
		~ISteamMatchmakingPingResponse()
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

		// Token: 0x0600016B RID: 363 RVA: 0x000031C1 File Offset: 0x000013C1
		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
			m_ServerResponded(server);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000031CF File Offset: 0x000013CF
		private void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
			m_ServerFailedToRespond();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000031DC File Offset: 0x000013DC
		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return that.m_pGCHandle.AddrOfPinnedObject();
		}

		// Token: 0x04000668 RID: 1640
		private readonly ISteamMatchmakingPingResponse.VTable m_VTable;

		// Token: 0x04000669 RID: 1641
		private readonly IntPtr m_pVTable;

		// Token: 0x0400066A RID: 1642
		private GCHandle m_pGCHandle;

		// Token: 0x0400066B RID: 1643
		private readonly ISteamMatchmakingPingResponse.ServerResponded m_ServerResponded;

		// Token: 0x0400066C RID: 1644
		private readonly ISteamMatchmakingPingResponse.ServerFailedToRespond m_ServerFailedToRespond;

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x0600016F RID: 367
		public delegate void ServerResponded(gameserveritem_t server);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x06000173 RID: 371
		public delegate void ServerFailedToRespond();

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x06000177 RID: 375
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x0600017B RID: 379
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		// Token: 0x020000D6 RID: 214
		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			// Token: 0x0400066D RID: 1645
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingPingResponse.InternalServerResponded m_VTServerResponded;

			// Token: 0x0400066E RID: 1646
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingPingResponse.InternalServerFailedToRespond m_VTServerFailedToRespond;
		}
	}
}
