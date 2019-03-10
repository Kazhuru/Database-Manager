using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace FileManager
{
    public partial class Form1 : Form
    {
        //create others Windows forms 
        private NewFileForm NForm;
        private EntityWindow EntWindow;
        private AttributeWindow AttWindow;
        private DataWindow DatWindow;

        public string FileURL { get; set; }
        public List<Entity> EntityList { get; set; }
        private FileStream fs;
        public string NewWindowInput { get { return labelSelectFile.Text; } set { labelSelectFile.Text = value; } }

        /// <summary>
        /// Form1 constructor.
        /// </summary>
        public Form1()
        {
            FileURL = "";
            EntityList = new List<Entity>();
            InitializeComponent();
            //panel1.HorizontalScroll.Maximum = 0;
            //panel1.AutoScroll = false;
            //panel1.VerticalScroll.Visible = false;
            //panel1.AutoScroll = true;
        }

        /// <summary>
        /// Click event that creates a new file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuNewFile_Click(object sender, EventArgs e)
        {
            NForm = new NewFileForm(this)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            if (NForm.ShowDialog() == DialogResult.OK)
            {
                fs = new FileStream(labelSelectFile.Text, FileMode.Create);
                fs.Close();
                FileURL = labelSelectFile.Text;
            }
        }

        /// <summary>
        /// Click event that Opens an already created file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuSearchFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Binary files (*.bin)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelSelectFile.Text = openFileDialog.FileName;
                FileURL = labelSelectFile.Text;
                UpdateDictonaryGrid();
            }
        }

        /// <summary>
        /// Click event that open a new Entity Window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FileURL != "")
            {
                EntWindow = new EntityWindow(this) { StartPosition = FormStartPosition.CenterParent };
                EntWindow.ShowDialog();
                UpdateDictonaryGrid();
            }
        }

        /// <summary>
        /// Click event that open a new Attribute Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyAttributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileURL != "")
            {
                AttWindow = new AttributeWindow(this) { StartPosition = FormStartPosition.CenterParent };
                AttWindow.ShowDialog();
                UpdateDictonaryGrid();
            }
        }

        /// <summary>
        /// method that reads all the list and display it on the DataViewGrids.
        /// </summary>
        private void UpdateDictonaryGrid()
        {
            EntityGridView.Rows.Clear();
            AttribGridView.Rows.Clear();
            foreach (Entity itEnt in EntityList)
            {
                string[] rowE = new string[] {itEnt.Name};
                EntityGridView.Rows.Add(rowE);
                foreach (Attribute itAtt in itEnt.AttributeList)
                {
                    string[] rowA;
                    rowA = new string[] {itEnt.Name, itAtt.Name, itAtt.DataType,
                        itAtt.LengthDataType.ToString(), itAtt.IndexType};
                    AttribGridView.Rows.Add(rowA);
                }
            }
        }

        /// <summary>
        /// method that calls Data Window to instert the new register Data and create it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDataRegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileURL != "")
            {
                if (comboRegEntitySec.SelectedItem != null)
                {   //--- Create a Register
                    Entity SelectedEntity = EntityList.Find(query => query.Name == comboRegEntitySec.SelectedItem.ToString());
                    DatWindow = new DataWindow(this, SelectedEntity,-1)
                    { StartPosition = FormStartPosition.CenterParent };
                    DatWindow.ShowDialog();
                    UpdateRegisterGrid();
                    UpdateDictonaryGrid();
                }
            }
        }

        /// <summary>
        /// event that calls remove or modify when the properly button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FileURL != "")
            {
                if (comboRegEntitySec.SelectedItem != null)
                {
                    Entity SelectedEnt = EntityList[comboRegEntitySec.SelectedIndex];
                    int RowIdx;
                    if (e.ColumnIndex == SelectedEnt.AttributeList.Count + 2)
                    { //--- Remove a Register
                        RowIdx = e.RowIndex;
                        SelectedEnt.RemoveRegister(RowIdx);
                    }
                    if (e.ColumnIndex == SelectedEnt.AttributeList.Count + 3)
                    {   //--- Modify a Register
                        RowIdx = e.RowIndex;
                        DatWindow = new DataWindow(this, SelectedEnt, RowIdx) { StartPosition = FormStartPosition.CenterParent };
                        DatWindow.ShowDialog();
                    }
                    UpdateRegisterGrid();
                    UpdateDictonaryGrid();
                }
            }
        }

        /// <summary>
        /// method that selects a Entity to manipulate his Registers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboRegEntitySec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Entity SelectedEntity = EntityList.Find(query => query.Name == comboRegEntitySec.SelectedItem.ToString());
            RegistersGridView.Columns.Clear();
            RegistersGridView.AutoResizeColumns();
            foreach (Attribute att in SelectedEntity.AttributeList)
            {
                RegistersGridView.Columns.Add(att.Name, att.Name);
            }
            DataGridViewButtonColumn Remove = new DataGridViewButtonColumn
            {
                Name = "Remove",
                HeaderText = "Remove"
            };
            DataGridViewButtonColumn Modify = new DataGridViewButtonColumn
            {
                Name = "Modify",
                HeaderText = "Modify"
            };
            RegistersGridView.Columns.AddRange(new DataGridViewColumn[] { Remove, Modify });
            UpdateRegisterGrid();
            UpdateDictonaryGrid();
        }

        /// <summary>
        /// Update the Register Grid View
        /// </summary>
        private void UpdateRegisterGrid()
        {
            if (comboRegEntitySec.SelectedItem != null)
            {
                RegistersGridView.Rows.Clear();
                Entity SelectedEntity = EntityList[comboRegEntitySec.SelectedIndex];
                foreach (var DataItem in SelectedEntity.Data)
                {
                    string[] rowR;
                    rowR = new string[DataItem.Value.Count()];
                    for (int i = 0; i < DataItem.Value.Count(); i++)
                        rowR[i] = DataItem.Value[i];
                    RegistersGridView.Rows.Add(rowR);
                }
            }

            foreach (Entity ent in EntityList)
                comboRegEntitySec.Items.Add(ent.Name);
        }
    }
}
