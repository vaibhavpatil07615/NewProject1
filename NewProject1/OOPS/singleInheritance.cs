using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.OOPS
{
    internal class Bike


    {
        internal int wheels = 2;
        internal int seatingcapacity = 2;
        internal string fuelused = "petrol";



    }
    class Bullet : Bike
    {
        string bikename = "bullet";
        int enginecapacity = 550;
        string companyname = "royal enfield";
        string colour = "black / red/ blue";
        public void show()
        {
            Console.WriteLine("bikename = " + bikename + "\n" + "companyname = " + companyname + "\n" + "engineapacity =" + enginecapacity + "\n" + "fuelused=" + fuelused + "\n" + "seatingcapacity =" + seatingcapacity);
        }
    }
        class Singledemo
        {


            static void Main(string[] args)
            {
                Bullet b = new Bullet();
                b.show();
            }
        }

    class Electricbike
    {
        protected int wheels = 2;
        protected int seatingcapacity = 2;
        protected string motorused = "Bldc motors";


        
    }
    class Ola : Electricbike
    {
        internal string model = "s1";
        internal int range = 128;
        internal int motorcapacity = 8500 ;
        public void show()
        {
            Console.WriteLine("model ="+model+"\n"+"motorused ="+motorused+"\n"+"motor capacity ="+motorcapacity+"\n" +"seating capacity = "+seatingcapacity+"\n"+"wheels ="+wheels);
        }


    }
    class Singleleveldemo
    {
        static void Main(string[] args)
        {
            Ola o = new Ola();
            o.show();
        }
    }

    
}
