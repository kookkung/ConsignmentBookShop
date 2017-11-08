namespace TestConsignmentBookShop
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsbItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.lsbCart = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbVendors = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.txbProfit = new System.Windows.Forms.TextBox();
            this.txbOwed = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txbTotalInCart = new System.Windows.Forms.TextBox();
            this.shopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnEmptyCart = new System.Windows.Forms.Button();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Consignment Book Shop";
            // 
            // lsbItems
            // 
            this.lsbItems.FormattingEnabled = true;
            this.lsbItems.Location = new System.Drawing.Point(17, 77);
            this.lsbItems.Name = "lsbItems";
            this.lsbItems.Size = new System.Drawing.Size(265, 199);
            this.lsbItems.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Items:";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(309, 101);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(95, 34);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add to Cart ->";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(309, 141);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(95, 41);
            this.btnRemoveFromCart.TabIndex = 4;
            this.btnRemoveFromCart.Text = "<- Remove from Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // lsbCart
            // 
            this.lsbCart.FormattingEnabled = true;
            this.lsbCart.Location = new System.Drawing.Point(429, 77);
            this.lsbCart.Name = "lsbCart";
            this.lsbCart.Size = new System.Drawing.Size(265, 199);
            this.lsbCart.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shopping Cart:";
            // 
            // lsbVendors
            // 
            this.lsbVendors.FormattingEnabled = true;
            this.lsbVendors.Location = new System.Drawing.Point(17, 325);
            this.lsbVendors.Name = "lsbVendors";
            this.lsbVendors.Size = new System.Drawing.Size(265, 173);
            this.lsbVendors.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vendors";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(619, 325);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 9;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Shop Profit: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Vendor Owed:";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(567, 368);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(127, 20);
            this.txbTotalPrice.TabIndex = 13;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbProfit
            // 
            this.txbProfit.Location = new System.Drawing.Point(567, 400);
            this.txbProfit.Name = "txbProfit";
            this.txbProfit.ReadOnly = true;
            this.txbProfit.Size = new System.Drawing.Size(127, 20);
            this.txbProfit.TabIndex = 14;
            this.txbProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbOwed
            // 
            this.txbOwed.Location = new System.Drawing.Point(567, 431);
            this.txbOwed.Name = "txbOwed";
            this.txbOwed.ReadOnly = true;
            this.txbOwed.Size = new System.Drawing.Size(127, 20);
            this.txbOwed.TabIndex = 15;
            this.txbOwed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.shopBindingSource;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataSource = typeof(ConsignmentShopLibrary.Shop);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total in Cart:";
            // 
            // txbTotalInCart
            // 
            this.txbTotalInCart.Location = new System.Drawing.Point(568, 287);
            this.txbTotalInCart.Name = "txbTotalInCart";
            this.txbTotalInCart.ReadOnly = true;
            this.txbTotalInCart.Size = new System.Drawing.Size(126, 20);
            this.txbTotalInCart.TabIndex = 17;
            this.txbTotalInCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // shopBindingSource1
            // 
            this.shopBindingSource1.DataSource = typeof(ConsignmentShopLibrary.Shop);
            // 
            // shopBindingSource2
            // 
            this.shopBindingSource2.DataSource = typeof(ConsignmentShopLibrary.Shop);
            // 
            // btnEmptyCart
            // 
            this.btnEmptyCart.Location = new System.Drawing.Point(320, 253);
            this.btnEmptyCart.Name = "btnEmptyCart";
            this.btnEmptyCart.Size = new System.Drawing.Size(75, 23);
            this.btnEmptyCart.TabIndex = 18;
            this.btnEmptyCart.Text = "Empty Cart";
            this.btnEmptyCart.UseVisualStyleBackColor = true;
            this.btnEmptyCart.Click += new System.EventHandler(this.btnEmptyCart_Click);
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToOrderColumns = true;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(105, 301);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.RowTemplate.ReadOnly = true;
            this.dgvTest.Size = new System.Drawing.Size(348, 150);
            this.dgvTest.TabIndex = 19;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(752, 509);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.btnEmptyCart);
            this.Controls.Add(this.txbTotalInCart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbOwed);
            this.Controls.Add(this.txbProfit);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbVendors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbCart);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbItems);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 540);
            this.MinimumSize = new System.Drawing.Size(760, 540);
            this.Name = "MainUI";
            this.ShowIcon = false;
            this.Text = "Consignment Book Shop";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lsbItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.ListBox lsbCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbVendors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.TextBox txbProfit;
        private System.Windows.Forms.TextBox txbOwed;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTotalInCart;
        private System.Windows.Forms.BindingSource shopBindingSource1;
        private System.Windows.Forms.BindingSource shopBindingSource2;
        private System.Windows.Forms.Button btnEmptyCart;
        private System.Windows.Forms.DataGridView dgvTest;
    }
}

