using System;
using System.Collections.Generic;
using System.Text;

namespace LordOfTheRing
{
    public class Orc : Combattant
    {
        public Orc() : base("Orc", "capacité physique exeptionnel")
        {
            Console.WriteLine("Ajout d'Orc");
        }
    }
}
