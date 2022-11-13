using System;
using System.Collections.Generic;

namespace GenericsQuestion21
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate generics with Integer
            MyGenericClass<int> num= new MyGenericClass<int>();

            //adding integer values into collection
            num.Add(2);
            num.Add(4);
            num.Add(3);
            num.Add(5);
            num.Add(1);

            //setting the indexes
            for (int i = 5 - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            //returns an item
            int val = num[1];
            Console.WriteLine("print a " + val);
            Console.ReadKey();

        }
    }


}