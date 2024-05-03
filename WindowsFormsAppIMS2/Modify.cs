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
    public partial class ModifyForm : Form
    {

        private MySqlConnection connection;
        private string connectionString = "server=localhost;Database=imsdb;User ID=root;Password=A_ty2.d%Horn_y";
        public ModifyForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertitmbtn_Click(object sender, EventArgs e)
        {
            string itemCodeToSearch = txtMICode.Text;

            dataGridViewModifyFrm.Rows.Clear();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM StockSold WHERE ItemCode = @ItemCode";
                    using (MySqlCommand cmdSelect = new MySqlCommand(selectQuery, connection))
                    {
                        cmdSelect.Parameters.AddWithValue("@ItemCode", itemCodeToSearch);

                        using (MySqlDataReader reader = cmdSelect.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataGridViewModifyFrm.Rows.Add(
                                    reader["ItemCode"].ToString(),
                                    reader["ItemName"].ToString(),
                                    reader["Price"].ToString(),
                                    reader["Quantity"].ToString(),
                                    reader["Category"].ToString(),
                                    reader["Manufacturer"].ToString(),
                                    reader["DateAdded"].ToString());
                            }
                        }
                    }
                }
                //ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        
    }
       
        private void txtMICode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewModifyFrm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            dataGridViewModifyFrm.Columns.Add("ItemCode", "Item Code");
            dataGridViewModifyFrm.Columns.Add("ItemName", "Item Name");
            dataGridViewModifyFrm.Columns.Add("Price", "Price");
            dataGridViewModifyFrm.Columns.Add("Quantity", "Quantity");
            dataGridViewModifyFrm.Columns.Add("Category", "Category");
            dataGridViewModifyFrm.Columns.Add("Manufacturer", "Manufacturer");
            dataGridViewModifyFrm.Columns.Add("DateAdded", "Date Added");
        }

        private void MitemBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewModifyFrm.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewModifyFrm.SelectedRows[0];

                // Update the values in the DataGridView
                selectedRow.Cells["ItemName"].Value = MtxtNa.Text;
                selectedRow.Cells["Price"].Value = MtxtPr.Text;
                selectedRow.Cells["Quantity"].Value = MtxtQu.Text;
                selectedRow.Cells["Category"].Value = MtxtCa.Text;
                selectedRow.Cells["Manufacturer"].Value = MtxtMa.Text;
                selectedRow.Cells["DateAdded"].Value = dateTimePickerM.Value;

                // Update the database with the modified data
                UpdateDatabase(selectedRow);

                // Close the ModifyForm
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a row to modify.");
            }
        }
        private void UpdateDatabase(DataGridViewRow selectedRow)
        {
            string itemCodeToUpdate = selectedRow.Cells["ItemCode"].Value.ToString();

            // Retrieve the modified values from the textboxes
            string itemName = MtxtNa.Text;
            decimal price = Convert.ToDecimal(MtxtPr.Text);
            int quantity = Convert.ToInt32(MtxtQu.Text);
            string category = MtxtCa.Text;
            string manufacturer = MtxtMa.Text;
            DateTime dateAdded = dateTimePickerM.Value;

            try
            {
                string query = "UPDATE Items " +
                               "SET ItemName = @ItemName, " +
                               "Price = @Price, " +
                               "Quantity = @Quantity, " +
                               "Category = @Category, " +
                               "Manufacturer = @Manufacturer, " +
                               "DateAdded = @DateAdded " +
                               "WHERE ItemCode = @ItemCode";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    cmd.Parameters.AddWithValue("@DateAdded", dateAdded);
                    cmd.Parameters.AddWithValue("@ItemCode", itemCodeToUpdate);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No records were updated.");
                    }
                }
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
    }
}
