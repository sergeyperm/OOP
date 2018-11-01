using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 6, '*');
            Point p2 = new Point(3, 10, '#');
            p1.Draw();
            p2.Draw();
            Console.ReadLine();


        }
    }
}
