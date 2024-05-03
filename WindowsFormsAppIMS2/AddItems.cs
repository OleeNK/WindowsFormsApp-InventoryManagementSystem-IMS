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

namespace WindowsFormsAppIMS2
{
    public partial class StockManager : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;Database=imsdb;User ID=root;Password=A_ty2.d%Horn_y";
        public StockManager()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            //txtdeleteitems += txtdeleteitems;
        }
        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string itemName = txtitems.Text;
            decimal price = Convert.ToDecimal(txtprice.Text);
            string category = txtategory.Text;
            string manufacturer = txtmanufacturer.Text;


            try
            {
                string query = "INSERT INTO items (ItemName, Price,, Category, Manufacturer) VALUES (@ItemName, @Price, @Category, @Manufacturer)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Manufacturer", manufacturer);

                    connection.Open();
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item added successfully!");
                }

                LoadItemsIntoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                

                connection.Close();
            
        }
    }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                int selectedItemID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ItemID"].Value);

                try
                {
                    string query = "DELETE FROM Items WHERE ItemID = @ItemID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", selectedItemID);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item deleted successfully!");
                    }


                    LoadItemsIntoDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    
                    
                        connection.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            LoadItemsIntoDataGridView();
        }
        private void LoadItemsIntoDataGridView()
        {
            try
            {
                string query = "SELECT * FROM Items";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void txtitems_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtadditems_Click(object sender, EventArgs e)
        {

        }
    }
}
