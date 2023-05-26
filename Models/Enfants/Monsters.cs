using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants
{
    internal class Monsters : Personnage
    {
        
        public Monsters(string Nom) : base(Nom)
        {
            IsDead = false;
        }
    }
}