// See https://aka.ms/new-console-template for more information

using System;
namespace firstDNProject
{
    class myClass
    {
        public static void Main(String[] args)
        {
            // List-no of elements is not fixed
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers.ElementAt(i));
            }
            numbers.Remove(3);//will remove element 3
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers.ElementAt(i));
            }


List<int> newNumbers = new List<int>();
            numbers.Add(9);
            numbers.Add(8);
            numbers.Add(7);
            numbers.AddRange(newNumbers);
                            Console.WriteLine(numbers.Count);






        }
    }
}

