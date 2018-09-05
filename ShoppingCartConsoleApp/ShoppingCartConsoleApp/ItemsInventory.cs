using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsoleApp.Entities
{
    class ItemsInventory
    {
        private List<Item> _itemsInventory = new List<Item>()
        {
            new Item() { ItemId=1, ItemName="Pen", ItemPrice=100 },
            new Item() { ItemId=2, ItemName="Pencil", ItemPrice=200 },
            new Item() { ItemId=3, ItemName="Book", ItemPrice=300 }

        };

        public List<Item> GetAllItems()
        {
            return this._itemsInventory;
        }
    }
}
