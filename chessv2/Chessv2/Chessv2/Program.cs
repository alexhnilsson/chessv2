﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chessv2
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Menu menu = new Menu();// SKRIVER UT MENYN
            menu.MenuStart(); // STARTAR MENYN

            Game gametime = new Game(); // SKAPAR NYTT GAME
            gametime.StartGame(); // STARTAR NYTT GAME
        }
    }
}