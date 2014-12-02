﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chessv2
{
    public class Position // Positionshantering
    {
        public int x; // skapar x
        public int y; // skapar y
        public Position(int x, int y) // skapar classen position med inten x och inten y
        {
            this.x = x; // denna x = x
            this.y = y; // denna y = y
        }
    }
}