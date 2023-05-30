using Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models
{
    internal class Visual
    {
        string[,] grid = new string[15, 15];


        public void CreateGrid(Heroes hero)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = "[ ]";
                }
            }
            grid[hero.CoordonateX, hero.CoordonateY] = "[H]";
        }
        public void ShowGrid(Heroes hero)
        {
            Console.Clear();
            grid[hero.CoordonateY, hero.CoordonateX] = "[H]";
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void MoveHero(Heroes hero)
        {
            grid[hero.CoordonateY, hero.CoordonateX] = "[ ]";
            switch (Console.ReadKey().Key)
            {                
                case ConsoleKey.UpArrow:

                    hero.CoordonateY -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    hero.CoordonateY += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    hero.CoordonateX -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    hero.CoordonateX += 1;
                    break;
                default:
                    break;
            }
        }
        public void PopulateGrid() // A TERMINER
        {
            int ennemyNumber = 10;
            while(ennemyNumber < 0)
            {
                Random rnd = new Random();
                int i, j;
                i = rnd.Next(1, grid.GetLength(0));
                j = rnd.Next(1, grid.GetLength(1));


                if (grid[i, j] == "[ ]")
                {
                    grid[i, j] = "[M]";
                    ennemyNumber--;
                }
            }
        }
        public bool Presence(int x, int y) // A TERMINER
        {
            if (grid[x + 1, y] == "[ ]")
            {
                return false;
            }
            else if (grid[x + 1, y + 1] == "[ ]")
            {
                return false;
            }
            else if (grid[x + 1, y - 1] == "[ ]")
            {
                return false;
            }
            else if (grid[x - 1, y] == "[ ]")
            {
                return false;
            }
            else if (grid[x - 1, y + 1] == "[ ]")
            {
                return false;
            }
            else if (grid[x - 1, y - 1] == "[ ]")
            {
                return false;
            }
            else if (grid[x + 1, y] == "[ ]")
            {
                return false;
            }
            else if (grid[x - 1, y] == "[ ]")
            {
                return false;
            }
            return true;
        }
    }
}
