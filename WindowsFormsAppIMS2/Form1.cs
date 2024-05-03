using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsAppIMS2
{

    public partial class loginpage : Form
    {
       
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        
        public loginpage()
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

            string connectionString = "server=localhost;Database=imsdb;User ID=root;Password=A_ty2.d%Horn_y";

            connection = new MySqlConnection(connectionString);
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }
       

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                dashboard Form2 = new dashboard();
                Form2.ShowDialog();
      
                
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }
        }
             
        private bool ValidateUser(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM imsdb.registration_new WHERE username = @username AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void txtnewuser_Click(object sender, EventArgs e)
        {
            registration registrationForm = new registration();
            registrationForm.ShowDialog();
            this.Hide();
        }
     
    }
};


