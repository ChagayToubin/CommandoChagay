using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Commando
{
    public class AirCommando:Commandoes, InterfaceAttack
    {
        public AirCommando(string Name, string Codename) :base( Name,  Codename)
        {
          
        }
        public void skydiving()
        {
            Console.WriteLine("He have the abaliti to skydiving");
        }
        public override void Attack()
        {
            status = "Attack";
            Console.WriteLine($"The commando {codename} attack in the air");
        }
        public override void PrintInfo()
        {
            Program.PrintRed($"Commando Info:\nName: {this.SayName("GENERAL")}\nCodename: {codename}\nStatus: {status}\nSpeciality: Air Commando (Can skydiving)\n------------------------\n");
        }

    }
}
