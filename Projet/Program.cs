using System;
using LordOfTheRing;

namespace Laboratoire_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Faction factionAlliance = new Faction("Alliance");
            factionAlliance.AjouterCombattant(new Homme());
            factionAlliance.AjouterCombattant(new Elf());

            Faction factionAnneau = new Faction("Serviteur de l'anneau");
            factionAnneau.AjouterCombattant(new Orc());
            factionAnneau.AjouterCombattant(new Nazgul());

            Console.WriteLine(factionAlliance.ToString());
            Console.WriteLine(factionAnneau.ToString());

            factionAlliance.supprimerCombattant("Homme");
            factionAnneau.supprimerCombattant("Orc", "Nazgul");
            Console.ReadKey();
        }
    }
}
