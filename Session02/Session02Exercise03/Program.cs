using System;

namespace Session02Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binary Operation
            var additionResult = 1 + 2;

            Console.WriteLine("additionResult: " + additionResult.ToString());

            var incrementResult = additionResult++; //prefix incrementerar först, suffix gör det efter

            Console.WriteLine("incrementResult: " + incrementResult.ToString());

            var trueValue = true;
            var falseValue = false;

            var andResult = trueValue & falseValue;  //operand allt är sant
            var orResult = trueValue | falseValue;   //operand en eller fler av de är sann
            var xorResult = trueValue ^ falseValue;  //operand bara en är sann

            Console.WriteLine("andResult: " + andResult);
            Console.WriteLine("orResult: " + orResult);
            Console.WriteLine("xorResult: " + xorResult);

            var moduloResult = 3 % 2; //operand hur många får plats, division

            Console.WriteLine("moduloResult: " + moduloResult);

            var round = 0.6;
            Console.WriteLine("rundar av: " + Math.Ceiling(round));

            Console.WriteLine(Convert.ToInt32(round));
        }
    }
}
