using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
     class NewC
    {
        public string colour = "blue";
        public static void main (string[] args)
        {
            
            //creating multiple objects
            NewC car2 = new NewC();
            NewC car3 = new NewC();
            Console.WriteLine(car2.colour);
            Console.WriteLine(car3.colour);


        }
    }
}
