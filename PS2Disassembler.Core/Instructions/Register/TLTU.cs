﻿namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLTU : RegisterBase
    {
        public TLTU(string rs, string rt, string rd, string sa, string funct)
            : base("TLTU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}