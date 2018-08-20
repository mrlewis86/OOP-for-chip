using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class car:automobile //car is inheriting from automobile class. doesnt need to have make, model year etc
    {
        public int NumberofDoors { get; set; }
        public decimal Discount { get; set; }
    }
}
