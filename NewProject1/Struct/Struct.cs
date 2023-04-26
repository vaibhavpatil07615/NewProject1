using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Struct
{
    internal struct Car

    {
        int price;
        string colour;
        string Brand;
        public Car(int price, string colour, string Brand)
        {
            this.price = price;
            this.colour = colour;
            this.Brand = Brand;
        }


        public void info()
        {
            price = 500000;
            colour = "red";
            Brand = "mahindra";
            Console.WriteLine(price + " " + colour + " " + Brand);
        }
    }

    class Carinfo
    {
        static void Main(string[] args)
        {
            Car b = new Car(800000, "black", "oddy");



        }
    }
    struct student
    {
        int id;
        string name;
        int marks;

        public student(int id, string name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + marks);
        }
    }
    class Student
    {
        static void Main(string[] args)
        {
            student[] s = new student[3];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("enter student id ");
                int id1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter student name");
                string name1 = Console.ReadLine();
                Console.WriteLine("enter students marks");
                int marks1 = int.Parse(Console.ReadLine());

                student v = new student(id1, name1, marks1);
                s[i] = v;

            }
            foreach (student v in s)
            {
                v.display();
            }
        }





        // c.info();







    }
}
    

