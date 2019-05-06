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
        private Form1 MainForm = null;
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
            MainForm = callingForm as Form1;
            InitializeComponent();
            createLabelList = new List<Label>();
            createTextBoxList = new List<TextBox>();
            CurrentEntity = Ent;
            RegisterIndex = RegisterIdx;
            if (RegisterIndex == -1) //create new Register   
                CreateDR.Text = "Create New Register";
            else                     //modify current Reggister 
                CreateDR.Text = "Modify Current Register";
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
            bool FKintegrity = true;
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

            //Verify Fk's values
            List<TextBox> ListTBox = createPanel.Controls.OfType<TextBox>().ToList();
            List<Attribute> currentsFKs = CurrentEntity.AttributeList.FindAll(pred => pred.IndexType == "FOREING KEY");

            foreach (var iAttribute in currentsFKs)
            {
                //gets the index location of the selected FK Attribute
                int idx = CurrentEntity.AttributeList.FindIndex(pred => pred.Name == iAttribute.Name);
                //gets the relationed Entity with our current Attribute
                Entity RelationEnt = MainForm.EntityList.Find(pred => pred.Name == iAttribute.FKEntityRel);
                //gets the Idx of the relationed Pk Attribute
                int relIindex = RelationEnt.AttributeList.FindIndex(pred => pred.Name == iAttribute.FKPrimKeyRel);
                //try to find any match
                bool findedPkData = false;
                foreach (var iRegister in RelationEnt.Registers)
                    if(iRegister.RegisterData[relIindex] == ListTBox[idx].Text)
                        findedPkData = true;

                if (!findedPkData)
                    FKintegrity = false;
            }

            if (validData && FKintegrity && CurrentEntity.AttributeList.Count > 0)
            {
                if (RegisterIndex == -1) //create new Register   
                    CurrentEntity.AddRegister(DataBuffer);
                else                     //modify current Reggister 
                    CurrentEntity.ModifyRegister(DataBuffer, RegisterIndex);
                this.Close();
            }
            else
            {
                if(!FKintegrity)
                    MessageBox.Show("Bad Foreing data input, care with data integrity", "Input Error");
                else
                    MessageBox.Show("Wrong Data input, Retry please", "Input Error");
            }
            
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

                //Labels
                createLabelList.Add(
                    new Label()
                    {
                        Name = "AutoCreateLabel-" + i,
                        Text = it.Name + " (" + it.DataType + ") ",
                        Location = new Point(x: 20, y: 5 + (i - 1) * 28),
                        AutoSize = true
                    });
                createPanel.Controls.Add(createLabelList.Last());

                //TextBox's
                createTextBoxList.Add(
                    new TextBox()
                    {
                        Name = "AutoCreateTextbox-" + i,
                        Location = new Point(x: 140, y: 5 + (i - 1) * 28),
                        Visible = true,
                        Width = 140
                    });
                createPanel.Controls.Add(createTextBoxList.Last());

                //Attribute is a FK so needs more fields 
                if(it.IndexType == "FOREING KEY")
                {
                    //FK Labels
                    createLabelList.Add(
                        new Label()
                        {
                            Name = "Label-" + it.Name + "-" + it.FKEntityRel + "-" + it.FKPrimKeyRel,
                            Text = "FK!:Must exist the PK to be a correct input",
                            Location = new Point(x: 295, y: 5 + (i - 1) * 28),
                            AutoSize = true
                        });
                    createPanel.Controls.Add(createLabelList.Last());
                }
            }
        }
    }
}
