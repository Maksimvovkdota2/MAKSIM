using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Введіть число A: ");
        int a = int.Parse(Console.ReadLine());

     
        Console.Write("Введіть кількість елементів масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Елемент {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        
        int count = CountElementsGreaterThanA(a, array);
        Console.WriteLine("Кількість елементів, більших за {0}: {1}", a, count);
    }

    static int CountElementsGreaterThanA(int a, int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > a)
            {
                count++;
            }
        }
        return count;
    }
}