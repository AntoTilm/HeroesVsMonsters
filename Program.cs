using Exercice_récapitulatif___Heroes_Vs_Monsters.Models;
using Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants.Enfants;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans la forêt de Shorewood, la forêt enchantée du pays de StormWall!\n");

            //Orc orc1 = new Orc("Orc1");            
            //Wolf wolf1 = new Wolf("Wolf1");            
            //Dragon dragon1 = new Dragon("Dragon1");

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

            //Inventory playerInventory = new Inventory();
            //playerInventory.AddItem("Or", 100);
            //playerInventory.AddItem("Cuir", 10);
            //playerInventory.RemoveItem("Verre", 10);
            //playerInventory.RemoveItem("Or", 10);
            //Console.WriteLine(playerInventory.GetItemQuantity("Or"));
            //playerInventory.DisplayInventory();

            //playerInventory.DisplayInventory();

            //Dwarf Gimli = new Dwarf("Gimli");
            //Dwarf Gloin = new Dwarf("Gloin");

            //Gimli.Frappe(Gloin);
            //Gloin.Frappe(Gimli);


            //Dice dice = new Dice();
            //foreach (int d in dice.LancerDeTest(5))
            //{
            //    Console.WriteLine(d);
            //}
        }
    }
}