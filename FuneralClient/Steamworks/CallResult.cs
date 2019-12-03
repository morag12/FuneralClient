using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000013 RID: 19
	public sealed class CallResult<T> : IDisposable
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000033 RID: 51 RVA: 0x0000A304 File Offset: 0x00008504
		// (remove) Token: 0x06000034 RID: 52 RVA: 0x0000A33C File Offset: 0x0000853C
		private event CallResult<T>.APIDispatchDelegate m_Func;

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000222F File Offset: 0x0000042F
		public SteamAPICall_t Handle
		{
			get
			{
				return m_hAPICall;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002237 File Offset: 0x00000437
		public static CallResult<T> Create(CallResult<T>.APIDispatchDelegate func = null)
		{
			return new CallResult<T>(func);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000223F File Offset: 0x0000043F
		public CallResult(CallResult<T>.APIDispatchDelegate func = null)
		{
			m_Func = func;
			BuildCCallbackBase();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000A374 File Offset: 0x00008574
		~CallResult()
		{
			Dispose();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000A3A0 File Offset: 0x000085A0
		public void Dispose()
		{
			if (m_bDisposed)
			{
				return;
			}
			GC.SuppressFinalize(this);
			Cancel();
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

		// Token: 0x0600003A RID: 58 RVA: 0x0000A400 File Offset: 0x00008600
		public void Set(SteamAPICall_t hAPICall, CallResult<T>.APIDispatchDelegate func = null)
		{
			if (func != null)
			{
				m_Func = func;
			}
			if (m_Func == null)
			{
				throw new Exception("CallResult function was null, you must either set it in the CallResult Constructor or via Set()");
			}
			if (m_hAPICall != SteamAPICall_t.Invalid)
			{
				NativeMethods.SteamAPI_UnregisterCallResult(m_pCCallbackBase.AddrOfPinnedObject(), (ulong)m_hAPICall);
			}
			m_hAPICall = hAPICall;
			if (hAPICall != SteamAPICall_t.Invalid)
			{
				NativeMethods.SteamAPI_RegisterCallResult(m_pCCallbackBase.AddrOfPinnedObject(), (ulong)hAPICall);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000227F File Offset: 0x0000047F
		public bool IsActive()
		{
			return m_hAPICall != SteamAPICall_t.Invalid;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002291 File Offset: 0x00000491
		public void Cancel()
		{
			if (m_hAPICall != SteamAPICall_t.Invalid)
			{
				NativeMethods.SteamAPI_UnregisterCallResult(m_pCCallbackBase.AddrOfPinnedObject(), (ulong)m_hAPICall);
				m_hAPICall = SteamAPICall_t.Invalid;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000022CB File Offset: 0x000004CB
		public void SetGameserverFlag()
		{
			CCallbackBase ccallbackBase = m_CCallbackBase;
			ccallbackBase.m_nCallbackFlags |= 2;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000A484 File Offset: 0x00008684
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
			m_hAPICall = SteamAPICall_t.Invalid;
			try
			{
				m_Func((T)((object)Marshal.PtrToStructure(pvParam, typeof(T))), false);
			}
			catch (Exception e)
			{
				CallbackDispatcher.ExceptionHandler(e);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000A4D8 File Offset: 0x000086D8
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall_)
		{
			if ((SteamAPICall_t)hSteamAPICall_ == m_hAPICall)
			{
				m_hAPICall = SteamAPICall_t.Invalid;
				try
				{
					m_Func((T)((object)Marshal.PtrToStructure(pvParam, typeof(T))), bFailed);
				}
				catch (Exception e)
				{
					CallbackDispatcher.ExceptionHandler(e);
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000022E1 File Offset: 0x000004E1
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return m_size;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000A540 File Offset: 0x00008740
		private void BuildCCallbackBase()
		{
			m_CallbackBaseVTable = new CCallbackBaseVTable
			{
				m_RunCallback = new CCallbackBaseVTable.RunCBDel(OnRunCallback),
				m_RunCallResult = new CCallbackBaseVTable.RunCRDel(OnRunCallResult),
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

		// Token: 0x0400002F RID: 47
		private CCallbackBaseVTable m_CallbackBaseVTable;

		// Token: 0x04000030 RID: 48
		private IntPtr m_pVTable = IntPtr.Zero;

		// Token: 0x04000031 RID: 49
		private CCallbackBase m_CCallbackBase;

		// Token: 0x04000032 RID: 50
		private GCHandle m_pCCallbackBase;

		// Token: 0x04000033 RID: 51
		private SteamAPICall_t m_hAPICall = SteamAPICall_t.Invalid;

		// Token: 0x04000034 RID: 52
		private readonly int m_size = Marshal.SizeOf(typeof(T));

		// Token: 0x04000035 RID: 53
		private bool m_bDisposed;

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000043 RID: 67
		public delegate void APIDispatchDelegate(T param, bool bIOFailure);
	}
}
