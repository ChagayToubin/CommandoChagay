using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Commando
{
    public class AirCommando:Commandoes
    {
        public AirCommando(string Name, string Codename) :base( Name,  Codename)
        {
            Console.WriteLine("Update ");
        }
        public void skydiving()
        {
            Console.WriteLine("He have the abaliti to skydiving");
        }
    }
}
