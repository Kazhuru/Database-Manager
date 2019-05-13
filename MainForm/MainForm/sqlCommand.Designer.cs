namespace FileManager
{
    partial class sqlCommand
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GoInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(2, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(523, 173);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // GoInput
            // 
            this.GoInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GoInput.Location = new System.Drawing.Point(413, 181);
            this.GoInput.Name = "GoInput";
            this.GoInput.Size = new System.Drawing.Size(112, 23);
            this.GoInput.TabIndex = 1;
            this.GoInput.Text = "Enter Command";
            this.GoInput.UseVisualStyleBackColor = false;
            this.GoInput.Click += new System.EventHandler(this.GoInput_Click);
            // 
            // sqlCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(529, 206);
            this.Controls.Add(this.GoInput);
            this.Controls.Add(this.richTextBox1);
            this.Name = "sqlCommand";
            this.Text = "SQL Commands";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GoInput;
    }
}