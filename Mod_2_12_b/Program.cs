using System;

namespace Mod_2_12_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение b (b > 10): ");
            int b = int.Parse(Console.ReadLine());

            if (b > 10)
            {
                Console.WriteLine($"Квадраты всех чисел от 10 до {b}:");
                for (int i = 10; i <= b; i++)
                {
                    Console.WriteLine(i * i);
                }
            }
            else
            {
                Console.WriteLine("Значение b должно быть больше 10.");
            }
        }
    }
}
