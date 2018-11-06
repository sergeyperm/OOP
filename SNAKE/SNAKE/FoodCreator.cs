using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;
        Random rand = new Random();

        public FoodCreator(int mapWidht, int mapHeight,char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point Create()
        {
            Point p = new Point();
            p.x = rand.Next(2, mapHeight-5);
            p.y =  rand.Next(2, mapWidht-5);
            p.sym = sym;
            return p;
        }
    }
}
