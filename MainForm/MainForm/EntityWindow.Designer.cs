namespace FileManager
{
    partial class EntityWindow
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
            this.EntityBox = new System.Windows.Forms.GroupBox();
            this.CreateEnt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateNameBox = new System.Windows.Forms.TextBox();
            this.DeleteEnt = new System.Windows.Forms.Button();
            this.ModifyEnt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteSelectBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ModifyNameBox = new System.Windows.Forms.TextBox();
            this.ModifySelectBox = new System.Windows.Forms.ComboBox();
            this.EntityBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntityBox
            // 
            this.EntityBox.Controls.Add(this.CreateEnt);
            this.EntityBox.Controls.Add(this.label3);
            this.EntityBox.Controls.Add(this.CreateNameBox);
            this.EntityBox.Location = new System.Drawing.Point(12, 11);
            this.EntityBox.Name = "EntityBox";
            this.EntityBox.Size = new System.Drawing.Size(418, 77);
            this.EntityBox.TabIndex = 2;
            this.EntityBox.TabStop = false;
            this.EntityBox.Text = "Create Entity";
            // 
            // CreateEntity
            // 
            this.CreateEnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateEnt.Location = new System.Drawing.Point(337, 48);
            this.CreateEnt.Name = "CreateEntity";
            this.CreateEnt.Size = new System.Drawing.Size(75, 23);
            this.CreateEnt.TabIndex = 5;
            this.CreateEnt.Text = "Create Entity";
            this.CreateEnt.UseVisualStyleBackColor = false;
            this.CreateEnt.Click += new System.EventHandler(this.CreateEnt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // CreateNameBox
            // 
            this.CreateNameBox.Location = new System.Drawing.Point(9, 37);
            this.CreateNameBox.Name = "CreateNameBox";
            this.CreateNameBox.Size = new System.Drawing.Size(139, 20);
            this.CreateNameBox.TabIndex = 1;
            // 
            // DeleteEntity
            // 
            this.DeleteEnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteEnt.Location = new System.Drawing.Point(337, 48);
            this.DeleteEnt.Name = "DeleteEntity";
            this.DeleteEnt.Size = new System.Drawing.Size(75, 23);
            this.DeleteEnt.TabIndex = 6;
            this.DeleteEnt.Text = "Delete Entity";
            this.DeleteEnt.UseVisualStyleBackColor = false;
            this.DeleteEnt.Click += new System.EventHandler(this.DeleteEnt_Click);
            // 
            // ModifyEnt
            // 
            this.ModifyEnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ModifyEnt.Location = new System.Drawing.Point(337, 48);
            this.ModifyEnt.Name = "ModifyEnt";
            this.ModifyEnt.Size = new System.Drawing.Size(75, 23);
            this.ModifyEnt.TabIndex = 4;
            this.ModifyEnt.Text = "Modify Entity";
            this.ModifyEnt.UseVisualStyleBackColor = false;
            this.ModifyEnt.Click += new System.EventHandler(this.ModifyEnt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteEnt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DeleteSelectBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Entity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Entity";
            // 
            // DeleteSelectBox
            // 
            this.DeleteSelectBox.FormattingEnabled = true;
            this.DeleteSelectBox.Location = new System.Drawing.Point(9, 39);
            this.DeleteSelectBox.Name = "DeleteSelectBox";
            this.DeleteSelectBox.Size = new System.Drawing.Size(139, 21);
            this.DeleteSelectBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ModifyEnt);
            this.groupBox2.Controls.Add(this.ModifyNameBox);
            this.groupBox2.Controls.Add(this.ModifySelectBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 77);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify Entity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Select Entity";
            // 
            // ModifyNameBox
            // 
            this.ModifyNameBox.Location = new System.Drawing.Point(171, 39);
            this.ModifyNameBox.Name = "ModifyNameBox";
            this.ModifyNameBox.Size = new System.Drawing.Size(139, 20);
            this.ModifyNameBox.TabIndex = 1;
            // 
            // ModifySelectBox
            // 
            this.ModifySelectBox.FormattingEnabled = true;
            this.ModifySelectBox.Location = new System.Drawing.Point(9, 38);
            this.ModifySelectBox.Name = "ModifySelectBox";
            this.ModifySelectBox.Size = new System.Drawing.Size(139, 21);
            this.ModifySelectBox.TabIndex = 0;
            // 
            // EntityWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(437, 266);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EntityBox);
            this.Name = "EntityWindow";
            this.Text = "Entity Window";
            this.EntityBox.ResumeLayout(false);
            this.EntityBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EntityBox;
        private System.Windows.Forms.Button DeleteEnt;
        private System.Windows.Forms.Button CreateEnt;
        private System.Windows.Forms.Button ModifyEnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreateNameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DeleteSelectBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ModifyNameBox;
        private System.Windows.Forms.ComboBox ModifySelectBox;
    }
}