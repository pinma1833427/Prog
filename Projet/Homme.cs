using System;
using System.Collections.Generic;
using System.Text;

namespace LordOfTheRing
{
    public class Homme : Combattant
    {
        public Homme() : base("Homme", "le courage, l'honneur font des homme d'exelent combattant")
        {
            Console.WriteLine("Ajout d'Homme");
        }
    }
}
