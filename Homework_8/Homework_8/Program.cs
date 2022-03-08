using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] arg)
        {
            GenericList<string> m1 = new GenericList<string>(item: 4);
            m1.add("hi");
            m1.add("hello");
            m1.add("good morning");
            m1.add("хай");
            Printer.Print(m1);
            m1.Print();
        }
       
    public class Generic<T>
    {
        public T Value;
    } 
    }
   
}


