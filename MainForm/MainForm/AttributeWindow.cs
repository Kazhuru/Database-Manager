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
    public partial class AttributeWindow : Form
    {
        private Form1 MainForm = null;

        /// <summary>
        /// Attribute Window constructor.
        /// </summary>
        /// <param name="callingForm"></param>
        public AttributeWindow(Form callingForm)
        {
            MainForm = callingForm as Form1;
            InitializeComponent();

            foreach (Entity iterator in MainForm.EntityList)
                SelectEntityBox.Items.Add(iterator.Name);
            //--Create Box's
            IndexTBox.Items.Add("NONE KEY"); 
            IndexTBox.Items.Add("PRIMARY KEY"); 
            IndexTBox.Items.Add("FOREING KEY");
            TypeBox.Items.Add("STRING");
            TypeBox.Items.Add("INT");
            TypeBox.Items.Add("LONG");
            TypeBox.Items.Add("BOOL");
        }

        /// <summary>
        /// creates a new Attribute with the input data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeAttrib_Click(object sender, EventArgs e)
        {
            if (SelectEntityBox.SelectedItem != null)
            {
                if (NameBox.Text.Trim() != "" && IndexTBox.Text != "" && TypeBox.Text != "" && 
                    SelectEntityBox.SelectedItem.ToString() != "")
                {
                    int DataLen = 0;
                    switch (TypeBox.Text)
                    {
                        case "STRING":
                            DataLen = int.Parse(LenghtBox.Text);
                            break;
                        case "INT":
                            DataLen = 4;
                            break;
                        case "LONG":
                            DataLen = 8;
                            break;
                        case "BOOL":
                            DataLen = 1;
                            break;
                    }
                    Attribute inputAttribute;
                    inputAttribute = new Attribute(NameBox.Text, TypeBox.Text, IndexTBox.Text, DataLen,DescriptionBox.Text);
                    CreateAttribute(inputAttribute, SelectEntityBox.SelectedItem.ToString());
                           
                    this.Close();
                }
            }
        }

        /// <summary>
        /// method that receives a attribute and stores it in the List and File dictionary.
        /// </summary>
        /// <param name="inputAtt"></param>
        /// <param name="idx"></param>
        public void CreateAttribute(Attribute inputAtt, string EntityInputName)
        {
            Entity SelectedEntity = MainForm.EntityList.Find(ent => ent.Name == EntityInputName);
            bool issues = false;
            if(IndexTBox.Text == "FOREING KEY")
            {
                if (PKEntityBox.Text.Trim() != "" && PKSearchBox.Text.Trim() != "")
                {
                    int Indx = MainForm.EntityList.FindIndex(ent => ent.Name == EntityInputName);
                    if (Indx > 0)
                    {
                        int indexResult = MainForm.EntityList[Indx].AttributeList.
                            FindIndex(pred => pred.IndexType == "PRIMARY KEY" && pred.Name == PKSearchBox.Text);
                        if (indexResult > 0)
                        {
                            //Correct Data integratity check
                            inputAtt.SetFKey(PKEntityBox.Text, PKSearchBox.Text);
                        }
                        else
                            issues = true;
                    }
                    else
                        issues = true;
                }
                else
                    issues = true;
            }
            if(!issues)
                SelectedEntity.AttributeList.Add(inputAtt);
            else
                MessageBox.Show("Wrong Data on Attribute's input", "Attribute Input Error");
        }

        /// <summary>
        /// deletes Attribute with the input data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAttrib_Click(object sender, EventArgs e)
        {
            if (SelectEntityBox.SelectedItem != null)
            {
                if (SelectAtributeBox.Text != "" && SelectEntityBox.SelectedItem.ToString() != "")
                {
                    DeleteAttribute(SelectEntityBox.SelectedIndex, SelectAtributeBox.SelectedIndex);
                }
                this.Close();
            }
        }

        /// <summary>
        /// method that receives the entity and attribute index and removes it in the List and File dictionary.
        /// </summary>
        /// <param name="Entidx"></param>
        /// <param name="Attidx"></param>
        public void DeleteAttribute(int Entidx, int Attidx)
        {
            MainForm.EntityList[Entidx].AttributeList.RemoveAt(Attidx);
        }

        /// <summary>
        /// modify a Attribute with the input data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyAttrib_Click(object sender, EventArgs e)
        {
            if (SelectEntityBox.SelectedItem != null)
            {
                if (NameBox.Text.Trim() != "" && IndexTBox.Text != "" && TypeBox.Text != "" 
                    && SelectAtributeBox.Text != "" && SelectEntityBox.SelectedItem.ToString() != "")
                {
                    int DataLen = 0;
                    switch (TypeBox.Text)
                    {
                        case "STRING":
                            DataLen = int.Parse(LenghtBox.Text);
                            break;
                        case "INT":
                            DataLen = 4;
                            break;
                        case "LONG":
                            DataLen = 8;
                            break;
                        case "BOOL":
                            DataLen = 1;
                            break;
                    }
                    Attribute inputAttribute;
                    inputAttribute = new Attribute(NameBox.Text, TypeBox.Text,
                        IndexTBox.Text, DataLen, DescriptionBox.Text);
                    DeleteAttribute(SelectEntityBox.SelectedIndex, SelectAtributeBox.SelectedIndex);
                    CreateAttribute(inputAttribute, SelectEntityBox.SelectedItem.ToString());
                }
                this.Close();
            }
        }
           
        /// <summary>
        /// refresh the Modify and Delete ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEntityBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectAtributeBox.Items.Clear();
            foreach (Attribute iterator in MainForm.EntityList[SelectEntityBox.SelectedIndex].AttributeList)
            {
                SelectAtributeBox.Items.Add(iterator.Name);
            }
        }

        private void CreateTypeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (TypeBox.SelectedItem.ToString() == "STRING")
                LenghtBox.ReadOnly = false;
            else
                LenghtBox.ReadOnly = true;
        }

        private void IndexTBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeBox.SelectedItem.ToString() == "FOREING KEY")
            {
                PKSearchBox.ReadOnly = false;
                PKEntityBox.ReadOnly = false;  
            }
            else
            { 
                PKSearchBox.ReadOnly = true;
                PKEntityBox.ReadOnly = true;
            }
        }
    }
}
