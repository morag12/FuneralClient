using System;
using System.Runtime.InteropServices;

namespace Steamworks2
{
	// Token: 0x0200001F RID: 31
	[CallbackIdentity(211)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		// Token: 0x04000051 RID: 81
		public const int k_iCallback = 211;

		// Token: 0x04000052 RID: 82
		public EResult m_eResult;

		// Token: 0x04000053 RID: 83
		public int m_cPlayersThatDontLikeCandidate;

		// Token: 0x04000054 RID: 84
		public int m_cPlayersThatCandidateDoesntLike;

		// Token: 0x04000055 RID: 85
		public int m_cClanPlayersThatDontLikeCandidate;

		// Token: 0x04000056 RID: 86
		public CSteamID m_SteamIDCandidate;
	}
}
