using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList1;
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList1 = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList1.Add(p);
            }
        }
        public void Drow()
        {
            foreach (Point p in pList1)
            {
                p.Draw();
            }

        }

    }
}
