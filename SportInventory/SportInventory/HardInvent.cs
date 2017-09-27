using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class HardInvent : AllInventory
    {
        public string ProfessionalLevel { get; set; }

        public HardInvent(string name, float rentPrice, string level) : base(name, rentPrice)
        {
            ProfessionalLevel = level;
        }

        public override string AllInventInfo()
        {
            return $"Name: {Name}\n Rent price: {RentPrice}\n Level: {ProfessionalLevel}\n";
        }
    }
}
