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
    public partial class registration : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;

        private loginpage loginForm;

        //private TextBox txtpassword;
        
        public registration()
        {
           
            InitializeComponent();
            InitializeDatabaseConnection();
            

        }
        private void InitializeDatabaseConnection()
        {
            server = "localhost"; 
            database = "imsdb";
            uid = "root";
            password = "A_ty2.d%Horn_y";

            connectionString = $"Server=localhost;Database=imsdb;User ID=root;Password=A_ty2.d%Horn_y;";

            connection = new MySqlConnection(connectionString);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void registrationbutton_Click(object sender, EventArgs e)
        {
            string username = newtxtusername.Text;
            string password = newtxtpassword.Text;
            string confirmpassword = confirmtxtpassword.Text;
            string email = textemail.Text;
            string contactno = txtcontact.Text;


            if (password != confirmpassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }
            try
            {
                connection.Open();

                // Check if the username already exists
                string checkQuery = "SELECT COUNT(*) FROM imsdb.registration_new WHERE username = @Username";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different one.");
                        return;
                    }
                }

                // Insert the new user
                string insertQuery = "INSERT INTO imsdb.registration_new (username, password,confirmpassword, email, contactno) VALUES (@Username, @Password,@ConfirmPassword, @Email, @ContactNo)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", password);
                    insertCmd.Parameters.AddWithValue("@ConfirmPassword", confirmpassword);
                    insertCmd.Parameters.AddWithValue("@Email", email);
                    insertCmd.Parameters.AddWithValue("@ContactNo", contactno);

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
                       // this.Close(); // Close the registration form after successful registration
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
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

        private void label5_Click(object sender, EventArgs e)
        {
            if (loginForm == null)
            {
                loginForm = new loginpage();
                loginForm.FormClosed += (s, args) => { loginForm = null; }; 
            }

            
            loginForm.Show();
            this.Hide(); 
        }

        private void newtxtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void newtxtpassword_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void confirmtxtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkpassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearallbutton_Click(object sender, EventArgs e)
        {
            newtxtusername.Clear();
            newtxtpassword.Clear();
            confirmtxtpassword.Clear();
            textemail.Clear();
            txtcontact.Clear();
        }
    }
}
