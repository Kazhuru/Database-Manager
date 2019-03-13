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
            this.AttributeBox = new System.Windows.Forms.GroupBox();
            this.MakeAttrib = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateIndexTBox = new System.Windows.Forms.ComboBox();
            this.CreateLenghtBox = new System.Windows.Forms.TextBox();
            this.CreateTypeBox = new System.Windows.Forms.ComboBox();
            this.CreateNameBox = new System.Windows.Forms.TextBox();
            this.DeleteAttrib = new System.Windows.Forms.Button();
            this.ModifyAttrib = new System.Windows.Forms.Button();
            this.DeleteSeletBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ModifySelectBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ModifyIndexTBox = new System.Windows.Forms.ComboBox();
            this.ModifyLenghtBox = new System.Windows.Forms.TextBox();
            this.ModifyTypeBox = new System.Windows.Forms.ComboBox();
            this.ModifyNameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectEntityBox = new System.Windows.Forms.ComboBox();
            this.AttributeBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttributeBox
            // 
            this.AttributeBox.Controls.Add(this.MakeAttrib);
            this.AttributeBox.Controls.Add(this.label7);
            this.AttributeBox.Controls.Add(this.label6);
            this.AttributeBox.Controls.Add(this.label5);
            this.AttributeBox.Controls.Add(this.label4);
            this.AttributeBox.Controls.Add(this.CreateIndexTBox);
            this.AttributeBox.Controls.Add(this.CreateLenghtBox);
            this.AttributeBox.Controls.Add(this.CreateTypeBox);
            this.AttributeBox.Controls.Add(this.CreateNameBox);
            this.AttributeBox.Location = new System.Drawing.Point(13, 31);
            this.AttributeBox.Name = "AttributeBox";
            this.AttributeBox.Size = new System.Drawing.Size(458, 103);
            this.AttributeBox.TabIndex = 8;
            this.AttributeBox.TabStop = false;
            this.AttributeBox.Text = "Create Attribute";
            // 
            // MakeAttrib
            // 
            this.MakeAttrib.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MakeAttrib.Location = new System.Drawing.Point(356, 73);
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
            this.label7.Location = new System.Drawing.Point(315, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Index Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lenght";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // CreateIndexTBox
            // 
            this.CreateIndexTBox.FormattingEnabled = true;
            this.CreateIndexTBox.Location = new System.Drawing.Point(318, 47);
            this.CreateIndexTBox.Name = "CreateIndexTBox";
            this.CreateIndexTBox.Size = new System.Drawing.Size(116, 21);
            this.CreateIndexTBox.TabIndex = 3;
            // 
            // CreateLenghtBox
            // 
            this.CreateLenghtBox.Location = new System.Drawing.Point(252, 46);
            this.CreateLenghtBox.Name = "CreateLenghtBox";
            this.CreateLenghtBox.Size = new System.Drawing.Size(60, 20);
            this.CreateLenghtBox.TabIndex = 2;
            // 
            // CreateTypeBox
            // 
            this.CreateTypeBox.FormattingEnabled = true;
            this.CreateTypeBox.Location = new System.Drawing.Point(163, 46);
            this.CreateTypeBox.Name = "CreateTypeBox";
            this.CreateTypeBox.Size = new System.Drawing.Size(83, 21);
            this.CreateTypeBox.TabIndex = 1;
            this.CreateTypeBox.SelectionChangeCommitted += new System.EventHandler(this.CreateTypeBox_SelectionChangeCommitted);
            // 
            // CreateNameBox
            // 
            this.CreateNameBox.Location = new System.Drawing.Point(6, 46);
            this.CreateNameBox.Name = "CreateNameBox";
            this.CreateNameBox.Size = new System.Drawing.Size(151, 20);
            this.CreateNameBox.TabIndex = 0;
            // 
            // DeleteAttrib
            // 
            this.DeleteAttrib.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteAttrib.Location = new System.Drawing.Point(358, 50);
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
            this.ModifyAttrib.Location = new System.Drawing.Point(356, 111);
            this.ModifyAttrib.Name = "ModifyAttrib";
            this.ModifyAttrib.Size = new System.Drawing.Size(94, 23);
            this.ModifyAttrib.TabIndex = 11;
            this.ModifyAttrib.Text = "Modify Attribute";
            this.ModifyAttrib.UseVisualStyleBackColor = false;
            this.ModifyAttrib.Click += new System.EventHandler(this.ModifyAttrib_Click);
            // 
            // DeleteSeletBox
            // 
            this.DeleteSeletBox.FormattingEnabled = true;
            this.DeleteSeletBox.Location = new System.Drawing.Point(10, 46);
            this.DeleteSeletBox.Name = "DeleteSeletBox";
            this.DeleteSeletBox.Size = new System.Drawing.Size(136, 21);
            this.DeleteSeletBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Select Attribute";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DeleteSeletBox);
            this.groupBox1.Controls.Add(this.DeleteAttrib);
            this.groupBox1.Location = new System.Drawing.Point(13, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 80);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Attribute";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ModifySelectBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ModifyIndexTBox);
            this.groupBox2.Controls.Add(this.ModifyLenghtBox);
            this.groupBox2.Controls.Add(this.ModifyTypeBox);
            this.groupBox2.Controls.Add(this.ModifyNameBox);
            this.groupBox2.Controls.Add(this.ModifyAttrib);
            this.groupBox2.Location = new System.Drawing.Point(13, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 140);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify Attribute";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Select Attribute";
            // 
            // ModifySelectBox
            // 
            this.ModifySelectBox.FormattingEnabled = true;
            this.ModifySelectBox.Location = new System.Drawing.Point(9, 44);
            this.ModifySelectBox.Name = "ModifySelectBox";
            this.ModifySelectBox.Size = new System.Drawing.Size(136, 21);
            this.ModifySelectBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Index Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lenght";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Name";
            // 
            // ModifyIndexTBox
            // 
            this.ModifyIndexTBox.FormattingEnabled = true;
            this.ModifyIndexTBox.Location = new System.Drawing.Point(334, 85);
            this.ModifyIndexTBox.Name = "ModifyIndexTBox";
            this.ModifyIndexTBox.Size = new System.Drawing.Size(116, 21);
            this.ModifyIndexTBox.TabIndex = 15;
            // 
            // ModifyLenghtBox
            // 
            this.ModifyLenghtBox.Location = new System.Drawing.Point(264, 87);
            this.ModifyLenghtBox.Name = "ModifyLenghtBox";
            this.ModifyLenghtBox.Size = new System.Drawing.Size(60, 20);
            this.ModifyLenghtBox.TabIndex = 14;
            // 
            // ModifyTypeBox
            // 
            this.ModifyTypeBox.FormattingEnabled = true;
            this.ModifyTypeBox.Location = new System.Drawing.Point(167, 86);
            this.ModifyTypeBox.Name = "ModifyTypeBox";
            this.ModifyTypeBox.Size = new System.Drawing.Size(83, 21);
            this.ModifyTypeBox.TabIndex = 13;
            this.ModifyTypeBox.SelectedIndexChanged += new System.EventHandler(this.ModifyTypeBox_SelectedIndexChanged);
            // 
            // ModifyNameBox
            // 
            this.ModifyNameBox.Location = new System.Drawing.Point(10, 86);
            this.ModifyNameBox.Name = "ModifyNameBox";
            this.ModifyNameBox.Size = new System.Drawing.Size(151, 20);
            this.ModifyNameBox.TabIndex = 12;
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
            // AttributeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(478, 378);
            this.Controls.Add(this.SelectEntityBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AttributeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttributeWindow";
            this.Text = "Attribute Window";
            this.AttributeBox.ResumeLayout(false);
            this.AttributeBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AttributeBox;
        private System.Windows.Forms.Button DeleteAttrib;
        private System.Windows.Forms.Button ModifyAttrib;
        private System.Windows.Forms.ComboBox DeleteSeletBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button MakeAttrib;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CreateIndexTBox;
        private System.Windows.Forms.TextBox CreateLenghtBox;
        private System.Windows.Forms.ComboBox CreateTypeBox;
        private System.Windows.Forms.TextBox CreateNameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ModifySelectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ModifyIndexTBox;
        private System.Windows.Forms.TextBox ModifyLenghtBox;
        private System.Windows.Forms.ComboBox ModifyTypeBox;
        private System.Windows.Forms.TextBox ModifyNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox SelectEntityBox;
    }
}