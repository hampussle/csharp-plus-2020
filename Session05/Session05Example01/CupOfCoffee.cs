using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Example01
{
    class CupOfCoffee
    {
        public static string DefaultBeanType = "Kaffeböna";
        public static string[] BeanTypes;
        
        public string BeanType;
        public bool Instant;
        public bool Milk;
        public Byte SugarCubes;
        public string Description;

        private string _id;

        //statisk konstruktor
        static CupOfCoffee()
        {
            BeanTypes = new[]
            {
                "Arusha",
                "Arabica",
                "Blue Mountain",
                "Robusta"
            };
        }

        //konstruktor
        public CupOfCoffee()
        {

        }

        //konstruktor med inparametrar
        public CupOfCoffee(bool milk, byte sugarCubes)
        {
            SugarCubes = sugarCubes;
            Milk = milk;
        }

        //Finalizer eller destruktor, används i samband med IDisposable
        ~CupOfCoffee()
        {

        }
    }
}
