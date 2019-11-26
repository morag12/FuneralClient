using System;

namespace Steamworks2
{
	// Token: 0x0200000F RID: 15
	public static class CallbackDispatcher
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000021FA File Offset: 0x000003FA
		public static void ExceptionHandler(Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
