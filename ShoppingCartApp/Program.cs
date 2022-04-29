using System;
using System.Collections.Generic;
using ShoppingLibrary;

namespace ShoppingCartApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            FoodItem foodItem = new FoodItem("Chicken", 120.99m);
            cart.AddShoppingCartItem(foodItem);
            Appliances appliances = new Appliances("Toaster", 199.99m);
            cart.AddShoppingCartItem(appliances);
            appliances = new Appliances("Stove", 1549.99m);
            cart.AddShoppingCartItem(appliances);
            appliances = new Appliances("Kettle", 179.99m);
            cart.AddShoppingCartItem(appliances);
            foodItem = new FoodItem("Corn", 25.99m);
            cart.AddShoppingCartItem(foodItem);

            //This displays the list of items
            List<ShoppingCartItem> items = cart.CartItems();

            foreach(ShoppingCartItem item in items)
            {
                Console.WriteLine(item.Items() + "\t\t" + item.Price());
            }

            Console.WriteLine(" ");

            Console.WriteLine("Subtotal:\t" + cart.GetSubTotal());

            Console.WriteLine(" ");

            Console.WriteLine("VAT Total:\t" + cart.GetVAT());

        }
    }
}
