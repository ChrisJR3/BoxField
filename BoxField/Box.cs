using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BoxField
{
    class Box
    {
        public SolidBrush boxBrush;
        public int x, y, size;

        public Box(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
        }

        public Box(SolidBrush _boxBrush, int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
        }

        public void Fall()
        {
            y = y + 3;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x = x - 5;
            }
            if (direction == "right")
            {
                x = x + 5;
            }
        }
    }
}
