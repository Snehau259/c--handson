// See https://aka.ms/new-console-template for more information

using System;
namespace firstDNProject
{
    class myClass
    {//methods
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        static int greatest(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        public static void Main(String[] args)
        {
            MyMethod();
            int big = greatest(40, 45);
            Console.WriteLine(big);

        }
    }
}

