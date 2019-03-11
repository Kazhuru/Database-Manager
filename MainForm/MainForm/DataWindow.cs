using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class DataWindow : Form
    {
        private Form1 mainForm = null;
        private List<TextBox> createTextBoxList;
        private List<Label> createLabelList;
        private Entity CurrentEntity;
        private int RegisterIndex; //CREATE -1 - MODIFY 0 >

        /// <summary>
        /// DataWindow Form constructor to create Registers
        /// </summary>
        /// <param name="callingForm"></param>
        /// <param name="Ent"></param>
        public DataWindow(Form callingForm,Entity Ent,int RegisterIdx)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            createLabelList = new List<Label>();
            createTextBoxList = new List<TextBox>();
            CurrentEntity = Ent;
            RegisterIndex = RegisterIdx;
        }

        /// <summary>
        /// event that creates or modify a register with the new information 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateDR_Click(object sender, EventArgs e)
        {
            //determine if all textbox are filled with something
            List<string> DataBuffer = new List<string>();
            bool validData = true;
            int i = 0;
            foreach (TextBox it in createPanel.Controls.OfType<TextBox>())
            {
                if (it.Text.Trim() == "")
                    validData = false;
                else
                {
                    switch(CurrentEntity.AttributeList[i].DataType)
                    {
                        case "INT":
                            validData = int.TryParse(it.Text, out int oint);
                            break;
                        case "LONG":
                            validData = long.TryParse(it.Text, out long olong);
                            break;
                        case "BOOL":
                            validData = bool.TryParse(it.Text, out bool obool);
                            break;

                    }
                    DataBuffer.Add(it.Text.Trim());
                }
                i++;
            }

            if (validData && CurrentEntity.AttributeList.Count > 0)
            {
                if (RegisterIndex == -1) //create new Register   
                    CurrentEntity.AddRegister(DataBuffer);
                else //modify current Reggister 
                    CurrentEntity.ModifyRegister(DataBuffer, RegisterIndex); 
            }
            else
            {

            }
            this.Close();
        }

        /// <summary>
        /// Event that loads dinamic forms inside of a panels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataWindow_Load(object sender, EventArgs e)
        {
            createTextBoxList.Clear();
            createLabelList.Clear();
            createPanel.Controls.Clear();
            //fill the createPanel with the selected entity attributes list
            int i = 0;
            foreach (Attribute it in CurrentEntity.AttributeList)
            {
                i++;
                createLabelList.Add(
                    new Label()
                    {
                        Name = "CreateLabel" + i,
                        Text = it.Name,
                        Location = new Point(x: 20, y: 5 + (i - 1) * 28),
                        AutoSize = true
                    });
                createPanel.Controls.Add(createLabelList.Last());
                createTextBoxList.Add(
                    new TextBox()
                    {
                        Name = "CreateTextbox" + i,
                        Location = new Point(x: 150, y: 5 + (i - 1) * 28),
                        Visible = true,
                    });
                    createLabelList.Last().Text += " "+ it.DataType + " ";
                    createTextBoxList.Last().Width = 140;
                

                createPanel.Controls.Add(createTextBoxList.Last());
            }
        }
    }
}
