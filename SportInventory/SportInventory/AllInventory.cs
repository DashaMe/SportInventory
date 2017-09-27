using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class AllInventory
    {
        public string Name { get; set; }
        public float RentPrice { get; set; }

        public AllInventory(string name, float rentPrice)
        {
            Name = name;
            RentPrice = rentPrice;
        }

        public virtual string AllInventInfo()
        {
            return $"Name: {Name}\n Rent price: {RentPrice}\n";
        }
    }
}
