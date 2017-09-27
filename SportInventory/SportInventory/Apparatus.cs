using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class Apparatus : HardInvent
    {
        public string Producer { get; set; }
        public string Category { get; set; }

        public Apparatus(string name, float rentPrice, string level, string producer, string category) : base (name, rentPrice, level)
        {
            Producer = producer;
            Category = category;
        }

        public override string AllInventInfo()
        {
            return $" Apparatus name: {Name}\n Rent price: {RentPrice}\n Level: {ProfessionalLevel}\n Producer: {Producer}\n Category: {Category}\n";
        }
    }
}
