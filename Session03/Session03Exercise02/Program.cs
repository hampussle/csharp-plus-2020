using System;

namespace Session03Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken. ");
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            double?[] numberArray = new double?[inputArray.Length];

            //konvertera sträng till int och spara i array
            for (var i = 0; i < inputArray.Length; i++)
            {
                try
                {
                    numberArray[i] = double.Parse(inputArray[i]);
                }
                catch(Exception)
                {
                    Console.WriteLine("Misslyckat");
                }
            }

            //skriv ut resultat
            for (var i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
            //Console.WriteLine("Största nummer: " + Math.Ceiling(numberArray));
            //Console.WriteLine("Minsta nummer: " + Math.Floor(numberArray));
        }
    }
}
