﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSLLVW : RegisterBase
    {
        public PSLLVW(int rs, int rt, int rd, int sa, int funct) 
            : base("PSLLVW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
