using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessv2
{
    class ChessBoard
    {
        Player play = new Player();
        public ChessBoard()
        {
            play.ChessPieces();
        }
        public IChessPiece GetChessPieceAt(int x, int y)
        {
            foreach (var blackpiece in play.BlackPieces)
            {
                if (blackpiece.position.X == x && blackpiece.position.Y == y)
                {
                    return blackpiece;
                }
            }
            foreach (var whitepiece in play.WhitePieces)
            {
                if (whitepiece.position.X == x && whitepiece.position.Y == y)
                {
                    return whitepiece;
                }
            }
            return null;
        }
        public void Print()
        {
            //play.BlackPieces;
            //play.WhitePieces;

            //skapar ett shackbräde som är 8 gånger 8
            //denna skapar en vit bakgrund som är 8x8
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("█");
                    Console.WriteLine();
                }
            }
            //denna skapar en ruta som är svart på varanan ruta
            for (int x = 0; x < 8; x = x + 2)
            {
                for (int y = 0; y < 8; y = y + 2)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                    Console.WriteLine();
                }
            }
            //denna skapar en ruta som är svart på varanan ruta som inte in gick i den förra loopen
            for (int x = 1; x < 8; x = x + 2)
            {
                for (int y = 1; y < 8; y = y + 2)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                    Console.WriteLine();

                }
            }

        }





    }
}
