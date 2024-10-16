using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication96
{
    class Student
    {
        private string name;
        private string address;
        private double mark;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public Student(string n, string addr, double m)
        {
            name = n;
            address = addr;
            mark = m;
        }
        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Mark: " + mark);

        }

        class program
        {
            static void Main(string[] args)
            {
                Student student = new Student("rasha", "60 St", 75.5);

                student.Display();
                Console.ReadLine();



            }
        }
    }
}
