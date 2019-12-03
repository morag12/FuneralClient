using IL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using UnityEngine;
using Valve.VR;

namespace Funeral
{
    // Token: 0x02000007 RID: 7
    public static class ViveInput
    {
        // Token: 0x06000021 RID: 33 RVA: 0x000031F0 File Offset: 0x000013F0
        static ViveInput()
        {
            IEnumerable<MethodInfo> source = Enumerable.Where<MethodInfo>(Enumerable.Select<ILInstruction, MethodInfo>(Enumerable.Where<ILInstruction>(typeof(VRCInputProcessorVive).GetMethod("Apply", (BindingFlags)(-1)).Parse(), (ILInstruction x) => x.OpCode == OpCodes.Callvirt), delegate (ILInstruction x)
            {
                ILInstruction ilinstruction = x;
                return ilinstruction.GetArgument<MethodInfo>();
            }), (MethodInfo x) => x.DeclaringType == ViveInput.getSteamVRControllerById.ReturnType).Distinct<MethodInfo>();
            ViveInput.viveGetAxis2D = source.ElementAt(0);
            ViveInput.viveGetButtonPressed = source.ElementAt(1);
            ViveInput.viveGetButtonTouched = source.ElementAt(2);
            ViveInput.getIndex = typeof(SteamVR_TrackedObject).GetField("index");
        }

        // Token: 0x06000022 RID: 34 RVA: 0x00003330 File Offset: 0x00001530
        internal static bool GetButtonPressed(EVRButtonId button, ViveInput.Controller controller)
        {
            bool result;
            try
            {
                result = (bool)ViveInput.viveGetButtonPressed.Invoke(ViveInput.GetControllerObject(controller), new object[]
                {
                    (int)button
                });
            }
            catch
            {
                result = false;
            }
            return result;
        }

        // Token: 0x06000023 RID: 35 RVA: 0x00003384 File Offset: 0x00001584
        internal static bool GetButtonTouched(EVRButtonId button, ViveInput.Controller controller)
        {
            bool result;
            try
            {
                result = (bool)ViveInput.viveGetButtonTouched.Invoke(ViveInput.GetControllerObject(controller), new object[]
                {
                    (int)button
                });
            }
            catch
            {
                result = false;
            }
            return result;
        }

        // Token: 0x06000024 RID: 36 RVA: 0x000033D8 File Offset: 0x000015D8
        internal static Vector2 GetAxis2D(EVRButtonId axis, ViveInput.Controller controller)
        {
            Vector2 result;
            try
            {
                result = (Vector2)ViveInput.viveGetAxis2D.Invoke(ViveInput.GetControllerObject(controller), new object[]
                {
                    (int)axis
                });
            }
            catch
            {
                result = Vector2.zero;
            }
            return result;
        }

        // Token: 0x06000025 RID: 37 RVA: 0x00003430 File Offset: 0x00001630
        public static SteamVR_ControllerManager GetSteamVR_ControllerManager()
        {
            bool flag = !VRCTrackingManager.IsInitialized();
            SteamVR_ControllerManager result;
            if (flag)
            {
                result = null;
            }
            else
            {
                result = VRCTrackingManager.GetTrackingComponent<SteamVR_ControllerManager>();
            }
            return result;
        }

        // Token: 0x06000026 RID: 38 RVA: 0x00003458 File Offset: 0x00001658

        public static object GetControllerObject(ViveInput.Controller c)
        {
            try
            {
                SteamVR_TrackedObject component = ((c == ViveInput.Controller.Left) ? ViveInput.GetSteamVR_ControllerManager().left : ViveInput.GetSteamVR_ControllerManager().right).GetComponent<SteamVR_TrackedObject>();
                int index = component.GetIndex();
                bool flag = index >= 0 && component.IsValid();
                if (flag)
                {
                    return ViveInput.getSteamVRControllerById.Invoke(null, new object[]
                    {
                        index
                    });
                }
            }
            catch (Exception value)
            {
                Console.WriteLine(value);
            }
            return null;
        }

        // Token: 0x06000027 RID: 39 RVA: 0x000034E4 File Offset: 0x000016E4
        public static bool IsValid(this SteamVR_TrackedObject o)
        {
            return (bool)ViveInput.getObjectIsValid.Invoke(o, null);
        }

        // Token: 0x06000028 RID: 40 RVA: 0x00003508 File Offset: 0x00001708
        public static int GetIndex(this SteamVR_TrackedObject obj)
        {
            return (int)ViveInput.getIndex.GetValue(obj);
        }

        // Token: 0x04000016 RID: 22
        public static MethodInfo viveGetAxis2D;

        // Token: 0x04000017 RID: 23
        public static MethodInfo viveGetButtonPressed;

        // Token: 0x04000018 RID: 24
        public static MethodInfo viveGetButtonTouched;

        // Token: 0x04000019 RID: 25
        public static FieldInfo getIndex;

        // Token: 0x0400001A RID: 26
        public static Type steamVRControllerType = Enumerable.FirstOrDefault<ILInstruction>(typeof(SteamVR_Render).GetMethod("Update", (BindingFlags)(-1)).Parse(), (ILInstruction x) => x.OpCode == OpCodes.Call).GetArgument<MethodInfo>().DeclaringType;

        // Token: 0x0400001B RID: 27
        public static MethodInfo getSteamVRControllerById = Enumerable.First<MethodInfo>(ViveInput.steamVRControllerType.GetMethods(), delegate (MethodInfo x)
        {
            bool flag = x.GetParameters().Length == 1 && x.GetParameters()[0].ParameterType == typeof(int);
            bool result;
            if (flag)
            {
                result = (Enumerable.FirstOrDefault<ILInstruction>(x.Parse(), (ILInstruction y) => y.OpCode == OpCodes.Ldc_I4_S).GetArgument<byte>() == 64);
            }
            else
            {
                result = false;
            }
            return result;
        });

        // Token: 0x0400001C RID: 28
        public static MethodInfo getObjectIsValid = Enumerable.First<PropertyInfo>(typeof(SteamVR_TrackedObject).GetProperties(), (PropertyInfo x) => x.GetGetMethod().Name == "get_isValid").GetGetMethod();

        // Token: 0x02000192 RID: 402
        internal enum Axis2D
        {
            // Token: 0x040008AA RID: 2218
            None,
            // Token: 0x040008AB RID: 2219
            PrimaryThumbstick,
            // Token: 0x040008AC RID: 2220
            SecondaryThumbstick,
            // Token: 0x040008AD RID: 2221
            Any = -1
        }

        // Token: 0x02000193 RID: 403
        public enum Controller
        {
            // Token: 0x040008AF RID: 2223
            Left,
            // Token: 0x040008B0 RID: 2224
            Right
        }

        // Token: 0x02000194 RID: 404
        internal enum Button
        {
            // Token: 0x040008B2 RID: 2226
            None,
            // Token: 0x040008B3 RID: 2227
            One,
            // Token: 0x040008B4 RID: 2228
            Two,
            // Token: 0x040008B5 RID: 2229
            Three = 4,
            // Token: 0x040008B6 RID: 2230
            Four = 8,
            // Token: 0x040008B7 RID: 2231
            PrimaryIndexTrigger = 8192,
            // Token: 0x040008B8 RID: 2232
            PrimaryThumbstick = 32768,
            // Token: 0x040008B9 RID: 2233
            PrimaryThumbRest = 4096,
            // Token: 0x040008BA RID: 2234
            SecondaryIndexTrigger = 2097152,
            // Token: 0x040008BB RID: 2235
            SecondaryThumbstick = 8388608,
            // Token: 0x040008BC RID: 2236
            SecondaryThumbRest = 1048576,
            // Token: 0x040008BD RID: 2237
            Any = -1
        }
    }
}
