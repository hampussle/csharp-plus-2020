using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public class Chicken : Animal, IBarnyardAnimal
    {
        private string _restingArea;
        private string _feedingArea;
        
        public override void Breed()
        {
            throw new NotImplementedException();
        }

        public override void EatFood()
        {
            throw new NotImplementedException();
        }

        //Genväg för att kalla på konstruktor i basklass
        public Chicken(int ageInYears) : base(ageInYears)
        {

        }

        //Egenskapsdefinition
        public string FeedingArea
        {
            get
            {
                return _feedingArea;
            }
            set
            {
                _feedingArea = value;
            }
        }

        // "=>" skriver get-instruktion 
        public string RestingArea => _restingArea;

        public void TestMethod()
        {

        }
    }
}
