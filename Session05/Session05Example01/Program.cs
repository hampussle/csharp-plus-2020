using Session05Animals;
using System;

namespace Session05Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            var beanType = CupOfCoffee.DefaultBeanType;

            Animal myAnimal = new Chicken(1);
            myAnimal = new Cow(2);

            //Tvingad datakonvertering | Genererar InvalidCastException
            Cow myCow = (Cow)myAnimal;

            //Säker datakonvertering | Blir null om typen inte går att konvertera
            myCow = myAnimal as Cow;

            Chicken myChicken = new Chicken(3);
            myChicken.TestMethod();
            IBarnyardAnimal myBarnyardAnimal = new Chicken(4);
            myBarnyardAnimal.FeedingArea = "Main yard";
            //myBarnyardAnimal.RestingArea = "";    går inte för det finns ingen "set"

            myAnimal = (Animal)myBarnyardAnimal;
        }
    }
}
