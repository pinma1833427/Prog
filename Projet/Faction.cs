using System;
using System.Collections.Generic;
using System.Text;

namespace LordOfTheRing
{
    public class Faction
    {
        private List<Combattant> combattants;
        private string nom;
        public Faction(string _nom)
        {
            nom = _nom;
            combattants = new List<Combattant>();
            Console.WriteLine("Création de faction : " + _nom);
        }    
        public void AjouterCombattant(Combattant option)
        {
            combattants.Add(option); 
        }
        public void supprimerCombattant(string nomCombattantASupprimer)
        {
            Combattant membre = GetCombattant(nomCombattantASupprimer);
            if (combattants != null)
            {
                combattants.Remove(membre);
                Console.WriteLine("Supprimer: " + membre);
            }                         
        }
        public void supprimerCombattant(string nomCombattantASupprimer1, string nomCombattantASupprimer2)
        {
            Combattant membre1 = GetCombattant(nomCombattantASupprimer1);
            Combattant membre2 = GetCombattant(nomCombattantASupprimer2);
            if(membre1 != null && membre2 != null)            
            {
                combattants.Remove(membre1);
                combattants.Remove(membre2);
                Console.WriteLine("Supprimmer: " + membre1 + " et " + membre2);
            }
            else if(membre1 == null && membre2 != null)
            {
                combattants.Remove(membre2);
                Console.WriteLine("Supprimmer: " + membre2);
            }
            else if(membre1 != null && membre2 == null)
            {
                combattants.Remove(membre1);
                Console.WriteLine("Supprimmer: " + membre1);
            }
                
        }
        private Combattant GetCombattant(string nomCombattantAChercher)
        {
            foreach (Combattant membre in combattants)
                if (membre.Nom.CompareTo(nomCombattantAChercher) == 0)               
                    return membre;             
            return null;
        }
        public override string ToString()
        {
            string phrase = "";
            foreach (Combattant combattant in combattants)
            {
                phrase += base.ToString();
            }
            return phrase;
        }
    }
}
