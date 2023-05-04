using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static Myprojectadvance.Delegates.Uppercase;

namespace Myprojectadvance.Delegates
{
    public delegate string UppercaseDelegate(string s);
    public  class Uppercase
    {
       
        public string Upper(string s)
        {
            Console.WriteLine("enter string to convert uppercase");
            s = Console.ReadLine();

            string s1  = s.ToUpper();
            return s1;
        }
        public string Lower(string s)
        {
            Console.WriteLine("enter string to convert lowercase");
            s = Console.ReadLine();

            string s2 = s.ToLower();
            return s2;
        }
    }
    class programme
    {
        static void Main(string[] args)
        {
            Uppercase up = new Uppercase();
            UppercaseDelegate del = new UppercaseDelegate(up.Upper);
            del += new UppercaseDelegate(up.Lower);
            Delegate[] list = del.GetInvocationList();
            foreach(Delegate d in list)
            {
                Console.WriteLine(d.DynamicInvoke("vaibhav patil"));
            }
        }
    }
    public delegate void BankDelegate();
    public class Bank
    {
 
        int balance;
        public Bank(int balance)
        {
            this.balance = balance;
        }
        public event BankDelegate insufficientbalance;
        public event BankDelegate lowbalance;

        public void Debit()
        {
            Console.WriteLine("enter debit amount");
           int  amount = int.Parse(Console.ReadLine());
           

            if (amount > balance)
            {
                insufficientbalance();
            }
            balance = balance - amount;
            if (balance < 3000)
            {
                lowbalance();
            }


            else Console.WriteLine("new balnce = " +balance);


        }

    }


    public class program3
    {
        static void Message1()
        {
            Console.WriteLine("sorry..balance is low");
           
        }
        static void Message2()
        {
            Console.WriteLine("insufficient balance");
        }
        static void Main(string[] args)
        {
            Bank b = new Bank(10000);
            b.insufficientbalance += new BankDelegate(Message2);
            b.lowbalance += new BankDelegate(Message1);
           // Console.WriteLine("enter amount for debit");
            
            b.Debit();



        }
    }
   class stringsplit
    {
        static void Main(string[] args)
        {
            string ip = Console.ReadLine();
           string check = Console.ReadLine();
           // string op = "";
            string[] ip1 = ip.Split();
            for (int i = 0;i<ip1.Length;i++)
            {
                bool ispresent = false;
                int count = 1;
                for (int j = i-1;j>=0;j--)
                {
                    if (ip1[j] == ip1[i]) { 
                     ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    for (int k = i+1;k <ip1.Length;k++)
                    {
                        if (ip1[i] == ip1[k])
                        {
                            count++;
                           

                        }
                        //Console.WriteLine($"{ip1[i]} >> {count}");
                       
                    }
                    if (ip1[i] == check)
                    {
                        Console.WriteLine($"{ip1[i]} >> {count}");
                    }


                }
            }
        }
    }
}
