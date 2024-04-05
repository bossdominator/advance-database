namespace CemeteryManagement1
{
    partial class Grave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grave));
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
            this.modifypanel = new System.Windows.Forms.Panel();
            this.modify_combobox = new System.Windows.Forms.ComboBox();
            this.submit_btnlbl = new System.Windows.Forms.Button();
            this.grave_typelbl = new System.Windows.Forms.Label();
            this.grave_namelbl = new System.Windows.Forms.Label();
            this.grave_nametxtbox = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModGrave = new System.Windows.Forms.Button();
            this.btnDelGrave = new System.Windows.Forms.Button();
            this.btnAddGrave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
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
            this.modifypanel.SuspendLayout();
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
            this.panel8.TabIndex = 15;
            // 
            // srvc
            // 
            this.srvc.Location = new System.Drawing.Point(0, 0);
            this.srvc.Name = "srvc";
            this.srvc.Size = new System.Drawing.Size(337, 46);
            this.srvc.TabIndex = 13;
            this.srvc.Text = "services";
            this.srvc.UseVisualStyleBackColor = true;
            this.srvc.Click += new System.EventHandler(this.srvc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Grave Information";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.modifypanel);
            this.panel7.Controls.Add(this.Refresh);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Controls.Add(this.btnModGrave);
            this.panel7.Controls.Add(this.btnDelGrave);
            this.panel7.Controls.Add(this.btnAddGrave);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(346, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(916, 673);
            this.panel7.TabIndex = 14;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // modifypanel
            // 
            this.modifypanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifypanel.Controls.Add(this.modify_combobox);
            this.modifypanel.Controls.Add(this.submit_btnlbl);
            this.modifypanel.Controls.Add(this.grave_typelbl);
            this.modifypanel.Controls.Add(this.grave_namelbl);
            this.modifypanel.Controls.Add(this.grave_nametxtbox);
            this.modifypanel.Location = new System.Drawing.Point(261, 405);
            this.modifypanel.Name = "modifypanel";
            this.modifypanel.Size = new System.Drawing.Size(380, 179);
            this.modifypanel.TabIndex = 22;
            this.modifypanel.Visible = false;
            // 
            // modify_combobox
            // 
            this.modify_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.modify_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_combobox.FormattingEnabled = true;
            this.modify_combobox.Location = new System.Drawing.Point(163, 60);
            this.modify_combobox.Name = "modify_combobox";
            this.modify_combobox.Size = new System.Drawing.Size(167, 33);
            this.modify_combobox.TabIndex = 5;
            // 
            // submit_btnlbl
            // 
            this.submit_btnlbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.submit_btnlbl.FlatAppearance.BorderSize = 0;
            this.submit_btnlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_btnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btnlbl.Location = new System.Drawing.Point(120, 113);
            this.submit_btnlbl.Name = "submit_btnlbl";
            this.submit_btnlbl.Size = new System.Drawing.Size(144, 35);
            this.submit_btnlbl.TabIndex = 4;
            this.submit_btnlbl.Text = "SAVE";
            this.submit_btnlbl.UseVisualStyleBackColor = false;
            this.submit_btnlbl.Click += new System.EventHandler(this.submit_btnlbl_Click);
            // 
            // grave_typelbl
            // 
            this.grave_typelbl.AutoSize = true;
            this.grave_typelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grave_typelbl.Location = new System.Drawing.Point(34, 65);
            this.grave_typelbl.Name = "grave_typelbl";
            this.grave_typelbl.Size = new System.Drawing.Size(113, 24);
            this.grave_typelbl.TabIndex = 3;
            this.grave_typelbl.Text = "Grave Type:";
            // 
            // grave_namelbl
            // 
            this.grave_namelbl.AutoSize = true;
            this.grave_namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grave_namelbl.Location = new System.Drawing.Point(34, 32);
            this.grave_namelbl.Name = "grave_namelbl";
            this.grave_namelbl.Size = new System.Drawing.Size(121, 24);
            this.grave_namelbl.TabIndex = 2;
            this.grave_namelbl.Text = "Grave Name:";
            // 
            // grave_nametxtbox
            // 
            this.grave_nametxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.grave_nametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grave_nametxtbox.Location = new System.Drawing.Point(163, 26);
            this.grave_nametxtbox.Name = "grave_nametxtbox";
            this.grave_nametxtbox.Size = new System.Drawing.Size(167, 30);
            this.grave_nametxtbox.TabIndex = 1;
            // 
            // Refresh
            // 
            this.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Refresh.Location = new System.Drawing.Point(698, 59);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(35, 35);
            this.Refresh.TabIndex = 21;
            this.Refresh.Text = "🔃";
            this.Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(739, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 304);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnModGrave
            // 
            this.btnModGrave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnModGrave.FlatAppearance.BorderSize = 0;
            this.btnModGrave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModGrave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModGrave.Location = new System.Drawing.Point(587, 592);
            this.btnModGrave.Name = "btnModGrave";
            this.btnModGrave.Size = new System.Drawing.Size(200, 39);
            this.btnModGrave.TabIndex = 18;
            this.btnModGrave.Text = "o Modify grave";
            this.btnModGrave.UseVisualStyleBackColor = false;
            this.btnModGrave.Click += new System.EventHandler(this.btnModGrave_Click);
            // 
            // btnDelGrave
            // 
            this.btnDelGrave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelGrave.FlatAppearance.BorderSize = 0;
            this.btnDelGrave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelGrave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelGrave.Location = new System.Drawing.Point(344, 592);
            this.btnDelGrave.Name = "btnDelGrave";
            this.btnDelGrave.Size = new System.Drawing.Size(200, 39);
            this.btnDelGrave.TabIndex = 17;
            this.btnDelGrave.Text = "- Delete grave";
            this.btnDelGrave.UseVisualStyleBackColor = false;
            this.btnDelGrave.Click += new System.EventHandler(this.btnDelGrave_Click);
            // 
            // btnAddGrave
            // 
            this.btnAddGrave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddGrave.FlatAppearance.BorderSize = 0;
            this.btnAddGrave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrave.Location = new System.Drawing.Point(100, 592);
            this.btnAddGrave.Name = "btnAddGrave";
            this.btnAddGrave.Size = new System.Drawing.Size(200, 39);
            this.btnAddGrave.TabIndex = 16;
            this.btnAddGrave.Text = "+ Add new grave";
            this.btnAddGrave.UseVisualStyleBackColor = false;
            this.btnAddGrave.Click += new System.EventHandler(this.btnAddGrave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CemeteryManagement1.Properties.Resources.Grave_Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Grave
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
            this.Name = "Grave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grave Information Page";
            this.Load += new System.EventHandler(this.Grave_Load);
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
            this.modifypanel.ResumeLayout(false);
            this.modifypanel.PerformLayout();
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
        private System.Windows.Forms.Button btnModGrave;
        private System.Windows.Forms.Button btnDelGrave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Panel modifypanel;
        private System.Windows.Forms.TextBox grave_nametxtbox;
        private System.Windows.Forms.Button submit_btnlbl;
        private System.Windows.Forms.Label grave_typelbl;
        private System.Windows.Forms.Label grave_namelbl;
        private System.Windows.Forms.ComboBox modify_combobox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button srvc;
        private System.Windows.Forms.Button btnAddGrave;
    }
}