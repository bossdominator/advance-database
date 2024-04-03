namespace CemeteryManagement1
{
    partial class Deceased
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deceased));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGrave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeceased = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModDec = new System.Windows.Forms.Button();
            this.btnDelDec = new System.Windows.Forms.Button();
            this.btnAddDec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
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
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGrave);
            this.panel4.Location = new System.Drawing.Point(3, 268);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.btnPayment);
            this.panel6.Location = new System.Drawing.Point(3, 320);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Deceased Information";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Controls.Add(this.btnModDec);
            this.panel7.Controls.Add(this.btnDelDec);
            this.panel7.Controls.Add(this.btnAddDec);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(346, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(916, 673);
            this.panel7.TabIndex = 13;
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
            this.dataGridView1.TabIndex = 17;
            // 
            // btnModDec
            // 
            this.btnModDec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnModDec.FlatAppearance.BorderSize = 0;
            this.btnModDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModDec.Location = new System.Drawing.Point(587, 592);
            this.btnModDec.Name = "btnModDec";
            this.btnModDec.Size = new System.Drawing.Size(200, 39);
            this.btnModDec.TabIndex = 16;
            this.btnModDec.Text = "o Modify deceased";
            this.btnModDec.UseVisualStyleBackColor = false;
            this.btnModDec.Click += new System.EventHandler(this.btnModDec_Click);
            // 
            // btnDelDec
            // 
            this.btnDelDec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelDec.FlatAppearance.BorderSize = 0;
            this.btnDelDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelDec.Location = new System.Drawing.Point(344, 592);
            this.btnDelDec.Name = "btnDelDec";
            this.btnDelDec.Size = new System.Drawing.Size(200, 39);
            this.btnDelDec.TabIndex = 15;
            this.btnDelDec.Text = "- Delete deceased";
            this.btnDelDec.UseVisualStyleBackColor = false;
            // 
            // btnAddDec
            // 
            this.btnAddDec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddDec.FlatAppearance.BorderSize = 0;
            this.btnAddDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDec.Location = new System.Drawing.Point(100, 592);
            this.btnAddDec.Name = "btnAddDec";
            this.btnAddDec.Size = new System.Drawing.Size(200, 39);
            this.btnAddDec.TabIndex = 14;
            this.btnAddDec.Text = "+ Add new deceased";
            this.btnAddDec.UseVisualStyleBackColor = false;
            this.btnAddDec.Click += new System.EventHandler(this.btnAddDec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CemeteryManagement1.Properties.Resources.Deceased_Icon_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Deceased
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
            this.Name = "Deceased";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deceased Information Page";
            this.Load += new System.EventHandler(this.Deceased_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private System.Windows.Forms.Button btnModDec;
        private System.Windows.Forms.Button btnDelDec;
        private System.Windows.Forms.Button btnAddDec;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}