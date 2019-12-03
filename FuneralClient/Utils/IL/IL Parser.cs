using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace IL
{
    // Token: 0x02000003 RID: 3
    public static class ILParser
    {
        // Token: 0x06000004 RID: 4 RVA: 0x0000250C File Offset: 0x0000070C
        static ILParser()
        {
            FieldInfo[] fields = typeof(OpCodes).GetFields();
            for (int i = 0; i < fields.Length; i++)
            {
                OpCode opCode = (OpCode)fields[i].GetValue(null);
                if (opCode.Size == 1)
                {
                    ILParser.OpCodes[(int)opCode.Value] = opCode;
                }
                else
                {
                    ILParser.MultiOpCodes[(int)(opCode.Value & 255)] = opCode;
                }
            }
        }

        // Token: 0x06000005 RID: 5 RVA: 0x0000205D File Offset: 0x0000025D
        public static ILInstruction[] Parse(this MethodInfo method)
        {
            return ILParser.Parse(method.GetMethodBody().GetILAsByteArray(), method.DeclaringType.Assembly.ManifestModule);
        }

        // Token: 0x06000006 RID: 6 RVA: 0x0000207F File Offset: 0x0000027F
        public static ILInstruction[] Parse(this MethodBase methodBase)
        {
            return ILParser.Parse(methodBase.GetMethodBody().GetILAsByteArray(), methodBase.Module);
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002097 File Offset: 0x00000297
        public static ILInstruction[] Parse(this MethodBody methodBody, Module manifest)
        {
            return ILParser.Parse(methodBody.GetILAsByteArray(), manifest);
        }

        // Token: 0x06000008 RID: 8 RVA: 0x00002598 File Offset: 0x00000798
        public static ILInstruction[] Parse(byte[] ilCode, Module manifest)
        {
            List<ILInstruction> list = new List<ILInstruction>();
            for (int i = 0; i < ilCode.Length; i++)
            {
                ILInstruction ilinstruction = new ILInstruction((ilCode[i] == 254) ? ILParser.MultiOpCodes[(int)ilCode[i + 1]] : ILParser.OpCodes[(int)ilCode[i]], ilCode, i, manifest);
                list.Add(ilinstruction);
                i += ilinstruction.Length - 1;
            }
            return list.ToArray();
        }

        // Token: 0x04000006 RID: 6
        public static readonly OpCode[] OpCodes = new OpCode[256];

        // Token: 0x04000007 RID: 7
        public static readonly OpCode[] MultiOpCodes = new OpCode[31];
    }
}
