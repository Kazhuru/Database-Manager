namespace FileManager
{
    partial class AttributeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttributeWindow));
            this.MakeAttrib = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IndexTBox = new System.Windows.Forms.ComboBox();
            this.LenghtBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DeleteAttrib = new System.Windows.Forms.Button();
            this.ModifyAttrib = new System.Windows.Forms.Button();
            this.SelectAtributeBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectEntityBox = new System.Windows.Forms.ComboBox();
            this.Descriptionlbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PKSearchBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeAttrib
            // 
            this.MakeAttrib.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MakeAttrib.Location = new System.Drawing.Point(77, 56);
            this.MakeAttrib.Name = "MakeAttrib";
            this.MakeAttrib.Size = new System.Drawing.Size(94, 23);
            this.MakeAttrib.TabIndex = 8;
            this.MakeAttrib.Text = "Create Attribute";
            this.MakeAttrib.UseVisualStyleBackColor = false;
            this.MakeAttrib.Click += new System.EventHandler(this.MakeAttrib_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Index Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lenght";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // IndexTBox
            // 
            this.IndexTBox.FormattingEnabled = true;
            this.IndexTBox.Location = new System.Drawing.Point(347, 52);
            this.IndexTBox.Name = "IndexTBox";
            this.IndexTBox.Size = new System.Drawing.Size(116, 21);
            this.IndexTBox.TabIndex = 3;
            this.IndexTBox.SelectedIndexChanged += new System.EventHandler(this.IndexTBox_SelectedIndexChanged);
            // 
            // LenghtBox
            // 
            this.LenghtBox.Location = new System.Drawing.Point(277, 52);
            this.LenghtBox.Name = "LenghtBox";
            this.LenghtBox.Size = new System.Drawing.Size(60, 20);
            this.LenghtBox.TabIndex = 2;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(180, 51);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(83, 21);
            this.TypeBox.TabIndex = 1;
            this.TypeBox.SelectionChangeCommitted += new System.EventHandler(this.CreateTypeBox_SelectionChangeCommitted);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(23, 51);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(151, 20);
            this.NameBox.TabIndex = 0;
            // 
            // DeleteAttrib
            // 
            this.DeleteAttrib.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteAttrib.Location = new System.Drawing.Point(277, 56);
            this.DeleteAttrib.Name = "DeleteAttrib";
            this.DeleteAttrib.Size = new System.Drawing.Size(94, 23);
            this.DeleteAttrib.TabIndex = 12;
            this.DeleteAttrib.Text = "Delete Attribute";
            this.DeleteAttrib.UseVisualStyleBackColor = false;
            this.DeleteAttrib.Click += new System.EventHandler(this.DeleteAttrib_Click);
            // 
            // ModifyAttrib
            // 
            this.ModifyAttrib.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ModifyAttrib.Location = new System.Drawing.Point(177, 56);
            this.ModifyAttrib.Name = "ModifyAttrib";
            this.ModifyAttrib.Size = new System.Drawing.Size(94, 23);
            this.ModifyAttrib.TabIndex = 11;
            this.ModifyAttrib.Text = "Modify Attribute";
            this.ModifyAttrib.UseVisualStyleBackColor = false;
            this.ModifyAttrib.Click += new System.EventHandler(this.ModifyAttrib_Click);
            // 
            // SelectAtributeBox
            // 
            this.SelectAtributeBox.FormattingEnabled = true;
            this.SelectAtributeBox.Location = new System.Drawing.Point(177, 29);
            this.SelectAtributeBox.Name = "SelectAtributeBox";
            this.SelectAtributeBox.Size = new System.Drawing.Size(194, 21);
            this.SelectAtributeBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Select Entity";
            // 
            // SelectEntityBox
            // 
            this.SelectEntityBox.FormattingEnabled = true;
            this.SelectEntityBox.Location = new System.Drawing.Point(226, 6);
            this.SelectEntityBox.Name = "SelectEntityBox";
            this.SelectEntityBox.Size = new System.Drawing.Size(136, 21);
            this.SelectEntityBox.TabIndex = 11;
            this.SelectEntityBox.SelectionChangeCommitted += new System.EventHandler(this.SelectEntityBox_SelectionChangeCommitted);
            // 
            // Descriptionlbl
            // 
            this.Descriptionlbl.AutoSize = true;
            this.Descriptionlbl.Location = new System.Drawing.Point(20, 74);
            this.Descriptionlbl.Name = "Descriptionlbl";
            this.Descriptionlbl.Size = new System.Drawing.Size(60, 13);
            this.Descriptionlbl.TabIndex = 15;
            this.Descriptionlbl.Text = "Description";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "P.K. Search";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(22, 93);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(315, 62);
            this.DescriptionBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Select Attribute";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModifyAttrib);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DeleteAttrib);
            this.groupBox1.Controls.Add(this.SelectAtributeBox);
            this.groupBox1.Controls.Add(this.MakeAttrib);
            this.groupBox1.Location = new System.Drawing.Point(9, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 90);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // PKSearchBox
            // 
            this.PKSearchBox.Location = new System.Drawing.Point(347, 103);
            this.PKSearchBox.Name = "PKSearchBox";
            this.PKSearchBox.Size = new System.Drawing.Size(116, 20);
            this.PKSearchBox.TabIndex = 19;
            // 
            // AttributeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(478, 259);
            this.Controls.Add(this.PKSearchBox);
            this.Controls.Add(this.Descriptionlbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.IndexTBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SelectEntityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LenghtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttributeWindow";
            this.Text = "Attribute Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteAttrib;
        private System.Windows.Forms.Button ModifyAttrib;
        private System.Windows.Forms.Button MakeAttrib;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IndexTBox;
        private System.Windows.Forms.TextBox LenghtBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox SelectAtributeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox SelectEntityBox;
        private System.Windows.Forms.Label Descriptionlbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PKSearchBox;
    }
}