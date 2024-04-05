namespace CemeteryManagement1
{
    partial class add_grave
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
            this.gravetypelbl = new System.Windows.Forms.Label();
            this.descriptionlbl = new System.Windows.Forms.Label();
            this.no_of_boneslbl = new System.Windows.Forms.Label();
            this.no_of_bodylbl = new System.Windows.Forms.Label();
            this.grave_occupantlbl = new System.Windows.Forms.Label();
            this.grave_typecmb = new System.Windows.Forms.ComboBox();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.no_of_bonescmb = new System.Windows.Forms.ComboBox();
            this.no_of_bodycmb = new System.Windows.Forms.ComboBox();
            this.grave_nametxt = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // gravetypelbl
            // 
            this.gravetypelbl.AutoSize = true;
            this.gravetypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravetypelbl.Location = new System.Drawing.Point(69, 89);
            this.gravetypelbl.Name = "gravetypelbl";
            this.gravetypelbl.Size = new System.Drawing.Size(113, 25);
            this.gravetypelbl.TabIndex = 0;
            this.gravetypelbl.Text = "Grave type:";
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlbl.Location = new System.Drawing.Point(69, 130);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(115, 25);
            this.descriptionlbl.TabIndex = 1;
            this.descriptionlbl.Text = "Description:";
            // 
            // no_of_boneslbl
            // 
            this.no_of_boneslbl.AutoSize = true;
            this.no_of_boneslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_boneslbl.Location = new System.Drawing.Point(69, 171);
            this.no_of_boneslbl.Name = "no_of_boneslbl";
            this.no_of_boneslbl.Size = new System.Drawing.Size(130, 25);
            this.no_of_boneslbl.TabIndex = 2;
            this.no_of_boneslbl.Text = "No. of Bones:";
            // 
            // no_of_bodylbl
            // 
            this.no_of_bodylbl.AutoSize = true;
            this.no_of_bodylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_bodylbl.Location = new System.Drawing.Point(69, 213);
            this.no_of_bodylbl.Name = "no_of_bodylbl";
            this.no_of_bodylbl.Size = new System.Drawing.Size(119, 25);
            this.no_of_bodylbl.TabIndex = 3;
            this.no_of_bodylbl.Text = "No. of Body:";
            // 
            // grave_occupantlbl
            // 
            this.grave_occupantlbl.AutoSize = true;
            this.grave_occupantlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grave_occupantlbl.Location = new System.Drawing.Point(69, 257);
            this.grave_occupantlbl.Name = "grave_occupantlbl";
            this.grave_occupantlbl.Size = new System.Drawing.Size(161, 25);
            this.grave_occupantlbl.TabIndex = 4;
            this.grave_occupantlbl.Text = "Grave Occupant:";
            // 
            // grave_typecmb
            // 
            this.grave_typecmb.BackColor = System.Drawing.SystemColors.Control;
            this.grave_typecmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grave_typecmb.FormattingEnabled = true;
            this.grave_typecmb.Location = new System.Drawing.Point(246, 86);
            this.grave_typecmb.Name = "grave_typecmb";
            this.grave_typecmb.Size = new System.Drawing.Size(227, 33);
            this.grave_typecmb.TabIndex = 5;
            this.grave_typecmb.SelectedIndexChanged += new System.EventHandler(this.grave_typecmb_SelectedIndexChanged);
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descriptiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontxt.Location = new System.Drawing.Point(246, 130);
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.ReadOnly = true;
            this.descriptiontxt.Size = new System.Drawing.Size(227, 30);
            this.descriptiontxt.TabIndex = 6;
            // 
            // no_of_bonescmb
            // 
            this.no_of_bonescmb.BackColor = System.Drawing.SystemColors.Control;
            this.no_of_bonescmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_bonescmb.FormattingEnabled = true;
            this.no_of_bonescmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.no_of_bonescmb.Location = new System.Drawing.Point(246, 171);
            this.no_of_bonescmb.Name = "no_of_bonescmb";
            this.no_of_bonescmb.Size = new System.Drawing.Size(227, 33);
            this.no_of_bonescmb.TabIndex = 7;
            // 
            // no_of_bodycmb
            // 
            this.no_of_bodycmb.BackColor = System.Drawing.SystemColors.Control;
            this.no_of_bodycmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_bodycmb.FormattingEnabled = true;
            this.no_of_bodycmb.Items.AddRange(new object[] {
            "1",
            "2"});
            this.no_of_bodycmb.Location = new System.Drawing.Point(246, 213);
            this.no_of_bodycmb.Name = "no_of_bodycmb";
            this.no_of_bodycmb.Size = new System.Drawing.Size(227, 33);
            this.no_of_bodycmb.TabIndex = 8;
            // 
            // grave_nametxt
            // 
            this.grave_nametxt.BackColor = System.Drawing.SystemColors.Control;
            this.grave_nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grave_nametxt.Location = new System.Drawing.Point(246, 257);
            this.grave_nametxt.Name = "grave_nametxt";
            this.grave_nametxt.Size = new System.Drawing.Size(227, 30);
            this.grave_nametxt.TabIndex = 9;
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
            this.submitbtn.TabIndex = 10;
            this.submitbtn.Text = "SUBMIT";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "+ Add New Grave";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // add_grave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 383);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.grave_nametxt);
            this.Controls.Add(this.no_of_bodycmb);
            this.Controls.Add(this.no_of_bonescmb);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.grave_typecmb);
            this.Controls.Add(this.grave_occupantlbl);
            this.Controls.Add(this.no_of_bodylbl);
            this.Controls.Add(this.no_of_boneslbl);
            this.Controls.Add(this.descriptionlbl);
            this.Controls.Add(this.gravetypelbl);
            this.Name = "add_grave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_grave";
            this.Load += new System.EventHandler(this.add_grave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gravetypelbl;
        private System.Windows.Forms.Label descriptionlbl;
        private System.Windows.Forms.Label no_of_boneslbl;
        private System.Windows.Forms.Label no_of_bodylbl;
        private System.Windows.Forms.Label grave_occupantlbl;
        private System.Windows.Forms.ComboBox grave_typecmb;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.ComboBox no_of_bonescmb;
        private System.Windows.Forms.ComboBox no_of_bodycmb;
        private System.Windows.Forms.TextBox grave_nametxt;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}