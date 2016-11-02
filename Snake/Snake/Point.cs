﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char s;

        public Point(int _x, int _y, char _s)
        {
            x = _x;
            y = _y;
            s = _s;
        }

        public void Show()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
