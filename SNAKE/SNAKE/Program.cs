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
            HorisontalLine horLine = new HorisontalLine(10,50,5,'=');
            horLine.Draw();
            Console.ReadLine();
            VerticalLine verLine = new VerticalLine(10, 5, 20, '*');
            verLine.Draw();
            Console.ReadLine();
        

        }

        static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

    }
}
