﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessv2
{



    // DETTA CHESS FUNGERAR,
    public class PrintBoard // SKRIVER UT OCH HANTERAR CHESSBOARD
    {
        public void Board(List<ChessPiece> piece)
        {
            Console.Clear();
            Console.WriteLine("   AlphaChess v.1.33.7 | Copyright 2014 c The Game Geeks at EC \r\n" + // TOPPEN
                              "   -------------------------------------------------------------");
            var TheBoard = FillBoard(piece);

            for (var y = 0; y < 8; y++) // SKAPAR EN FOR-LOOP SOM SKRIVER UT "HÖJDEN" Skriver ut en slot på höjden varje gång
            {

                for (var x = 0; x < 8; x++) // SKAPAR EN FOR-LOOP SOM SKRIVER UT "Bredded" skriver ut 8 slots på bredden varje gång
                {
                    Console.Write("[");
                    if (TheBoard[x, y] == null) // om boarden är tom så skapas ett mellanrum
                    {
                        Console.Write("  "); // ^
                    }
                    Console.Write(TheBoard[x, y] + "]" ); 
                }
                
                Console.WriteLine();
            }

        }
        public string[,] FillBoard(List<ChessPiece> popPieces) // fyller boarden med pjäser
        {
            var Board = new string[8, 8]; // Säger att en board ska skapas med 8 x och 8 y
            foreach (var piece in popPieces)
            {
                Board[piece.GetPositionX, piece.GetPositionY] = piece.GetSign();
            }
            return Board;
        }
    }
}