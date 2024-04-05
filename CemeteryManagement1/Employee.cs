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
    public partial class Employee : Form
    {
        bool sidebarExpand;
        private string connectionString = "server=localhost;database=cemeterydb;uid=root;pwd=\"\";";
        private MySqlConnection cnn;
        private MySqlDataReader reader;

        public Employee()
        {
            InitializeComponent();
            cnn = new MySqlConnection(connectionString);

            cnn.Open();

            string query = "SELECT * FROM employee";
            MySqlCommand command = new MySqlCommand(query, cnn);

            // Execute the command and load the data into a DataTable
            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;

            cnn.Close();

            sidebar.BackColor = ColorTranslator.FromHtml("#b47566");
            btnHome.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnEmployee.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnGrave.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnPayment.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnDeceased.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            panel2.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            this.BackColor = ColorTranslator.FromHtml("#f5fcf7");
            btnAddEmp.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            btnDelEmp.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            btnModEmp.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            dataGridView1.BackColor = ColorTranslator.FromHtml("#e1d6c3");
        }

        private void LoadEmployeeData()
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();

                string query = "SELECT * FROM employee";
                MySqlCommand command = new MySqlCommand(query, cnn);

                // Execute the command and load the data into a DataTable
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                cnn.Close();
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
            //Employee f3 = new Employee();
            //f3.Show();
            //Visible = false;
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            //addEmployee addEmployee = new addEmployee();


            // Show the form
            //addEmployee.Show();

            cnn.Open();

            string newName = textName.Text;
            string newContact = textContact.Text;
            string newStatus = comboStatus.Text;


            // Create command with parameterized query
            string query = "INSERT INTO employee (employee_name, contact_no, status) VALUES (@newName, @newContact, @newStatus)";
            MySqlCommand command = new MySqlCommand(query, cnn);

            command.Parameters.AddWithValue("@newName", newName);
            command.Parameters.AddWithValue("@newContact", newContact);
            command.Parameters.AddWithValue("@newStatus", newStatus);

            int rowsAffected = command.ExecuteNonQuery();

            // Check if insertion was successful
            if (rowsAffected > 0)
            {
                MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            textName.Text = "";
            textContact.Text = "";

            // Clear selected item in combo box
            comboStatus.SelectedIndex = -1;

            cnn.Close();

            LoadEmployeeData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve values from the clicked row and display them in text boxes
                textName.Text = selectedRow.Cells["employee_name"].Value.ToString();
                textContact.Text = selectedRow.Cells["contact_no"].Value.ToString();
                comboStatus.Text = selectedRow.Cells["status"].Value.ToString();
                textID.Text = selectedRow.Cells["employee_id"].Value.ToString();
            }
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string empID = dataGridView1.SelectedRows[0].Cells["Employee_ID"].Value.ToString();

            // Confirm deletion with the user
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Create connection
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open connection
                    connection.Open();

                    // Create command to delete the record
                    string query = "DELETE FROM employee WHERE employee_id = @empID";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Add parameter
                    command.Parameters.AddWithValue("@empID", empID);

                    // Execute command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if deletion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }

            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            //Environment.Exit(0);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void srvc_Click(object sender, EventArgs e)
        {
            services f7 = new services();
            f7.Show();
            Visible = false;
        }
    }
}

