using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class knight1
    {
        public static bool IsCorrectKnight(int x, int y, int x1, int y1)
        {
            bool state;
            if (((x1 == x + 1) || (x1 == x - 1)) && ((y1 == y + 2) || (y1 == y - 2)) || ((x1 == x + 2) || (x1 == x - 2)) && ((y1 == y + 1) || (y1 == y - 1)))
            {
                state = true;
            }
            else
            {
                state = false;
            }
            return state;
        }
    }
}
