using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class add_grave : Form
    {

        public add_grave()
        {
            InitializeComponent();
        }

        private string connectionString = "server=localhost;database=cemeterydb;uid=root;pwd=\"\";";
        private MySqlConnection cnn;
        private MySqlDataReader reader;

        private void loaddata()
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open connection
                    cnn.Open();

                    string query = "SELECT grave_type_name FROM gravetype";

                    MySqlCommand command = new MySqlCommand(query, cnn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Add grave_type_name directly to the ComboBox
                            string graveTypeName = reader["grave_type_name"].ToString();
                            grave_typecmb.Items.Add(graveTypeName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Close connection
                    cnn.Close();
                }
            }
        }



        private void add_grave_Load(object sender, EventArgs e)
        {
            loaddata();

        }

        private void InsertGraveRecord()
        {
            
            // Check if a grave type is selected
            if (grave_typecmb.SelectedItem == null)
            {
                MessageBox.Show("Please select a grave type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve the selected grave type name from the ComboBox
            string selectedGraveTypeName = grave_typecmb.SelectedItem.ToString();

            // Query to fetch the gravetype_id based on the selected grave type name
            string gravetypeIdQuery = "SELECT gravetype_id FROM gravetype WHERE grave_type_name = @graveTypeName";

            // Convert selected values from ComboBoxes to integers
            int noOfBody = Convert.ToInt32(no_of_bodycmb.SelectedItem);
            int noOfBones = Convert.ToInt32(no_of_bonescmb.SelectedItem);

            using (MySqlConnection gravetypeIdConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open connection
                    gravetypeIdConnection.Open();

                    MySqlCommand gravetypeIdCommand = new MySqlCommand(gravetypeIdQuery, gravetypeIdConnection);
                    gravetypeIdCommand.Parameters.AddWithValue("@graveTypeName", selectedGraveTypeName);

                    // Execute the query to fetch the gravetype_id
                    object gravetypeIdResult = gravetypeIdCommand.ExecuteScalar();

                    // Check if gravetype_id is found
                    if (gravetypeIdResult != null)
                    {
                        // Convert the fetched gravetype_id to string
                        string gravetypeId = gravetypeIdResult.ToString();

                        string checkDuplicateQuery = "SELECT COUNT(*) FROM grave WHERE grave_name = @graveName";

                        MySqlCommand checkDuplicateCommand = new MySqlCommand(checkDuplicateQuery, gravetypeIdConnection);
                        //checkDuplicateCommand.Parameters.AddWithValue("@gravetypeId", gravetypeId);
                        checkDuplicateCommand.Parameters.AddWithValue("@graveName", grave_nametxt.Text);

                        int count = Convert.ToInt32(checkDuplicateCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("A record with the same grave type already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Insert into the grave table
                        string insertQuery = "INSERT INTO grave (gravetype_id, no_of_body, no_of_bones, grave_name, status) VALUES (@gravetypeId, @noOfBody, @noOfBones, @graveName, @status)";

                        using (MySqlConnection insertConnection = new MySqlConnection(connectionString))
                        {
                            // Open connection
                            insertConnection.Open();

                            MySqlCommand insertCommand = new MySqlCommand(insertQuery, insertConnection);
                            insertCommand.Parameters.AddWithValue("@gravetypeId", gravetypeId);
                            insertCommand.Parameters.AddWithValue("@noOfBody", noOfBody);
                            insertCommand.Parameters.AddWithValue("@noOfBones", noOfBones);
                            insertCommand.Parameters.AddWithValue("@graveName", grave_nametxt.Text);
                            insertCommand.Parameters.AddWithValue("@status", "not paid");

                            // Execute the insert query
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Show success message
                                MessageBox.Show("Record successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            // Close connection
                            insertConnection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve grave type ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("An error occurred: " + ex.Message);
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close connection
                    gravetypeIdConnection.Close();
                }
            }
        }



        private void submitbtn_Click(object sender, EventArgs e)
        {
            InsertGraveRecord();
            // Create an instance of the Grave class

            grave_nametxt.Text = "";
            grave_typecmb.SelectedIndex = -1;
            no_of_bodycmb.SelectedIndex = -1;
            no_of_bonescmb.SelectedIndex = -1;


        }

        private void grave_typecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grave_typecmb.SelectedItem != null)
            {
                using (MySqlConnection descriptionConnection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        // Open connection
                        descriptionConnection.Open();

                        // Get the selected grave type name from the ComboBox
                        string selectedGraveTypeName = grave_typecmb.SelectedItem.ToString();

                        // Query to fetch the description based on the selected grave type name
                        string descriptionQuery = "SELECT description FROM gravetype WHERE grave_type_name = @graveTypeName";

                        MySqlCommand descriptionCommand = new MySqlCommand(descriptionQuery, descriptionConnection);
                        descriptionCommand.Parameters.AddWithValue("@graveTypeName", selectedGraveTypeName);

                        // Execute the query
                        object descriptionResult = descriptionCommand.ExecuteScalar();

                        // Check if the description is not null
                        if (descriptionResult != null)
                        {
                            // Update the descriptiontxt TextBox with the fetched description
                            descriptiontxt.Text = descriptionResult.ToString();
                        }
                        else
                        {
                            // Clear the descriptiontxt TextBox if no description is found
                            descriptiontxt.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        Console.WriteLine("An error occurred while fetching description: " + ex.Message);
                    }
                    finally
                    {
                        // Close connection
                        descriptionConnection.Close();
                    }
                }
            }
        }
    }
}
