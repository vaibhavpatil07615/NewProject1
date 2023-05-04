using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myprojectadvance.Collection
{
    internal class Nongeneric
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            list1.Add(60);
            list1.Remove(30);
            list1.RemoveAt(1);
            list1.Sort();
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" queue type data");
            Queue<string> q1 = new Queue<string>();
            q1.Enqueue("vaibhav");
            q1.Enqueue("sagar");
            q1.Enqueue("harish");
            q1.Enqueue("mayur");
            q1.Enqueue("ashwini"); ;
            q1.Enqueue("priyanka");
            q1.Dequeue();

            Console.WriteLine($"first element from queue is {q1.Peek()}");
            Console.WriteLine($" total element on the stack is {q1.Count()}");
            foreach (string s in q1)
            {
                Console.WriteLine(s);
            }

            Stack<double> s1 = new Stack<double>();
            s1.Push(82.67);
            s1.Push(76.56);
            s1.Push(90.23);
            s1.Push(87.888);
            s1.Pop();
            Console.WriteLine($"top element on the stack is {s1.Peek()}");
            Console.WriteLine($" total element on the stack is {s1.Count()}");
            foreach (double d in s1)
            {
                Console.WriteLine(d);
            }








        }
    }
    class ListObject
    {
        public int Productid { get; set; }
        public int Productprice { get; set; }

        public override string ToString()
        {
            return $" {Productid} >> {Productprice}";
        }
        static void Main(string[] args)
        {

            ListObject l1 = new ListObject { Productid = 1, Productprice = 450 };
            ListObject l2 = new ListObject { Productid = 2, Productprice = 350 };
            ListObject l3 = new ListObject { Productid = 3, Productprice = 250 };


            List<ListObject> op = new List<ListObject> { l1, l2, l3 };

            foreach (ListObject o in op)
            {
                Console.WriteLine(o);
            }


        }
    }
    public class MyGeneric<T>
    {
        private T data;
        public void Add(T data)
        {
            this.data = data;
        }
        public T display()
        {
            return data;
        }
    }
    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }

        public override string ToString()
        {
            return $"{Empid} >> {Empname}";

        }

        class Program
        {
            static void Main(string[] args)
            {
                MyGeneric<Employee> g = new MyGeneric<Employee>();
                MyGeneric<Employee> g2 = new MyGeneric<Employee>();

                g.Add(new Employee { Empid = 1, Empname = "vaibhav" });
                g2.Add(new Employee { Empid = 2, Empname = "sagar" });


                Console.WriteLine(g.display());
                Console.WriteLine(g2.display());


            }
        }
    }
    // 21 april 2023
    public class Product : IComparable<Product>
    {
        private string productname;
        private int price;
        public string Productname
        {
            get { return Productname; }
        }
        public int Price
        {
            get { return price; }
        }


        public Product(string productname, int price)
        {
            this.productname = productname;
            this.price = price;

        }

        public int CompareTo(Product other)
        {
            if (this.price < other.price)
            {
                return -1;
            }
            if (this.price > other.price)
            {
                return 1;
            }
            else
                return 0;





        }
    }
    public class Test : IComparer<Product>
    {

        public int Compare(Product x, Product y)
        {
            if (x.Price < y.Price)
            {
                return -1;
            }
            if (x.Price > y.Price)
            {
                return 1;
            }
            else
                return 0;
        }
    }



    public class Programm
    {
        static void Main(string[] args)
        {
            Product mobile = new Product("mobile", 80000);
            Product Laptop = new Product("laptop", 70000);
            Product Watch = new Product("watch", 10000);



            int result = mobile.CompareTo(Laptop);
            if (result == -1)
            {
                Console.WriteLine("mobile price is less than laptop");
            }
            if (result == 1)
            {
                Console.WriteLine("mobile price is more than laptop");
            }
            if (result == 0)
            {
                Console.WriteLine("mobile and laptop price is same");
            }


            Test test = new Test();
            int op = test.Compare(mobile, Laptop);




        }
    }

}



