using System;
using System.Globalization;

namespace klass_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя... ");
            string name = Console.ReadLine();
            
                
                Console.WriteLine("Введите возраст... ");
                
                double age = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Введите название вашей профессии...");
                string prof = Console.ReadLine();
                
                Console.WriteLine("Введите ваш рост(в метрах)...");
                double height = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("расскажите о себе...");
                string other = Console.ReadLine();

                Console.WriteLine($"Имя:{name} Возраст:{age} Профессия:{prof} Рост:{height} О себе:{other}");
                
                
                Console.ReadKey();
        }
    }
}
