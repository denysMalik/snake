﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.s = '*';
            p1.Show();

            Point p2 = new Point();
            p2.x = 6;
            p2.y = 7;
            p2.s = '#';
            p2.Show();

            Console.ReadLine();
        }
    }
}
