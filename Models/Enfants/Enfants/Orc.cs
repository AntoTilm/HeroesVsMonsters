using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants.Enfants
{
    internal class Orc : Monsters
    {
        public Orc(string Nom) : base(Nom)
        {
            // Gestion statistiques
            Strength += 1;

            // Gestion inventaire
            Inventory OrcInventory = new Inventory();
            Dice d = new Dice();
            OrcInventory.AddItem("Or", d.LancerDé6());

            // Display
            Console.Write($"{this.Name} à été créer avec les statistiques suivantes: \nEndurance: {Endurance} \nForce: {Strength} \nPoints de vie: {HealPoint}\n");
            OrcInventory.DisplayInventory();
            Console.WriteLine();
        }
    }
}
