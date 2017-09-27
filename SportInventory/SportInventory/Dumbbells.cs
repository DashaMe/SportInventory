using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class Dumbbells : HardInvent
    {
        public string Material { get; set; }
        public int Weight { get; set; }

        public Dumbbells(string name, float rentPrice, string level, string material, int weight) : base (name, rentPrice, level)
        {
            Material = material;
            Weight = weight;
        }

        public override string AllInventInfo()
        {
            return $" Dumbbells name: {Name}\n Rent price: {RentPrice}\n Level: {ProfessionalLevel}\n Material: {Material}\n Weight: {Weight}\n";
        }
    }
}
