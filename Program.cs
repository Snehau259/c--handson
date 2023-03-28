// See https://aka.ms/new-console-template for more information

using System;
namespace firstDNProject
{
    class myClass
    {

        public static void Main(String[] args)
        {
            GenericDatabase<String> GDB = new GenericDatabase<string>();
            GDB.Create("sNEHA");
            GDB.Create("abcd");
            GDB.Create("xyza");
            GDB.display();
            GDB.Delete("abcd");
            GDB.display();



        }
    }
}

