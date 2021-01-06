using System;
using System.Collections.Generic;
using System.Text;

namespace Section6
{
    //struct =\= de classe, sendo mais performatico
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
