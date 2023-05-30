using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants
{
    internal class Heroes : Personnage
    {
        public Heroes(string Nom) : base(Nom)
        {
            CoordonateX = 0;
            CoordonateY = 0;
            IsDead = false;
        }
    }
}
