using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.OOPS
{
    internal class Order
    //contentment programme
    {
        int oid;
        int quant;
        Menue m;

        public Order(int oid, int quant, Menue m)
        {
            this.oid = oid;
            this.quant = quant;
            this.m = m;
        }

        public void show()
        {
            Console.WriteLine(oid + " " + " " + quant);
            Menue m = new Menue(222, "vadapav", 20);
            m.showmenue();
        }
    }
    class Menue
    {
        int mid;
        string item;
        double price;
        public Menue(int mid, string item, double price)
        {
            this.mid = mid;
            this.item = item;
            this.price = price;
        }

        public void showmenue()
        {
            Console.WriteLine(mid + " " + item + " " + price + "rs.");
        }

        static void Main(string[] args)
        {
            Menue m = new Menue(234, "dosa", 50);
            Order o = new Order(2, 3, m);
            o.show();
        }




    }



    class Methodoverload
    {
        public void Area(int r)
        {
            float pi = 3.14f;

            Console.WriteLine("area of circle = " + (pi * r * r));


        }
        public void Area(int b, int h, float f)
        {

            Console.WriteLine("area of triangle = " + f * b * h);
        }
        public void Area(int b, int l)
        {
            int a = l * b;
            Console.WriteLine("area of rectangle = " + a);

        }
        public void Area(double s)
        {
            Console.WriteLine("area of square = " + (s * s));
        }

        static void Main(string[] args)
        {


            Methodoverload m = new Methodoverload();

            m.Area(4);
            m.Area(4, 5, 0.5f);
            m.Area(6, 7);
            m.Area(7);
        }

    }
    class Constructoroverload
    {
        public Constructoroverload()
        {
            Console.WriteLine("default conatructor with no parameter");
        }
        public Constructoroverload(string carname)
        {
            Console.WriteLine("parametarize constructor with 1 parameter ");
            Console.WriteLine("carname = " + carname);
        }
        public Constructoroverload(string carname, int price)
        {
            Console.WriteLine("parametarize constructor with 2 parameter ");
            Console.WriteLine("caranme = " + carname + "\n" + "price = " + price);

        }
        public static void Main(string[] args)
        {
            Constructoroverload car = new Constructoroverload();
            Constructoroverload car1 = new Constructoroverload(" oddy");
            Constructoroverload car2 = new Constructoroverload("oddy", 1000000);






        }



    }
   

}
 
