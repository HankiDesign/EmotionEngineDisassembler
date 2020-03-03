﻿namespace PS2Disassembler.Core.Instructions.Immediate.C790
{
    public class MTSAH : ImmediateBase
    {
        public MTSAH(int rs, int rt, int imm) : base("MTSAH", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
