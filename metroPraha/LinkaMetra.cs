using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metroPraha
{
    internal class LinkaMetra
    {

        public string Name { get; set; }
        public string[] Stanice { get; set; }
        public bool Aktivni { get; set; }
        public string Color { get; set; }

        public void VypisVsechnyStanice()
        {
            if (Stanice.Length > 0)
            {
            foreach (var jednaStanice in Stanice)
                {
                    Console.WriteLine(jednaStanice);
                }
            }
        }
        public void VypisPrvniPosledni()
     {
        if(Stanice.Length >= 2)
       {
        Console.WriteLine(Stanice[0]);
        Console.WriteLine(Stanice[Stanice.Length - 1]);
        }
    }

        public void NastavLinku()
    {
        if(Color == "zelená")
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
        else if (Color == "červená")
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
        else if (Color == "žlutá")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
        else if (Color == "modrá")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
        Console.WriteLine($"Vítej v lince metra {Name}");
    }
        public void CasCesty()
        {
            VypisVsechnyStanice();
            Console.WriteLine("Vyber 1. stanici");
            string prvniStanice = Console.ReadLine();
            int indexPrvni = Array.IndexOf(Stanice, prvniStanice);
            Console.WriteLine("-----------");

            Console.WriteLine("Vyber 2. stanici");
            string druhaStanice = Console.ReadLine();
            int indexDruhe = Array.IndexOf(Stanice, druhaStanice);
            Console.WriteLine("-----------");
            int dobaCesty = (indexPrvni+ indexDruhe) *2;
            Console.WriteLine("Doba cesty:" + dobaCesty);
        }
    }
}
