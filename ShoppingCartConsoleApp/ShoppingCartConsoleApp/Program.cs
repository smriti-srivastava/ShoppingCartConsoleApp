using ShoppingCartConsoleApp.ConcreteClass;
using ShoppingCartConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsoleApp
{
    class Program
    {
        static void showListOfItems(List<Item> items)
        {
            for (int index = 0; index < items.Count; index++)
            {
                Console.WriteLine("\n\nItem Id {0}", items[index].ItemId);
                Console.WriteLine("Item Name: {0}", items[index].ItemName);
                Console.WriteLine("Item Price: {0}", items[index].ItemPrice);
            }
        }
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.CardId = 1;
            cart.CartItems = new List<Item>();
            ItemsInventory itemsInventory = new ItemsInventory();
            CartOperations cartOperations = new CartOperations();
            List<Item> availableItems = itemsInventory.GetAllItems();
            while(true)
            {
                Console.WriteLine("\n\n---------AVAILABLE ITEMS----------");
                showListOfItems(availableItems);
                Console.WriteLine("\n\n--------------CART OPERATIONS---------------");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove An Item");
                Console.WriteLine("3. Remove All Items Of One Type");
                Console.WriteLine("4. Clear Cart");
                Console.WriteLine("5. Total Amount Of Items in Cart");
                Console.WriteLine("6. Show Cart");
                Console.WriteLine("\n\nEnter Your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Id Of the Item To Add: ");
                            int itemId = Convert.ToInt32(Console.ReadLine());
                            Item item = new Item(availableItems.Find(x => x.ItemId == itemId));
                            Console.WriteLine("Enter Number Of Item selected to be Added: ");
                            int count = Convert.ToInt32(Console.ReadLine());
                            cartOperations.AddItemToCart(cart, item, count);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\n---------ITEMS IN YOUR CART----------");
                            showListOfItems(cartOperations.GetCartItems(cart));
                            Console.WriteLine("Enter Id Of An Item To Delete: ");
                            int itemId = Convert.ToInt32(Console.ReadLine());
                            cartOperations.RemoveOneItemByIdFromCart(cart,itemId);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("---------ITEMS IN YOUR CART----------");
                            showListOfItems(cartOperations.GetCartItems(cart));
                            Console.WriteLine("Enter Id Of the Items To Delete: ");
                            int itemId = Convert.ToInt32(Console.ReadLine());
                            cartOperations.RemoveAllItemsByIdFromCart(cart, itemId);
                            break;
                        }
                    case 4:
                        {
                            cartOperations.ClearCart(cart);
                            break;
                        }
                    case 5:
                        {
                            float amount = cartOperations.GetTotalAmountOfCart(cart);
                            Console.WriteLine("Total Amount: {0}", amount);
                            break;
                        }
                    case 6:
                        {
                            List<Item> cartItems = cartOperations.GetCartItems(cart);
                            if (cartItems.Count == 0)
                                Console.WriteLine("Cart Is Empty");
                            else
                                showListOfItems(cartItems);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                }
                Console.WriteLine("\nDo You Want To Continue(Y/N) : ");
                if (Console.ReadLine().Equals("N")) Environment.Exit(0);
            }
        }
    }
}
