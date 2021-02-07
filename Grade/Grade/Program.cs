using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            double ph=60;
            Console.WriteLine("Press Enter after each grade please." );

            Console.Write("Physics :");
          



            if (ph < 50)
            {
                Console.Write("F");
                Console.ReadLine();
            }
            else if (ph < 75)
            {
                Console.Write("C+ ");
                Console.ReadLine();
            }
            else if (ph < 80)
            {
                Console.Write("B ");
                Console.ReadLine();
            }
            else if (ph < 85)
            {
                Console.Write("B+ ");
                Console.ReadLine();
            }
            else if (ph < 90)
            {
                Console.Write("A ");
                Console.ReadLine();
            }
            else
            {
                Console.Write("A+ ");
                Console.ReadLine();
            }

            double ch = 90;

            Console.Write("Chemistry :");


            if (ch < 50)
            {
                Console.Write("F");
                Console.ReadLine();
            }
            else if (ch < 75)
            {
                Console.Write("C+ ");
                Console.ReadLine();
            }
            else if (ch < 80)
            {
                Console.Write("B ");
                Console.ReadLine();
            }
            else if (ch < 85)
            {
                Console.Write("B+ ");
                Console.ReadLine();
            }
            else if (ch < 90)
            {
                Console.Write("A ");
                Console.ReadLine();
            }
            else
            {
                Console.Write("A+ ");
                Console.ReadLine();
            }
            double bi = 83;

            Console.Write("Biology :");


            if (bi < 50)
            {
                Console.Write("F");
                Console.ReadLine();
            }
            else if (bi < 75)
            {
                Console.Write("C+ ");
                Console.ReadLine();
            }
            else if (bi < 80)
            {
                Console.Write("B ");
                Console.ReadLine();
            }
            else if (bi < 85)
            {
                Console.Write("B+ ");
                Console.ReadLine();
            }
            else if (bi < 90)
            {
                Console.Write("A ");
                Console.ReadLine();
            }
            else
            {
                Console.Write("A+ ");
                Console.ReadLine();
            }

            double ma = 83;

            Console.Write("Math :");


            if (ma < 50)
            {
                Console.Write("F");
                Console.ReadLine();
            }
            else if (ma < 75)
            {
                Console.Write("C+ ");
                Console.ReadLine();
            }
            else if (ma < 80)
            {
                Console.Write("B ");
                Console.ReadLine();
            }
            else if (ma < 85)
            {
                Console.Write("B+ ");
                Console.ReadLine();
            }
            else if (ma < 90)
            {
                Console.Write("A ");
                Console.ReadLine();
            }
            else
            {
                Console.Write("A+ ");
                Console.ReadLine();
            }

            double co = 83;

            Console.Write("Computer :");


            if (co < 50)
            {
                Console.Write("F");
                Console.ReadLine();
            }
            else if (co < 75)
            {
                Console.Write("C+ ");
                Console.ReadLine();
            }
            else if (co < 80)
            {
                Console.Write("B ");
                Console.ReadLine();
            }
            else if (co < 85)
            {
                Console.Write("B+ ");
                Console.ReadLine();
            }
            else if (co < 90)
            {
                Console.Write("A ");
                Console.ReadLine();
            }
            else
            {
                Console.Write("A+ ");
                Console.ReadLine();
            }

            double total;
            total = ph + ch + co + ma + bi;
            double a;
            a = total / 5;
            Console.WriteLine("average: ");
            Console.Write(a);
            Console.ReadLine();



        }
    }
}
