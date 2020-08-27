using System;

namespace Session02Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts = TimeSpan.FromMinutes(30195);

            string tss = ts.ToString(@"hh\:mm\:ss");

            Console.WriteLine(tss);
            Console.ReadLine();
        }
    }
}
