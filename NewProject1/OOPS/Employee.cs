using NewProject1.OOPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace NewProject1.OOPS
{
    internal class Employee
    { //25 feb friday questions
        int id;
        string name;
        int salary;
        long mobileno;
        public void Accept(int eid, string ename, int esalary, long emobileno)
        {

            id = eid;
            name = ename;
            salary = esalary;
            mobileno = emobileno;
        }



        public void display()

        {

            Console.WriteLine(" id = " + id + " name = " + name + " salary = " + salary + " mobile no = " + mobileno);

        }







        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            e1.Accept(123, "vaibhav patil", 40000, 7767070356);
            
            e1.display();




        }
    }
    class Car
    {
        int modelno;
        string name;
        string colour;
        long price;
        public void Accept(int model, string carname, string carcolour, long carprice)
        {
            modelno = model;
            name = carname;
            colour = carcolour;
            price = carprice;



        }
        public void display()
        {
            Console.WriteLine(" model no = " + modelno + "name = " + name + " colour = " + colour + "price = " + price);
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Accept(1234, "oddy", "red", 1000000);
            c.display();
            Car c2 = new Car();
            c2.Accept(123, "nexa", "black", 500000);
            c2.display();
            Car c3 = new Car();
            c3.Accept(12, "XUV", "blue", 900000);
            c3.display();




        }
    }
    class Product
    {
        // 27feb monday assignment
        string name;
        int price;
        int quantity;
        public void Accept(string pname, int pprice, int pquantity)
        {
            name = pname;
            price = pprice;
            quantity = pquantity;


        }
        public void display()
        {
            Console.WriteLine("name = " + name + " price = " + price + " quantity = " + quantity);
        }
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Accept("mobile", 50000, 10);
            p.display();
        }

    }
    class Factors
    {

        public void Fact(int a)
        {

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                }
            }



        }

        static void Main(string[] args)
        {
            Factors f = new Factors();
            Console.WriteLine("please enter number");
            int x = int.Parse(Console.ReadLine());
            f.Fact(x);
        }

    }
    class Student2
    {

        int id;
        string name;
        int marathi;
        int hindi;
        int english;

        public void Accept(int sid, string sname, int smarathi, int shindi, int senglish)
        {
            id = sid;
            name = sname;
            marathi = smarathi;
            hindi = shindi;
            english = senglish;

        }
        public int percent()

        {
            int a = marathi + hindi + english;
            int b = (a * 100) / 300;
            return (b);

        }
        public void Display()
        {
            Console.WriteLine("id = " + id + "name = " + name + "marathi= " + marathi + "hindi = " + hindi + "english = " + english);

        }
        static void Main(string[] args)
        {
            Student2 s = new Student2();
            s.Accept(1234, "vaibhav patil", 40, 50, 60);
            s.Display();
            Console.WriteLine("percentage = " + s.percent());
        }


    }
    class Employee2 
    {
        // this keyword usage (28feb assignment)
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
            Employee2 e = new Employee2(123,"vaibhav patil",10000);
            
            
            
            

        }
    }
    class Product2
    {
        
            string name;
            int price;
            int quantity;
            int ans;
            public Product2(string pname, int pprice, int pquantity)  //constructor
            {
                name = pname;
                price = pprice;
                quantity = pquantity;
            //this.Bill();

            }
        public int  Bill()

        {
            if (quantity > 0)
            {
                 ans = quantity * price;
            }



            this.Display();

            return (ans);

        }
       




        public void Display()
            {
                Console.WriteLine("name = " + name + " price = " + price + " quantity = " + quantity);
            if (quantity > 0)
            {
                Console.WriteLine("bill of total product = " + ans);
            }
            else
                Console.WriteLine(" quantity is out of range");

        }
            static void Main(string[] args)
            {
                Product2 p = new Product2("mobile", 50000, 0); // call constructor
                
                 p.Bill();
              //  p.display();
            }
        }
    class Account
    {
        int basicsalary;
        float gst;
        float ta;
        float da;
        //float grosssalary;

        public int Basicsalary
        {
            set
            {
                basicsalary = value;
            }
            get
            {
                return basicsalary;
            }
        }
        public float Gst
        {
            set
            {
                gst = value;
            }
            get
            {
                return gst;
            }
        }
        public float Ta
        {
            set
            {
                ta = value;
            }
            get
            {
                return ta;
            }
        }
        public float Da
        {
            set
            {
                da = value;
            }
            get
            {
                return da;
            }
        }
       

    }
    class Encapsulate
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.Basicsalary = 30000;
            a.Da = 0.8f;
            a.Gst = 0.18f;
            a.Ta = 0.6f;

            Console.WriteLine(a.Basicsalary);
            Console.WriteLine(a.Da);
            Console.WriteLine(a.Ta);
            Console.WriteLine(a.Gst);




        }
    }
    
    
}
