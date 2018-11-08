using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Figure
    {
        protected List<Point> pointList;
        public void Drow()
        {
            foreach (Point p in pointList)
            {
                p.Drow();
            }
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pointList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        internal bool IsHit(Point point)
        {
            foreach (var p in pointList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
