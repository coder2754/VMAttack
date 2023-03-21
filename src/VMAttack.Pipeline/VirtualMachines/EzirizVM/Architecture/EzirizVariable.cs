﻿namespace VMAttack.Pipeline.VirtualMachines.EzirizVM.Architecture;

public class EzirizVariable
{
    public EzirizVariable(uint index, EzirizType type, bool isByRef)
    {
        Index = index;
        Type = type;
        IsByRef = isByRef;
    }

    public uint Index { get; }
    public bool IsByRef { get; }
    public EzirizType Type { get; }

    public override string ToString() => $"V_{Index} : Type {Type} : IsByRef: {IsByRef}";
}