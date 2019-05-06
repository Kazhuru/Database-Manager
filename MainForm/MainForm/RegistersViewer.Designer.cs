namespace FileManager
{
    partial class RegistersViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistersViewer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistersGrid = new System.Windows.Forms.GroupBox();
            this.RegistersGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.RegistersGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataToolStripMenuItem,
            this.removeDataToolStripMenuItem,
            this.modifyDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addDataToolStripMenuItem.Image")));
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.addDataToolStripMenuItem.Text = "Add Data ";
            this.addDataToolStripMenuItem.Click += new System.EventHandler(this.addDataToolStripMenuItem_Click);
            // 
            // removeDataToolStripMenuItem
            // 
            this.removeDataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeDataToolStripMenuItem.Image")));
            this.removeDataToolStripMenuItem.Name = "removeDataToolStripMenuItem";
            this.removeDataToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.removeDataToolStripMenuItem.Text = "Remove Select. Data";
            this.removeDataToolStripMenuItem.Click += new System.EventHandler(this.removeDataToolStripMenuItem_Click);
            // 
            // modifyDataToolStripMenuItem
            // 
            this.modifyDataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifyDataToolStripMenuItem.Image")));
            this.modifyDataToolStripMenuItem.Name = "modifyDataToolStripMenuItem";
            this.modifyDataToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.modifyDataToolStripMenuItem.Text = "Modify Select. Data";
            this.modifyDataToolStripMenuItem.Click += new System.EventHandler(this.modifyDataToolStripMenuItem_Click);
            // 
            // RegistersGrid
            // 
            this.RegistersGrid.Controls.Add(this.RegistersGridView);
            this.RegistersGrid.Location = new System.Drawing.Point(0, 27);
            this.RegistersGrid.Name = "RegistersGrid";
            this.RegistersGrid.Size = new System.Drawing.Size(892, 388);
            this.RegistersGrid.TabIndex = 10;
            this.RegistersGrid.TabStop = false;
            this.RegistersGrid.Text = "Data Registers Grid";
            // 
            // RegistersGridView
            // 
            this.RegistersGridView.AllowUserToAddRows = false;
            this.RegistersGridView.AllowUserToDeleteRows = false;
            this.RegistersGridView.AllowUserToResizeColumns = false;
            this.RegistersGridView.AllowUserToResizeRows = false;
            this.RegistersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RegistersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RegistersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.RegistersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistersGridView.Location = new System.Drawing.Point(6, 19);
            this.RegistersGridView.MultiSelect = false;
            this.RegistersGridView.Name = "RegistersGridView";
            this.RegistersGridView.ReadOnly = true;
            this.RegistersGridView.RowHeadersVisible = false;
            this.RegistersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RegistersGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RegistersGridView.Size = new System.Drawing.Size(880, 363);
            this.RegistersGridView.TabIndex = 11;
            this.RegistersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistersGridView_CellClick);
            // 
            // RegistersViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(892, 413);
            this.Controls.Add(this.RegistersGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistersViewer";
            this.Text = "Registers Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RegistersGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegistersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyDataToolStripMenuItem;
        private System.Windows.Forms.GroupBox RegistersGrid;
        private System.Windows.Forms.DataGridView RegistersGridView;
    }
}