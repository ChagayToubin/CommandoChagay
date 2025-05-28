using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Commando
{
    public  abstract class BaseWeapon
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }

        protected BaseWeapon(string name, string color, double weight)
        {
            Name = name;
            Color = color;
            Weight = weight;
        }
        public abstract void PrintInfo();
    }

}
