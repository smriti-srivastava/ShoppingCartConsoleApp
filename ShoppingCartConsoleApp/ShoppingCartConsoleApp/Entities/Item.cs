using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsoleApp
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public float ItemPrice { get; set; }
        public Item(Item item)
        {
            this.ItemId = item.ItemId;
            this.ItemName = item.ItemName;
            this.ItemPrice = item.ItemPrice;
        }

        public Item() { }
    }
}
