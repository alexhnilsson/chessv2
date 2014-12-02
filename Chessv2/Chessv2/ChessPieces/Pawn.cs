using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chessv2
{
    public class Pawn : IChessPiece
    {
        public Position position;
        public Pawn(string color, Position pos)
        {
            this.Color = color;

        }
        public string Name()
        {
            string name = "P";
            return Color + name;
        }
        public string Color
        {
            get;
            set;
        }

        public void Move()
        {



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
