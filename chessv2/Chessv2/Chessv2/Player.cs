﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chessv2
{
    public class Player
    {
        private List<ChessPiece> pieceList;
        public Move MakeMove;
        private string Color;
        public Player(string color, List<ChessPiece> pieceList)
        {
            this.pieceList = pieceList;
            MakeMove = new Move(pieceList, this);
            this.Color = color;  
        }
        public string Team()
        {
            return Color;
        }
        public void GetMove()
        {
            var gamepieces = MakeMove.CanMovePieces();
            ChessPiece piece = gamepieces[new Random().Next(0, gamepieces.Count)];
            var position = piece.MovePositions[new Random().Next(0, piece.MovePositions.Count)];
            EraseEnemy(position);
            piece.GetPositionX = position.x;
            piece.GetPositionY = position.y;
        }
        public void EraseEnemy(Position mypos)
        {
            ChessPiece piece = null;
            foreach (var chessPiece in pieceList)
            {
                if (mypos.x == chessPiece.GetPositionX && mypos.y == chessPiece.GetPositionY)
                {
                    piece = chessPiece;
                }
            }
            if (piece != null)
            {
                pieceList.Remove(piece);
            }
        }
    }
}