using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x020000D7 RID: 215
	public class ISteamMatchmakingPlayersResponse
	{
		// Token: 0x0600017F RID: 383 RVA: 0x0000B0F0 File Offset: 0x000092F0
		public ISteamMatchmakingPlayersResponse(ISteamMatchmakingPlayersResponse.AddPlayerToList onAddPlayerToList, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond onPlayersFailedToRespond, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete onPlayersRefreshComplete)
		{
			if (onAddPlayerToList == null || onPlayersFailedToRespond == null || onPlayersRefreshComplete == null)
			{
				throw new ArgumentNullException();
			}
			m_AddPlayerToList = onAddPlayerToList;
			m_PlayersFailedToRespond = onPlayersFailedToRespond;
			m_PlayersRefreshComplete = onPlayersRefreshComplete;
			m_VTable = new ISteamMatchmakingPlayersResponse.VTable
			{
				m_VTAddPlayerToList = new ISteamMatchmakingPlayersResponse.InternalAddPlayerToList(InternalOnAddPlayerToList),
				m_VTPlayersFailedToRespond = new ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond(InternalOnPlayersFailedToRespond),
				m_VTPlayersRefreshComplete = new ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete(InternalOnPlayersRefreshComplete)
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ISteamMatchmakingPlayersResponse.VTable)));
			Marshal.StructureToPtr(m_VTable, m_pVTable, false);
			m_pGCHandle = GCHandle.Alloc(m_pVTable, GCHandleType.Pinned);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000B1AC File Offset: 0x000093AC
		~ISteamMatchmakingPlayersResponse()
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

		// Token: 0x06000181 RID: 385 RVA: 0x000031E9 File Offset: 0x000013E9
		private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
			m_AddPlayerToList(InteropHelp.PtrToStringUTF8(pchName), nScore, flTimePlayed);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000031FF File Offset: 0x000013FF
		private void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
			m_PlayersFailedToRespond();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000320C File Offset: 0x0000140C
		private void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
			m_PlayersRefreshComplete();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00003219 File Offset: 0x00001419
		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			return that.m_pGCHandle.AddrOfPinnedObject();
		}

		// Token: 0x0400066F RID: 1647
		private readonly ISteamMatchmakingPlayersResponse.VTable m_VTable;

		// Token: 0x04000670 RID: 1648
		private readonly IntPtr m_pVTable;

		// Token: 0x04000671 RID: 1649
		private GCHandle m_pGCHandle;

		// Token: 0x04000672 RID: 1650
		private readonly ISteamMatchmakingPlayersResponse.AddPlayerToList m_AddPlayerToList;

		// Token: 0x04000673 RID: 1651
		private readonly ISteamMatchmakingPlayersResponse.PlayersFailedToRespond m_PlayersFailedToRespond;

		// Token: 0x04000674 RID: 1652
		private readonly ISteamMatchmakingPlayersResponse.PlayersRefreshComplete m_PlayersRefreshComplete;

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x06000186 RID: 390
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x0600018A RID: 394
		public delegate void PlayersFailedToRespond();

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x0600018E RID: 398
		public delegate void PlayersRefreshComplete();

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x06000192 RID: 402
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x06000196 RID: 406
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x0600019A RID: 410
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr);

		// Token: 0x020000DE RID: 222
		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			// Token: 0x04000675 RID: 1653
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingPlayersResponse.InternalAddPlayerToList m_VTAddPlayerToList;

			// Token: 0x04000676 RID: 1654
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond m_VTPlayersFailedToRespond;

			// Token: 0x04000677 RID: 1655
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete m_VTPlayersRefreshComplete;
		}
	}
}
