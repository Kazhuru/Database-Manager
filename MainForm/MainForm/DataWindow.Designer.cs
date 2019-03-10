namespace FileManager
{
    partial class DataWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataWindow));
            this.CreateDR = new System.Windows.Forms.Button();
            this.createPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CreateDR
            // 
            this.CreateDR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateDR.Location = new System.Drawing.Point(386, 122);
            this.CreateDR.Name = "CreateDR";
            this.CreateDR.Size = new System.Drawing.Size(109, 23);
            this.CreateDR.TabIndex = 9;
            this.CreateDR.Text = "Create / Modify";
            this.CreateDR.UseVisualStyleBackColor = false;
            this.CreateDR.Click += new System.EventHandler(this.CreateDR_Click);
            // 
            // createPanel
            // 
            this.createPanel.AutoScroll = true;
            this.createPanel.Location = new System.Drawing.Point(12, 5);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(368, 149);
            this.createPanel.TabIndex = 1;
            // 
            // DataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(500, 157);
            this.Controls.Add(this.CreateDR);
            this.Controls.Add(this.createPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataWindow";
            this.Text = "DataWindow";
            this.Load += new System.EventHandler(this.DataWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Button CreateDR;
    }
}