using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class Triangle
    {
        int x;
        int y;
        int z;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
       public void ShowInfo()
        {
            Console.WriteLine("X :" + x);
            Console.WriteLine("Y :" + y);
            Console.WriteLine("Z :" + z);
        }
        
        public void TestTriangle()
        {
            if (x == y || y == z)
            {
                Console.WriteLine("The Triangle is equalateral");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("The Triangle is isosceles");
            }
            else
            {
                Console.WriteLine("The Triangle is scalene");
            }
        }
    }
}
