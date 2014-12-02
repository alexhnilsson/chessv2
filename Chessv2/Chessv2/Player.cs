using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessv2
{
    class Player
    {
        
        public static void ChessPieces()
        {
            // Sets out Black pawns
            Pawn BlackPawn1 = new Pawn("B", new Position(0, 6));
            Pawn BlackPawn2 = new Pawn("B", new Position(1, 6));
            Pawn BlackPawn3 = new Pawn("B", new Position(2, 6));
            Pawn BlackPawn4 = new Pawn("B", new Position(3, 6));
            Pawn BlackPawn5 = new Pawn("B", new Position(4, 6));
            Pawn BlackPawn6 = new Pawn("B", new Position(5, 6));
            Pawn BlackPawn7 = new Pawn("B", new Position(6, 6));
            Pawn BlackPawn8 = new Pawn("B", new Position(7, 6));
            // Sets out White pawns
            Pawn WhitePawn1 = new Pawn("W", new Position(0, 1));
            Pawn WhitePawn2 = new Pawn("W", new Position(1, 1));
            Pawn WhitePawn3 = new Pawn("W", new Position(2, 1));
            Pawn WhitePawn4 = new Pawn("W", new Position(3, 1));
            Pawn WhitePawn5 = new Pawn("W", new Position(4, 1));
            Pawn WhitePawn6 = new Pawn("W", new Position(5, 1));
            Pawn WhitePawn7 = new Pawn("W", new Position(6, 1));
            Pawn WhitePawn8 = new Pawn("W", new Position(7, 1));
            // Sets out White King
            King WhiteKing = new King("W", new Position(4, 0));
            // Sets out Black Kings
            King BlackKing = new King("B", new Position(4, 7));
            // Sets out White Queen
            Queen WhiteQueen = new Queen("W", new Position(3, 0));
            // Sets out Black Queen
            Queen BlackQueen = new Queen("B", new Position(3, 7));
            // Sets out White Tower
            Tower WhiteTower = new Tower("W", new Position(0, 0));
            Tower WhiteTower2 = new Tower("W", new Position(7, 0));
            // Sets out Black Tower
            Tower BlackTower = new Tower("B", new Position(0, 7));
            Tower BlackTower2 = new Tower("B", new Position(7, 7));
            // Sets out White Crusader
            Crusader WhiteCrusader = new Crusader("W", new Position(1, 0));
            Crusader WhiteCrusader2 = new Crusader("W", new Position(6, 0));
            // Sets out Black Crusader
            Crusader BlackCrusader = new Crusader("B", new Position(1, 7));
            Crusader BlackCrusader2 = new Crusader("B", new Position(6, 7));
            // Sets out white Bishop
            Bishop WhiteBishop = new Bishop("W", new Position(2, 0));
            Bishop WhiteBishop2 = new Bishop("W", new Position(5, 0));
            // Sets out Black Bishop
            Bishop BlackBishop = new Bishop("B", new Position(2, 7));
            Bishop BlackBishop2 = new Bishop("B", new Position(5, 7));

            //Lista
            List<IChessPiece> BlackPieces = new List<IChessPiece>();
            List<IChessPiece> WhitePieces = new List<IChessPiece>();
            
            //Lägger till i vit lista
            WhitePieces.Add(WhitePawn1);
            WhitePieces.Add(WhitePawn2);
            WhitePieces.Add(WhitePawn3);
            WhitePieces.Add(WhitePawn4);
            WhitePieces.Add(WhitePawn5);
            WhitePieces.Add(WhitePawn6);
            WhitePieces.Add(WhitePawn7);
            WhitePieces.Add(WhitePawn8);
            WhitePieces.Add(WhiteKing);
            WhitePieces.Add(WhiteQueen);
            WhitePieces.Add(WhiteCrusader2);
            WhitePieces.Add(WhiteCrusader);
            WhitePieces.Add(WhiteBishop);
            WhitePieces.Add(WhiteBishop2);
            WhitePieces.Add(WhiteTower);
            WhitePieces.Add(WhiteTower2);

            // Lägger till i svart lista
            BlackPieces.Add(BlackPawn1);
            BlackPieces.Add(BlackPawn2);
            BlackPieces.Add(BlackPawn3);
            BlackPieces.Add(BlackPawn4);
            BlackPieces.Add(BlackPawn5);
            BlackPieces.Add(BlackPawn6);
            BlackPieces.Add(BlackPawn7);
            BlackPieces.Add(BlackPawn8);
            BlackPieces.Add(BlackKing);
            BlackPieces.Add(BlackQueen);
            BlackPieces.Add(BlackBishop);
            BlackPieces.Add(BlackBishop2);
            BlackPieces.Add(BlackCrusader);
            BlackPieces.Add(BlackCrusader2);
            BlackPieces.Add(BlackTower);
            BlackPieces.Add(BlackTower2);

             
        }
        
        

    }
}
