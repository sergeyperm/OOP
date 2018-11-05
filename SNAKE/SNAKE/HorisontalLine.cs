using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class HorisontalLine:Figure
    {
       
        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            pointList = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                pointList.Add(new Point(i, y, sym));
            }
        }

     }
}
