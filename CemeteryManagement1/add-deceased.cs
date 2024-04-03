using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CemeteryManagement1
{
    public partial class add_deceased : Form
    {
        public add_deceased()
        {
            InitializeComponent();
        }
        private string connectionString = "server=localhost;database=cemeterydb;uid=root;pwd=\"\";";
        private MySqlConnection cnn;
        private MySqlDataReader reader;

        private void add_deceased_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            // Get the values from the controls
            string name = nametxt.Text;
            string gender = gendercmb.Text;
            string dateOfBirth = dateofbirthcl.Value.ToString("MM/dd/yyyy");
            string dateOfDeath = dateofdeathcl.Value.ToString("MM/dd/yyyy");

            // Establish database connection
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();

                // Query to insert data into the deceased table
                string query = "INSERT INTO deceased (name, gender, date_of_birth, date_of_death) VALUES (@name, @gender, @dateOfBirth, @dateOfDeath)";
                MySqlCommand command = new MySqlCommand(query, cnn);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@dateOfDeath", dateOfDeath);

                // Execute the query
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully.");

                    nametxt.Text = "";
                    gendercmb.SelectedIndex = -1;
                    dateofbirthcl.Value = DateTime.Now;
                    dateofdeathcl.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Failed to insert data.");
                }

                cnn.Close();
            }
        }
    }
}
