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

namespace FileManager
{
    public partial class NewFileForm : Form
    {
        private string folderString;
        private string nameString;
        private Form1 mainForm = null;

        /// <summary>
        /// NewFileForm constructor
        /// </summary>
        /// <param name="callingForm"></param>
        public NewFileForm(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            folderString = "C:";
            nameString = "NewFile";
            label2.Text = folderString + "\\" + nameString + ".txt";
        }

        /// <summary>
        /// Ok button to finish the task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.NewWindowInput = label2.Text;
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Browse button to look for the destination folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderString = folderBrowserDialog1.SelectedPath;
            }
            label2.Text = folderString + "\\" + nameString + ".txt";
        }

        /// <summary>
        /// when you type a file name this method generate the proper URL.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            nameString = textBox1.Text;
            label2.Text = folderString + "\\" + nameString + ".txt";
        }
    }
}
