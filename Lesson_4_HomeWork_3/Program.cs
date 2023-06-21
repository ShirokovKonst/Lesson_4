using System;

namespace Lesson_4_HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[7];
            int i = 0;
            while (i < mas.Length)
            {
                mas[i] = new Random().Next(1, 100);
                i++;
            }
            i=0;

            while (i < mas.Length)
            {
                Console.WriteLine(mas[i]);
                i++;
            }
        }
    }
}
