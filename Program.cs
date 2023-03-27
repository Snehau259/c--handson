// See https://aka.ms/new-console-template for more information

using System;
namespace firstDNProject
{
    class myClass
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter your name:");
            String name=Console.ReadLine();
                        Console.WriteLine("hello "+name);//concatenation
                        Console.WriteLine("hello {0}",name);//COMPOSITE FORMATTING
                        Console.WriteLine($"hello {name}");//string interpolation

                        Console.ReadKey();

        }
    } ̰
}

