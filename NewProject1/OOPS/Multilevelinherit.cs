using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.OOPS
{
    //multilevel inheritance example1
    internal class  Mi
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
            Console.WriteLine("company name ="+base.Companyname+"\n" + "companyorigin ="+ base.companyorigin+"\n"+"product="+
                base.products+"\n"+ "type = " + base.type + "\n" + "wearble =" + base.wearble + "\n" + "tv=" + tv + "\n" + "mobile = " + mobile);

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

    class Grandparent
       // multilevel inheritance example2

    {
        internal string grandfather = "grandfather of vaibhav";
        internal string grandmother = "grandmother of vaibhav";


    }
    class Parent:Grandparent

    {
        internal string parent1 = "parents of vaibhav";

    }
    class Child :Parent 

    {
        internal string v = "im vaibhav. son of my parents";

        public void show()
        {
            Console.WriteLine(grandfather +"\n "+grandmother+"\n"+parent1+"\n" +v);
        }
    }
    class Multilevel2


    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.show();
        }

    }

    class house
        // example1 of hierachical inheritance
    {
        public string housetype = "aparmental house in co operative society";

    }
    class Onebhk : house
    {
        internal string housetype1 = " type 1 = 1 BHK";
        public string bedroom1 = "1 bedroom";
        public string hall1 = "1 hall";
        public string kithen1 = "1 kithen";

        public void show()
        {
            Console.WriteLine(housetype+"\n" +housetype1+"\n"+bedroom1+"\n"+hall1+"\n"+kithen1);
        }






    }
    class twobhk : house
    {
        public string housetype2 = "type2 = 2 BHK";
        internal string bedroom2 = "2 bedroom";
        internal string hall2 = "2 hall";
        internal string kithen2 = "2 kithen";
        public void show()
        {
            Console.WriteLine(housetype + "\n" + housetype2 + "\n" + bedroom2 + "\n" + hall2 + "\n" + kithen2);

        }
    }
        class Hierachical

        {
            static void Main(string[] args)
            {
                Onebhk o = new Onebhk();
                o.show();
                twobhk t = new twobhk();
                t.show();
            }
        }
    
    

    class Itcompany
        //example2 of hierachical inheritance.
    {
        public string itcompany2 = "product based IT company";
        public string itcompany1 = "service base it company ";
    }
    class Servicebased: Itcompany
    {
        
        public string it1 = "tcs, wipro,HCL,";
        public void show1()
        {
            Console.WriteLine(itcompany1 + " = " + it1);
        }


    }
    class Productbased : Itcompany
    {
        
        public string it2 = "amazon,apple,microsoft";
        public void show()
        {
            Console.WriteLine(itcompany2 +"="+it2);
        }


    }
    class hierachical1
    {
        static void Main(string[] args)
        {
            Servicebased s = new Servicebased();
            s.show1();
            Productbased p =new Productbased();
            p.show();
        }
    }
    class Propertyclass {
        //apply all property in 1 programme
        int Id;
        string Name;
        string Location;
        double Rating;
        bool isOnlineorderAvailable;
        int  SeatingCapcity;
        string paymentType;

        public Propertyclass(int id, string name, string location, double rating, bool isOnlineorderAvailable, int seatingCapcity, string paymentType)
        {
           this. Id = id;
           this. Name = name;
           this. Location = location;
           this. Rating = rating;
            this.isOnlineorderAvailable = isOnlineorderAvailable;
           this. SeatingCapcity = seatingCapcity;
            this.paymentType = paymentType;
        }
        public void bookhotel()
        {
            if (isOnlineorderAvailable ==true && Rating >=4)
            {
                Console.WriteLine("book hotel ");


            }
             if (Location =="jalgaon" && SeatingCapcity >= 5)
            {
                Console.WriteLine("direct go to hotel without book");

            }
             if (paymentType == "online")
            {
                Console.WriteLine("no need to carry cash");
            }
            else Console.WriteLine("carry cash");
            this.display();

        }

        public void display()
        {
            Console.WriteLine("id ="+Id+"\n" +"name ="+Name +"\n" +"location="+Location+"\n"+"ratng ="+Rating+"\n"+
                "is online order avilable="+ isOnlineorderAvailable+"\n"+ "seating capacity =" +SeatingCapcity+"\n"+
                "payment type = " +paymentType);

        }
        static void Main(string[] args)
        {
            Propertyclass p = new Propertyclass(123,"silver palace","jalgaon",4,true,8,"online");
            
           
            p.bookhotel();


        }


    }
    


    
}
