using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class FactoryWeapon
    {
       public static List<BaseWeapon> ListWeapon = new List<BaseWeapon>();
        //(int KINDOFWEAPON,string name="", string color="", double weight=0, bool Status=true, int Quantitydurability=0, string Manufacturer="", string Metaltype="", double Numberbullets=0)
        public static void AddWeapon()
        {
            Console.WriteLine("enter number betwin 1-3 to create new weapon");
            int KINDOFWEAPON = int.Parse(Console.ReadLine());
            switch (KINDOFWEAPON)
            {
                case 1:
                    FactoryWeapon.ListWeapon.Add(new WeaponBullet("M-16", "Black", 3.5, "Colt", 30));

                    break;
                case 2:
                    FactoryWeapon.ListWeapon.Add(new knif("Combat Knife", "Silver", 1.1, "Gerber", "Steel"));
                    break;
                case 3:
                    FactoryWeapon.ListWeapon.Add(new Stone("Granite Rock", "Gray", 5.2, true, 5));
                    break;


            }

        }
    }
}
