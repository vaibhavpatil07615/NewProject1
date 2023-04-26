using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewProject1.OOPS
{
    internal class Employee4
    {
       //2. employee with parameterized constructor , display method 
         int id;
        int salary;
       string name;
        public Employee4(int id, int salary,string name)
        {
           this.id = id;
            this.salary = salary;
            this.name = name;
         

        }
        public static void total()
        {
            int total_no_of_employee = 20;
            Console.WriteLine("total no of employee = " + total_no_of_employee);
        }
        public override string ToString()
        {
            return "id = "+ this.id + " " + "salary = " + this.salary + " "+ "name = " +this. name;
        }
        static void Main(string[] args)
        {
            Employee4 e = new Employee4(123, 40000, "vaibhav");
            Employee4.total();
            Console.WriteLine(e.ToString());
        }
    }
    // method overloading.+ using static method + ambiguity
    class Overload
    {
       static  void Arithmatic (int a ,int b)
        {
            Console.WriteLine("addition of 2 integer type parameter = " +(a+b));
        }
        static  void Arithmatic (int a,float b)
        {
            float c = a-b ;
            
            Console.WriteLine(" substraction using 1 integer,1 float type parameter = "+ c);
        }
       static  void Arithmatic (float a, double b)
        {
           double c =  a * b;
            Console.WriteLine("multiplication using 3 double type variable " + c);
        }
        static  void Arithmatic(float a, float b)
        {
            double c = a / b;
            Console.WriteLine("dividation using float type variable =  " + c);
        }
        static void Main(string[] args)
        {
            Overload.Arithmatic(2, 4);
            Overload.Arithmatic(3, 5f);
            Overload.Arithmatic(4f, 6);
            Overload.Arithmatic(10f, 5f);
        }

       

    }
    class Employee3
    {
        // overriding example
        public virtual void Employee(int salary)
        {

            Console.WriteLine("temperoary and permanant employee");
            Console.WriteLine("temperoary and permanant employee have diffrent salary");

        }




    }
    class Temperoary : Employee3
    {
        public override void Employee(int salary)
        {
            base.Employee(salary);

            Console.WriteLine("non techical staff are temperoary");
            Console.WriteLine("salary of non technical staff = " + salary);
        }
    }
    class permanant : Employee3
    {
        public override void Employee(int salary)
        {

            Console.WriteLine("Technical staff are permanant");
            Console.WriteLine("salary of  techniical staff = " + salary);
        }

    }
    class Override2
    {
        static void Main(string[] args)
        {

            Employee3 e = new Temperoary();

            e.Employee(20000);

            Employee3 s = new permanant();

            s.Employee(45000);

        }

    }
    class Employee2
    {
        // this keyword usage.
        int id;
        int salary;
        string name;
        float DA;
        float grosssalary;
        float sum;


        public Employee2(int id, string name, int salary) // constructor


        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.DA = DA;
            this.grosssalary = grosssalary;
            this.sum = sum;

            this.Addition();
        }

        public int Addition()
        {
            if (salary <= 20000)
            {
                DA = 0.5f;
                sum = 0.5f * salary;
                grosssalary = sum + salary;

            }
            else if (salary > 20000 && salary < 50000)
            {
                DA = 0.8f;
                sum = 0.8f * salary;
                grosssalary = sum + salary;
            }
            else
                Console.WriteLine("salary not in range");
            this.Display();
            return (salary);
        }




        public void Display()
        {
            Console.WriteLine("gross salary of employee = " + grosssalary);
        }




    }


    class Emp
    {
        static void Main(string[] args)
        {
            Employee2 e = new Employee2(123, "vaibhav patil", 10000);





        }
    }
    class Construcor
    {
        // static method + parameterized constructor + static constructor + static variable acces
       static int a;
       static int b;
        int c;
        int d;

     
        public Construcor(int c ,  int d) // parameterized constructor with instance variable
        {
            this.c = c;
            this.d = d;
        }
        static Construcor() // static constructor., always default.
        {
            a = 3; b = 2;

        }
        static void Addition() // static method.
        {
            int Add = a+b;
            Console.WriteLine("addition of static variable =  " + Add);


        }
        public void Sum()   // public method.
        {
            int ans = c + d;
            Console.WriteLine("addition of instance variable =  " + ans);

        }
        static void Main(string[] args)
        {
            Construcor con = new Construcor(4,5); // invoke parametrized constructor.
            con.Sum(); // call public method.
            Construcor.a = 3;  // access static variables
            Construcor.b = 8;
                Construcor.Addition(); // call static method.


        }

    }
    class Convert
    { // convert input rupees to dollar .
        public void Dollar(float rupees)
        {

            rupees = rupees/69.2f;
            Console.WriteLine("the value of rupees after convert  to dollar  = " + rupees + "RS.");

        }
        static void Main(string[] args)
        {
            Convert c = new Convert();
            Console.WriteLine("enter value for rupees");
            float f = float.Parse(Console.ReadLine());
            
            c.Dollar(f);


        }

    }




}
