using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Funeral.Discord
{
    // Token: 0x02000029 RID: 41
    public class DiscordRPC
    {
        // Token: 0x060000DC RID: 220
        [DllImport("discord-rpc.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
        public static extern void Initialize(string applicationId, ref DiscordRPC.EventHandlers handlers, bool autoRegister, string optionalSteamId);

        // Token: 0x060000DD RID: 221
        [DllImport("discord-rpc.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
        public static extern void Shutdown();

        // Token: 0x060000DE RID: 222
        [DllImport("discord-rpc.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
        public static extern void RunCallbacks();

        // Token: 0x060000DF RID: 223
        [DllImport("discord-rpc.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
        private static extern void UpdatePresenceNative(ref DiscordRPC.RichPresenceStruct presence);

        // Token: 0x060000E0 RID: 224
        [DllImport("discord-rpc.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_ClearPresence")]
        public static extern void ClearPresence();

        // Token: 0x060000E1 RID: 225
        [DllImport("discord-rpc.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Respond")]
        public static extern void Respond(string userId, DiscordRPC.Reply reply);

        // Token: 0x060000E2 RID: 226
        [DllImport("discord-rpc.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdateHandlers")]
        public static extern void UpdateHandlers(ref DiscordRPC.EventHandlers handlers);

        // Token: 0x060000E3 RID: 227 RVA: 0x0000A6F0 File Offset: 0x000088F0
        public static void UpdatePresence(DiscordRPC.RichPresence presence)
        {
            DiscordRPC.RichPresenceStruct @struct = presence.GetStruct();
            DiscordRPC.UpdatePresenceNative(ref @struct);
            presence.FreeMem();
        }

        // Token: 0x060000E4 RID: 228 RVA: 0x00002080 File Offset: 0x00000280
        public DiscordRPC()
        {
        }

        // Token: 0x0200002A RID: 42
        // (Invoke) Token: 0x060000E6 RID: 230
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ReadyCallback(ref DiscordRPC.DiscordUser connectedUser);

        // Token: 0x0200002B RID: 43
        // (Invoke) Token: 0x060000EA RID: 234
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void DisconnectedCallback(int errorCode, string message);

        // Token: 0x0200002C RID: 44
        // (Invoke) Token: 0x060000EE RID: 238
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ErrorCallback(int errorCode, string message);

        // Token: 0x0200002D RID: 45
        // (Invoke) Token: 0x060000F2 RID: 242
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JoinCallback(string secret);

        // Token: 0x0200002E RID: 46
        // (Invoke) Token: 0x060000F6 RID: 246
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void SpectateCallback(string secret);

        // Token: 0x0200002F RID: 47
        // (Invoke) Token: 0x060000FA RID: 250
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RequestCallback(ref DiscordRPC.DiscordUser request);

        // Token: 0x02000030 RID: 48
        public struct EventHandlers
        {
            // Token: 0x040000D0 RID: 208
            public DiscordRPC.ReadyCallback readyCallback;

            // Token: 0x040000D1 RID: 209
            public DiscordRPC.DisconnectedCallback disconnectedCallback;

            // Token: 0x040000D2 RID: 210
            public DiscordRPC.ErrorCallback errorCallback;

            // Token: 0x040000D3 RID: 211
            public DiscordRPC.JoinCallback joinCallback;

            // Token: 0x040000D4 RID: 212
            public DiscordRPC.SpectateCallback spectateCallback;

            // Token: 0x040000D5 RID: 213
            public DiscordRPC.RequestCallback requestCallback;
        }

        // Token: 0x02000031 RID: 49
        [Serializable]
        public struct RichPresenceStruct
        {
            // Token: 0x040000D6 RID: 214
            public IntPtr state;

            // Token: 0x040000D7 RID: 215
            public IntPtr details;

            // Token: 0x040000D8 RID: 216
            public long startTimestamp;

            // Token: 0x040000D9 RID: 217
            public long endTimestamp;

            // Token: 0x040000DA RID: 218
            public IntPtr largeImageKey;

            // Token: 0x040000DB RID: 219
            public IntPtr largeImageText;

            // Token: 0x040000DC RID: 220
            public IntPtr smallImageKey;

            // Token: 0x040000DD RID: 221
            public IntPtr smallImageText;

            // Token: 0x040000DE RID: 222
            public IntPtr partyId;

            // Token: 0x040000DF RID: 223
            public int partySize;

            // Token: 0x040000E0 RID: 224
            public int partyMax;

            // Token: 0x040000E1 RID: 225
            public IntPtr matchSecret;

            // Token: 0x040000E2 RID: 226
            public IntPtr joinSecret;

            // Token: 0x040000E3 RID: 227
            public IntPtr spectateSecret;

            // Token: 0x040000E4 RID: 228
            public bool instance;
        }

        // Token: 0x02000032 RID: 50
        [Serializable]
        public struct DiscordUser
        {
            // Token: 0x040000E5 RID: 229
            public string userId;

            // Token: 0x040000E6 RID: 230
            public string username;

            // Token: 0x040000E7 RID: 231
            public string discriminator;

            // Token: 0x040000E8 RID: 232
            public string avatar;
        }

        // Token: 0x02000033 RID: 51
        public enum Reply
        {
            // Token: 0x040000EA RID: 234
            No,
            // Token: 0x040000EB RID: 235
            Yes,
            // Token: 0x040000EC RID: 236
            Ignore
        }

        // Token: 0x02000034 RID: 52
        public class RichPresence
        {
            // Token: 0x060000FD RID: 253 RVA: 0x0000A714 File Offset: 0x00008914
            internal DiscordRPC.RichPresenceStruct GetStruct()
            {
                if (this._buffers.Count > 0)
                {
                    this.FreeMem();
                }
                this._presence.state = this.StrToPtr(this.state, 128);
                this._presence.details = this.StrToPtr(this.details, 128);
                this._presence.startTimestamp = this.startTimestamp;
                this._presence.endTimestamp = this.endTimestamp;
                this._presence.largeImageKey = this.StrToPtr(this.largeImageKey, 32);
                this._presence.largeImageText = this.StrToPtr(this.largeImageText, 128);
                this._presence.smallImageKey = this.StrToPtr(this.smallImageKey, 32);
                this._presence.smallImageText = this.StrToPtr(this.smallImageText, 128);
                this._presence.partyId = this.StrToPtr(this.partyId, 128);
                this._presence.partySize = this.partySize;
                this._presence.partyMax = this.partyMax;
                this._presence.matchSecret = this.StrToPtr(this.matchSecret, 128);
                this._presence.joinSecret = this.StrToPtr(this.joinSecret, 128);
                this._presence.spectateSecret = this.StrToPtr(this.spectateSecret, 128);
                this._presence.instance = this.instance;
                return this._presence;
            }

            // Token: 0x060000FE RID: 254 RVA: 0x0000A8A4 File Offset: 0x00008AA4
            private IntPtr StrToPtr(string input, int maxbytes)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return IntPtr.Zero;
                }
                string s = DiscordRPC.RichPresence.StrClampBytes(input, maxbytes);
                int byteCount = Encoding.UTF8.GetByteCount(s);
                IntPtr intPtr = Marshal.AllocHGlobal(byteCount);
                this._buffers.Add(intPtr);
                Marshal.Copy(Encoding.UTF8.GetBytes(s), 0, intPtr, byteCount);
                return intPtr;
            }

            // Token: 0x060000FF RID: 255 RVA: 0x0000A8FC File Offset: 0x00008AFC
            private static string StrToUtf8NullTerm(string toconv)
            {
                string text = toconv.Trim();
                byte[] bytes = Encoding.Default.GetBytes(text);
                if (bytes.Length != 0 && bytes[bytes.Length - 1] != 0)
                {
                    text += "\0\0";
                }
                return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
            }

            // Token: 0x06000100 RID: 256 RVA: 0x0000A94C File Offset: 0x00008B4C
            private static string StrClampBytes(string toclamp, int maxbytes)
            {
                string text = DiscordRPC.RichPresence.StrToUtf8NullTerm(toclamp);
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                if (bytes.Length <= maxbytes)
                {
                    return text;
                }
                byte[] array = new byte[0];
                Array.Copy(bytes, 0, array, 0, maxbytes - 1);
                array[array.Length - 1] = 0;
                array[array.Length - 2] = 0;
                return Encoding.UTF8.GetString(array);
            }

            // Token: 0x06000101 RID: 257 RVA: 0x0000A9A4 File Offset: 0x00008BA4
            internal void FreeMem()
            {
                for (int i = this._buffers.Count - 1; i >= 0; i--)
                {
                    Marshal.FreeHGlobal(this._buffers[i]);
                    this._buffers.RemoveAt(i);
                }
            }

            // Token: 0x06000102 RID: 258 RVA: 0x000026C8 File Offset: 0x000008C8
            public RichPresence()
            {
            }

            // Token: 0x040000ED RID: 237
            private DiscordRPC.RichPresenceStruct _presence;

            // Token: 0x040000EE RID: 238
            private readonly List<IntPtr> _buffers = new List<IntPtr>(10);

            // Token: 0x040000EF RID: 239
            public string state;

            // Token: 0x040000F0 RID: 240
            public string details;

            // Token: 0x040000F1 RID: 241
            public long startTimestamp;

            // Token: 0x040000F2 RID: 242
            public long endTimestamp;

            // Token: 0x040000F3 RID: 243
            public string largeImageKey;

            // Token: 0x040000F4 RID: 244
            public string largeImageText;

            // Token: 0x040000F5 RID: 245
            public string smallImageKey;

            // Token: 0x040000F6 RID: 246
            public string smallImageText;

            // Token: 0x040000F7 RID: 247
            public string partyId;

            // Token: 0x040000F8 RID: 248
            public int partySize;

            // Token: 0x040000F9 RID: 249
            public int partyMax;

            // Token: 0x040000FA RID: 250
            public string matchSecret;

            // Token: 0x040000FB RID: 251
            public string joinSecret;

            // Token: 0x040000FC RID: 252
            public string spectateSecret;

            // Token: 0x040000FD RID: 253
            public bool instance;
        }
    }
}
