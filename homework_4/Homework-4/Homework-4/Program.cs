using System;

namespace Homework_4
{
   
        
        class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int chetn = 0;
            int nechetn = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введите элемент под индексом {i} : ");
                array[i] = int.Parse(Console.ReadLine());
                    
            }



            for (int i = 0; i < 10; i++)
            {
                if (array[i] % 2 == 0) 
                
                    chetn = chetn + array[i];

                
            }

            for (int i = 0; i < 10; i++)
            {
                if (array[i] % 2 != 0) 

                nechetn = nechetn + array[i];

            }
            Console.WriteLine(chetn-nechetn);

        }
    }
}