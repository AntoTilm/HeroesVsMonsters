using Exercice_récapitulatif___Heroes_Vs_Monsters.Models;
using Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants.Enfants;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans la forêt de Shorewood, la forêt enchantée du pays de StormWall!\n");


            Human Guts = new Human("Guts");

            Visual grid = new Visual();
            grid.CreateGrid(Guts);
            grid.PopulateGrid();

            while(!Guts.IsDead)
            {
                if (grid.Presence4(Guts.CoordonateX, Guts.CoordonateY))
                {
                    Combat combat = new Combat();
                    combat.Encounter(Guts, combat.GenerateMonster());
                }
                grid.MoveHero(Guts);
                grid.ShowGrid(Guts);
            } 

        }
    }
}