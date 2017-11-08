using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Commission { get; set; } = 0.5;

        public decimal AmountOwed { get; set; } = 0;


        public string Display
        {
            get { return string.Format("{0} - {1} - Rate={2} - Amount Owed: {3}", ID, Name, Commission, AmountOwed ); ; }
                 
        }


}
}
