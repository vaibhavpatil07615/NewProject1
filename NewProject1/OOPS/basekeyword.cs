using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.OOPS
{
    //multilevel inheritnce with 'base' keyword use1.
    internal class Mi1
    {
        internal string Companyname = "mi";
        internal string companyorigin = "china";
        internal string products = "electronic products and mobile";



    }
    class Electronicproduct1 : Mi1
    {
        internal string type = "wearable and nonwearable elctronic product";
        internal string wearble = "smart mi watches";
        internal string earbud = "mi earbuds";



    }
    class nonWearable1 : Electronicproduct1
    {
        internal string tv = "mi android tv";
        internal string mobile = "redmi note 9 mobile";

        public void show()
        {
            Console.WriteLine("company name =" + base.Companyname + "\n" + "companyorigin =" + base.companyorigin + "\n" + "product=" +
                base.products + "\n" + "type = " + base.type + "\n" + "wearble =" + base.wearble + "\n" + "tv=" + tv + "\n" + "mobile = " + mobile);

        }




    }
    class Multilevel1
    {
        static void Main(string[] args)
        {
            nonWearable v = new nonWearable();
            v.show();
        }
    }

    class Grandparent1
    // multilevel inheritance with keyword 'base' for calling data  from parent class to child class

    {
        public Grandparent1(string name)
        {
            Console.WriteLine("grandparent of child ="+name);
        }


    }
    class Parent1 : Grandparent1

    {
        public Parent1(string n) : base(n)
        {
            Console.WriteLine("parent of my parent = MY grandparent");
        }

    }
    class Child1 : Parent1

    {
        public Child1 (string k) : base(k)
        {
            Console.WriteLine("grandson of grandparent = me");

        }

        
    }
    class Multilevel3


    {
        static void Main(string[] args)
        {
            Child1 c = new Child1("my grandparent");
           
        }

    }
    internal class Baseclass
        //over riding with 'base' keyword use for calling method from parent class to child.
    {
        public virtual void Greetings()
        {
            Console.WriteLine("base class saying hello");
        }

    }
    class Subclass1 : Baseclass
    {
        public override void Greetings()
        {
           base.Greetings();
            Console.WriteLine("1 sub classs saying hello and good morining");
            

        }
       
    }
    class Subclass2 : Subclass1
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("2nd sub class says wake up early and ready for office");

        }
        


    }
    class Override
    {
        static void Main(string[] args)
        {
           
            Baseclass b = new Subclass2();
            
            b.Greetings();
        }
    }

    class Nib
        //Contentment problem
    {
        int price;
        string  materialtype;

        public Nib(int price, string materialtype)
        {
            this.price = price;
            this.materialtype = materialtype;
        }
        public void Nibdetails()
        {
            Console.WriteLine("nib price = " +price+"\n"+" nib material type ="+materialtype);
        }

    }
    class Pen
    {
        string colour;
        string name;
        string type;
        Nib nib;
        public Pen(string colour, string name, string type,Nib nib)
        {
            this.colour = colour;
            this.name = name;
            this.type = type;
            this.nib = nib;

        }
        public void pendetails()
        {
            Console.WriteLine("pen colour ="+colour+"\n"+"pen name ="+name+"\n"+"pen type ="+type);
            nib.Nibdetails();
        }

    }
    class Bag
    {
        string bag_name;
        string bag_colour;
        int price;
        Pen pen;

        public Bag (string bag_name,string bag_colour,int price,Pen pen)
        {
            this.bag_name = bag_name;
            this.bag_colour = bag_colour;
            this.price = price;
            this.pen = pen;
        }
        public void showdetail()
        {
            Console.WriteLine("bag name =" + bag_name + "\n" + "bag_colour =" + bag_colour + "\n" + "bag price =" + price);
                

        }
        static void Main(string[] args)
        {
            Nib n = new Nib(30, "stainless steel");
           
            Pen p = new Pen("blue", "trimax", "ball pen",n);
         
            Bag b = new Bag("school bag", "red", 700, p);
         
            p.pendetails();

            b.showdetail();

        }
    }


}

