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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace FileManager
{
    public partial class Form1 : Form
    {
        //create others Windows forms 
        private NewFileForm NForm;
        private EntityWindow EntWindow;
        private AttributeWindow AttWindow;
        private RegistersViewer RegViewer;
        private sqlCommand commsConsole;

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
            {   //finded a OK file
                labelSelectFile.Text = openFileDialog.FileName;
                FileURL = labelSelectFile.Text;
                //read the stuff from the file
                RestoreFileToManager();
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
                        itAtt.LengthDataType.ToString(), itAtt.IndexType, itAtt.Description};
                    AttribGridView.Rows.Add(rowA);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FileURL != "")
            {
                string SerialOutput = SerialTool.Serialize(EntityList);
                File.WriteAllText(FileURL, SerialOutput);
            }
        }

        private void RestoreFileToManager()
        {
            string SerialInputdText = File.ReadAllText(FileURL);
            EntityList = SerialTool.Deserialize<List<Entity>>(SerialInputdText);
            if (EntityList == null)
                EntityList = new List<Entity>();

        }

        private void ShowDataWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataWinTextBox.Text.Trim() != "" && FileURL != "")
            {
                int indexResult = EntityList.FindIndex(pred => pred.Name == DataWinTextBox.Text);
                if(indexResult >= 0)
                {
                    RegViewer = new RegistersViewer(this,EntityList[indexResult]) { StartPosition = FormStartPosition.CenterParent };
                    RegViewer.ShowDialog();
                }
            }
        }

        private void slqCommandMenuItem_Click(object sender, EventArgs e)
        {
            //if(FileURL != "")
            //{
                commsConsole = new sqlCommand() { StartPosition = FormStartPosition.CenterParent };
                commsConsole.ShowDialog();
            //}
        }
    }
}
