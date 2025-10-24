using System;

public abstract class Player
{
    internal enum DiskColor { White, Black }

    DiskColor diskColor { get; set; }

    public abstract void NextMove();
}
