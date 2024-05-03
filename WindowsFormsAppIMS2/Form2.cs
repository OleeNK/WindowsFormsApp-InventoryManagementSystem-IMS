using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsAppIMS2
{
    public partial class dashboard : Form
    {
        //private string loggedInUsername;
        private Form stockupdateForm;
        private Form homeForm;
        private Form stocksoldForm;
        private Form returnstockForm;
        private Form createinvoiceForm;
        private Form settingForm;

        public dashboard()
        {

            InitializeComponent();
            stockupdateForm = new stockupdate(); 
            homeForm = new home(); 
            returnstockForm = new returnstock();
            createinvoiceForm = new createinvoice();
            stocksoldForm = new stocksold();
            settingForm = new setting();

           // loggedInUsername = username;
            LoadFormIntoPanel(homeForm);
        }
        private void LoadFormIntoPanel(Form form)
        {
            mainpanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            mainpanel.Controls.Add(form);
            form.Show();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homebutton_Click(object sender, EventArgs e)
        {
             LoadFormIntoPanel(homeForm);
        }

        private void stockbutton_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(stockupdateForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(stocksoldForm);
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(returnstockForm);
        }

        private void invoicebutton_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(createinvoiceForm);
        }

        private void settingbutton_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(settingForm);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loginpage loginForm = new loginpage();
            loginForm.Show();

            this.Close();
        }
    }
}
