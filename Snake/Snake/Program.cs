using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {

        public static void Show(int x, int y, char s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Program.Show(x1, y1, sym1);

            int x2 = 6;
            int y2 = 7;
            char sym2 = '#';

            Program.Show(x2, y2, sym2);

            Console.ReadLine();

        }
    }
}
