// See https://aka.ms/new-console-template for more information

using System;
namespace firstDNProject
{
    class myClass
    {
        public static void Main(String[] args)
        {
           // arrays
           int [] nums={1,2,3,4,5};
           Console.WriteLine(nums[1]);
           nums[2]=300;
            Console.WriteLine(nums[2]);
                        Console.WriteLine(nums.Min());



            //2d array
            int[,] nums2d={{1,2},{3,4}};
            Console.WriteLine(nums2d[1,0]);//3
            Console.WriteLine(nums2d.Length);//4
            


        }
    }
}

