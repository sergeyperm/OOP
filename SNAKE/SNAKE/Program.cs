using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SNAKE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);
            //Point p1 = new Point(3, 6, '*');
            //Point p2 = new Point(3, 10, '#');
            HorisontalLine upLine = new HorisontalLine(1,78,1,'o');
            HorisontalLine downLine = new HorisontalLine(1, 78, 24, 'o');
            upLine.Drow();
            downLine.Drow();

            VerticalLine leftLine = new VerticalLine(1, 1, 24, 'o');
            leftLine.Drow();
            VerticalLine rightLine = new VerticalLine(78, 1, 24, 'o');
            rightLine.Drow();
            Console.ReadLine();

            Point point = new Point(10, 10, '*');
            Snake snake = new Snake(point, 10, Direction.Right);
            snake.Drow();
            for (int j = 0; j <=10; j++)
            {
                snake.Move();
                Thread.Sleep(300);
            }
            Console.ReadLine();

            //horLine.Draw();
            //Console.ReadLine();
            //VerticalLine verLine = new VerticalLine(10, 5, 20, '*');
            //verLine.Draw();
            //Console.ReadLine();


        }

        //static void Move(Point p, int dx, int dy)
        //{
        //    p.x = p.x + dx;
        //    p.y = p.y + dy;
        //}

    }
}
