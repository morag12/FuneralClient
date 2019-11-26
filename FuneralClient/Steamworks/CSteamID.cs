using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00002736 File Offset: 0x00000936
		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
			m_SteamID = 0UL;
			Set(unAccountID, eUniverse, eAccountType);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002749 File Offset: 0x00000949
		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
			m_SteamID = 0UL;
			InstancedSet(unAccountID, unAccountInstance, eUniverse, eAccountType);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000275E File Offset: 0x0000095E
		public CSteamID(ulong ulSteamID)
		{
			m_SteamID = ulSteamID;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002767 File Offset: 0x00000967
		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
			SetAccountID(unAccountID);
			SetEUniverse(eUniverse);
			SetEAccountType(eAccountType);
			if (eAccountType == EAccountType.k_EAccountTypeClan || eAccountType == EAccountType.k_EAccountTypeGameServer)
			{
				SetAccountInstance(0u);
				return;
			}
			SetAccountInstance(1u);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002795 File Offset: 0x00000995
		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
			SetAccountID(unAccountID);
			SetEUniverse(eUniverse);
			SetEAccountType(eAccountType);
			SetAccountInstance(unInstance);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000027B4 File Offset: 0x000009B4
		public void Clear()
		{
			m_SteamID = 0UL;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000027BE File Offset: 0x000009BE
		public void CreateBlankAnonLogon(EUniverse eUniverse)
		{
			SetAccountID(new AccountID_t(0u));
			SetEUniverse(eUniverse);
			SetEAccountType(EAccountType.k_EAccountTypeAnonGameServer);
			SetAccountInstance(0u);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000027E1 File Offset: 0x000009E1
		public void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
			SetAccountID(new AccountID_t(0u));
			SetEUniverse(eUniverse);
			SetEAccountType(EAccountType.k_EAccountTypeAnonUser);
			SetAccountInstance(0u);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002805 File Offset: 0x00000A05
		public bool BBlankAnonAccount()
		{
			return GetAccountID() == new AccountID_t(0u) && BAnonAccount() && GetUnAccountInstance() == 0u;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000282D File Offset: 0x00000A2D
		public bool BGameServerAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeGameServer || GetEAccountType() == EAccountType.k_EAccountTypeAnonGameServer;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002843 File Offset: 0x00000A43
		public bool BPersistentGameServerAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeGameServer;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000284E File Offset: 0x00000A4E
		public bool BAnonGameServerAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeAnonGameServer;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002859 File Offset: 0x00000A59
		public bool BContentServerAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeContentServer;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002864 File Offset: 0x00000A64
		public bool BClanAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeClan;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000286F File Offset: 0x00000A6F
		public bool BChatAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeChat;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000287A File Offset: 0x00000A7A
		public bool IsLobby()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeChat && (GetUnAccountInstance() & 262144u) > 0u;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002896 File Offset: 0x00000A96
		public bool BIndividualAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeIndividual || GetEAccountType() == EAccountType.k_EAccountTypeConsoleUser;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000028AD File Offset: 0x00000AAD
		public bool BAnonAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeAnonUser || GetEAccountType() == EAccountType.k_EAccountTypeAnonGameServer;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000028C4 File Offset: 0x00000AC4
		public bool BAnonUserAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeAnonUser;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000028D0 File Offset: 0x00000AD0
		public bool BConsoleUserAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeConsoleUser;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000028DC File Offset: 0x00000ADC
		public void SetAccountID(AccountID_t other)
		{
			m_SteamID = ((m_SteamID & 18446744069414584320UL) | ((ulong)((uint)other) & ulong.MaxValue));
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000028FF File Offset: 0x00000AFF
		public void SetAccountInstance(uint other)
		{
			m_SteamID = ((m_SteamID & 18442240478377148415UL) | ((ulong)other & 1048575UL) << 32);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002924 File Offset: 0x00000B24
		public void SetEAccountType(EAccountType other)
		{
			m_SteamID = ((m_SteamID & 18379190079298994175UL) | (ulong)((ulong)((long)other & 15L) << 52));
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002946 File Offset: 0x00000B46
		public void SetEUniverse(EUniverse other)
		{
			m_SteamID = ((m_SteamID & 72057594037927935UL) | (ulong)((ulong)((long)other & 255L) << 56));
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000296B File Offset: 0x00000B6B
		public void ClearIndividualInstance()
		{
			if (BIndividualAccount())
			{
				SetAccountInstance(0u);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000297C File Offset: 0x00000B7C
		public bool HasNoIndividualInstance()
		{
			return BIndividualAccount() && GetUnAccountInstance() == 0u;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002991 File Offset: 0x00000B91
		public AccountID_t GetAccountID()
		{
			return new AccountID_t((uint)(m_SteamID & ulong.MaxValue));
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000029A2 File Offset: 0x00000BA2
		public uint GetUnAccountInstance()
		{
			return (uint)(m_SteamID >> 32 & 1048575UL);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000029B5 File Offset: 0x00000BB5
		public EAccountType GetEAccountType()
		{
			return (EAccountType)(m_SteamID >> 52 & 15UL);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000029C5 File Offset: 0x00000BC5
		public EUniverse GetEUniverse()
		{
			return (EUniverse)(m_SteamID >> 56 & 255UL);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000ACB4 File Offset: 0x00008EB4
		public bool IsValid()
		{
			return GetEAccountType() > EAccountType.k_EAccountTypeInvalid && GetEAccountType() < EAccountType.k_EAccountTypeMax && GetEUniverse() > EUniverse.k_EUniverseInvalid && GetEUniverse() < EUniverse.k_EUniverseMax && (GetEAccountType() != EAccountType.k_EAccountTypeIndividual || (!(GetAccountID() == new AccountID_t(0u)) && GetUnAccountInstance() <= 4u)) && (GetEAccountType() != EAccountType.k_EAccountTypeClan || (!(GetAccountID() == new AccountID_t(0u)) && GetUnAccountInstance() == 0u)) && (GetEAccountType() != EAccountType.k_EAccountTypeGameServer || !(GetAccountID() == new AccountID_t(0u)));
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000029D8 File Offset: 0x00000BD8
		public override string ToString()
		{
			return m_SteamID.ToString();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000029E5 File Offset: 0x00000BE5
		public override bool Equals(object other)
		{
			return other is CSteamID && this == (CSteamID)other;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002A02 File Offset: 0x00000C02
		public override int GetHashCode()
		{
			return m_SteamID.GetHashCode();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002A0F File Offset: 0x00000C0F
		public static bool operator ==(CSteamID x, CSteamID y)
		{
			return x.m_SteamID == y.m_SteamID;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002A1F File Offset: 0x00000C1F
		public static bool operator !=(CSteamID x, CSteamID y)
		{
			return !(x == y);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002A2B File Offset: 0x00000C2B
		public static explicit operator CSteamID(ulong value)
		{
			return new CSteamID(value);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002A33 File Offset: 0x00000C33
		public static explicit operator ulong(CSteamID that)
		{
			return that.m_SteamID;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002A0F File Offset: 0x00000C0F
		public bool Equals(CSteamID other)
		{
			return m_SteamID == other.m_SteamID;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002A3B File Offset: 0x00000C3B
		public int CompareTo(CSteamID other)
		{
			return m_SteamID.CompareTo(other.m_SteamID);
		}

		// Token: 0x04000124 RID: 292
		public static readonly CSteamID Nil = default(CSteamID);

		// Token: 0x04000125 RID: 293
		public static readonly CSteamID OutofDateGS = new CSteamID(new AccountID_t(0u), 0u, EUniverse.k_EUniverseInvalid, EAccountType.k_EAccountTypeInvalid);

		// Token: 0x04000126 RID: 294
		public static readonly CSteamID LanModeGS = new CSteamID(new AccountID_t(0u), 0u, EUniverse.k_EUniversePublic, EAccountType.k_EAccountTypeInvalid);

		// Token: 0x04000127 RID: 295
		public static readonly CSteamID NotInitYetGS = new CSteamID(new AccountID_t(1u), 0u, EUniverse.k_EUniverseInvalid, EAccountType.k_EAccountTypeInvalid);

		// Token: 0x04000128 RID: 296
		public static readonly CSteamID NonSteamGS = new CSteamID(new AccountID_t(2u), 0u, EUniverse.k_EUniverseInvalid, EAccountType.k_EAccountTypeInvalid);

		// Token: 0x04000129 RID: 297
		public ulong m_SteamID;
	}
}
