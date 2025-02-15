using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание(1 или 2): ");
            int userChoice = Convert.ToInt16(Console.ReadLine());

            if (userChoice == 1)
            {
                TaskOne();
            }
            else if (userChoice == 2)
            {
                TaskTwo();
            }
            else
            {
                Console.WriteLine("Некоректный ввод, убедитесь что вы выбрали правильной номер задания");
            }
        }

        static void TaskOne()
        {
            Console.WriteLine("Введите значение a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int savedA = a;

            if (a < 0 || n < 0)
            {
                Console.WriteLine("Числа должны быть натуральными!");
                return;
            }

            for (int i = 1; i < n; ++i)
            {
                a *= savedA;
            }

            Console.WriteLine($"{savedA} в {n} степени: {a}");
        }
    }
}
