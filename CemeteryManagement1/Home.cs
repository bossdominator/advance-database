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

namespace CemeteryManagement1
{
    public partial class Home : Form
    {
        bool sidebarExpand;
        int occupiedGravesCount; // Track the number of occupied graves

        public Home()
        {
            InitializeComponent();
            sidebar.BackColor = ColorTranslator.FromHtml("#b47566");
            btnHome.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnEmployee.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnGrave.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnPayment.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnDeceased.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            panel2.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            this.BackColor = ColorTranslator.FromHtml("#f5fcf7");

            // Example: Initialize occupiedGravesCount
            occupiedGravesCount = count; // Set to your initial count
            UpdateOccupiedGravesLabel(); // Update the label to show the initial count
        }

        // Method to update the label showing occupied graves count
        private void UpdateOccupiedGravesLabel()
        {
            label4.Text = "Occupied Graves: " + count.ToString() + "/500";
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Home f2 = new Home();
            //f2.Show();
            //Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee f3 = new Employee();
            f3.Show();
            Visible = false;
        }

        private void btnGrave_Click(object sender, EventArgs e)
        {
            Grave f4 = new Grave();
            f4.Show();
            Visible = false;
        }

        private void btnDeceased_Click(object sender, EventArgs e)
        {
            Deceased f5 = new Deceased();
            f5.Show();
            Visible = false;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment f6 = new Payment();
            f6.Show();
            Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            GetOccupiedGravesCount();
            UpdateOccupiedGravesLabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            services f7 = new services();
            f7.Show();
            Visible = false;
        }

        private void services1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string connectionString = "server=localhost;database=cemeterydb;uid=root;pwd=\"\";";

        int count = 0;
        int GetOccupiedGravesCount()
        {
           
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM grave WHERE status = 'paid'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        count = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching occupied graves count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            return count;
        }
    }
}
