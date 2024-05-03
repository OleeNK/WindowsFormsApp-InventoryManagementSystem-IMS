using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppIMS2
{
    public partial class stockupdate : Form
    {
        //private Panel mainpanel;
        private MySqlConnection connection;
        private string connectionString = "server=localhost;Database=imsdb;User ID=root;Password=A_ty2.d%Horn_y";  
        public stockupdate()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            
        }
       
        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtadditems_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            string category = textCategory.Text;
            string manufacturer = txtManufacturer.Text;
            DateTime dateAdded = dateTimePicker1.Value;

            try
            {

                string query = "INSERT INTO Items (ItemCode, ItemName, Price, Quantity, Category, Manufacturer, DateAdded) " +
                               "VALUES (@ItemCode, @ItemName, @Price, @Quantity, @Category, @Manufacturer, @DateAdded)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    string itemCode = $"ITM-{DateTime.Now:yyyyMMddHHmmss}";

                    cmd.Parameters.AddWithValue("@ItemCode", itemCode);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item added successfully!");
                    

                    MessageBox.Show($"Item added successfully! Item Code: {itemCode}");
                }
                ClearTextBoxes();

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
        private void LoadItemsIntoDataGridView()
        {
            try
            {
                string query = "SELECT * FROM Items";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ClearTextBoxes()
        {
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            textCategory.Text = "";
            txtManufacturer.Text = "";
        }

        private void txtdeleteitems_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string itemCodeToDelete = dataGridView1.SelectedRows[0].Cells["ItemCode"].Value.ToString();

                try
                {
                    string query = "DELETE FROM Items WHERE ItemCode = @ItemCode";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemCode", itemCodeToDelete);

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

        private void txtmodifyitems_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.ShowDialog();
        }

        private void stockupdate_Load(object sender, EventArgs e)
        {
            
        }
       

    }
}
