// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;
class Program
{
    static void Main()
    {
        int[] CreateArray(int numbers)
        {
            int[] array = new int[numbers];
            Random rnd = new Random();
            int size = array.Length;
            for(int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 11);
            }
            return array;
        }

        void ShowArray(int[] array)
        {
           int size = array.Length;
           for(int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]} ");
            } 
            Console.WriteLine();
        }

        int[] array = CreateArray(4);
        ShowArray(array);

        void rec(int[] array, int i = 0)
        {
            if(i < array.Length)
            {
                rec(array, i + 1);
                Console.Write($"{array[i]} ");                
            }    
        }
        
        rec(array);
    }
}