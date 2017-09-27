using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class FitBalls : LightInvent
    {
        public float Diameter { get; set; }
        public int Elasticity { get; set; }

        public FitBalls (string name, float rentPrice, double weight, float diameter, int elasticity): base (name, rentPrice, weight)
        {
            Diameter = diameter;
            Elasticity = elasticity;
        }

        public override string AllInventInfo()
        {
            return $" Fitball name: {Name}\n Price: {RentPrice}\n Weight: {Weight}\n Diameter: {Diameter}\n Elasticity rank: {Elasticity}\n";
        }
    }
}
