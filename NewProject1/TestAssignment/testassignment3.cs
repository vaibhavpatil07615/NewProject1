using NewProject1.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewProject1.TestAssignment
{
    class Tutorial_class
    {
        public string name;
        public DateTime created_date;
        public List<string> topics;
        public string description;
        public bool draft;

        public Tutorial_class() : this("tutorial draft")
        {
            // initial constructor,with no parameter.
            this.description = "no parameter passed";

        }
        public Tutorial_class(string name) : this(name, DateTime.Now)
        {
            this.description = "a tutorial name has been passed";
        }

        public Tutorial_class(string name, DateTime date)
        {
            this.name = name;
            this.created_date = date;
            this.topics = new List<string>();
            this.description = "a tutorial name and date have both passed";
            this.draft = true;
        }
        public static void PrintVariable(Tutorial_class tutorial)
        {
            Console.WriteLine("Tutorial Name: " + tutorial.name + "\n");
            Console.WriteLine("Description: " + tutorial.description + "\n");
            Console.WriteLine("Created Date = " + tutorial.created_date.ToString() + "\n");
            Console.WriteLine("\n");

        }




        static void Main(string[] args)
        {
            Tutorial_class noparameter = new Tutorial_class();
            Console.WriteLine("tutorial class with no parameter");
            PrintVariable(noparameter);

            Tutorial_class stringparameter = new Tutorial_class("sample tutorial 1");
            Console.WriteLine("tutotial class with tutorial name:\n ");
            PrintVariable(stringparameter);

            Tutorial_class stringanddate = new Tutorial_class("sample tutorial 2", new DateTime(2023, 1, 03));
            Console.WriteLine("tutorial class with tutorial name and created date provided");
            PrintVariable(stringanddate);




        }
    }





    class Baseclass
    //over riding with 'base' keyword use for calling method from parent class to child.
    {
        string name;
        string gender;
        int dateofbirth;


        public Baseclass(string name, string gender, int dateofbirth)


        {
            this.name = name;
            this.gender = gender;
            this.dateofbirth = dateofbirth;


        }
        public virtual void Personal()
        {

            Console.WriteLine("personal information");
            Console.WriteLine("name = " + name);
            Console.WriteLine("gender = " + gender);
            Console.WriteLine("date of birth = " + dateofbirth);
        }

    }
    class Subclass1 : Baseclass
    {

        string collegename;
        string stream;
        string degree;
        public Subclass1(string collegename, string stream, string degree, string name, string gender,
        int dateofbirth) : base(name, gender, dateofbirth)
        {



            this.collegename = collegename;
            this.stream = stream;
            this.degree = degree;
        }

        public override void Personal()
        {
            base.Personal();
            Console.WriteLine("educational information");
            Console.WriteLine("college name = " + collegename);
            Console.WriteLine("stream = " + stream);
            Console.WriteLine("degree = " + degree);



        }





    }

    class Override
    {
        // multilevel inheritance example .
        static void Main(string[] args)
        {

            Subclass1 s = new Subclass1("ssbt", "engineering", "BE-", "vaibhav", "male", 14022000);

            s.Personal();
        }
    }

    internal class Mi
    {
        internal string Companyname = "mi";
        internal string companyorigin = "china";
        internal string products = "electronic products and mobile";



    }
    class Electronicproduct : Mi
    {
        internal string type = "wearable and nonwearable elctronic product";
        internal string wearble = "smart mi watches";
        internal string earbud = "mi earbuds";



    }
    class nonWearable : Electronicproduct
    {
        internal string tv = "mi android tv";
        internal string mobile = "redmi note 9 mobile";

        public void show()
        {
            Console.WriteLine("company name =" + base.Companyname + "\n" + "companyorigin =" + base.companyorigin + "\n" + "product=" +
                base.products + "\n" + "type = " + base.type + "\n" + "wearble =" + base.wearble + "\n" + "tv=" + tv + "\n" + "mobile = " + mobile);

        }




    }
    class Multilevel
    {
        static void Main(string[] args)
        {
            nonWearable v = new nonWearable();
            v.show();
        }
    }






    internal class testassignment3
    {
        // national games.
        static void Main(string[] args)
        {
            // problem 5
            Console.WriteLine("select any countryname from user");
            Console.WriteLine(" india \n china \n bangladesh \n italy \n amarica");
            string s = Console.ReadLine();

            switch (s)
            {
                case ("india"):
                    Console.WriteLine("hockey");
                    break;

                case ("china"):
                    Console.WriteLine("table tennis");
                    break;

                case ("bangladesh"):

                    Console.WriteLine("kabbaddi");
                    break;
                case ("italy"):
                    Console.WriteLine("football");
                    break;

                case ("america"):
                    Console.WriteLine("baseball");
                    break;
                default:
                    Console.WriteLine("input is not in range ");
                    break;


            }
        }
    }
    class Transaction
    {
        //problem 6


        public  void Creditcard()
        {
            Console.WriteLine(" thanks for using credit card !! you get 15% discount on payment ");

        }
    }
    class Dotransaction:Transaction
    {

         

        public  void Debitcard()
        {
            base.Creditcard();
            Console.WriteLine(" sorry!! you did not get any discount");

        }
    }
    class Payment
    {


        static void Main(string[] args)
        {
            Transaction t = new Transaction();
            t.Creditcard();
            




        }


    }

   
    class Pattern
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 7; i++)// forward pyramid
            {
                for (int j = 7; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=i; k++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(k+" ");

                    }
                    else Console.Write(" ");
                }

                Console.WriteLine(" ");
            }
        }
    }
  /*  class Demo
    {
        static void main(String[] args)
        {
            Car c1 = new Car();
            c1.color = "Blue";
            Car c2 = new Car();
            c2.changeColor(c1);
            c2.color = "Pink";
            Console.WriteLine(c1.color);
            Console.WriteLine(c2.color);
        }
    }
    class Car
    {
        String color;
        public void changeColor(Car c2)
        {
            c2.color = color;
            color = "Red";
        }
    }*/



}
