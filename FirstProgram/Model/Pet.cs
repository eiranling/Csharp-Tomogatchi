using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomogatchi.Enums.HungerLevels;

namespace Tomogatchi.Model
{
    public abstract class Pet
    {
        public string Name
        {
            get;
            set;
        }

        protected int hungerValue;
        public HungerLevels HungerLevel
        { 
            get
            {
                HungerLevels minLevel = HungerLevels.Bursting;
                foreach (HungerLevels level in Enum.GetValues(typeof(HungerLevels))) {
                    if ((int)level < (int)minLevel && hungerValue <= (int)level)
                    {
                        minLevel = level;
                    }
                }
                return minLevel;
            }

            set
            {
                hungerValue = (int)value;
            }
        }

        public Pet(string name)
        {
            this.Name = name;
        }

    }
}
