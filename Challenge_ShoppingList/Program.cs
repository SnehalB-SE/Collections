using System;
using System.Collections.Generic;

namespace Challenge_ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ShoppingItems> itemList = new List<ShoppingItems>();

            itemList.Add(new ShoppingItems() {itemName = "Apples", price = 0.95, quantity = 6});
            itemList.Add(new ShoppingItems() { itemName = "Milk", price = 2.25, quantity = 1 });
            itemList.Add(new ShoppingItems() { itemName = "Sugar", price = 1.75, quantity = 2 });
            itemList.Add(new ShoppingItems() { itemName = "Bread", price = 3.25, quantity = 1 });
            itemList.Add(new ShoppingItems() { itemName = "Butter", price = 4.95, quantity = 1 });
            itemList.Add(new ShoppingItems() { itemName = "Cookies", price = 0.50, quantity = 4 });
            itemList.Add(new ShoppingItems() { itemName = "Oranges", price = 0.65, quantity = 5 });
            itemList.Add(new ShoppingItems() { itemName = "Chicken", price = 8.95, quantity = 1 });

            foreach (ShoppingItems si in itemList)
            {
                Console.WriteLine("Item: " + si.itemName + "," + "Price: " + si.price + "," + "Quantity: " + si.quantity);

                Console.WriteLine("\n");

                Console.WriteLine("Item: {0,10}, Price: {1:C}, Quantity: {2}",
                    si.itemName, si.price, si.quantity);
            }
        }
    }

    public class ShoppingItems
    {
        public string itemName;
        public double price;
        public int quantity;
    }
}