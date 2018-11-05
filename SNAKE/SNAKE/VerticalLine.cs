using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class VerticalLine:Figure
    {
       
        public VerticalLine(int x, int yTop, int yDown, char sym)
        {
            pointList = new List<Point>();
            for (int i = yTop; i <= yDown; i++)
            {
                pointList.Add(new Point(x, i, sym));
            }
        }

        
    }
}
