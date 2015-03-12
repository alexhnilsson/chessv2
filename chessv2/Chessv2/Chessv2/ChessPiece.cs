
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chessv2
{
    public class ChessPiece
    {
        public List<List<Position>> movePattern { get; set; }
        public List<Position> MovePositions { get; set; }
        protected string color;
        public bool CanKill = false;
        public bool CanMove = false;
        public bool IsThreatened = false;
        public int GetPositionX { get; set; }
        public int GetPositionY { get; set; }
        public ChessPiece()
        {
            MovePositions = new List<Position>();
            movePattern = new List<List<Position>>();
        }
        public virtual string Describe()
        {
            return "I am at position " + GetPositionX + ", " + GetPositionY;
        }
        public virtual string GetChessType()
        {
            return "Chesspiece type should be written here.";
        }
        public virtual string GetColor()
        {
            return "Color should be written here.";
        }
        public virtual string GetSign()
        {
            return "chesstype sign";
        }
    }
}





namespace Chessv2
{
    public interface IChessPiece
    {
        string Name();
        string Color { get; set; }
        void Move();

    }
}
