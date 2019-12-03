using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x02000016 RID: 22
	[StructLayout(LayoutKind.Sequential)]
	internal class CCallbackBaseVTable
	{
		// Token: 0x0400003B RID: 59
		private const CallingConvention cc = CallingConvention.ThisCall;

		// Token: 0x0400003C RID: 60
		[NonSerialized]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CCallbackBaseVTable.RunCRDel m_RunCallResult;

		// Token: 0x0400003D RID: 61
		[NonSerialized]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CCallbackBaseVTable.RunCBDel m_RunCallback;

		// Token: 0x0400003E RID: 62
		[NonSerialized]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CCallbackBaseVTable.GetCallbackSizeBytesDel m_GetCallbackSizeBytes;

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000049 RID: 73
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void RunCBDel(IntPtr thisptr, IntPtr pvParam);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600004D RID: 77
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void RunCRDel(IntPtr thisptr, IntPtr pvParam, [MarshalAs(UnmanagedType.I1)] bool bIOFailure, ulong hSteamAPICall);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000051 RID: 81
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate int GetCallbackSizeBytesDel(IntPtr thisptr);
	}
}
