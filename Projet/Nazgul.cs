using System;
using System.Collections.Generic;
using System.Text;

namespace LordOfTheRing
{
    public class Nazgul : Combattant
    {     
        public Nazgul() : base("Nazgul", "Ne peut pas être tuer par des hommes et monte des dragons")
        {
            Console.WriteLine("Ajout de Nazgul");
        }
    }
}
