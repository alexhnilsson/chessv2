using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessv2
{
    public interface IChessPiece
    {
        string Name();
        string Color { get; set; }
        void Move();
    }
}
