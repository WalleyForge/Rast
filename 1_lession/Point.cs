﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lession
{
    class Point
    {
        public int x;
        public int y;
        public char s;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
