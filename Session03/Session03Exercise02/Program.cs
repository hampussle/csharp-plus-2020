using System;
using System.Linq;

namespace Session03Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers, separated by a comma.");
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            double[] numberArray = new double[inputArray.Length];

            //konvertera sträng till int och spara i array
            for (var i = 0; i < inputArray.Length; i++)
            {
                try
                {
                    numberArray[i] = double.Parse(inputArray[i]);
                }
                catch(Exception)
                {
                    Console.WriteLine("Failed input");
                }
            }

            //skriv ut resultat
            /*
            for (var i = 0; i < numberArray.Length; i++)
            {
                Console.Write($"{numberArray[i]} ");
            }
            */
            
            int largestNumber1 = (int)numberArray.Max();
            int smallestNumber1 = (int)numberArray.Min();
            int averageValue = (int)numberArray.Sum() / numberArray.Length;


            //int largestNumber = (int)Math.Ceiling(numberArray[]);
            //int smallestNumber = (int)Math.Floor(numberArray[]);

            Console.WriteLine($"\nLargest Number: {largestNumber1}");
            Console.WriteLine($"Smallest Number: {smallestNumber1}");
            Console.WriteLine($"Average: {averageValue}");
        }
    }
}
