using System;

namespace Steamworks2
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000022E9 File Offset: 0x000004E9
		public CGameID(ulong GameID)
		{
			m_GameID = GameID;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000022F2 File Offset: 0x000004F2
		public CGameID(AppId_t nAppID)
		{
			m_GameID = 0UL;
			SetAppID(nAppID);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002303 File Offset: 0x00000503
		public CGameID(AppId_t nAppID, uint nModID)
		{
			m_GameID = 0UL;
			SetAppID(nAppID);
			SetType(CGameID.EGameIDType.k_EGameIDTypeGameMod);
			SetModID(nModID);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002322 File Offset: 0x00000522
		public bool IsSteamApp()
		{
			return Type() == CGameID.EGameIDType.k_EGameIDTypeApp;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000232D File Offset: 0x0000052D
		public bool IsMod()
		{
			return Type() == CGameID.EGameIDType.k_EGameIDTypeGameMod;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002338 File Offset: 0x00000538
		public bool IsShortcut()
		{
			return Type() == CGameID.EGameIDType.k_EGameIDTypeShortcut;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002343 File Offset: 0x00000543
		public bool IsP2PFile()
		{
			return Type() == CGameID.EGameIDType.k_EGameIDTypeP2P;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000234E File Offset: 0x0000054E
		public AppId_t AppID()
		{
			return new AppId_t((uint)(m_GameID & 16777215UL));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002363 File Offset: 0x00000563
		public CGameID.EGameIDType Type()
		{
			return (CGameID.EGameIDType)(m_GameID >> 24 & 255UL);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002376 File Offset: 0x00000576
		public uint ModID()
		{
			return (uint)(m_GameID >> 32 & ulong.MaxValue);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000A600 File Offset: 0x00008800
		public bool IsValid()
		{
			switch (Type())
			{
			case CGameID.EGameIDType.k_EGameIDTypeApp:
				return AppID() != AppId_t.Invalid;
			case CGameID.EGameIDType.k_EGameIDTypeGameMod:
				return AppID() != AppId_t.Invalid && (ModID() & 2147483648u) > 0u;
			case CGameID.EGameIDType.k_EGameIDTypeShortcut:
				return (ModID() & 2147483648u) > 0u;
			case CGameID.EGameIDType.k_EGameIDTypeP2P:
				return AppID() == AppId_t.Invalid && (ModID() & 2147483648u) > 0u;
			default:
				return false;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002385 File Offset: 0x00000585
		public void Reset()
		{
			m_GameID = 0UL;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000022E9 File Offset: 0x000004E9
		public void Set(ulong GameID)
		{
			m_GameID = GameID;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000238F File Offset: 0x0000058F
		private void SetAppID(AppId_t other)
		{
			m_GameID = ((m_GameID & 18446744073692774400UL) | ((ulong)((uint)other) & 16777215UL));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000023B3 File Offset: 0x000005B3
		private void SetType(CGameID.EGameIDType other)
		{
			m_GameID = ((m_GameID & 18446744069431361535UL) | (ulong)((ulong)((long)other & 255L) << 24));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000023D8 File Offset: 0x000005D8
		private void SetModID(uint other)
		{
			m_GameID = ((m_GameID & ulong.MaxValue) | ((ulong)other & ulong.MaxValue) << 32);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000023F2 File Offset: 0x000005F2
		public override string ToString()
		{
			return m_GameID.ToString();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000023FF File Offset: 0x000005FF
		public override bool Equals(object other)
		{
			return other is CGameID && this == (CGameID)other;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000241C File Offset: 0x0000061C
		public override int GetHashCode()
		{
			return m_GameID.GetHashCode();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002429 File Offset: 0x00000629
		public static bool operator ==(CGameID x, CGameID y)
		{
			return x.m_GameID == y.m_GameID;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002439 File Offset: 0x00000639
		public static bool operator !=(CGameID x, CGameID y)
		{
			return !(x == y);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002445 File Offset: 0x00000645
		public static explicit operator CGameID(ulong value)
		{
			return new CGameID(value);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000244D File Offset: 0x0000064D
		public static explicit operator ulong(CGameID that)
		{
			return that.m_GameID;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002429 File Offset: 0x00000629
		public bool Equals(CGameID other)
		{
			return m_GameID == other.m_GameID;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002455 File Offset: 0x00000655
		public int CompareTo(CGameID other)
		{
			return m_GameID.CompareTo(other.m_GameID);
		}

		// Token: 0x0400003F RID: 63
		public ulong m_GameID;

		// Token: 0x0200001B RID: 27
		public enum EGameIDType
		{
			// Token: 0x04000041 RID: 65
			k_EGameIDTypeApp,
			// Token: 0x04000042 RID: 66
			k_EGameIDTypeGameMod,
			// Token: 0x04000043 RID: 67
			k_EGameIDTypeShortcut,
			// Token: 0x04000044 RID: 68
			k_EGameIDTypeP2P
		}
	}
}
