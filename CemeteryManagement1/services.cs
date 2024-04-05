using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemeteryManagement1
{
    public partial class services : Form
    {
        private bool serviceSelected = false;

        public services()
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


            sevices_panel.Visible = false;
            back_btn.Visible = false;

            label5.Visible = false;
            label6.Visible = false;


            // Attach event handlers to picture boxes
            pictureBox1.Click += pictureBox1_Click; // This line attaches the event handler
            pictureBox2.Click += pictureBox2_Click; // This line attaches the event handler

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            // Toggle the visibility of the description
            label5.Text = (pictureBox == pictureBox1) ? "Price: $1000" : "Price: $1500";
            label5.Visible = !label5.Visible;

            // Toggle the visibility of the button
        

            // Set the flag to indicate service selected
            serviceSelected = !serviceSelected;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label5.Text = "Price: 10,000"; // Set the price according to the selected service
            label5.Visible = true;
            label6.Visible = false;

         

            // Set the flag to indicate service selected
            serviceSelected = true;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Show the price label and button
            label6.Text = "Price: 20,000"; // Set the price according to the selected service
            label6.Visible = true;
            label5.Visible = false;

         

            // Set the flag to indicate service selected
            serviceSelected = true;


        }

        private void add_btn_Click(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment f6 = new Payment();
            f6.Show();
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

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee f3 = new Employee();
            f3.Show();
            Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
            f2.Show();
            Visible = false;
        }

        private void services_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sevices_panel.Show();
        }

        private void sevices_panel_Paint(object sender, PaintEventArgs e)
        {
            back_btn.Visible = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            sevices_panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}