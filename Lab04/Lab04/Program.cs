using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Survey Corp", "SC");
            Department d2 = new Department("Military Police", "MP");
            Student s1 = new Student("Eren", "1001", 3.2f);
            Student s2 = new Student("Annie", "2060", 3.7f);
            Student s3 = new Student("Mikasa", "1020", 4.0f);
            s1.Department = d1;
            s2.Department = d2;
            s3.Department = d1;
            s1.ShowInfo();
            s2.ShowInfo();
            s3.ShowInfo();
        }
    }
}