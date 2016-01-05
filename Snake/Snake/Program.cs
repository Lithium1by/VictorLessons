using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine HLine1 = new HorizontalLine(2, 50, 1, '_');
            HLine1.Drow();

            HorizontalLine HLine2 = new HorizontalLine(2, 50, 20, '_');
            HLine2.Drow();

            VerticalLine VLine1 = new VerticalLine(2, 20, 1, '|');
            VLine1.Drow();

            VerticalLine VLine2 = new VerticalLine(2, 20, 51, '|');
            VLine2.Drow();

            Console.ReadLine();
        }
    }
}
