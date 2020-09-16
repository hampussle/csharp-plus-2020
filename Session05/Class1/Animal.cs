﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public abstract class Animal
    {
        public int AgeInYears;
        public Animal(int ageInYears)
        {
            AgeInYears = ageInYears;
        }

        public abstract void EatFood();
        public abstract void Breed();
    }
}
