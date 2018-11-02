using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class VerticalLine
    {
        public List<Point> pointList;
        public VerticalLine(int y, int yTop, int yDown, char sym)
        {
            pointList = new List<Point>();
            for (int i = yTop; i <= yDown; i++)
            {
                pointList.Add(new Point(i, y, sym));
            }
        }

        public void Draw()
        {
            foreach (Point p in pointList)
            {
                p.Draw();
                Console.WriteLine();
            }
        }
    }
}
