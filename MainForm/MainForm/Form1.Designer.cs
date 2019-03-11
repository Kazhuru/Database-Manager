namespace FileManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelectFile = new System.Windows.Forms.Label();
            this.DictionaryGrid = new System.Windows.Forms.GroupBox();
            this.AttribGridView = new System.Windows.Forms.DataGridView();
            this.AttEntName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttDataLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttIndexType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityGridView = new System.Windows.Forms.DataGridView();
            this.EntName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistersGrid = new System.Windows.Forms.GroupBox();
            this.RegistersGridView = new System.Windows.Forms.DataGridView();
            this.comboRegEntitySec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataRegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.DictionaryGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttribGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntityGridView)).BeginInit();
            this.RegistersGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(93, 26);
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.asdToolStripMenuItem.Text = "asd";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.addDataRegToolStripMenuItem,
            this.CreateToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1273, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected File:";
            // 
            // labelSelectFile
            // 
            this.labelSelectFile.AutoSize = true;
            this.labelSelectFile.Location = new System.Drawing.Point(89, 34);
            this.labelSelectFile.Name = "labelSelectFile";
            this.labelSelectFile.Size = new System.Drawing.Size(16, 13);
            this.labelSelectFile.TabIndex = 6;
            this.labelSelectFile.Text = "...";
            // 
            // DictionaryGrid
            // 
            this.DictionaryGrid.Controls.Add(this.AttribGridView);
            this.DictionaryGrid.Controls.Add(this.EntityGridView);
            this.DictionaryGrid.Location = new System.Drawing.Point(0, 55);
            this.DictionaryGrid.Name = "DictionaryGrid";
            this.DictionaryGrid.Size = new System.Drawing.Size(628, 464);
            this.DictionaryGrid.TabIndex = 8;
            this.DictionaryGrid.TabStop = false;
            this.DictionaryGrid.Text = "Data Dictionary Grid";
            // 
            // AttribGridView
            // 
            this.AttribGridView.AllowUserToAddRows = false;
            this.AttribGridView.AllowUserToDeleteRows = false;
            this.AttribGridView.AllowUserToResizeColumns = false;
            this.AttribGridView.AllowUserToResizeRows = false;
            this.AttribGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.AttribGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttribGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttEntName,
            this.AttName,
            this.AttDataType,
            this.AttDataLenght,
            this.AttIndexType});
            this.AttribGridView.Location = new System.Drawing.Point(118, 19);
            this.AttribGridView.MultiSelect = false;
            this.AttribGridView.Name = "AttribGridView";
            this.AttribGridView.ReadOnly = true;
            this.AttribGridView.RowHeadersVisible = false;
            this.AttribGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AttribGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AttribGridView.Size = new System.Drawing.Size(499, 435);
            this.AttribGridView.TabIndex = 9;
            // 
            // AttEntName
            // 
            this.AttEntName.HeaderText = "Entity Owner";
            this.AttEntName.Name = "AttEntName";
            this.AttEntName.ReadOnly = true;
            // 
            // AttName
            // 
            this.AttName.HeaderText = "Attrib Name";
            this.AttName.Name = "AttName";
            this.AttName.ReadOnly = true;
            this.AttName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AttDataType
            // 
            this.AttDataType.HeaderText = "Data Type";
            this.AttDataType.Name = "AttDataType";
            this.AttDataType.ReadOnly = true;
            // 
            // AttDataLenght
            // 
            this.AttDataLenght.HeaderText = "Data Lenght";
            this.AttDataLenght.Name = "AttDataLenght";
            this.AttDataLenght.ReadOnly = true;
            // 
            // AttIndexType
            // 
            this.AttIndexType.HeaderText = "Index Type";
            this.AttIndexType.Name = "AttIndexType";
            this.AttIndexType.ReadOnly = true;
            // 
            // EntityGridView
            // 
            this.EntityGridView.AllowUserToAddRows = false;
            this.EntityGridView.AllowUserToDeleteRows = false;
            this.EntityGridView.AllowUserToResizeColumns = false;
            this.EntityGridView.AllowUserToResizeRows = false;
            this.EntityGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.EntityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntName});
            this.EntityGridView.Location = new System.Drawing.Point(6, 19);
            this.EntityGridView.MultiSelect = false;
            this.EntityGridView.Name = "EntityGridView";
            this.EntityGridView.ReadOnly = true;
            this.EntityGridView.RowHeadersVisible = false;
            this.EntityGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EntityGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EntityGridView.Size = new System.Drawing.Size(103, 435);
            this.EntityGridView.TabIndex = 8;
            // 
            // EntName
            // 
            this.EntName.HeaderText = "Entity Name";
            this.EntName.Name = "EntName";
            this.EntName.ReadOnly = true;
            this.EntName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RegistersGrid
            // 
            this.RegistersGrid.Controls.Add(this.RegistersGridView);
            this.RegistersGrid.Location = new System.Drawing.Point(634, 55);
            this.RegistersGrid.Name = "RegistersGrid";
            this.RegistersGrid.Size = new System.Drawing.Size(631, 464);
            this.RegistersGrid.TabIndex = 9;
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
            this.RegistersGridView.BackgroundColor = System.Drawing.Color.Thistle;
            this.RegistersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistersGridView.Location = new System.Drawing.Point(6, 19);
            this.RegistersGridView.MultiSelect = false;
            this.RegistersGridView.Name = "RegistersGridView";
            this.RegistersGridView.ReadOnly = true;
            this.RegistersGridView.RowHeadersVisible = false;
            this.RegistersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RegistersGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RegistersGridView.Size = new System.Drawing.Size(615, 436);
            this.RegistersGridView.TabIndex = 11;
            this.RegistersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistersGridView_CellContentClick);
            // 
            // comboRegEntitySec
            // 
            this.comboRegEntitySec.FormattingEnabled = true;
            this.comboRegEntitySec.Location = new System.Drawing.Point(933, 36);
            this.comboRegEntitySec.Name = "comboRegEntitySec";
            this.comboRegEntitySec.Size = new System.Drawing.Size(136, 21);
            this.comboRegEntitySec.TabIndex = 10;
            this.comboRegEntitySec.SelectionChangeCommitted += new System.EventHandler(this.ComboRegEntitySec_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entity Select";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewFile,
            this.MenuSearchFile});
            this.openFileToolStripMenuItem.Image = global::FileManager.Properties.Resources.if_folder_open_o_1608381;
            this.openFileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // MenuNewFile
            // 
            this.MenuNewFile.Name = "MenuNewFile";
            this.MenuNewFile.ShowShortcutKeys = false;
            this.MenuNewFile.Size = new System.Drawing.Size(130, 22);
            this.MenuNewFile.Text = "New File";
            this.MenuNewFile.Click += new System.EventHandler(this.MenuNewFile_Click);
            // 
            // MenuSearchFile
            // 
            this.MenuSearchFile.Name = "MenuSearchFile";
            this.MenuSearchFile.Size = new System.Drawing.Size(130, 22);
            this.MenuSearchFile.Text = "Search File";
            this.MenuSearchFile.Click += new System.EventHandler(this.MenuSearchFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveToolStripMenuItem.Image = global::FileManager.Properties.Resources.iconfinder_save_2561379;
            this.saveToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // addDataRegToolStripMenuItem
            // 
            this.addDataRegToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addDataRegToolStripMenuItem.Image = global::FileManager.Properties.Resources.if_data_115746;
            this.addDataRegToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.addDataRegToolStripMenuItem.Name = "addDataRegToolStripMenuItem";
            this.addDataRegToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.addDataRegToolStripMenuItem.Text = "Add Data";
            this.addDataRegToolStripMenuItem.Click += new System.EventHandler(this.AddDataRegToolStripMenuItem_Click);
            // 
            // CreateToolStripMenuItem1
            // 
            this.CreateToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyEntityToolStripMenuItem,
            this.modifyAttributeToolStripMenuItem});
            this.CreateToolStripMenuItem1.Image = global::FileManager.Properties.Resources.if_create_new_2639799;
            this.CreateToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(3);
            this.CreateToolStripMenuItem1.Name = "CreateToolStripMenuItem1";
            this.CreateToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.CreateToolStripMenuItem1.Text = "New Item";
            // 
            // modifyEntityToolStripMenuItem
            // 
            this.modifyEntityToolStripMenuItem.Name = "modifyEntityToolStripMenuItem";
            this.modifyEntityToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.modifyEntityToolStripMenuItem.Text = "Entity\'s Window";
            this.modifyEntityToolStripMenuItem.Click += new System.EventHandler(this.ModifyEntityToolStripMenuItem_Click);
            // 
            // modifyAttributeToolStripMenuItem
            // 
            this.modifyAttributeToolStripMenuItem.Name = "modifyAttributeToolStripMenuItem";
            this.modifyAttributeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.modifyAttributeToolStripMenuItem.Text = "Attribute\'s Window";
            this.modifyAttributeToolStripMenuItem.Click += new System.EventHandler(this.ModifyAttributeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1273, 531);
            this.Controls.Add(this.comboRegEntitySec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DictionaryGrid);
            this.Controls.Add(this.RegistersGrid);
            this.Controls.Add(this.labelSelectFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File Manager";
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DictionaryGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttribGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntityGridView)).EndInit();
            this.RegistersGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegistersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchFile;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSelectFile;
        private System.Windows.Forms.ToolStripMenuItem modifyAttributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyEntityToolStripMenuItem;
        private System.Windows.Forms.GroupBox DictionaryGrid;
        private System.Windows.Forms.DataGridView EntityGridView;
        private System.Windows.Forms.ToolStripMenuItem MenuNewFile;
        private System.Windows.Forms.DataGridView AttribGridView;
        private System.Windows.Forms.GroupBox RegistersGrid;
        private System.Windows.Forms.ComboBox comboRegEntitySec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RegistersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttEntName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttDataLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttIndexType;
        private System.Windows.Forms.ToolStripMenuItem addDataRegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

