using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chessv2;

namespace Chessv2
{
    public class Tower : IChessPiece
    {
        public Position position;
        public Tower(string color, Position pos)
        {
            this.Color = color;
            position = pos;
        }

        public string Name()
        {
            string name = "T";
            return Color + name;
        }
        public string Color
        {
            get;
            set;
        }
        public void Move()
        {
            //DoStuff
        }
        public override string ToString()
        {
            return Name();
        }
        public void Draw()
        {
            //int startX = Position.X;
            //int startY = Position.Y;

            //Console.SetCursorPosition(startX, startY);
        }
    }
}
