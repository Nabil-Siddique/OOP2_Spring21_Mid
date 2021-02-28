using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Student
    {

        private string name;
        private string id;
        private float cgpa;


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

        public float Cgpa
        {

            get { return cgpa; }
            set { cgpa = value; }

        }


        Department department;

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }

        public Student() { }

        public Student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("CGPA: " + cgpa);
            department.ShowInfo();
        }
    }
}