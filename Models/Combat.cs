using Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants;
using Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants.Enfants;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models
{
    internal class Combat
    {
        public Combat()
        {

        }

        Random rdn = new Random();

        public Monsters GenerateMonster()
        {
            Monsters monster;

            switch (rdn.Next(1, 4))
            {
                case 1:
                    monster = new Wolf("Wolf1");
                    break;
                case 2:
                    monster = new Orc("Orc1");
                    break;
                default:
                    monster = new Dragon("Dragon1");
                    break;
            }
            return monster;
        }

        public void Encounter(Heroes hero, Monsters monster)
        {
            while(hero.IsDead == false && monster.IsDead == false)
            {
                hero.Frappe(monster);
                if (monster.IsDead == false)
                {
                    monster.Frappe(hero);
                }
            }
            if(hero.IsDead == true)
            {
                Console.WriteLine("Votre héro est mort, fin de la partie");
            }
            else
            {
                hero.Loot(monster);
                hero.inventory.DisplayInventory();
            }
        }
    }
}
