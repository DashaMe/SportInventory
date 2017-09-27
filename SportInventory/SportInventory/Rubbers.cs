using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class Rubbers : LightInvent
    {
        public int Width { get; set; }
        public int Hardness { get; set; }
        public string Color { get; set; }

        public Rubbers(string name, float rentPrice, double weight, int width, int hardness, string color): base (name, rentPrice, weight)
        {
            Width = width;
            Hardness = hardness;
            Color = color;
        }

        public override string AllInventInfo()
        {
            return $" Rubber name: {Name}\n Rent price: {RentPrice}\n Weight: {Weight}\n Width: {Width}\n Hardness: {Hardness}\n Color: {Color}\n";
        }


    }
}
