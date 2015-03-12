﻿using System;
using System.Collections.Generic;
using System.Linq;
﻿using System.Runtime.InteropServices.WindowsRuntime;
﻿using System.Text;

namespace Chessv2
{
    public class Game
    {
        public Pieces PieceList;
        private Player WhitePlayer;
        private Player BlackPlayer;
        private PrintBoard PrintBoard;
        public Game()
        {
            PrintBoard = new PrintBoard();
            PieceList = new Pieces();
            WhitePlayer = new Player("White", PieceList.GetPieceList());
            BlackPlayer = new Player("Black", PieceList.GetPieceList());
        }
        public void StartGame()
        {
            while (true)
            {
                PrintBoard.Board(PieceList.GetPieceList());
                Console.ReadKey();
                WhiteTurn();

                PrintBoard.Board(PieceList.GetPieceList());
                Console.ReadKey();
                BlackTurn();
                PrintBoard.Board(PieceList.GetPieceList());
            }
        }
        public void BlackTurn()
        {
            BlackPlayer.MakeMove.AnalyzePieces();
            BlackPlayer.GetMove();
        }
        public void WhiteTurn()
        {
            WhitePlayer.MakeMove.AnalyzePieces();
            WhitePlayer.GetMove();
        }
    }
}