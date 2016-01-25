using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    public class Move_Circle : Circle
    {
        int x1, y1,
            x2, y2;
        public void MoveTo(int tox, int toy)
            {
            x1 = x;
            y1 = y;
            x2 = tox;
            y2 = toy;
            }

        public void step(int p)
        {
            x = x1 + (x2 - x1) * p / 100;
            y = y1 + (y2 - y1) * p / 100;
        }
        public Move_Circle(int x, int y, int radius)
            : base (x, y, radius)
        {

        }
    }
}
