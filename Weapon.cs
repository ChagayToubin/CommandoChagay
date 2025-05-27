using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Weapon
    {
        public string name;
        public string manufacturer;
        public double numberbullets;
        public Weapon(string Name,string Manufacturer ,double Numberbullets)
        {
            name = Name;
            manufacturer = Manufacturer;
            numberbullets = Numberbullets;

        }
        public void Shoot()
        {
            numberbullets--;
            Console.WriteLine("The bullet was shoot");
        }
        



    }
}
