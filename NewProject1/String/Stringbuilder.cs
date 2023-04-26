using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.String
{
    internal class Stringbuilder
    {
        static void Main(string[] args)
        {
            // proerty of stringbuilder
            StringBuilder sb = new StringBuilder("vaibhav");
            // use append property
            sb.Append(" " + "patil");
            Console.WriteLine(sb); // vaibhav patil 
            // use replace property
            sb.Replace("patil" , sb.ToString()); 
            Console.WriteLine(sb); // vaibhav vaibhav patil.
            sb.Replace("vaibhav patil", "rajendra patil");
            Console.WriteLine(sb);  // vaibhav rajendra patil

            sb.Insert(8, "ashabai " + " "); // vaibhav ashabai rajendra patil.
            Console.WriteLine(sb);

        }



    }
    class Array
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("jalgaon");
            arr.Add("pune");
            arr.Add("nagar");
            arr.Add("dhule");
            arr.RemoveAt(0);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            
            
        }
       
    }
}
