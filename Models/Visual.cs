using Exercice_récapitulatif___Heroes_Vs_Monsters.Models.Enfants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            grid[hero.CoordonateX, hero.CoordonateY] = "[H]";
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
            grid[hero.CoordonateX, hero.CoordonateY] = "[ ]";
            switch (Console.ReadKey().Key)
            {                
                case ConsoleKey.UpArrow:
                    hero.CoordonateX -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    hero.CoordonateX += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    hero.CoordonateY -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    hero.CoordonateY += 1;
                    break;
                default:
                    break;
            }
        }
        public void PopulateGrid()
        {
            int ennemyNumber = 10;
            while(ennemyNumber > 0)
            {
                Random rnd = new Random();
                int i, j;
                i = rnd.Next(0, grid.GetLength(0));
                j = rnd.Next(0, grid.GetLength(1));

                if (!Presence9(i, j))
                {
                    grid[i, j] = "[M]";
                    ennemyNumber--;
                }
                Console.Clear();
                for (int k = 0; k < grid.GetLength(0); k++)
                {
                    for (int l = 0; l < grid.GetLength(1); l++)
                    {
                        Console.Write(grid[k, l]);
                    }
                    Console.WriteLine();                    
                }
                Console.WriteLine();
                Thread.Sleep(10);
                //Console.Clear();
            }
            
        }
        public bool Presence4(int x, int y)
        {
            if (x + 1 < grid.GetLength(0) && grid[x + 1, y] != "[ ]")
            {
                return true;
            }
            else if (x - 1 >= 0 && grid[x - 1, y] != "[ ]")
            {
                return true;
            }
            else if (y + 1 < grid.GetLength(1) && grid[x, y + 1] != "[ ]")
            {
                return true;
            }
            else if (y - 1 >= 0 && grid[x, y - 1] != "[ ]")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Presence5(int x, int y)
        {
            if (x + 1 < grid.GetLength(0) && grid[x + 1, y] != "[ ]")
            {
                return true;
            }
            else if (x - 1 >= 0 && grid[x - 1, y] != "[ ]")
            {
                return true;
            }
            else if (y + 1 < grid.GetLength(1) && grid[x, y + 1] != "[ ]")
            {
                return true;
            }
            else if (y - 1 >= 0 && grid[x, y - 1] != "[ ]")
            {
                return true;
            }
            else if (grid[x, y] != "[ ]")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Presence9(int x, int y)
        {
            if (x + 1 < grid.GetLength(0) && grid[x + 1, y] != "[ ]")
            {
                return true;
            }
            else if (x + 1 < grid.GetLength(0) && y + 1 < grid.GetLength(1) && grid[x + 1, y + 1] != "[ ]")
            {
                return true;
            }
            else if (x + 1 < grid.GetLength(0) && y - 1 >= 0 && grid[x + 1, y - 1] != "[ ]")
            {
                return true;
            }
            else if (x - 1 >= 0 && grid[x - 1, y] != "[ ]")
            {
                return true;
            }
            else if (x - 1 >= 0 && y + 1 < grid.GetLength(1) && grid[x - 1, y + 1] != "[ ]")
            {
                return true;
            }
            else if (x - 1 >= 0 && y - 1 >= 0 && grid[x - 1, y - 1] != "[ ]")
            {
                return true;
            }
            else if (y + 1 < grid.GetLength(1) && grid[x, y + 1] != "[ ]")
            {
                return true;
            }
            else if (y - 1 >= 0 && grid[x, y - 1] != "[ ]")
            {
                return true;
            }
            else if (grid[x, y] != "[ ]")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Combat4(int x, int y)
        {
            if (x + 1 < grid.GetLength(0) && grid[x + 1, y] == "[ ]")
            {
                return true;
            }
            else if (x - 1 >= 0 && grid[x - 1, y] == "[ ]")
            {
                return true;
            }
            else if (y + 1 < grid.GetLength(1) && grid[x, y + 1] == "[ ]")
            {
                return true;
            }
            else if (y - 1 >= 0 && grid[x, y - 1] == "[ ]")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}