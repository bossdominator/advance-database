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


    public partial class Payment : Form
    {
        bool sidebarExpand;
        public Payment()
        {
            InitializeComponent();
            gcash.Visible = false;
            sidebar.BackColor = ColorTranslator.FromHtml("#b47566");
            btnHome.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnEmployee.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnGrave.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnPayment.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            btnDeceased.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            panel2.BackColor = ColorTranslator.FromHtml("#e5c1b3");
            this.BackColor = ColorTranslator.FromHtml("#f5fcf7");
            submit_btn.BackColor = ColorTranslator.FromHtml("#c6d1b3");
            dataGridView1.BackColor = ColorTranslator.FromHtml("#e1d6c3");
        }

        private string connectionString = "server=localhost;database=cemeterydb;uid=root;pwd=\"\";";
        private MySqlConnection cnn;
        private MySqlDataReader reader;

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

        private void LoadGraveData()
        {
            if (!paid_chkbox.Checked)
            {
                LoadGraveDataAll();
            }
            else
            {
                LoadGraveDataPaid();
            }
        }

        private void LoadGraveDataAll()
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();

                string query = "SELECT g.grave_id AS Grave_id,g.grave_name AS Name, gt.grave_type_name AS Grave_type, " +
                    "gt.gravecost AS Cost, g.status AS Status FROM grave g INNER JOIN gravetype gt ON g.gravetype_id = gt.gravetype_id;";

                MySqlCommand command = new MySqlCommand(query, cnn);

                // Execute the command and load the data into a DataTable
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                cnn.Close();
            }
        }

        private void LoadGraveDataPaid()
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();

                string query = "SELECT g.grave_id AS Grave_id, g.grave_name AS Name, " +
                    "gt.grave_type_name AS Grave_type, gt.gravecost AS Cost, g.status AS Status " +
                    "FROM grave g " +
                    "INNER JOIN gravetype gt ON g.gravetype_id = gt.gravetype_id " +
                    "WHERE g.status = 'paid' " +  // Filter by status = 'paid'
                    "ORDER BY g.grave_id";        // Sort by grave_id

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
            //Payment f6 = new Payment();
            //f6.Show();
            //Visible = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gcash.Visible = true;
            LoadGraveData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Status" column and its value is "paid"
            if (e.ColumnIndex == dataGridView1.Columns["Status"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell statusCell = dataGridView1.Rows[e.RowIndex].Cells["Status"];
                if (statusCell.Value != null && statusCell.Value.ToString() == "paid")
                {
                    // Get the grave ID from the selected row
                    string graveId = dataGridView1.Rows[e.RowIndex].Cells["Grave_id"].Value.ToString();

                    // Query to retrieve the payment date based on the grave ID
                    string paymentDateQuery = "SELECT p.payment_date " +
                          "FROM payment p " +
                          "INNER JOIN grave g ON p.grave_id = g.grave_id " +
                          "WHERE g.grave_id = @graveId";


                    // Retrieve the payment date from the database
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            MySqlCommand command = new MySqlCommand(paymentDateQuery, connection);
                            command.Parameters.AddWithValue("@graveId", graveId);

                            object result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                // Display the payment date in a message box
                                MessageBox.Show($"Payment date: {result.ToString()}", "Payment Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Payment date not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract values from the selected row
                string graveId = selectedRow.Cells["Grave_id"].Value.ToString();
                string graveName = selectedRow.Cells["Name"].Value.ToString();
                string graveType = selectedRow.Cells["Grave_type"].Value.ToString();
                string graveCost = selectedRow.Cells["Cost"].Value.ToString();

                // Populate text boxes
                graveid_txtbox.Text = graveId;
                name_txtbox.Text = graveName;
                grave_txtbox.Text = graveType;
                cost_txtbox.Text = graveCost;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            // Calculate change amount
            decimal totalAmount = decimal.Parse(cost_txtbox.Text);
            decimal cashAmount = decimal.Parse(cashamt_txtbox.Text);
            decimal changeAmount = cashAmount - totalAmount;

            // Check if cash amount is sufficient
            if (cashAmount < totalAmount)
            {
                MessageBox.Show("Insufficient cash. Please provide enough cash to cover the cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // Initialize variables to store the transaction ID and the incremented transaction ID
            int currentTransactionId = 0;
            int incrementedTransactionId = 0;

            // Construct the SQL query to fetch the current transaction ID
            string transactionIdQuery = "SELECT MAX(transaction_id) FROM payment;";

            // Construct the SQL query for inserting payment record
            string insertPaymentQuery = "INSERT INTO payment (transaction_id, paid_by, total_amount, payment_date, payment_type, transaction_status, grave_id) " +
             "VALUES (@transactionId, @paidBy, @totalAmount, CURRENT_TIMESTAMP(), 'cash', 'paid', @graveId);";

            // Construct the SQL query for updating grave status
            string updateGraveStatusQuery = "UPDATE grave SET status = 'paid' WHERE grave_id = @graveId;";

            // Execute the queries
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Fetch the current transaction ID
                    MySqlCommand transactionIdCommand = new MySqlCommand(transactionIdQuery, connection);
                    object result = transactionIdCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        currentTransactionId = Convert.ToInt32(result);
                    }

                    // Increment the transaction ID
                    incrementedTransactionId = currentTransactionId + 1;

                    // Begin a transaction
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        // Insert payment record
                        MySqlCommand insertPaymentCommand = new MySqlCommand(insertPaymentQuery, connection, transaction);
                        insertPaymentCommand.Parameters.AddWithValue("@transactionId", incrementedTransactionId);
                        insertPaymentCommand.Parameters.AddWithValue("@paidBy", paidby_txtbox.Text);
                        insertPaymentCommand.Parameters.AddWithValue("@totalAmount", totalAmount);
                        insertPaymentCommand.Parameters.AddWithValue("@graveId", graveid_txtbox.Text);


                        int paymentRowsAffected = insertPaymentCommand.ExecuteNonQuery();

                        // Update grave status
                        MySqlCommand updateGraveStatusCommand = new MySqlCommand(updateGraveStatusQuery, connection, transaction);
                        updateGraveStatusCommand.Parameters.AddWithValue("@graveId", graveid_txtbox.Text);

                        int graveStatusRowsAffected = updateGraveStatusCommand.ExecuteNonQuery();

                        // Check if both operations were successful
                        if (paymentRowsAffected > 0 && graveStatusRowsAffected > 0)
                        {
                            // If change amount is positive, show it in a message box
                            if (changeAmount > 0)
                            {
                                // Set the culture info to Filipino (Philippines)
                                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("fil-PH");

                                // Format the change amount using the Philippine peso currency symbol
                                string changeAmountPHP = changeAmount.ToString("C2", culture);

                                // Show the message box with the change amount in Philippine peso
                                MessageBox.Show($"Change amount: {changeAmountPHP}", "Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            // Commit the transaction
                            transaction.Commit();
                            MessageBox.Show("Payment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Rollback the transaction if any operation fails
                            transaction.Rollback();
                            MessageBox.Show("Failed to add payment or update grave status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

                paidby_txtbox.Text = "";
                cashamt_txtbox.Text = "";
                graveid_txtbox.Text = "";
                name_txtbox.Text = "";
                grave_txtbox.Text = "";
                cost_txtbox.Text = "";

                LoadGraveData();
            }
        }

        private void paid_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            LoadGraveData();
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

        private void srvc_Click_1(object sender, EventArgs e)
        {
            services f7 = new services();
            f7.Show();
            Visible = false;
        }
    }
}
