// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int function(int m, int n)
        {
            if(m == 0)
            {
                return n + 1;
            }
            else
            {
                if(n == 0)
                {
                    return function(m - 1, 1);
                }
                else
                {
                    return function(m - 1, function(m, n - 1));
                }
            }           
        }

        Console.Write($"Значение функции Аккермана равно {function(m, n)}"); // Признаюсь чесно, мне еще предстоит постичь всю прелесть функции Аккермана и ее использование в программировании. 
    }                                                                        // Решил погуглить про эту функцию и прямо в Википедии на псевдокоде наткнулся на готовое решение.
}                                                                            // Поэтому эта задачка тут бонусом))