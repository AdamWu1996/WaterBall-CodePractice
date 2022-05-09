using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1S4_12
{
    internal class Directory : Item
    {
        private List<Item> items;

        internal List<Item> Items { get => items; set => items = value; }

        public void contain(Item item)
        {
            items.Add(item);
        }
    }
}
