using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace CemeteryManagement1
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;database=cemeterydb;uid=root;pwd=\"\";";
        private MySqlConnection cnn;
        

        public Form1()
        {
            InitializeComponent();
            cnn = new MySqlConnection(connectionString);
            this.BackColor = ColorTranslator.FromHtml("#f5fcf7");
            btnLogin.BackColor = ColorTranslator.FromHtml("#c6d1b3");
        }

        private void LoginUser(string username, string password)
        {
            // Establish database connection
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();

                // Query to check if the username and password match
                string query = "SELECT COUNT(*) FROM employee WHERE username = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(query, cnn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                // Execute the query
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    // If user credentials are valid, open the Home form
                    Home f2 = new Home();
                    f2.Show();
                    this.Hide(); // Hide the current login form
                }
                else
                {
                    // If user credentials are invalid, display an error message
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
                cnn.Close();
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            LoginUser(username, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                cnn.Close(); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usernametxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (usernametxt.Text == "Username")
            {
                usernametxt.Text = "";
            }
            
            
        }

        private void passwordtxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (passwordtxt.Text == "Password")
            {
                passwordtxt.Text = "";
            }
        }

        private void login(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string username = usernametxt.Text;
                string password = passwordtxt.Text;

                LoginUser(username, password);
            }
        }

        private void passenter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string username = usernametxt.Text;
                string password = passwordtxt.Text;

                LoginUser(username, password);
            }
        }
    }
}
