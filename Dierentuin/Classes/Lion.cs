﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.Classes
{
    sealed class Lion : Animal
    {
        int maxEnergy = 100;
        int foodUsage = 25;
        int energyUsage = 10;

        public override string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public override int energy
        {
            get
            {
                return energy;
            }
            set
            {
                energy = value;
            }
        }

        public override int Feed()
        {
            if (energy >= maxEnergy)
            {
                return maxEnergy;
            }
            else
            {
                return energy + 25;
            }
        }

        public override int UseEnergy()
        {
            if (energy <= 0)
            {
                return 0;
            }
            else
            {
                int adjustedEnergy = energy - energyUsage;
                return adjustedEnergy;
            }
        }
    }
}
