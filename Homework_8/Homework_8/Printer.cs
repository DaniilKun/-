using System;

namespace Homework_8
{
    public class Printer
    {
        public static void Print<T>(T item) 
        {
            Console.WriteLine(item.GetType());
        }
    }
}