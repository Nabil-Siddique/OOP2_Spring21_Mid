using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_1_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Number :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
