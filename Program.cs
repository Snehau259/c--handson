// See https://aka.ms/new-console-template for more information

using System;
namespace firstDNProject
{
    class myClass
    {

        public static void Main(String[] args)
        {
            Vehicle bmw1 = new Car("BMW", "2023");
            bmw1.Honk();//  Buut, tuut!
            Car bmw2 = new Car("BMW", "2023");
            bmw2.Honk();//Buut, Buut!

        }
    }
}

