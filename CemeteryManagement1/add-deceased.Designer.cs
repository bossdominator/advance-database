namespace CemeteryManagement1
{
    partial class add_deceased
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.gendercmb = new System.Windows.Forms.ComboBox();
            this.dateofbirthcl = new System.Windows.Forms.DateTimePicker();
            this.dateofdeathcl = new System.Windows.Forms.DateTimePicker();
            this.submitbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Death:";
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.SystemColors.Window;
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(209, 93);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(318, 30);
            this.nametxt.TabIndex = 4;
            // 
            // gendercmb
            // 
            this.gendercmb.BackColor = System.Drawing.SystemColors.Window;
            this.gendercmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendercmb.FormattingEnabled = true;
            this.gendercmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercmb.Location = new System.Drawing.Point(209, 147);
            this.gendercmb.Name = "gendercmb";
            this.gendercmb.Size = new System.Drawing.Size(318, 33);
            this.gendercmb.TabIndex = 5;
            // 
            // dateofbirthcl
            // 
            this.dateofbirthcl.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateofbirthcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirthcl.Location = new System.Drawing.Point(209, 203);
            this.dateofbirthcl.Name = "dateofbirthcl";
            this.dateofbirthcl.Size = new System.Drawing.Size(318, 30);
            this.dateofbirthcl.TabIndex = 6;
            // 
            // dateofdeathcl
            // 
            this.dateofdeathcl.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateofdeathcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofdeathcl.Location = new System.Drawing.Point(209, 255);
            this.dateofdeathcl.Name = "dateofdeathcl";
            this.dateofdeathcl.Size = new System.Drawing.Size(318, 30);
            this.dateofdeathcl.TabIndex = 7;
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.submitbtn.FlatAppearance.BorderSize = 0;
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(296, 307);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(130, 40);
            this.submitbtn.TabIndex = 8;
            this.submitbtn.Text = "SUBMIT";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "+ Add New Deceased";
            // 
            // add_deceased
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 383);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.dateofdeathcl);
            this.Controls.Add(this.dateofbirthcl);
            this.Controls.Add(this.gendercmb);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_deceased";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_deceased";
            this.Load += new System.EventHandler(this.add_deceased_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.ComboBox gendercmb;
        private System.Windows.Forms.DateTimePicker dateofbirthcl;
        private System.Windows.Forms.DateTimePicker dateofdeathcl;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label label5;
    }
}