﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMFHI : RegisterBase
    {
        public PMFHI(string rs, string rt, string rd, string sa, string funct) 
            : base("PMFHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
