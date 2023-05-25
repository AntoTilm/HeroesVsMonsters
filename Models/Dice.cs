using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models
{
    internal class Dice
    {
        public int LancerDé6() // d6
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
        public int LancerDé4() // d4
        {
            Random rnd = new Random();
            return rnd.Next(1, 5);
        }
        public int Lancer4Dé6_BO3() // BO3 4d6
        {
            int[] tableau = new int[4]; 

            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                tableau[i] = rnd.Next(1, 7);
            }
            Array.Sort(tableau);
            int result = tableau[1] + tableau[2] + tableau[3];
            return result;                     
        }

        // ZONE TEST //
        
        public int[] LancerDeTest(int repet)
        {
            Random rnd = new Random();
            int[] tableau = new int[repet]; 

            for (int i = 0; i < repet; i++)
            {
                tableau[i] = rnd.Next(1, 7);
            }
            return tableau;
        }

        // Essai avec MIN et MAX -- A COMPLETER OU SUPPRIMER
        public int Min { get; } = 1;
        public int Max { get; } = 100;

        public int LancerDé(int Min, int Max)
        {
            Random rnd = new Random();
            int result = rnd.Next(Min, Max);
            return result;
        }

    }
}
