using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class WeaponBullet:BaseWeapon
    {
      
        public string manufacturer;
        public double numberbullets;
        public WeaponBullet(string name, string color, double weight, string Manufacturer, double Numberbullets) :base( name,  color,  weight)
        {
           
            manufacturer = Manufacturer;
            numberbullets = Numberbullets;

        }
        public void Shoot()
        {
            numberbullets--;
            Console.WriteLine("The bullet was shoot");
        }
        public override void PrintInfo()
        {
            Program.PrintRed($"Weapon Info:\nName: {Name}\nColor: {Color}\nWeight: {Weight}\nManufacturer: {manufacturer}\nNumber of Bullets: {numberbullets}\n------------------------\n");
        }





    }
}
