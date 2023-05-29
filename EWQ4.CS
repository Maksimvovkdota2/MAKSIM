using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "output.txt";
        string outputFilePath = "prime_numbers.txt";

        
        int[] numbers = ReadNumbersFromFile(inputFilePath);

       
        int[] primeNumbers = GetPrimeNumbers(numbers);

        
        WriteNumbersToFile(primeNumbers, outputFilePath);

        Console.WriteLine("Програма завершила роботу.");
    }

    static int[] ReadNumbersFromFile(string filePath)
    {
       
    }

    static int[] GetPrimeNumbers(int[] numbers)
    {
       
    }

    static void WriteNumbersToFile(int[] numbers, string filePath)
    {
        
    }
}