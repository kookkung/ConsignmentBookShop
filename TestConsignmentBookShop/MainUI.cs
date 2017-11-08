using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConsignmentBookShop
{
    public partial class MainUI : Form
    {

        private Shop myShop = new Shop();
        BindingSource bndItems = new BindingSource();
        BindingSource bndVendors = new BindingSource();
        BindingSource bndCart = new BindingSource();

        BindingSource bndTest = new BindingSource();

        private void SetupSampleData()
        {
            myShop.Name = "U Chu Liang Shop";


            myShop.Vendors.Add(new Vendor { ID = 0001, Name = "Amarin", Commission = 0.5 });
            myShop.Vendors.Add(new Vendor { ID = 0002, Name = "Se-Ed", Commission = 0.4 });
            myShop.Vendors.Add(new Vendor { ID = 0003, Name = "Nanmee", Commission = 0.6 });

            myShop.Items.Add(new Item { ISBN = 12345, Name = "Praew", Vendor = myShop.Vendors[0], Price = 189 });
            myShop.Items.Add(new Item { ISBN = 43235, Name = "National Geo", Vendor = myShop.Vendors[0], Price = 220 });
            myShop.Items.Add(new Item { ISBN = 2345, Name = "Visual C#", Vendor = myShop.Vendors[1], Price = 345 });
            myShop.Items.Add(new Item { ISBN = 4345, Name = "Visual Basic", Vendor = myShop.Vendors[1], Price = 514 });
            myShop.Items.Add(new Item { ISBN = 8343, Name = "Harry Potter1", Vendor = myShop.Vendors[2], Price = 250 });
            myShop.Items.Add(new Item { ISBN = 5353, Name = "Harry Potter2", Vendor = myShop.Vendors[2], Price = 312 });
            myShop.Items.Add(new Item { ISBN = 33763, Name = "Harry Potter3", Vendor = myShop.Vendors[2], Price = 412 });

        }


        private void UpdateView()
        {


            txbTotalPrice.Text = myShop.TotalPrice.ToString();
            txbProfit.Text = myShop.TotalProfit.ToString();
            txbOwed.Text = myShop.TotalVendorOwed.ToString();
            txbTotalInCart.Text = myShop.TotalInCart.ToString();

            bndCart.ResetBindings(false);
            bndItems.ResetBindings(false);
            bndVendors.ResetBindings(false);
            bndTest.ResetBindings(false);
        }


        public MainUI()
        {
            InitializeComponent();

            SetupSampleData();

            
            bndItems.DataSource = myShop.Items;
            lsbItems.DataSource = bndItems;
            lsbItems.DisplayMember = "Display";
            lsbItems.ValueMember = "Display";

            
            
            bndVendors.DataSource = myShop.Vendors;
            lsbVendors.DataSource = bndVendors;
            lsbVendors.DisplayMember = "Display";
            lsbVendors.ValueMember = "Display";

            
            bndCart.DataSource = myShop.Cart;
            lsbCart.DataSource = bndCart;
            lsbCart.DisplayMember = "DisplaySimple";
            lsbCart.ValueMember = "DisplaySimple";

            bndTest.DataSource = myShop.Items;

            dgvTest.DataSource = bndTest;
            dgvTest.Columns["Display"].Visible = false;
            dgvTest.Columns["DisplaySimple"].Visible = false;
            dgvTest.AutoSizeColumnsMode =  DataGridViewAutoSizeColumnsMode.AllCells;

            //dgvTest.AutoResizeColumns();






        }


        private void MainUI_Load(object sender, EventArgs e)
        {

            UpdateView();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                Item selectedItem = (Item)lsbItems.SelectedItem;


                selectedItem.IsSold = true;
                myShop.Cart.Add(selectedItem);


                bndCart.ResetBindings(false);
                bndItems.ResetBindings(false);

                //Update Total In Cart Price
                myShop.TotalInCart += selectedItem.Price;
                txbTotalInCart.Text = myShop.TotalInCart.ToString();
            } catch
            {

            }


        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            try
            {
                //Update Total In Cart Price
                myShop.TotalInCart -= ((Item)lsbCart.SelectedItem).Price;
                txbTotalInCart.Text = myShop.TotalInCart.ToString();

                myShop.Cart.Remove((Item)lsbCart.SelectedItem);

                bndCart.ResetBindings(false);
                bndItems.ResetBindings(false);
            } catch
            {

            }
            
        }


        private void btnPurchase_Click(object sender, EventArgs e)
        {
            // Clear all data first

            myShop.TotalProfit = 0;
            myShop.TotalPrice = 0;
            myShop.TotalVendorOwed = 0;

            foreach (Vendor vendor in myShop.Vendors)
            {
                vendor.AmountOwed = 0;           
            }

            // Recalculate all Total values                                    
            foreach (Item itemInCart in myShop.Cart)
            {

                myShop.TotalPrice += itemInCart.Price;
                myShop.TotalVendorOwed += (decimal)itemInCart.Vendor.Commission * itemInCart.Price;
                myShop.TotalProfit = myShop.TotalPrice - myShop.TotalVendorOwed;

                itemInCart.Vendor.AmountOwed += (decimal)itemInCart.Vendor.Commission * itemInCart.Price;

            }

            UpdateView();
            

        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            myShop.Cart.Clear();
            myShop.TotalInCart = 0;    

            UpdateView();
        }
    }
}
