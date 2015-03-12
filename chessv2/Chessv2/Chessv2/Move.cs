using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Chessv2
{
    public class Move
    {
        private Player player;
        private List<ChessPiece> pieceList;
        public Move(List<ChessPiece> pieceList, Player player)
        {
            this.player = player;
            this.pieceList = pieceList;
        }
        public List<ChessPiece> GetMyPieces()
        {
            List<ChessPiece> Pieces = new List<ChessPiece>();
            foreach (var piece in pieceList)
            {
                if (piece.GetColor() == player.Team())
                {
                    Pieces.Add(piece);
                }
            }
            return Pieces;
        }
        public List<ChessPiece> CanMovePieces()
        {
            List<ChessPiece> Pieces = new List<ChessPiece>();
            foreach (var piece in GetMyPieces())
            {
                if (piece.CanMove)
                {
                    Pieces.Add(piece);
                }
            }
            return Pieces;
        }
        public void AnalyzePieces()
        {
            foreach (var chessPiece in pieceList)
            {
                if (chessPiece.GetChessType() == "Pawn")
                {
                    AnalyzePawnMoves(chessPiece);
                }
                else
                {
                    AnalyzeMoves(chessPiece);
                }
            }
        }
        private void AnalyzeMoves(ChessPiece piece)
        {
            foreach (var moveList in piece.movePattern)
            {
                foreach (var move in moveList)
                {
                    var possibleMove = new Position(move.x + piece.GetPositionX, move.y + piece.GetPositionY);
                    if (InsideGameboard(possibleMove) && Occupied(possibleMove) && Enemy(possibleMove, piece))
                    {
                        piece.MovePositions.Add(possibleMove);
                        piece.CanMove = true;
                        piece.CanKill = true;
                        break;
                    }
                    if (InsideGameboard(possibleMove) && !Occupied(possibleMove))
                    {
                        piece.MovePositions.Add(possibleMove);
                        piece.CanMove = true;
                    }
                    if (InsideGameboard(possibleMove) && Occupied(possibleMove) && !Enemy(possibleMove, piece))
                    {
                        break;
                    }
                }
            }
        }
        private void AnalyzePawnMoves(ChessPiece piece)
        {
            foreach (var moveList in piece.movePattern)
            {
                foreach (var move in moveList)
                {
                    //attackmove
                    var possibleMove = new Position(move.x + piece.GetPositionX, move.y + piece.GetPositionY);
                    if (InsideGameboard(possibleMove) && Occupied(possibleMove) && Enemy(possibleMove, piece) && DiagnolMove(possibleMove, piece))
                    {
                        piece.MovePositions.Add(possibleMove);
                        piece.CanMove = true;
                        piece.CanKill = true;
                        break;
                    }
                    //Go forward
                    if (InsideGameboard(possibleMove) && !Occupied(possibleMove) && VerticalMove(possibleMove, piece))
                    {
                        piece.MovePositions.Add(possibleMove);
                        piece.CanMove = true;
                    }
                    //obstacle in the way
                    if (InsideGameboard(possibleMove) && Occupied(possibleMove) && VerticalMove(possibleMove, piece))
                    {
                        break;
                    }
                }
            }
        }
        public bool VerticalMove(Position possibleMove, ChessPiece piece)
        {
            return possibleMove.x == piece.GetPositionX && possibleMove.y != piece.GetPositionY;
        }

        public bool DiagnolMove(Position possibleMove, ChessPiece piece)
        {
            return possibleMove.x != piece.GetPositionX && possibleMove.y != piece.GetPositionY;
        }
        private bool InsideGameboard(Position possibleMove)
        {
            return possibleMove.x >= 0 && possibleMove.x < 8 && possibleMove.y >= 0 && possibleMove.y < 8;
        }
        private bool Occupied(Position possibleMove)
        {
            foreach (var chessPiece in pieceList)
            {
                if (chessPiece.GetPositionX == possibleMove.x && chessPiece.GetPositionY == possibleMove.y)
                {
                    return true;
                }
            }

            return false;
        }
        private bool Enemy(Position possibleMove, ChessPiece myPiece)
        {
            foreach (var chessPiece in pieceList)
            {
                if (chessPiece.GetPositionX == possibleMove.x && chessPiece.GetPositionY == possibleMove.y && chessPiece.GetColor() != myPiece.GetColor())
                {
                    return true;
                }

            }
            return false;
        }
    }
}