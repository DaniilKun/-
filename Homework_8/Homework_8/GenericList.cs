using System;

namespace Homework_8
{
    public class GenericList<T>
    {
        private T[] array;
        private int index;

        public GenericList(int item)
        {
            array = new T[item];
        }

        public void add(T value)
        {
            array[index] = value;
            index++;
        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("....................");
        }
    }
}