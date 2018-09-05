using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsoleApp.Interfaces
{
    interface ICartOperations
    {
        void AddItemToCart(Cart cart, Item item, int CountOfItemsToAdd);
        void RemoveOneItemByIdFromCart(Cart cart, int itemId);
        void RemoveAllItemsByIdFromCart(Cart cart, int itemId);
        float GetTotalAmountOfCart(Cart cart);
        void ClearCart(Cart cart);
        List<Item> GetCartItems(Cart cart);
    }
}
