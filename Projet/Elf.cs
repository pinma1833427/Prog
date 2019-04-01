using System;
using System.Collections.Generic;
using System.Text;

namespace LordOfTheRing
{
    public class Elf : Combattant
    {       
        public Elf() : base("Elf", "Affinité avec la magie et precision extreme avec un arc")
        {
            Console.WriteLine("Ajout d'Elf");           
        }
    }
}
