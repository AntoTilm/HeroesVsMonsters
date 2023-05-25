using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_récapitulatif___Heroes_Vs_Monsters.Models
{
    internal class Inventory
    {
        private Dictionary<string, int> inventory = new Dictionary<string, int>();
        public void AddItem(string itemName, int itemQuantity)
        {
            if (inventory.ContainsKey(itemName))
            {
                inventory[itemName] += itemQuantity;
            }
            else
            {
                inventory.Add(itemName, itemQuantity);
            }
        }
        public void RemoveItem(string itemName, int itemQuantity)
        {
            foreach (KeyValuePair<string, int> entry in inventory)
            {
                string key = entry.Key;
                if (key == itemName)
                {
                    if (itemQuantity > inventory[itemName])
                    {
                        Console.WriteLine($"Vous n'avez pas assez de: {itemName}");
                        return;
                    }
                    else if (itemQuantity == inventory[itemName])
                    {
                        inventory.Remove(itemName);
                        return;
                    }
                    else
                    {
                        inventory[key] -= itemQuantity;
                        return;
                    }                
                }
            }
            Console.WriteLine($"Vous ne possedez pas: {itemName}");
        }
        public int GetItemQuantity(string itemName)
        {
            foreach (KeyValuePair<string, int> entry in inventory)
            {
                string key = entry.Key;
                if (key == itemName)
                {
                    return entry.Value;
                }          
            }
        Console.WriteLine("Vous ne possedez pas l'item");
        return 0;                
        }
        public void DisplayInventory()
        {
            foreach (KeyValuePair<string, int> entry in inventory)
            {
                Console.WriteLine($"L'inventaire contient {entry.Value} de {entry.Key}");                
            }            
        }
    }
}
