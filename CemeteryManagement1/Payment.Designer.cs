namespace CemeteryManagement1
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeceased = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGrave = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.srvc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.paid_chkbox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.gcash = new System.Windows.Forms.Panel();
            this.submit_btn = new System.Windows.Forms.Button();
            this.paidby_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.graveid_lbl = new System.Windows.Forms.Label();
            this.graveid_txtbox = new System.Windows.Forms.TextBox();
            this.cashamt_txtbox = new System.Windows.Forms.TextBox();
            this.cost_txtbox = new System.Windows.Forms.TextBox();
            this.grave_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.cashamt_lbl = new System.Windows.Forms.Label();
            this.cost_lbl = new System.Windows.Forms.Label();
            this.grave_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.gcash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.LightGray;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(346, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(59, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(346, 673);
            this.sidebar.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 103);
            this.panel2.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.BackgroundImage = global::CemeteryManagement1.Properties.Resources.CND_LOGO;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Location = new System.Drawing.Point(5, 26);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(50, 50);
            this.menuButton.TabIndex = 6;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "CND";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(3, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::CemeteryManagement1.Properties.Resources.home_4;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-7, -14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(354, 73);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEmployee);
            this.panel3.Location = new System.Drawing.Point(3, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 46);
            this.panel3.TabIndex = 8;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(-10, -14);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(356, 73);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "           Employee Information";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeceased);
            this.panel5.Location = new System.Drawing.Point(3, 216);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 46);
            this.panel5.TabIndex = 8;
            // 
            // btnDeceased
            // 
            this.btnDeceased.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeceased.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeceased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeceased.Image = global::CemeteryManagement1.Properties.Resources.Deceased_Icon_3;
            this.btnDeceased.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeceased.Location = new System.Drawing.Point(-7, -14);
            this.btnDeceased.Name = "btnDeceased";
            this.btnDeceased.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnDeceased.Size = new System.Drawing.Size(354, 73);
            this.btnDeceased.TabIndex = 7;
            this.btnDeceased.Text = "          Deceased Information";
            this.btnDeceased.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeceased.UseVisualStyleBackColor = false;
            this.btnDeceased.Click += new System.EventHandler(this.btnDeceased_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGrave);
            this.panel4.Location = new System.Drawing.Point(3, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 46);
            this.panel4.TabIndex = 8;
            // 
            // btnGrave
            // 
            this.btnGrave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGrave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrave.Image = global::CemeteryManagement1.Properties.Resources.Grave_Icon1;
            this.btnGrave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrave.Location = new System.Drawing.Point(-7, -14);
            this.btnGrave.Name = "btnGrave";
            this.btnGrave.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnGrave.Size = new System.Drawing.Size(354, 73);
            this.btnGrave.TabIndex = 7;
            this.btnGrave.Text = "          Grave Information";
            this.btnGrave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrave.UseVisualStyleBackColor = false;
            this.btnGrave.Click += new System.EventHandler(this.btnGrave_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnPayment);
            this.panel6.Location = new System.Drawing.Point(3, 372);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(337, 46);
            this.panel6.TabIndex = 8;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Image = global::CemeteryManagement1.Properties.Resources.Money_Icon1;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(-7, -14);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnPayment.Size = new System.Drawing.Size(354, 73);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "          Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.srvc);
            this.panel8.Location = new System.Drawing.Point(3, 268);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(337, 46);
            this.panel8.TabIndex = 14;
            // 
            // srvc
            // 
            this.srvc.Location = new System.Drawing.Point(0, 0);
            this.srvc.Name = "srvc";
            this.srvc.Size = new System.Drawing.Size(337, 46);
            this.srvc.TabIndex = 13;
            this.srvc.Text = "services";
            this.srvc.UseVisualStyleBackColor = true;
            this.srvc.Click += new System.EventHandler(this.srvc_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Payment Information";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.paid_chkbox);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.gcash);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.Refresh);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(346, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(916, 673);
            this.panel7.TabIndex = 13;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // paid_chkbox
            // 
            this.paid_chkbox.AutoSize = true;
            this.paid_chkbox.Location = new System.Drawing.Point(837, 76);
            this.paid_chkbox.Name = "paid_chkbox";
            this.paid_chkbox.Size = new System.Drawing.Size(73, 29);
            this.paid_chkbox.TabIndex = 32;
            this.paid_chkbox.Text = "Paid";
            this.paid_chkbox.UseVisualStyleBackColor = true;
            this.paid_chkbox.CheckedChanged += new System.EventHandler(this.paid_chkbox_CheckedChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(9, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 50);
            this.button4.TabIndex = 31;
            this.button4.Text = "CASH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gcash
            // 
            this.gcash.BackColor = System.Drawing.SystemColors.Menu;
            this.gcash.Controls.Add(this.submit_btn);
            this.gcash.Controls.Add(this.paidby_txtbox);
            this.gcash.Controls.Add(this.label3);
            this.gcash.Controls.Add(this.graveid_lbl);
            this.gcash.Controls.Add(this.graveid_txtbox);
            this.gcash.Controls.Add(this.cashamt_txtbox);
            this.gcash.Controls.Add(this.cost_txtbox);
            this.gcash.Controls.Add(this.grave_txtbox);
            this.gcash.Controls.Add(this.name_txtbox);
            this.gcash.Controls.Add(this.cashamt_lbl);
            this.gcash.Controls.Add(this.cost_lbl);
            this.gcash.Controls.Add(this.grave_lbl);
            this.gcash.Controls.Add(this.name_lbl);
            this.gcash.Location = new System.Drawing.Point(9, 305);
            this.gcash.Name = "gcash";
            this.gcash.Size = new System.Drawing.Size(895, 357);
            this.gcash.TabIndex = 30;
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.submit_btn.FlatAppearance.BorderSize = 0;
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_btn.Location = new System.Drawing.Point(451, 295);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(130, 40);
            this.submit_btn.TabIndex = 12;
            this.submit_btn.Text = "SUBMIT";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // paidby_txtbox
            // 
            this.paidby_txtbox.Location = new System.Drawing.Point(400, 218);
            this.paidby_txtbox.Name = "paidby_txtbox";
            this.paidby_txtbox.Size = new System.Drawing.Size(229, 30);
            this.paidby_txtbox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paid by:";
            // 
            // graveid_lbl
            // 
            this.graveid_lbl.AutoSize = true;
            this.graveid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graveid_lbl.Location = new System.Drawing.Point(240, 31);
            this.graveid_lbl.Name = "graveid_lbl";
            this.graveid_lbl.Size = new System.Drawing.Size(96, 24);
            this.graveid_lbl.TabIndex = 9;
            this.graveid_lbl.Text = "Grave ID:";
            // 
            // graveid_txtbox
            // 
            this.graveid_txtbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.graveid_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graveid_txtbox.Location = new System.Drawing.Point(400, 31);
            this.graveid_txtbox.Name = "graveid_txtbox";
            this.graveid_txtbox.ReadOnly = true;
            this.graveid_txtbox.Size = new System.Drawing.Size(229, 30);
            this.graveid_txtbox.TabIndex = 8;
            // 
            // cashamt_txtbox
            // 
            this.cashamt_txtbox.Location = new System.Drawing.Point(400, 254);
            this.cashamt_txtbox.Name = "cashamt_txtbox";
            this.cashamt_txtbox.Size = new System.Drawing.Size(229, 30);
            this.cashamt_txtbox.TabIndex = 7;
            // 
            // cost_txtbox
            // 
            this.cost_txtbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cost_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_txtbox.Location = new System.Drawing.Point(400, 149);
            this.cost_txtbox.Name = "cost_txtbox";
            this.cost_txtbox.ReadOnly = true;
            this.cost_txtbox.Size = new System.Drawing.Size(229, 30);
            this.cost_txtbox.TabIndex = 6;
            // 
            // grave_txtbox
            // 
            this.grave_txtbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grave_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grave_txtbox.Location = new System.Drawing.Point(400, 108);
            this.grave_txtbox.Name = "grave_txtbox";
            this.grave_txtbox.ReadOnly = true;
            this.grave_txtbox.Size = new System.Drawing.Size(229, 30);
            this.grave_txtbox.TabIndex = 5;
            // 
            // name_txtbox
            // 
            this.name_txtbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.Location = new System.Drawing.Point(400, 68);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.ReadOnly = true;
            this.name_txtbox.Size = new System.Drawing.Size(229, 30);
            this.name_txtbox.TabIndex = 4;
            this.name_txtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cashamt_lbl
            // 
            this.cashamt_lbl.AutoSize = true;
            this.cashamt_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashamt_lbl.Location = new System.Drawing.Point(239, 254);
            this.cashamt_lbl.Name = "cashamt_lbl";
            this.cashamt_lbl.Size = new System.Drawing.Size(129, 24);
            this.cashamt_lbl.TabIndex = 3;
            this.cashamt_lbl.Text = "Cash Amount:";
            // 
            // cost_lbl
            // 
            this.cost_lbl.AutoSize = true;
            this.cost_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_lbl.Location = new System.Drawing.Point(240, 149);
            this.cost_lbl.Name = "cost_lbl";
            this.cost_lbl.Size = new System.Drawing.Size(57, 24);
            this.cost_lbl.TabIndex = 2;
            this.cost_lbl.Text = "Cost:";
            // 
            // grave_lbl
            // 
            this.grave_lbl.AutoSize = true;
            this.grave_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grave_lbl.Location = new System.Drawing.Point(240, 108);
            this.grave_lbl.Name = "grave_lbl";
            this.grave_lbl.Size = new System.Drawing.Size(124, 24);
            this.grave_lbl.TabIndex = 1;
            this.grave_lbl.Text = "Grave Type:";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(240, 68);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(77, 24);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Name: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(211, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 50);
            this.button3.TabIndex = 29;
            this.button3.Text = "UNAVAILABLE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(110, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 50);
            this.button2.TabIndex = 28;
            this.button2.Text = "UNAVAILABLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(312, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 50);
            this.button1.TabIndex = 27;
            this.button1.Text = "UNAVAILABLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(713, 102);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(35, 35);
            this.Refresh.TabIndex = 26;
            this.Refresh.Text = "🔃";
            this.Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(754, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 159);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CemeteryManagement1.Properties.Resources.Money_Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Information Page";
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.gcash.ResumeLayout(false);
            this.gcash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGrave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDeceased;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel gcash;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label cashamt_lbl;
        private System.Windows.Forms.Label cost_lbl;
        private System.Windows.Forms.Label grave_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox cashamt_txtbox;
        private System.Windows.Forms.TextBox cost_txtbox;
        private System.Windows.Forms.TextBox grave_txtbox;
        private System.Windows.Forms.Label graveid_lbl;
        private System.Windows.Forms.TextBox graveid_txtbox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox paidby_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox paid_chkbox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button srvc;
    }
}