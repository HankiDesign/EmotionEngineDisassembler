﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSLLVW : RegisterBase
    {
        public PSLLVW(string rs, string rt, string rd, string sa, string funct) 
            : base("PSLLVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}