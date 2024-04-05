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
    public partial class Grave : Form
    {
        bool sidebarExpand;
        public Grave()
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
       //     btnAddGrave.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            btnDelGrave.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            btnModGrave.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            dataGridView1.BackColor = ColorTranslator.FromHtml("#e1d6c3");
        }

        private string connectionString = "server=localhost;database=cemeterydb;uid=root;pwd=\"\";";
        private MySqlConnection cnn;
        private MySqlDataReader reader;

        public void LoadGraveData()
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();

                string query = "SELECT g.grave_id AS Grave_id, g.grave_name AS Name, gt.grave_type_name AS Grave_type, " +
                    "gt.description AS Description, gt.gravecost AS Cost, g.status AS Status FROM grave g " +
                    "INNER JOIN gravetype gt ON g.gravetype_id = gt.gravetype_id;";

                MySqlCommand command = new MySqlCommand(query, cnn);

                // Execute the command and load the data into a DataTable
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                // Refresh the DataGridView
                dataGridView1.Refresh();

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
            //Grave f4 = new Grave();
            //f4.Show();
            //Visible = false;
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void Grave_Load(object sender, EventArgs e)
        {
            LoadGraveData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Retrieve the grave_id of the selected row
                int graveId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Grave_id"].Value);

                // Prompt the user to confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this grave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perform the deletion
                    DeleteGrave(graveId);
                }
            }
        }

        private void DeleteGrave(int graveId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Define the delete query
                    string query = "DELETE FROM grave WHERE grave_id = @graveId";

                    // Create a command
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@graveId", graveId);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Grave deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect changes
                        LoadGraveData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete grave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void btnAddGrave_Click(object sender, EventArgs e)
        {
            // Create a new instance of the add_deceased form
            add_grave addgraveForm = new add_grave();

            // Show the new form
            addgraveForm.Show();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnDelGrave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Retrieve the grave_id of the selected row
                int graveId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Grave_id"].Value);

                // Prompt the user to confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this grave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perform the deletion
                    DeleteGrave(graveId);
                }
            }
            else
            {
                MessageBox.Show("Please select a grave to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword from textBox1
            string searchKeyword = textBox1.Text.Trim();

            // Reload data from the database based on the search keyword
            LoadGraveData(searchKeyword);
        }

        private void LoadGraveData(string searchKeyword = "")
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();

                string query = "SELECT g.grave_id AS Grave_id, g.grave_name AS Name, gt.grave_type_name AS Grave_type, gt.description AS Description, " +
                               "gt.gravecost AS Cost, g.status AS Status FROM grave g INNER JOIN gravetype gt ON g.gravetype_id = gt.gravetype_id";

                // If search keyword is provided, add WHERE clause to filter results
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    // Check if the search keyword is numeric (grave ID)
                    if (int.TryParse(searchKeyword, out int graveId))
                    {
                        query += $" WHERE g.grave_id = {graveId}";
                    }
                    else
                    {
                        query += $" WHERE g.grave_name LIKE '%{searchKeyword}%' OR gt.grave_type_name LIKE '%{searchKeyword}%' OR " +
                                 $"gt.description LIKE '%{searchKeyword}%' OR g.status LIKE '%{searchKeyword}%'";
                    }
                }

                MySqlCommand command = new MySqlCommand(query, cnn);

                // Execute the command and load the data into a DataTable
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Clear the search keyword and reset the filter
            textBox1.Text = "";
            LoadGraveData(); // Reload all data
        }

        private void btnModGrave_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to modify this grave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            if (result == DialogResult.Yes)
            {
                modifypanel.Visible = true;
                modify_combobox.Items.Clear();
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();

                    string query = "SELECT DISTINCT gt.grave_type_name FROM gravetype gt";
                    MySqlCommand command = new MySqlCommand(query, cnn);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string gravetype = reader["grave_type_name"].ToString();
                        modify_combobox.Items.Add(gravetype);
                    }

                    reader.Close();
                }
            }

        }

        private void submit_btnlbl_Click(object sender, EventArgs e)
        {
            modifypanel.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int graveId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Grave_id"].Value);
                string updatedGraveName = grave_nametxtbox.Text; // Get updated grave name from the textbox
                string updatedGraveType = modify_combobox.Text; // Get updated grave type from the combobox

                // Update the database with modified values
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();
                    string query = "UPDATE grave SET grave_name = @graveName, gravetype_id = (SELECT gravetype_id FROM gravetype WHERE grave_type_name = @graveType) WHERE grave_id = @graveId";
                    MySqlCommand command = new MySqlCommand(query, cnn);
                    command.Parameters.AddWithValue("@graveName", updatedGraveName);
                    command.Parameters.AddWithValue("@graveType", updatedGraveType);
                    command.Parameters.AddWithValue("@graveId", graveId);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Grave information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGraveData(); // Refresh the DataGridView to reflect changes
                    }
                    else
                    {
                        MessageBox.Show("Failed to update grave information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract values from the selected row
                string graveName = selectedRow.Cells["Name"].Value.ToString();

                // Populate text boxes
                grave_nametxtbox.Text = graveName;
            }
        }

        private void srvc_Click(object sender, EventArgs e)
        {
            services f7 = new services();
            f7.Show();
            Visible = false;
        }

    

    }
}

