using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();
            tri.X = 5;
            tri.Y = 6;
            tri.Z = 5;
            tri.ShowInfo();
            tri.TestTriangle();

            Student st = new Student();
            st.Name = "Nabil";
            st.Id = "18-38834-3";
            st.Cgpa = 3.70f;
            st.Department = "BSc SE";
            st.ShowInfo();

            Account ac = new Account();
            ac.AccName = "Nabil";
            ac.AcId = "4879880";
            ac.Balance = 50000;
            ac.Deposit(12000);
            ac.Withdraw(6000);

            Course co = new Course();
            co.CourseName = "C#";
            co.CourseCredit = 3;
            co.CourseCode = "CS12201";
            co.ShowCourseInfo();
            Console.ReadKey();

        }
    }
}
