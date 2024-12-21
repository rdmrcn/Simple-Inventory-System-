using System;
using System.Collections.Generic;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory(10); // Inventory with a max capacity of 10 items

            inventory.AddItem(new Item("Sword", "A sharp blade."));
            inventory.AddItem(new Item("Potion", "Restores health."));
            inventory.AddItem(new Item("Shield", "Protects against attacks."));

            inventory.DisplayInventory();

            Console.WriteLine("\nUsing a Potion:");
            inventory.UseItem("Potion");

            inventory.DisplayInventory();

            Console.WriteLine("\nRemoving the Shield:");
            inventory.RemoveItem("Shield");

            inventory.DisplayInventory();
        }
    }

    class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Use()
        {
            Console.WriteLine($"Using {Name}: {Description}");
        }
    }

    class Inventory
    {
        private List<Item> items;
        private int maxCapacity;

        public Inventory(int capacity)
        {
            items = new List<Item>();
            maxCapacity = capacity;
        }

        public void AddItem(Item item)
        {
            if (items.Count >= maxCapacity)
            {
                Console.WriteLine("Inventory is full! Cannot add more items.");
                return;
            }

            items.Add(item);
            Console.WriteLine($"Added {item.Name} to the inventory.");
        }

        public void RemoveItem(string itemName)
        {
            Item itemToRemove = items.Find(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));

            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
                Console.WriteLine($"Removed {itemToRemove.Name} from the inventory.");
            }
            else
            {
                Console.WriteLine($"Item {itemName} not found in inventory.");
            }
        }

        public void UseItem(string itemName)
        {
            Item itemToUse = items.Find(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));

            if (itemToUse != null)
            {
                itemToUse.Use();
                items.Remove(itemToUse);
                Console.WriteLine($"{itemName} has been used and removed from the inventory.");
            }
            else
            {
                Console.WriteLine($"Item {itemName} not found in inventory.");
            }
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\nCurrent Inventory:");

            if (items.Count == 0)
            {
                Console.WriteLine("The inventory is empty.");
                return;
            }

            foreach (Item item in items)
            {
                Console.WriteLine($"- {item.Name}: {item.Description}");
            }
        }
    }
}
