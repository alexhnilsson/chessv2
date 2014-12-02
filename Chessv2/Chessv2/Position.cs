using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    public class Position
    {
        public Position(int x, int y)
        {

            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public Position()
        {

        }

    }

}
