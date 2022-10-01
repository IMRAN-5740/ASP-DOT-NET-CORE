using System;
using System.Collections.Generic;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int > list =  new List<int>();
            list.Add(1);    
            list.Add(2);
            foreach(var data in list)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
