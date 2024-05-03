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
    public partial class returnstock : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;Database=imsdb;User ID=root;Password=A_ty2.d%Horn_y";
        public returnstock()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

        }
        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            string itemName = txtReturnname.Text;
            decimal price = Convert.ToDecimal(txtReturnprice.Text);
            int quantity = Convert.ToInt32(txtReturnquantity.Text);
            string category = txtReturncategory.Text;
            string manufacturer = txtReturnmanufacturer.Text;
            DateTime dateAdded = dateTimePicker2.Value;

            try
            {

                string query = "INSERT INTO stockreturn (ItemCode, ItemName, Price, Quantity, Category, Manufacturer, DateAdded) " +
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
        private void ClearTextBoxes()
        {
            txtReturnname.Text = "";
            txtReturnprice.Text = "";
            txtReturnquantity.Text = "";
            txtReturncategory.Text = "";
            txtReturnmanufacturer.Text = "";
        }


        private void returncheckbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemCode = txtreturnItemCode.Text;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM stockreturn WHERE ItemCode = @ItemCode";
                    using (MySqlCommand cmdSelect = new MySqlCommand(selectQuery, connection))
                    {
                        cmdSelect.Parameters.AddWithValue("@ItemCode", itemCode);

                        using (MySqlDataReader reader = cmdSelect.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string itemName = reader["ItemName"].ToString();
                                decimal price = Convert.ToDecimal(reader["Price"]);
                                int quantity = Convert.ToInt32(reader["Quantity"]);
                                string category = reader["Category"].ToString();
                                string manufacturer = reader["Manufacturer"].ToString();
                                DateTime dateAdded = Convert.ToDateTime(reader["DateAdded"]);

                                string itemInfo = $"Item Name: {itemName}\n" +
                                                  $"Price: {price:C}\n" +
                                                  $"Quantity: {quantity}\n" +
                                                  $"Category: {category}\n" +
                                                  $"Manufacturer: {manufacturer}\n" +
                                                  $"Date Added: {dateAdded.ToShortDateString()}";

                                MessageBox.Show(itemInfo, "Item Details");
                            }
                            else
                            {
                                MessageBox.Show("Item not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
