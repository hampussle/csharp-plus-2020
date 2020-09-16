using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public class Cow : Animal
    {
        public Cow(int ageInYears) : base(ageInYears)
        {
        }

        public override void Breed()
        {
            throw new NotImplementedException();
        }

        public override void EatFood()
        {
            //metod som saknar implementation, men det är ok för det finns ingen returntyp
        }
    }
}
