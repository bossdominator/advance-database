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
    public partial class Deceased : Form
    {
        bool sidebarExpand;
        public Deceased()
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
            btnAddDec.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            btnDelDec.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            btnModDec.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            dataGridView1.BackColor = ColorTranslator.FromHtml("#e1d6c3");
        }

        private string connectionString = "server=localhost;database=cemeterydb;uid=root;pwd=\"\";";
        private MySqlConnection cnn;
        private MySqlDataReader reader;

        private void LoadDesceasedData()
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();

                string query = "SELECT * FROM deceased";
                MySqlCommand command = new MySqlCommand(query, cnn);

                // Execute the command and load the data into a DataTable
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                cnn.Close();
            }
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
            f2.Show();
            Visible = false;
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
            //Deceased f5 = new Deceased();
            //f5.Show();
            //Visible = false;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment f6 = new Payment();
            f6.Show();
            Visible = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void Deceased_Load(object sender, EventArgs e)
        {
            LoadDesceasedData();
        }

        private void btnAddDec_Click(object sender, EventArgs e)
        {
            // Create a new instance of the add_deceased form
            add_deceased addDeceasedForm = new add_deceased();


            // Show the new form
            addDeceasedForm.Show();
        }

        private void btnModDec_Click(object sender, EventArgs e)
        {
        }

        private void srvc_Click(object sender, EventArgs e)
        {
            services f7 = new services();
            f7.Show();
            Visible = false;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
