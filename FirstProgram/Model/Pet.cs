using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomogatchi.Model
{
    public abstract class Pet
    {
        public string Name
        {
            get;
            set;
        }

        protected double hungerValue;

        public Pet(string name)
        {
            this.Name = name;
        }

    }
}
