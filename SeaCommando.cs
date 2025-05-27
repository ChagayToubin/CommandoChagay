using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class SeaCommando:Commandoes
    {
        public SeaCommando(string Name, string Codename) :base(Name, Codename)
        {
            Console.WriteLine("Update ");
        }
        public void Diving()
        {
            Console.WriteLine("He have the abaliti to Diving");
        }
    }
}

