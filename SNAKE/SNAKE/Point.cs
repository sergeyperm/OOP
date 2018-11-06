using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

      

        public Point() { }
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void Drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
           
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
            {
                x = x + offset;
            }
            else if (direction == Direction.Left)
            {
                x = x - offset;
            }
            else if (direction == Direction.Up)
            {
                y = y - offset;
            }
            else if (direction == Direction.Down)
            {
                y = y + offset;
            }


        }

        internal void Clear()
        {
            sym = ' ';
            Drow();
        }

        public void PrintInfoPoint()
        {
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);
        }

        internal bool IsHit(Point food)
        {
            if ((this.x == food.x) && (this.y == food.y)) return true;
            else return false;
        }
    }
}
