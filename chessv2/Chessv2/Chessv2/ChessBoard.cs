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
                Console.Write("    ");
                for (var x = 0; x < 8; x++) // SKAPAR EN FOR-LOOP SOM SKRIVER UT "Bredded" skriver ut 8 slots på bredden varje gång
                {
                    Console.Beep(800, 30);
                    
                    Console.Write("[");
                    if (TheBoard[x, y] == null) // om boarden är tom så skapas ett mellanrum
                    {
                        Console.Write("  "); // ^
                    }
                    Console.Write(TheBoard[x, y] + "]" ); 

                }
                
                Console.WriteLine();
            }
            Console.Beep(200, 100);
            Console.WriteLine("   -------------------------------------------------------------");
            int Turn = 0;
            Console.WriteLine("   Turn: " + Turn);
            Console.WriteLine("   Player: ");

        }

        public string[,] FillBoard(List<ChessPiece> popPieces) // fyller boarden med pjäser
        {
            var Board = new string[8, 8]; // Säger att en board ska skapas som är 8x8
            foreach (var piece in popPieces)
            {
                Board[piece.GetPositionX, piece.GetPositionY] = piece.GetSign();
            }
            return Board;
        }
    }
}