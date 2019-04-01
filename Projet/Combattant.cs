using System;
using System.Collections.Generic;
using System.Text;

namespace LordOfTheRing
{
    public class Combattant
    {
        private string capacite;
        public string Nom { get; set; }
        protected Combattant(string _nom, string _capacite)
        {
            Nom = _nom;
            capacite = _capacite;
        }                
    }
}
