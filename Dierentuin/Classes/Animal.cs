using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.Classes
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract int energy { get; set; }
        public abstract int Feed();
        public abstract int UseEnergy();
    }
}
