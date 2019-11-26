using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Steamworks2
{
	// Token: 0x020000CC RID: 204
	public class InteropHelp
	{
		// Token: 0x06000160 RID: 352 RVA: 0x0000314D File Offset: 0x0000134D
		public static void TestIfPlatformSupported()
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000314F File Offset: 0x0000134F
		public static void TestIfAvailableClient()
		{
			InteropHelp.TestIfPlatformSupported();
			if (CSteamAPIContext.GetSteamClient() == IntPtr.Zero && !CSteamAPIContext.Init())
			{
				throw new InvalidOperationException("Steamworks is not initialized.");
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00003179 File Offset: 0x00001379
		public static void TestIfAvailableGameServer()
		{
			InteropHelp.TestIfPlatformSupported();
			if (CSteamGameServerAPIContext.GetSteamClient() == IntPtr.Zero && !CSteamGameServerAPIContext.Init())
			{
				throw new InvalidOperationException("Steamworks GameServer is not initialized.");
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000AE08 File Offset: 0x00009008
		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			if (nativeUtf8 == IntPtr.Zero)
			{
				return null;
			}
			int num = 0;
			while (Marshal.ReadByte(nativeUtf8, num) != 0)
			{
				num++;
			}
			if (num == 0)
			{
				return string.Empty;
			}
			byte[] array = new byte[num];
			Marshal.Copy(nativeUtf8, array, 0, array.Length);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x020000CD RID: 205
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			// Token: 0x06000165 RID: 357 RVA: 0x0000AE5C File Offset: 0x0000905C
			public UTF8StringHandle(string str) : base(true)
			{
				if (str == null)
				{
					base.SetHandle(IntPtr.Zero);
					return;
				}
				byte[] array = new byte[Encoding.UTF8.GetByteCount(str) + 1];
				Encoding.UTF8.GetBytes(str, 0, str.Length, array, 0);
				IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
				Marshal.Copy(array, 0, intPtr, array.Length);
				base.SetHandle(intPtr);
			}

			// Token: 0x06000166 RID: 358 RVA: 0x000031A3 File Offset: 0x000013A3
			protected override bool ReleaseHandle()
			{
				if (!IsInvalid)
				{
					Marshal.FreeHGlobal(handle);
				}
				return true;
			}
		}

		// Token: 0x020000CE RID: 206
		public class SteamParamStringArray
		{
			// Token: 0x06000167 RID: 359 RVA: 0x0000AEC4 File Offset: 0x000090C4
			public SteamParamStringArray(IList<string> strings)
			{
				if (strings == null)
				{
					m_pSteamParamStringArray = IntPtr.Zero;
					return;
				}
				m_Strings = new IntPtr[strings.Count];
				for (int i = 0; i < strings.Count; i++)
				{
					byte[] array = new byte[Encoding.UTF8.GetByteCount(strings[i]) + 1];
					Encoding.UTF8.GetBytes(strings[i], 0, strings[i].Length, array, 0);
					m_Strings[i] = Marshal.AllocHGlobal(array.Length);
					Marshal.Copy(array, 0, m_Strings[i], array.Length);
				}
				m_ptrStrings = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * m_Strings.Length);
				SteamParamStringArray_t steamParamStringArray_t = new SteamParamStringArray_t
				{
					m_ppStrings = m_ptrStrings,
					m_nNumStrings = m_Strings.Length
				};
				Marshal.Copy(m_Strings, 0, steamParamStringArray_t.m_ppStrings, m_Strings.Length);
				m_pSteamParamStringArray = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SteamParamStringArray_t)));
				Marshal.StructureToPtr(steamParamStringArray_t, m_pSteamParamStringArray, false);
			}

			// Token: 0x06000168 RID: 360 RVA: 0x000031B9 File Offset: 0x000013B9
			public static implicit operator IntPtr(InteropHelp.SteamParamStringArray that)
			{
				return that.m_pSteamParamStringArray;
			}

			// Token: 0x04000662 RID: 1634
			private readonly IntPtr[] m_Strings;

			// Token: 0x04000663 RID: 1635
			private readonly IntPtr m_ptrStrings;

			// Token: 0x04000664 RID: 1636
			private IntPtr m_pSteamParamStringArray;
		}
	}
}
