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
        private bool isOpenBySQL;

        /// <summary>
        /// Generic constructor 
        /// </summary>
        /// <param name="callingForm"></param>
        /// <param name="currentEnt"></param>
        public RegistersViewer(Form callingForm, Entity currentEnt,bool isSQL)
        {
            MainForm = callingForm as Form1; 
            InitializeComponent();
            currentEntity = currentEnt;
            currentRowIndex = -1;
            InitGridView();
            isOpenBySQL = isSQL;
            addDataToolStripMenuItem.Enabled = !isSQL;
            modifyDataToolStripMenuItem.Enabled = !isSQL;
            removeDataToolStripMenuItem.Enabled = !isSQL;
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

            if(isOpenBySQL == false)
            {
                foreach (Attribute attIterator in currentEntity.AttributeList)
                {
                    RegistersGridView.Columns.Add(attIterator.Name, attIterator.Name);
                }
                UpdateRegisterGrid();
            }
            else
            {
                //TODO checar SQL, generar cambios
                List<int> idxSelect = new List<int>();
                foreach (Attribute attIterator in currentEntity.AttributeList)
                {
                    if(MainForm.SELECT.First() == "*")
                    {
                        RegistersGridView.Columns.Add(attIterator.Name, attIterator.Name);
                    }
                    else
                    {
                        int idx = MainForm.SELECT.FindIndex(pred => pred == attIterator.Name);
                        if(idx >= 0)
                        {
                            idxSelect.Add(idx);
                            RegistersGridView.Columns.Add(attIterator.Name, attIterator.Name);
                        }
                    }
                }
                UpdateRegisterGrid(idxSelect);
            }
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
        private void UpdateRegisterGrid(List<int> idxSelect)
        {
            RegistersGridView.Rows.Clear();
            foreach (var DataItem in currentEntity.Registers)
            {
                
                
                if (MainForm.WHERE.Count > 0)
                {   //WHERE contains elements
                    bool WhereCondition = true;

                    int index = currentEntity.AttributeList.FindIndex(pred => pred.Name == MainForm.WHERE.First());
                    if (index >= 0)
                    {
                        WhereCondition = DoOperation(MainForm.WHERE[1], DataItem.RegisterData[index], MainForm.WHERE.Last());
                    }
                    else
                    {
                        index = currentEntity.AttributeList.FindIndex(pred => pred.Name == MainForm.WHERE.Last());
                        if (index >= 0)
                        {
                            WhereCondition = DoOperation(MainForm.WHERE[1], DataItem.RegisterData[index], MainForm.WHERE.First());
                        }
                        else
                            WhereCondition = false;
                    }
                    if(WhereCondition)
                    {
                        //imprimir
                        string[] rowR;
                        rowR = new string[idxSelect.Count()];
                        for (int i = 0; i < idxSelect.Count; i++)
                            rowR[i] = idxSelect[i].ToString();
                        RegistersGridView.Rows.Add(rowR);
                    }

                }
                else
                {// no WHERE
                    //imprimir
                    string[] rowR;
                    rowR = new string[idxSelect.Count()];
                    for (int i = 0; i < idxSelect.Count; i++)
                        rowR[i] = idxSelect[i].ToString();
                    RegistersGridView.Rows.Add(rowR);
                }
            }
        }

        private bool DoOperation(string operation, dynamic var1, dynamic var2)
        {
            switch(operation)
            {
                case "==":
                    return (var1 == var2);
                case ">=":
                    return (var1 >= var2);
                case ">":
                    return (var1 > var2);
                case "<=":
                    return (var1 <= var2);
                case "<":
                    return (var1 < var2);
                case "<>":
                    return (var1 != var2);      
            }
            return false;
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
