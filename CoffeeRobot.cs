﻿using Starbucks.CoffeeDrinks;
using Starbucks.Drinks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public class CoffeeRobot
    {
        public IDrink MakeDrink(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    return new CaramelMacchiato();
                case 2:
                    return new CaffeLatte();
                case 3:
                    return new Cappuccino();
                case 4:
                    return new CaffeAmericano();
                case 5:
                    return new WhiteChocolateMocha();
                case 6:
                    return new CaffeMocha();
                case 7:
                    return new ChaiTeaLatte();
                case 8:
                    return new PumpkinSpiceLatte();
                case 9:
                    return new DoppioEspressoMacchiato();
                case 10:
                    return new EspressoShot();
                default:
                    return null;

            }
        }    
    }
}
