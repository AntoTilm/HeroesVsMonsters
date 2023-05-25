using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models
{
    internal class Personnage
    {    
        public string Name { get; set; }
        public bool IsDead { get; set; } = false;
        //{ 
        //    get
        //    {
        //        return HealPoint<=0;
        //    }
        //    set
        //    {

        //    }
        //}

        private int _healPoint;
        public int HealPoint 
        { 
            get
            {
                return _healPoint;
            }
            set
            {
                if (value<=0)
                {
                    _healPoint = 0;
                    IsDead = true;
                }
                else
                {
                    _healPoint = value;                
                }
            }
        }

        private int _strength;
        public int Strength 
        { 
            get
            {
                return _strength;
            }
            set
            {
                _strength = value;
            }
        }

        private int _endurance;
        public int Endurance 
        { 
            get
            {
                return _endurance;
            }
            set
            {
                _endurance = value;
            }
        }


        public Personnage(string Nom)
        {
            Name = Nom;
            GenerateStat();            
        }

        //Interface pour implémenter les modificateurs?
        public void GenerateStat()
        {
            Dice des = new Dice();
            Endurance = des.Lancer4Dé6_BO3();
            Strength = des.Lancer4Dé6_BO3();

            if (Endurance<5)
            {
                HealPoint = (des.Lancer4Dé6_BO3()) - 1;
            }
            else if (Endurance<10)
            {
                HealPoint = (des.Lancer4Dé6_BO3());
            }
            else if (Endurance<15)
            {
                HealPoint = (des.Lancer4Dé6_BO3()) + 1;
            }
            else
            HealPoint = (des.Lancer4Dé6_BO3()) + 2;
        }
        public void Frappe(Personnage target)
        {
            if(target.IsDead == false)
            {
                Dice des = new Dice();

                // Calcule le modificateur de dégat en fonction de la force du personnage
                int modDamage;
                if (Strength < 5)
                {
                    modDamage = -1;
                }
                else if (Strength < 10)
                {
                    modDamage = 0;
                }
                else if (Strength < 15)
                {
                    modDamage = 1;
                }
                else
                {
                    modDamage = 2;
                }
                //Calcul les points de vie restant de l'ennemi lorsque les dégats sont appliqués et affiche un message reprennant les dégats
                int damage = des.LancerDé4() + modDamage;
                target.HealPoint -= damage;
                Console.WriteLine($"{this.Name} à infligé {damage} dégats à {target.Name}. Il reste {target.HealPoint} points de vie à {target.Name}\n");
            }
            else
            {
                Console.WriteLine("Le personnage que vous voulez attaquer est mort");
            }
        }

    }
}
