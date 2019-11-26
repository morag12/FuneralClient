using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Steamworks2
{
	// Token: 0x02000094 RID: 148
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 372)]
	public class gameserveritem_t
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00002BD1 File Offset: 0x00000DD1
		public string GetGameDir()
		{
			return Encoding.UTF8.GetString(m_szGameDir, 0, Array.IndexOf<byte>(m_szGameDir, 0));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002BF0 File Offset: 0x00000DF0
		public void SetGameDir(string dir)
		{
			m_szGameDir = Encoding.UTF8.GetBytes(dir + "\0");
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002C0D File Offset: 0x00000E0D
		public string GetMap()
		{
			return Encoding.UTF8.GetString(m_szMap, 0, Array.IndexOf<byte>(m_szMap, 0));
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002C2C File Offset: 0x00000E2C
		public void SetMap(string map)
		{
			m_szMap = Encoding.UTF8.GetBytes(map + "\0");
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002C49 File Offset: 0x00000E49
		public string GetGameDescription()
		{
			return Encoding.UTF8.GetString(m_szGameDescription, 0, Array.IndexOf<byte>(m_szGameDescription, 0));
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002C68 File Offset: 0x00000E68
		public void SetGameDescription(string desc)
		{
			m_szGameDescription = Encoding.UTF8.GetBytes(desc + "\0");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002C85 File Offset: 0x00000E85
		public string GetServerName()
		{
			if (m_szServerName[0] == 0)
			{
				return m_NetAdr.GetConnectionAddressString();
			}
			return Encoding.UTF8.GetString(m_szServerName, 0, Array.IndexOf<byte>(m_szServerName, 0));
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002CBA File Offset: 0x00000EBA
		public void SetServerName(string name)
		{
			m_szServerName = Encoding.UTF8.GetBytes(name + "\0");
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002CD7 File Offset: 0x00000ED7
		public string GetGameTags()
		{
			return Encoding.UTF8.GetString(m_szGameTags, 0, Array.IndexOf<byte>(m_szGameTags, 0));
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002CF6 File Offset: 0x00000EF6
		public void SetGameTags(string tags)
		{
			m_szGameTags = Encoding.UTF8.GetBytes(tags + "\0");
		}

		// Token: 0x04000581 RID: 1409
		public servernetadr_t m_NetAdr;

		// Token: 0x04000582 RID: 1410
		public int m_nPing;

		// Token: 0x04000583 RID: 1411
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bHadSuccessfulResponse;

		// Token: 0x04000584 RID: 1412
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bDoNotRefresh;

		// Token: 0x04000585 RID: 1413
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] m_szGameDir;

		// Token: 0x04000586 RID: 1414
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] m_szMap;

		// Token: 0x04000587 RID: 1415
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_szGameDescription;

		// Token: 0x04000588 RID: 1416
		public uint m_nAppID;

		// Token: 0x04000589 RID: 1417
		public int m_nPlayers;

		// Token: 0x0400058A RID: 1418
		public int m_nMaxPlayers;

		// Token: 0x0400058B RID: 1419
		public int m_nBotPlayers;

		// Token: 0x0400058C RID: 1420
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bPassword;

		// Token: 0x0400058D RID: 1421
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSecure;

		// Token: 0x0400058E RID: 1422
		public uint m_ulTimeLastPlayed;

		// Token: 0x0400058F RID: 1423
		public int m_nServerVersion;

		// Token: 0x04000590 RID: 1424
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_szServerName;

		// Token: 0x04000591 RID: 1425
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] m_szGameTags;

		// Token: 0x04000592 RID: 1426
		public CSteamID m_steamID;
	}
}
