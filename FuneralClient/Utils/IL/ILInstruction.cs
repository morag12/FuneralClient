using System;
using System.Reflection;
using System.Reflection.Emit;

namespace IL
{
    // Token: 0x02000002 RID: 2
    public struct ILInstruction
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002230 File Offset: 0x00000430
        internal ILInstruction(OpCode opCode, byte[] ilCode, int index, Module manifest)
        {
            OpCode = opCode;
            HasArgument = (opCode.OperandType != OperandType.InlineNone);
            HasSingleByteArgument = (OpCodes.TakesSingleByteArgument(opCode) && OpCode != OpCodes.Ldc_R4);
            Length = opCode.Size + (HasArgument ? (HasSingleByteArgument ? 1 : 4) : 0);
            if (HasArgument)
            {
                if (HasSingleByteArgument)
                {
                    Argument = ilCode[index + opCode.Size];
                }
                else if (OpCode == OpCodes.Ldc_R4)
                {
                    Argument = BitConverter.ToSingle(ilCode, index + opCode.Size);
                }
                else
                {
                    Argument = BitConverter.ToInt32(ilCode, index + opCode.Size);
                }
                if (OpCode == OpCodes.Ldstr)
                {
                    Argument = manifest.ResolveString((int)Argument);
                    return;
                }
                if (OpCode == OpCodes.Call || OpCode == OpCodes.Callvirt || OpCode == OpCodes.Ldftn || OpCode == OpCodes.Newobj)
                {
                    Argument = manifest.ResolveMethod((int)Argument);
                    return;
                }
                if (OpCode == OpCodes.Box || OpCode == OpCodes.Newarr)
                {
                    Argument = manifest.ResolveType((int)Argument);
                    return;
                }
                if (OpCode == OpCodes.Ldfld || OpCode == OpCodes.Stfld || OpCode == OpCodes.Ldflda || OpCode == OpCodes.Ldsfld || OpCode == OpCodes.Stsfld || OpCode == OpCodes.Ldsflda)
                {
                    Argument = manifest.ResolveField((int)Argument);
                    return;
                }
            }
            else
            {
                Argument = null;
            }
        }

        // Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
        public T GetArgument<T>()
        {
            return (T)((object)Argument);
        }

        // Token: 0x06000003 RID: 3 RVA: 0x00002468 File Offset: 0x00000668
        public override string ToString()
        {
            string arg = string.Empty;
            if (HasArgument)
            {
                if (Argument is int || Argument is byte)
                {
                    arg = string.Format(" 0x{0:X}", Argument);
                }
                else if (Argument is string)
                {
                    arg = " \"" + Argument.ToString() + "\"";
                }
                else
                {
                    arg = " " + Argument.ToString();
                }
            }
            return string.Format("{0}{1}", OpCode.Name, arg);
        }

        // Token: 0x04000001 RID: 1
        public readonly OpCode OpCode;

        // Token: 0x04000002 RID: 2
        public readonly object Argument;

        // Token: 0x04000003 RID: 3
        public readonly bool HasArgument;

        // Token: 0x04000004 RID: 4
        public readonly bool HasSingleByteArgument;

        // Token: 0x04000005 RID: 5
        public readonly int Length;
    }
}
