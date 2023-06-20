using System;

namespace Lesson_4_HomeWork_1
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

            int a = Prompt("Введите А: ");
            int b = Prompt("Введите В: ");
            //Не очень понятно из задания, зачем нужен цикл. 
            //Задача решается через метод POW библиотеки Math. 
            //На всякий случай, сделаю решение задачи и через цикл тоже.
            //Console.WriteLine(Math.Pow(a,b));

            int i = 0;
            int result = 1;
            while (i<b)
            {
                result = result*a;
                i++;
            }
            Console.WriteLine(result);
        }
    }
}
