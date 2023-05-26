using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants.Enfants
{
    internal class Wolf : Monsters
    {

    

        public Wolf(string Nom) : base(Nom)
        {
            // Gestion inventaire
            Dice d = new Dice();
            inventory.AddItem("Cuir", d.LancerDé4());

            // Display
            Console.Write($"{this.Name} à été créer avec les statistiques suivantes: \nEndurance: {Endurance} \nForce: {Strength} \nPoints de vie: {HealPoint}\n");
            inventory.DisplayInventory();
            Console.WriteLine();
        }
    }
}
