using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Commandoes
    {
        public string name;
        public string codename;
        public static string[] tools;
        public string status;
        public Commandoes(string Name,string Codename)
        {
            name = Name;
            codename = Codename;

        }
        public void Walk()
        {
            status = "Walk";
            Console.WriteLine("The soilder walk");
        }
        public void Hide()
        {
            status = "Hide";
            Console.WriteLine("The soilder hide");
        }
        public void Attack()
        {
            status = "Attack";
            Console.WriteLine($"The commando {codename} attack");
        }
    }
}
