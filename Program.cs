// See https://aka.ms/new-console-template for more information

using System;
namespace firstDNProject
{
    class myClass
    {
        public static void Main(String[] args)
        {
            //dictionaries
            Dictionary<String,long> phoneBook=new Dictionary<String,long>();
            phoneBook.Add("Steve",9458693057);
            phoneBook["Paul"]=98273853496;
            Console.WriteLine(phoneBook.Count);
        }
    }
}

