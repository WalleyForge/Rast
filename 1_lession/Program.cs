using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lession
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = 1;
            int y = 5;
            char s = '*';
            Draw(x, y, s);

            int x1 = 2;
            int y1 = 7;
            char s1 = '*';
            Draw(x1, y1, s1);
            Console.ReadLine();
        }
        static void Draw(int x, int y, char s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }  
    }
}
