﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class knif : BaseWeapon
    {
        public string metaltype;
        public string manufacturer;
        public knif(string name, string color, double weight, string Manufacturer, string Metaltype) : base(name, color, weight)
        {
            metaltype = Metaltype;
            manufacturer = Manufacturer;
        }


        public override void PrintInfo()
        {

            Program.PrintRed($"Weapon Info:\nName: {Name}\nColor: {Color}\nWeight: {Weight}\nManufacturer: {manufacturer}\nMetal Type: {metaltype}\n------------------------\n");
        }


    }
}
