using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200000D RID: 13
	public sealed class Callback<T> : IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600001B RID: 27 RVA: 0x0000A050 File Offset: 0x00008250
		// (remove) Token: 0x0600001C RID: 28 RVA: 0x0000A088 File Offset: 0x00008288
		private event Callback<T>.DispatchDelegate m_Func;

		// Token: 0x0600001D RID: 29 RVA: 0x0000217C File Offset: 0x0000037C
		public static Callback<T> Create(Callback<T>.DispatchDelegate func)
		{
			return new Callback<T>(func, false);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002185 File Offset: 0x00000385
		public static Callback<T> CreateGameServer(Callback<T>.DispatchDelegate func)
		{
			return new Callback<T>(func, true);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000218E File Offset: 0x0000038E
		public Callback(Callback<T>.DispatchDelegate func, bool bGameServer = false)
		{
			m_bGameServer = bGameServer;
			BuildCCallbackBase();
			Register(func);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000A0C0 File Offset: 0x000082C0
		~Callback()
		{
			Dispose();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000A0EC File Offset: 0x000082EC
		public void Dispose()
		{
			if (m_bDisposed)
			{
				return;
			}
			GC.SuppressFinalize(this);
			Unregister();
			if (m_pVTable != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pVTable);
			}
			if (m_pCCallbackBase.IsAllocated)
			{
				m_pCCallbackBase.Free();
			}
			m_bDisposed = true;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000A14C File Offset: 0x0000834C
		public void Register(Callback<T>.DispatchDelegate func)
		{
			if (func == null)
			{
				throw new Exception("Callback function must not be null.");
			}
			if ((m_CCallbackBase.m_nCallbackFlags & 1) == 1)
			{
				Unregister();
			}
			if (m_bGameServer)
			{
				SetGameserverFlag();
			}
			m_Func = func;
			NativeMethods.SteamAPI_RegisterCallback(m_pCCallbackBase.AddrOfPinnedObject(), CallbackIdentities.GetCallbackIdentity(typeof(T)));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021CA File Offset: 0x000003CA
		public void Unregister()
		{
			NativeMethods.SteamAPI_UnregisterCallback(m_pCCallbackBase.AddrOfPinnedObject());
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021DC File Offset: 0x000003DC
		public void SetGameserverFlag()
		{
			CCallbackBase ccallbackBase = m_CCallbackBase;
			ccallbackBase.m_nCallbackFlags |= 2;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000A1B4 File Offset: 0x000083B4
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
			try
			{
				m_Func((T)((object)Marshal.PtrToStructure(pvParam, typeof(T))));
			}
			catch (Exception e)
			{
				CallbackDispatcher.ExceptionHandler(e);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000A1B4 File Offset: 0x000083B4
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
			try
			{
				m_Func((T)((object)Marshal.PtrToStructure(pvParam, typeof(T))));
			}
			catch (Exception e)
			{
				CallbackDispatcher.ExceptionHandler(e);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021F2 File Offset: 0x000003F2
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return m_size;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000A1FC File Offset: 0x000083FC
		private void BuildCCallbackBase()
		{
			m_CallbackBaseVTable = new CCallbackBaseVTable
			{
				m_RunCallResult = new CCallbackBaseVTable.RunCRDel(OnRunCallResult),
				m_RunCallback = new CCallbackBaseVTable.RunCBDel(OnRunCallback),
				m_GetCallbackSizeBytes = new CCallbackBaseVTable.GetCallbackSizeBytesDel(OnGetCallbackSizeBytes)
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CCallbackBaseVTable)));
			Marshal.StructureToPtr(m_CallbackBaseVTable, m_pVTable, false);
			m_CCallbackBase = new CCallbackBase
			{
				m_vfptr = m_pVTable,
				m_nCallbackFlags = 0,
				m_iCallback = CallbackIdentities.GetCallbackIdentity(typeof(T))
			};
			m_pCCallbackBase = GCHandle.Alloc(m_CCallbackBase, GCHandleType.Pinned);
		}

		// Token: 0x04000022 RID: 34
		private CCallbackBaseVTable m_CallbackBaseVTable;

		// Token: 0x04000023 RID: 35
		private IntPtr m_pVTable = IntPtr.Zero;

		// Token: 0x04000024 RID: 36
		private CCallbackBase m_CCallbackBase;

		// Token: 0x04000025 RID: 37
		private GCHandle m_pCCallbackBase;

		// Token: 0x04000026 RID: 38
		private readonly bool m_bGameServer;

		// Token: 0x04000027 RID: 39
		private readonly int m_size = Marshal.SizeOf(typeof(T));

		// Token: 0x04000028 RID: 40
		private bool m_bDisposed;

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600002A RID: 42
		public delegate void DispatchDelegate(T param);
	}
}
