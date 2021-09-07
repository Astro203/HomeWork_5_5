using System;

namespace HomeWork_5_5
{
    class Program
    {
        /// <summary>
        /// метод вычисляющий функцию Аккермана
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int functionAkkerman(int n, int m)
        {
                if (m == 0)
                {
                    return n + 1;
                }
                if (n == 0)
                {
                    return functionAkkerman(m - 1, 1);
                }
                return functionAkkerman(m - 1, functionAkkerman(m, n - 1));
        }
        static void Main(string[] args)
        {
            //Задание 5. Написание функции Аккермана с применением рекурсии
            Console.Write("Введите n: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Введите m: "); int m = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int result = functionAkkerman(n, m);
            Console.WriteLine($"Число Аккермана: {result}");
        }
    }
}
