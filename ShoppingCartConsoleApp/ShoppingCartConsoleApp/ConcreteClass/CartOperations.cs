using ShoppingCartConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsoleApp.ConcreteClass
{
    class CartOperations : ICartOperations
    {
        public void AddItemToCart(Cart cart, Item item, int CountOfItemsToAdd)
        {
            for(int index=0; index < CountOfItemsToAdd; index++)
            {
                cart.CartItems.Add(item);
            }
        }

        public List<Item> GetCartItems(Cart cart)
        {
            return cart.CartItems;
        }

        public float GetTotalAmountOfCart(Cart cart)
        {
            float totalAmount = 0;
            for(int index=0; index < cart.CartItems.Count; index++)
            {
                totalAmount += cart.CartItems[index].ItemPrice;
            }
            return totalAmount;
        }

        public void RemoveOneItemByIdFromCart(Cart cart, int itemId)
        {
            Item itemToRemove = cart.CartItems.Find(item => item.ItemId == itemId);
            cart.CartItems.Remove(itemToRemove);
        }

        public void RemoveAllItemsByIdFromCart(Cart cart, int itemId)
        {
            cart.CartItems.RemoveAll(item => item.ItemId == itemId);
        }

        public void ClearCart(Cart cart)
        {
            cart.CartItems.Clear();
        }
    }
}
