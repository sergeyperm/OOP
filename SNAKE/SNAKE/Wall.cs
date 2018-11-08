using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorisontalLine upLine = new HorisontalLine(1, mapWidth-2, 0, 'o');
            HorisontalLine downLine = new HorisontalLine(1, mapWidth-2, mapHeight-1, 'o');
            VerticalLine leftLine = new VerticalLine(1, 1, mapHeight - 1, 'o');
            VerticalLine rightLine = new VerticalLine(mapWidth-2, 1, mapHeight-1, 'o');
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
        public void Draw()
        {
            foreach (var f in wallList)
            {
                f.Drow();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }
    }
}
