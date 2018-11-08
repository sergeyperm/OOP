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
            //HorisontalLine upLine = new HorisontalLine(1,78,1,'o');
            //HorisontalLine downLine = new HorisontalLine(1, 78, 24, 'o');
            //upLine.Drow();
            //downLine.Drow();

            //VerticalLine leftLine = new VerticalLine(1, 1, 24, 'o');
            //leftLine.Drow();
            //VerticalLine rightLine = new VerticalLine(78, 1, 24, 'o');
            //rightLine.Drow();

            Point point = new Point(10, 10, '*');
            Snake snake = new Snake(point, 5, Direction.Right);
            snake.Drow();
            FoodCreator foodCreator = new FoodCreator(25, 80, '$');
            Point food = foodCreator.Create();
            food.Drow();


            Walls walls = new Walls(79, 24);
            walls.Draw();

            while (true)
            {
                if ((walls.IsHit(snake)) || (snake.IsHitTail()))
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.Create();
                    food.Drow();
                }
                else
                {
                    snake.Move();
                }


                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                
            }

            Console.SetCursorPosition(40, 12);
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }

     }
}
