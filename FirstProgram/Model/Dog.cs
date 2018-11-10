using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomogatchi.Model
{
    public class Dog : Pet
    {
        /// <summary>
        /// A public constructor to create a Dog object
        /// </summary>
        /// <param name="name">Name to be associated with the Dog</param>
        public Dog(string name) : base(name)
        {
            hungerValue = 50.0;
        }

        /// <summary>
        /// Returns a string representation of the Dog
        /// </summary>
        /// <returns></returns>
        public override string ToString() => string.Format("{0} is a dog", Name);
    }
}
