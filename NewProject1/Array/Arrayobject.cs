using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Array
{
    internal class Employee

    {
        internal int id;
        internal string name;
        internal int salary;
        public Employee(int id, string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }
        public override string ToString()
        {
            return id + " " + name + " " + salary;

        }

    }
    class Arrayobject
    {
        static void Main(string[] args)
        {

            Employee[] e = new Employee[4];
            {
                e[0] = new Employee(123, "vaibhav", 15000);
                e[1] = new Employee(124, "rupesh", 20000);
                e[2] = new Employee(125, "sagar", 25000);
                e[3] = new Employee(126, "harish", 30000);



            }
            for (int i = 0; i< e.Length; i++)
            {
                Console.WriteLine(e[i]);

            }
            Console.WriteLine("....");
            foreach(Employee t in e)
            {
                if (t.salary>=25000)
                Console.WriteLine(t);

            }


        }
    }
    class Stud
    {
        int id;
        string name;
        int[] percentage;
        int[] marks;
        public Stud(int id, string name, int[] percentage, int[] marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;



        }
        public override string ToString()
        {
            return this.id + " " + this.name + " " + string.Join("", marks);
        }
    }
    class Object
    {

    

        static void Main(string[] args)
        {
            Stud[] s = new Stud[3];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("enter id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter number");
                string nm = Console.ReadLine();
                Console.WriteLine("enter marks");
                int[]mk = new int[3];
                for (int j =0; j < mk.Length; j++)
                {
                    mk[j] = int.Parse(Console.ReadLine());
                    

                }
               // s[i] = new Stud(id, nm, mk);


            }
          
            foreach (Stud st in s)
            {
                Console.WriteLine(st);
            }
        }
    }
    class Employee3
    {
        int id;
        string name;
      internal  int salary;
        public Employee3(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }
        public override string ToString()
        {
            return this.id +" " +this.name +" " +this.salary;
        }

    }
    class Salary
    {
        static void Main(string[] args)
        {
            Employee3[] emp = new Employee3[3];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("enter id");
                int id1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name");
                string nm = Console.ReadLine();
                Console.WriteLine("enter salary");
                int sl = int.Parse(Console.ReadLine());


                emp[i] = new Employee3(id1, nm, sl);
            }


            foreach (Employee3 s in emp)
            {
                Console.WriteLine(s);

                Console.WriteLine("..........");
                foreach (Employee3 t in emp)
                {
                    if (t.salary > 20000)
                    {
                        double b = (0.10 * t.salary) + t.salary;

                        Console.WriteLine("revised salary = " + b + s);
                    }


                }
            }
            }



         
                    


        }
       
       
    }
    


