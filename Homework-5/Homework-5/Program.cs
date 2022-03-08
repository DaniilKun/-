using System;



namespace Homework_5
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

            static void Print(int a, int b)///////////////////////////// вот тут запихал
            {
                Console.WriteLine(a - b);
            }

            Print(chetn , nechetn);

        }
    }
}