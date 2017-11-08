using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Item
    {

        public int ISBN { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool IsSold { get; set; } = false;

        public Vendor Vendor { get; set; }

        public string Display 
        {
            get {
                return string.Format("{0} ({1}) - {2} thb - {3}", Name, Vendor.Name, Price, IsSold ? "SOLD" : "Available"); ; }            
        }

        public string DisplaySimple
        {
            get
            {
                return string.Format("{0} - {1} thb", Name, Price); ;
            }
        }



    }
}
