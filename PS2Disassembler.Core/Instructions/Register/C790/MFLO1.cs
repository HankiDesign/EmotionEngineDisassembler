﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MFLO1 : RegisterBase
    {
        public MFLO1(int rs, int rt, int rd, int sa, int funct) 
            : base("MFLO1", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
