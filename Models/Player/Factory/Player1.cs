﻿using System;

internal class Player1 : Factory
{

    public HumanPlayer create(string name)
    {
        HumanPlayer player1 = new HumanPlayer(name);
        return player1;
    }
}
