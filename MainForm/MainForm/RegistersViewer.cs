using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class RegistersViewer : Form
    {
        private Form1 MainForm = null;
        private DataWindow DatWindow;
        public Entity currentEntity;
        private int currentRowIndex;

        /// <summary>
        /// Generic constructor 
        /// </summary>
        /// <param name="callingForm"></param>
        /// <param name="currentEnt"></param>
        public RegistersViewer(Form callingForm, Entity currentEnt)
        {
            MainForm = callingForm as Form1; 
            InitializeComponent();

            currentEntity = currentEnt;
            currentRowIndex = -1;
            InitGridView();
        }

        /// <summary>
        /// method that inits the GridView columns and headers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitGridView()
        {
            RegistersGridView.Columns.Clear();
            RegistersGridView.AutoResizeColumns();
            foreach (Attribute attIterator in currentEntity.AttributeList)
            {
                RegistersGridView.Columns.Add(attIterator.Name, attIterator.Name);
            }
            UpdateRegisterGrid();
        }

        /// <summary>
        /// Update the Register Grid View
        /// </summary>
        private void UpdateRegisterGrid()
        {
            RegistersGridView.Rows.Clear();
            foreach (var DataItem in currentEntity.Registers)
            {
                string[] rowR;
                rowR = new string[DataItem.RegisterData.Count()];
                for (int i = 0; i < DataItem.RegisterData.Count(); i++)
                    rowR[i] = DataItem.RegisterData[i];
                RegistersGridView.Rows.Add(rowR);
            }
        }

        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--- Create a Register ---
            DatWindow = new DataWindow(MainForm, currentEntity, -1)
            { StartPosition = FormStartPosition.CenterParent };
            DatWindow.ShowDialog();
            UpdateRegisterGrid(); 
        }

        private void removeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--- Remove a Register ---
            if(currentRowIndex >= 0)
            {
                currentEntity.RemoveRegister(currentRowIndex);
                currentRowIndex--;
                UpdateRegisterGrid();
            }
        }

        private void modifyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--- Modify a Register ---
            if (currentRowIndex >= 0)
            {
                DatWindow = new DataWindow(MainForm, currentEntity, currentRowIndex) { StartPosition = FormStartPosition.CenterParent };
                DatWindow.ShowDialog();
                UpdateRegisterGrid();
            }
        }

        private void RegistersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRowIndex = e.RowIndex;
        }
    }
}
