using MySql.Data.MySqlClient;
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
    public partial class setting : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;Database=imsdb;User ID=root;Password=A_ty2.d%Horn_y";
        public setting()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM stocksold";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewtbl3.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void setting_Load(object sender, EventArgs e)
        {
            
        }

        private void userDetailsLabel_Click(object sender, EventArgs e)
        {

            try
            {

                string query = $"SELECT Username, Email, ContactNo FROM registration_new";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewtbl1.DataSource = dataTable;
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void totalStockLabel_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM items";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewtbl2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void totalStockReturnLabel_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM stockreturn";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewtbl4.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
