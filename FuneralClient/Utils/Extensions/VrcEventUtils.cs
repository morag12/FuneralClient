using IL;
using Photon.Pun;
using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using VRC;
using VRCSDK2;

namespace Funeral
{
    // Token: 0x02000006 RID: 6
    internal static class VrcEventUtils
    {
        // Token: 0x0600001B RID: 27 RVA: 0x00002ED8 File Offset: 0x000010D8
        internal static void SendRpcSecure(this OKHDIEKIBPI to, VRC_EventHandler.VrcEvent ev)
        {
            object obj = Activator.CreateInstance(VrcEventUtils.vrcEventType);
            VrcEventUtils.setVrcEventMethod.Invoke(obj, new object[]
            {
                ev
            });
            VrcEventUtils.setPhotonTime.Invoke(obj, new object[]
            {
                VrcEventUtils.getPhotonTime.Invoke(null, null)
            });
            VrcEventUtils.vrcBroadcastTypeField.SetValue(obj, 0);
            VrcEventUtils.someRandomIntField.SetValue(obj, VrcEventUtils.getSomeInt.Invoke(null, null));
            VrcEventUtils.someRandomLongField.SetValue(obj, 0L);
            VrcEventUtils.someRandomFloatField.SetValue(obj, 0f);
            VrcEventUtils.RpcSecure(PhotonView.Find(1), "ProcessEvent", to.ECCAPFLNNJL, true, new object[]
            {
                obj
            });
        }

        // Token: 0x0600001C RID: 28 RVA: 0x00002F97 File Offset: 0x00001197
        internal static void RpcSecure(PhotonView pv, string n, object p, bool b, object[] objs)
        {
            VrcEventUtils.rpcSecureMethod.Invoke(pv, new object[]
            {
                n,
                p,
                b,
                objs
            });
        }

        // Token: 0x04000017 RID: 23
        private static BindingFlags any = (BindingFlags)(-1);

        // Token: 0x04000018 RID: 24
        private static Type photonPlayerType = Enumerable.First<PropertyInfo>(typeof(VRC.Player).GetProperties(), (PropertyInfo p) => p.GetGetMethod().Name == "get_PhotonPlayer").PropertyType;

        // Token: 0x04000019 RID: 25
        private static MethodInfo rpcSecureMethod = Enumerable.Last<MethodInfo>(typeof(PhotonView).GetMethods(), (MethodInfo x) => x.Name == "RpcSecure" && x.GetParameters().Length == 4 && x.GetParameters()[1].ParameterType == VrcEventUtils.photonPlayerType);

        // Token: 0x0400001A RID: 26
        private static Type vrcEventType = Enumerable.LastOrDefault<ILInstruction>(typeof(NetworkMetadata).GetMethod("OnDestroy", VrcEventUtils.any).Parse(), (ILInstruction x) => x.OpCode == OpCodes.Ldftn).GetArgument<MethodInfo>().GetParameters().First<ParameterInfo>().ParameterType;

        // Token: 0x0400001B RID: 27
        private static MethodInfo setVrcEventMethod = Enumerable.FirstOrDefault<PropertyInfo>(VrcEventUtils.vrcEventType.GetProperties(VrcEventUtils.any), (PropertyInfo x) => x.PropertyType == typeof(VRC_EventHandler.VrcEvent)).GetSetMethod();

        // Token: 0x0400001C RID: 28
        private static MethodInfo setPhotonTime = Enumerable.FirstOrDefault<PropertyInfo>(VrcEventUtils.vrcEventType.GetProperties(VrcEventUtils.any), (PropertyInfo x) => x.PropertyType == typeof(double)).GetSetMethod();

        // Token: 0x0400001D RID: 29
        private static FieldInfo vrcBroadcastTypeField = Enumerable.FirstOrDefault<FieldInfo>(VrcEventUtils.vrcEventType.GetFields(VrcEventUtils.any), (FieldInfo x) => x.FieldType == typeof(VRC_EventHandler.VrcBroadcastType));

        // Token: 0x0400001E RID: 30
        private static FieldInfo someRandomIntField = Enumerable.FirstOrDefault<FieldInfo>(VrcEventUtils.vrcEventType.GetFields(VrcEventUtils.any), (FieldInfo x) => x.FieldType == typeof(int));

        // Token: 0x0400001F RID: 31
        private static FieldInfo someRandomLongField = Enumerable.FirstOrDefault<FieldInfo>(VrcEventUtils.vrcEventType.GetFields(VrcEventUtils.any), (FieldInfo x) => x.FieldType == typeof(long));

        // Token: 0x04000020 RID: 32
        private static FieldInfo someRandomFloatField = Enumerable.FirstOrDefault<FieldInfo>(VrcEventUtils.vrcEventType.GetFields(VrcEventUtils.any), (FieldInfo x) => x.FieldType == typeof(float));

        // Token: 0x04000021 RID: 33
        private static MethodInfo getPhotonTime = Enumerable.First<ILInstruction>(typeof(ModerationManager).GetMethod("IsKicked").Parse(), (ILInstruction x) => x.OpCode == OpCodes.Call).GetArgument<MethodInfo>();

        // Token: 0x04000022 RID: 34
        private static MethodInfo getSomeInt = Enumerable.First<ILInstruction>(typeof(UserCameraController).GetMethod("onUseDown").Parse(), (ILInstruction x) => x.OpCode == OpCodes.Call).GetArgument<MethodInfo>();
    }
}
