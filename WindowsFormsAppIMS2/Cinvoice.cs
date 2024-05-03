using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppIMS2
{
    public partial class createinvoice : Form
    {
        private PrintDocument printDocument;
        private StringBuilder invoiceText;

        private MySqlConnection connection;
        private string connectionString = "server=localhost;Database=imsdb;User ID=root;Password=A_ty2.d%Horn_y";
        public createinvoice()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            invoiceText = new StringBuilder();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(invoiceText.ToString(), new Font("Nirmala UI", 16), Brushes.Black, 20, 20);
        }

        private void createinvoice_Load(object sender, EventArgs e)
        {
            dataGridViewresult.Columns.Add("ItemCode", "Item Code");
            dataGridViewresult.Columns.Add("ItemName", "Item Name");
            dataGridViewresult.Columns.Add("Price", "Price");
            dataGridViewresult.Columns.Add("Quantity", "Quantity");
            dataGridViewresult.Columns.Add("Category", "Category");
            dataGridViewresult.Columns.Add("Manufacturer", "Manufacturer");
            dataGridViewresult.Columns.Add("DateAdded", "Date Added");
        }

        private void checkitemtxtbtn_Click(object sender, EventArgs e)
        {
            string itemCodeToSearch = txtCICode.Text;

            dataGridViewresult.Rows.Clear();

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
                                dataGridViewresult.Rows.Add(
                                    reader["ItemCode"].ToString(),
                                    reader["ItemName"].ToString(),
                                    reader["Price"].ToString(),
                                    reader["Quantity"].ToString(),
                                    reader["Category"].ToString(),
                                    reader["Manufacturer"].ToString(),
                                    reader["DateAdded"].ToString() ) ;
                            }
                        }
                    }
                }
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ClearTextBoxes()
        {
            txtCICode.Text = "";
            
        }

        private void dataGridViewresult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void generateinvoicebtn_Click(object sender, EventArgs e)
        {
            string customerName = txtcustomername.Text;

            // Checking if a customer name is entered
            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Please enter the customer's name.");
                return;
            }

            // Creating the invoice header with the customer's name
            invoiceText.AppendLine($"Customer Name: {customerName}");
            invoiceText.AppendLine();
            HashSet<string> processedItemCodes = new HashSet<string>();


            // Iterating through DataGridView rows and add items to the invoice
            foreach (DataGridViewRow row in dataGridViewresult.Rows)
            {
                string itemCode = row.Cells["ItemCode"].Value != null ? row.Cells["ItemCode"].Value.ToString() : string.Empty;
                if (processedItemCodes.Contains(itemCode))
                    continue;
                processedItemCodes.Add(itemCode);
                string itemName = row.Cells["ItemName"].Value !=null ? row.Cells["ItemName"].Value.ToString() :string.Empty;
                if (processedItemCodes.Contains(itemName))  
                    continue;
                processedItemCodes.Add(itemName);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                string category = row.Cells["Category"].Value.ToString();
                string manufacturer = row.Cells["Manufacturer"].Value.ToString();
                string date = row.Cells["DateAdded"].Value.ToString();

                // Adding item details to the invoice
                invoiceText.AppendLine($"Item Code: {itemCode}");
                invoiceText.AppendLine($"Item Name: {itemName}");
                invoiceText.AppendLine($"Price: {price:C}");
                invoiceText.AppendLine($"Quantity: {quantity}");
                invoiceText.AppendLine($"Category: {category}");
                invoiceText.AppendLine($"Manufacturer: {manufacturer}");
                invoiceText.AppendLine($"Date Added: {date}");
                invoiceText.AppendLine("---------------------------");
            }

            // Showing PrintPreviewDialog before printing
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();

            // Clearing the StringBuilder and customername after printing 
            invoiceText.Clear();
            txtcustomername.Clear();
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Setting up printing logic here
            // To handle the printing of the content using e.Graphics.DrawString
            // Refering to the documentation for PrintPageEventArgs and Graphics.DrawString for details
            

            // Calculating the starting position for printing
            float yPos = 0f;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            Font printFont = new Font("Nirmala UI", 16);

            // Printing the contents of the invoiceText StringBuilder
            e.Graphics.DrawString(invoiceText.ToString(), printFont, Brushes.Black, leftMargin, yPos, new StringFormat());

            // If there are more pages to print,we have to set HasMorePages to true
            e.HasMorePages = false; 
        }

    }
}
    

