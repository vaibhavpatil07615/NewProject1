using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.OOPS
{
    //interface method already public and abstract

   interface INterfaces

    {
        void add(int a, int b);
        void multiply  (int a, int b);
    }
    interface IMobile :INterfaces
    {
        
        void call();
        void sms();
    }
    class Mobile : INterfaces, IMobile
    {
        public  void add (int a, int b)
        {
            Console.WriteLine("sum =" +(a+b));

        }
        public void multiply (int a, int b)
        {
            Console.WriteLine("multiplication ="+(a*b));
        }
        public void call()
        {
            Console.WriteLine("mobile use for calling");
        }
        public void sms()
        {
            Console.WriteLine("mobile use for send sms");
        }
        class Function2
        {
            static void Main(string[] args)
            {
                INterfaces c = new Mobile();
                c.add(10, 12);
                c.multiply(10, 12);
               IMobile m = new Mobile();
                m.call();
                m.sms();

            }
        }
    }
  
    
    

}
