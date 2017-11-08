namespace TestEikonSxS
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbResponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbDebug = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbHandshakeURL = new System.Windows.Forms.TextBox();
            this.btnHandshake = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbHandshakeResponse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.txbAPIKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSessionToken = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHandshakeResult = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbAppName = new System.Windows.Forms.TextBox();
            this.btnLaunchApp = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txbLaunchAppResponse = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvAppList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1 : Test Connection to Eikon SxS server - send HTTP GET request to local hos" +
    "t port 9000";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(432, 37);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL:";
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(95, 38);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(331, 20);
            this.txbURL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Response: ";
            // 
            // txbResponse
            // 
            this.txbResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbResponse.Location = new System.Drawing.Point(587, 38);
            this.txbResponse.Name = "txbResponse";
            this.txbResponse.ReadOnly = true;
            this.txbResponse.Size = new System.Drawing.Size(327, 20);
            this.txbResponse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(92, 65);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(185, 16);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "<result>/PASSED/FAILED";
            // 
            // txbDebug
            // 
            this.txbDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDebug.Location = new System.Drawing.Point(512, 544);
            this.txbDebug.Multiline = true;
            this.txbDebug.Name = "txbDebug";
            this.txbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDebug.Size = new System.Drawing.Size(411, 90);
            this.txbDebug.TabIndex = 8;
            this.txbDebug.Text = "DEBUG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Handshake URL";
            // 
            // txbHandshakeURL
            // 
            this.txbHandshakeURL.Location = new System.Drawing.Point(95, 149);
            this.txbHandshakeURL.Name = "txbHandshakeURL";
            this.txbHandshakeURL.Size = new System.Drawing.Size(331, 20);
            this.txbHandshakeURL.TabIndex = 10;
            // 
            // btnHandshake
            // 
            this.btnHandshake.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHandshake.Location = new System.Drawing.Point(433, 149);
            this.btnHandshake.Name = "btnHandshake";
            this.btnHandshake.Size = new System.Drawing.Size(75, 23);
            this.btnHandshake.TabIndex = 11;
            this.btnHandshake.Text = "Send";
            this.btnHandshake.UseVisualStyleBackColor = true;
            this.btnHandshake.Click += new System.EventHandler(this.btnHandshake_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Response: ";
            // 
            // txbHandshakeResponse
            // 
            this.txbHandshakeResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbHandshakeResponse.Location = new System.Drawing.Point(95, 178);
            this.txbHandshakeResponse.Multiline = true;
            this.txbHandshakeResponse.Name = "txbHandshakeResponse";
            this.txbHandshakeResponse.Size = new System.Drawing.Size(819, 83);
            this.txbHandshakeResponse.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Step 2 : Send HTTP POST request for Handshake";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Product ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "API Key:";
            // 
            // txbProductID
            // 
            this.txbProductID.Location = new System.Drawing.Point(95, 123);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(329, 20);
            this.txbProductID.TabIndex = 15;
            // 
            // txbAPIKey
            // 
            this.txbAPIKey.Location = new System.Drawing.Point(504, 123);
            this.txbAPIKey.Name = "txbAPIKey";
            this.txbAPIKey.Size = new System.Drawing.Size(277, 20);
            this.txbAPIKey.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Session Token: ";
            // 
            // txbSessionToken
            // 
            this.txbSessionToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSessionToken.Location = new System.Drawing.Point(331, 272);
            this.txbSessionToken.Name = "txbSessionToken";
            this.txbSessionToken.Size = new System.Drawing.Size(583, 20);
            this.txbSessionToken.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Handshake Result:";
            // 
            // lblHandshakeResult
            // 
            this.lblHandshakeResult.AutoSize = true;
            this.lblHandshakeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandshakeResult.Location = new System.Drawing.Point(106, 275);
            this.lblHandshakeResult.Name = "lblHandshakeResult";
            this.lblHandshakeResult.Size = new System.Drawing.Size(113, 13);
            this.lblHandshakeResult.TabIndex = 20;
            this.lblHandshakeResult.Text = "SUCCESS/FAILED";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Launch App:";
            // 
            // txbAppName
            // 
            this.txbAppName.Location = new System.Drawing.Point(95, 329);
            this.txbAppName.Name = "txbAppName";
            this.txbAppName.Size = new System.Drawing.Size(197, 20);
            this.txbAppName.TabIndex = 22;
            // 
            // btnLaunchApp
            // 
            this.btnLaunchApp.Location = new System.Drawing.Point(298, 327);
            this.btnLaunchApp.Name = "btnLaunchApp";
            this.btnLaunchApp.Size = new System.Drawing.Size(75, 23);
            this.btnLaunchApp.TabIndex = 23;
            this.btnLaunchApp.Text = "Launch";
            this.btnLaunchApp.UseVisualStyleBackColor = true;
            this.btnLaunchApp.Click += new System.EventHandler(this.btnLaunchApp_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Response :";
            // 
            // txbLaunchAppResponse
            // 
            this.txbLaunchAppResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbLaunchAppResponse.Location = new System.Drawing.Point(93, 359);
            this.txbLaunchAppResponse.Multiline = true;
            this.txbLaunchAppResponse.Name = "txbLaunchAppResponse";
            this.txbLaunchAppResponse.Size = new System.Drawing.Size(819, 83);
            this.txbLaunchAppResponse.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 460);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "List  of launched Apps:";
            // 
            // dgvAppList
            // 
            this.dgvAppList.AllowUserToAddRows = false;
            this.dgvAppList.AllowUserToDeleteRows = false;
            this.dgvAppList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAppList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppList.Location = new System.Drawing.Point(39, 477);
            this.dgvAppList.Name = "dgvAppList";
            this.dgvAppList.Size = new System.Drawing.Size(439, 150);
            this.dgvAppList.TabIndex = 27;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(935, 646);
            this.Controls.Add(this.dgvAppList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbLaunchAppResponse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLaunchApp);
            this.Controls.Add(this.txbAppName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblHandshakeResult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbSessionToken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbAPIKey);
            this.Controls.Add(this.txbProductID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbHandshakeResponse);
            this.Controls.Add(this.btnHandshake);
            this.Controls.Add(this.txbHandshakeURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDebug);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbResponse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label1);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MooMoo Test Eikon Side by Side API";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txbDebug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbHandshakeURL;
        private System.Windows.Forms.Button btnHandshake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbHandshakeResponse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.TextBox txbAPIKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSessionToken;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblHandshakeResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbAppName;
        private System.Windows.Forms.Button btnLaunchApp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbLaunchAppResponse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvAppList;
    }
}

