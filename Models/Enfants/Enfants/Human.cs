using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants.Enfants
{
    internal class Human : Heroes
    {
        public Human(string Nom) : base(Nom)
        {
            Console.WriteLine($"{this.Name} à été créer avec les statistiques suivantes: \nEndurance: {Endurance} \nForce: {Strength} \nPoints de vie: {HealPoint}\n");
            Endurance += 1;
            Strength += 1;
        }
    }
}
