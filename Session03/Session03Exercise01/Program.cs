using System;

namespace Session03Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new[] { 1, 2, 3 };

            for (var i = 0; i < integers.Length; i++)
            {
                var name = nameof(integers);
                var value = integers[i];

                Console.WriteLine($"Index {i} i arrayen {name} har värdet: {value}");
            }

            /*
            var doWhileIndex = 0;

            do
            {
                var value = integers[doWhileIndex];

                Console.WriteLine($"Index {doWhileIndex} i arrayen {nameof(integers)} har värdet {integers}");
            }
            while (doWhileIndex < integers.Length);
            */

            var whileIndex = 0;

            while (whileIndex < integers.Length)
            {
                var value = integers[whileIndex];

                Console.WriteLine($"While index {whileIndex} i arrayen {nameof(integers)} har värdet {integers[whileIndex]}");
                whileIndex++;
            }
        }
    }
}
