using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;

        void ShowInfo()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("ID :" + id);
            Console.WriteLine("Department :" + department);
            Console.WriteLine("CGPA :" + cgpa);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
    }
}
