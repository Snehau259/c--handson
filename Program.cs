// See https://aka.ms/new-console-template for more information

using System;
namespace firstDNProject
{
    class myClass
    {

        public static void Main(String[] args)
        {
            // Vehicle bmw1 = new Vehicle("BMW", "2023"); not allowed since vehicle is an abstract class
            // bmw1.Honk();
            Car bmw2 = new Car("BMW", "2023");
            bmw2.Honk();//Buut, Buut!
            bmw2.move();

        }
    }
}

