using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class LightInvent : AllInventory
    {
        public double Weight { get; set; }

        public LightInvent (string name, float rentPrice, double weight) : base (name, rentPrice)
        {
            Weight = weight;
        }

        public override string AllInventInfo ()
        {
            return $"Name: {Name}\n Rent price: {RentPrice}\n Weight: {Weight}\n";
        }
    }
}
