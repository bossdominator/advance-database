namespace CemeteryManagement1
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeceased = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGrave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.srvc = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModEmp = new System.Windows.Forms.Button();
            this.btnDelEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
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
            this.sidebar.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.srvc);
            this.panel8.Location = new System.Drawing.Point(3, 268);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(337, 46);
            this.panel8.TabIndex = 10;
            // 
            // srvc
            // 
            this.srvc.Location = new System.Drawing.Point(-2, 0);
            this.srvc.Name = "srvc";
            this.srvc.Size = new System.Drawing.Size(337, 46);
            this.srvc.TabIndex = 13;
            this.srvc.Text = "services";
            this.srvc.UseVisualStyleBackColor = true;
            this.srvc.Click += new System.EventHandler(this.srvc_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.exitbtn);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.textID);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.comboStatus);
            this.panel7.Controls.Add(this.textContact);
            this.panel7.Controls.Add(this.textName);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Controls.Add(this.btnModEmp);
            this.panel7.Controls.Add(this.btnDelEmp);
            this.panel7.Controls.Add(this.btnAddEmp);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(346, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(916, 673);
            this.panel7.TabIndex = 13;
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(739, 25);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(0, 0);
            this.exitbtn.TabIndex = 23;
            this.exitbtn.Text = "X";
            this.exitbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID:";
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.SystemColors.Window;
            this.textID.Enabled = false;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(100, 447);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(57, 30);
            this.textID.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 482);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 482);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contact No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 482);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name:";
            // 
            // comboStatus
            // 
            this.comboStatus.BackColor = System.Drawing.SystemColors.Window;
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Complicated"});
            this.comboStatus.Location = new System.Drawing.Point(587, 510);
            this.comboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(200, 33);
            this.comboStatus.TabIndex = 17;
            // 
            // textContact
            // 
            this.textContact.BackColor = System.Drawing.SystemColors.Window;
            this.textContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContact.Location = new System.Drawing.Point(344, 512);
            this.textContact.Margin = new System.Windows.Forms.Padding(4);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(200, 30);
            this.textContact.TabIndex = 16;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.Window;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(100, 512);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(200, 30);
            this.textName.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(870, 304);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnModEmp
            // 
            this.btnModEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnModEmp.FlatAppearance.BorderSize = 0;
            this.btnModEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModEmp.Location = new System.Drawing.Point(587, 592);
            this.btnModEmp.Name = "btnModEmp";
            this.btnModEmp.Size = new System.Drawing.Size(200, 39);
            this.btnModEmp.TabIndex = 13;
            this.btnModEmp.Text = "o Modify employee";
            this.btnModEmp.UseVisualStyleBackColor = false;
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelEmp.FlatAppearance.BorderSize = 0;
            this.btnDelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEmp.Location = new System.Drawing.Point(344, 592);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Size = new System.Drawing.Size(200, 39);
            this.btnDelEmp.TabIndex = 12;
            this.btnDelEmp.Text = "- Delete employee";
            this.btnDelEmp.UseVisualStyleBackColor = false;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddEmp.FlatAppearance.BorderSize = 0;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.Location = new System.Drawing.Point(100, 592);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(200, 39);
            this.btnAddEmp.TabIndex = 11;
            this.btnAddEmp.Text = "+ Add new employee";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CemeteryManagement1.Properties.Resources.ID_Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Employee Information";
            // 
            // Employee
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
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information Page";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDeceased;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGrave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModEmp;
        private System.Windows.Forms.Button btnDelEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button srvc;
    }
}