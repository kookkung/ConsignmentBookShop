using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Shop
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; } = new List<Vendor>();
        public List<Item> Items { get; set; } = new List<Item>();

        public List<Item> Cart { get; set; } = new List<Item>();

        public decimal TotalPrice { get; set; } = 0;
        public decimal TotalProfit { get; set; } = 0;
        public decimal TotalVendorOwed { get; set; } = 0;
        public decimal TotalInCart { get; set; } = 0;

    }
}
