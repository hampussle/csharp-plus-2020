using System;

namespace Session02Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ålder: ");

            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            if (integer >= 40)
            {
                Console.WriteLine("Du får köpa tobak! Du är även gammal.");
            }
            else if(integer >= 18)
            {
                Console.WriteLine("Du får köpa tobak!");
            }
            else
            {
                Console.WriteLine("Du får inte köpa tobak!");
            }
        }
    }
}
