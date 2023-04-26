using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Collection
{
    public  class Product
    {
        int Productid { get; set; }
        string product { get; set; }

        public override string ToString()
        {
            return ($" product id = {Productid} >>  product name = {product}");
        }

        static void Main(string[] args)
        {
            Product p = new Product { Productid = 1, product = "mobile" };
            Product p2 = new Product { Productid = 2, product = "watch" };
            Product p3 = new Product { Productid = 3, product = "laptop" };

            ArrayList arr = new ArrayList();
            arr.Add(p);
            arr.Add(p2);
            arr.Add(p3);

            foreach(Product pro in arr)
            {
                Console.WriteLine(pro);
            }

        }
       


    }
    class Hashtabledemo
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add (7767070356, "vaibhav patil");
            hash.Add(7773917004, "sagar");
            hash.Add(6768688686, "mayur");

            foreach (DictionaryEntry  item in hash)
            {
                Console.WriteLine($"{item.Key} >> {item.Value}");

            }



        }

    }
    class QueueDemo
    { 
        // first in first out.
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue("vaibhav patil");
            q.Enqueue(82.60);
            q.Enqueue(20);

            q.Dequeue();
            foreach (object item in q)
            {
                Console.WriteLine(item);
            }
            q.Dequeue();

        }
    }
    class Stachdemo
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(100);
            s.Push(200);
            s.Push(400);
            s.Push("vaibhav");
            foreach(object item in s)
            {
                Console.WriteLine(item);
            }

           // s.Pop();

           
        }
    }
   
}
