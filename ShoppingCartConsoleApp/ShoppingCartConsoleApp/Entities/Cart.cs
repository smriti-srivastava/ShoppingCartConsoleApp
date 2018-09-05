using ShoppingCartConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsoleApp
{
    class Cart
    {
        public int CardId{ get; set;}
        public List<Item> CartItems { get; set; }

    }
}
