using System;

namespace Lesson_4_HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Prompt (string message)
            {
                Console.WriteLine(message);
                return int.Parse(Console.ReadLine());
            }

            int num = Prompt("Введите число: ");
            int result = 0;
            int i = num;
            while (i > 1)
            {
                result = result + i%10;
                i=i/10;
            }
            Console.WriteLine("Сумма цифр в числе = " + result);
        }
    }
}
