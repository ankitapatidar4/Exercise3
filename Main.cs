using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Car
    {
        string colour = "red";
        
        public static void Main (string[] args)
        {
            //create an object
            Car car1 = new Car();
            NewC car4 = new NewC();
            CarProperty car5 = new CarProperty();
            Console.WriteLine(car1.colour);
            Console.WriteLine(car4.colour);
            Console.WriteLine(car5.maxspeed); // calling field from class CarProperty
            car5.throttle(); //call method throttle from Class CarProperty

            CarModel car6 = new CarModel();
            Console.WriteLine(car6.model);
        }
            

    }
}
