using NewProject1.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.OOPS
{
    abstract class Plant
        //task 1 8 march 23
    {
        public abstract void  typeofplant();
    }
    abstract class waterplant :Plant
    {
        public abstract void typeofwaterplant();
       
    }
    class Floweringplant : waterplant
    {
        public override void typeofwaterplant()
        {
            Console.WriteLine("type of water plant =floating plant and submurged plant");
        }
        public override void typeofplant()
        {
            Console.WriteLine(" type of plant =water plant and land plant");

        }


    }
    class Abstract
    {
        static void Main(string[] args)
        {
            Plant p = new Floweringplant();
            p.typeofplant();
            waterplant q = new Floweringplant();

            q.typeofwaterplant();


            


            
           
        }
    }
    //2nd task
     abstract class Addition
    {
        public int a;
    }
    interface IDigitable 
    {
        static int b;

    }
    internal class Output : Addition, IDigitable
    {
        public void display()
        {
            IDigitable.b = 20;
            int a = 10;
             Console.WriteLine(a+ IDigitable.b);
        }
    }
    class Abstract1
    {
        static void Main(string[] args)
        {
           Output x = new Output();
            x.display();
        }
    }

    //task 3
    
    interface ICalculatorable
    {
        static int a;
        static int b;
        public void add(); 
        
        
        
    }

    interface IScientificCalculatorable: ICalculatorable
    {
        static int a;
        static int b;
        void multiply();
      
       

    }
    class Casiocalculator: ICalculatorable, IScientificCalculatorable
    {
        public void add()
        {
            ICalculatorable.a = 10;
            ICalculatorable.b = 20;
            Console.WriteLine( "addition of a and b ="+ (ICalculatorable.a + ICalculatorable.b));
        }
        public void multiply()
        {
            IScientificCalculatorable.a = 20;
            IScientificCalculatorable.b = 30;
            Console.WriteLine("multiplication of a and b ="+IScientificCalculatorable.a* IScientificCalculatorable.b);

        }





    

    }
    class Abstract2
    {
        static void Main(string[] args)
        {
           ICalculatorable calculate = new Casiocalculator();
            calculate.add();
            IScientificCalculatorable calculate2 = new Casiocalculator();
            calculate2.multiply();
           



        }
    }



}
