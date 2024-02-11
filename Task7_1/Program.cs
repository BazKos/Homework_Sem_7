// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        if(M > N)
        {
            Console.Write("N должно быть больше M!");
        }
        
        void rec(int M, int N)
        {
            if (M > N)
            {
                return;
            }
            if (M <= N)
            {
                Console.Write($"{M} ");
            }
            rec(M + 1, N);
        }
        
        rec(M, N);
    }
}