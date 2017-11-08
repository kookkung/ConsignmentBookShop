using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EikonSxSClassLibrary;
using Newtonsoft.Json;

namespace TestEikonSxS
{
    public partial class MainUI : Form
    {

        EikonSxS eikon = new EikonSxS();
        BindingSource bndEikonApps = new BindingSource();
        
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            txbResponse.Text = "";
            txbURL.Text = "http://127.0.0.1:9000/ping";
            lblResult.Text = "";

            txbHandshakeURL.Text = "http://127.0.0.1:9000/sxs/v1";
            txbProductID.Text = "THEWOODBRIDGECOMPANY.CHACHANSXSAPP";
            txbAPIKey.Text = "95f79bb960db4964a00c7f6a1cb5cc674f5c3410";

            lblHandshakeResult.Text = "click SEND button";

            txbAppName.Text = "Quote";

            bndEikonApps.DataSource = eikon.EIKONAPP;
            dgvAppList.DataSource = bndEikonApps;            
            dgvAppList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
       
            eikon.URL_PING = txbURL.Text;
            txbResponse.Text = eikon.DoPingTest();

            try
            {
                int nResultPort = int.Parse(txbResponse.Text);

                if (nResultPort == eikon.PORT)
                {
                    lblResult.Text = "SUCCESS at port " + txbResponse.Text;

                } else
                {
                    lblResult.Text = "FAILED";
                }

            }
            catch (Exception)
            {

                lblResult.Text = "FAILED";
            }                  
                        

        }


        private void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txbDebug.Text = txbDebug.Text + strDebugText + Environment.NewLine;
                txbDebug.SelectionStart = txbDebug.TextLength;
                txbDebug.ScrollToCaret();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }

        }

        private void btnHandshake_Click(object sender, EventArgs e)
        {  

            string strResponse = "";

            eikon.PRODUCT_ID = txbProductID.Text;
            eikon.APIKEY = txbAPIKey.Text;
            strResponse = eikon.DoHandshake();

            txbHandshakeResponse.Text = strResponse;

            if (eikon.ISHANDSHAKESUCCESS)
            {
                txbSessionToken.Text = eikon.SESSIONTOKEN;
                lblHandshakeResult.Text = "SUCCESS";
            }
            else
            {
                txbSessionToken.Text = "";
                lblHandshakeResult.Text = "FAILED";
            }    
        }



        private void btnLaunchApp_Click(object sender, EventArgs e)
        {
            txbLaunchAppResponse.Text = eikon.DoLaunchApp(txbAppName.Text);

            bndEikonApps.ResetBindings(false);



        }
    }
}
