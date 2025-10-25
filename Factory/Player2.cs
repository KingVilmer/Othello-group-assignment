using System;

internal class Player2 : Factory
{

    public Player.HumanPlayer create(string name)
    {
        return new HumanPlayer(name, Player.DiskColor.White);
    }
}
