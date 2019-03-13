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
            CreateIndexTBox.Items.Add("NONE KEY"); 
            CreateIndexTBox.Items.Add("PRIMARY KEY"); 
            CreateIndexTBox.Items.Add("FOREING KEY");
            CreateTypeBox.Items.Add("STRING");
            CreateTypeBox.Items.Add("INT");
            CreateTypeBox.Items.Add("LONG");
            CreateTypeBox.Items.Add("BOOL");

            //--Modify Box's
            ModifyIndexTBox.Items.Add("NONE KEY");
            ModifyIndexTBox.Items.Add("PRIMARY KEY");
            ModifyIndexTBox.Items.Add("FOREING KEY");
            ModifyTypeBox.Items.Add("STRING");
            ModifyTypeBox.Items.Add("INT");
            ModifyTypeBox.Items.Add("LONG");
            ModifyTypeBox.Items.Add("BOOL");
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
                if (CreateNameBox.Text.Trim() != "" && CreateIndexTBox.Text != "" && CreateLenghtBox.Text.Trim() != ""
                    && CreateTypeBox.Text != "" && SelectEntityBox.SelectedItem.ToString() != "")
                {
                    int DataLen = 0;
                    switch (CreateTypeBox.Text)
                    {
                        case "STRING":
                            DataLen = int.Parse(CreateLenghtBox.Text);
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
                    inputAttribute = new Attribute(CreateNameBox.Text, CreateTypeBox.Text, CreateIndexTBox.Text, DataLen);
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
            //Determines if exists Inputs errors 
            bool finded = false;
            bool containsPK = SelectedEntity.AttributeList.Any(item => item.IndexType == "PRIMARY KEY");
            if (containsPK && CreateIndexTBox.Text == "PRIMARY KEY")
            {
                finded = true;
                MessageBox.Show("the Entity already has a Primary Key", " Input Error");
            }
            if (!finded)
            {   //finds no input errors
                SelectedEntity.AttributeList.Add(inputAtt);
            }
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
                if (DeleteSeletBox.Text != "" && SelectEntityBox.SelectedItem.ToString() != "")
                {
                    DeleteAttribute(SelectEntityBox.SelectedIndex, DeleteSeletBox.SelectedIndex);
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
                if (ModifyNameBox.Text.Trim() != "" && ModifyIndexTBox.Text != "" && ModifyLenghtBox.Text.Trim() != "" 
                    && ModifyTypeBox.Text != "" && ModifySelectBox.Text != "" && SelectEntityBox.SelectedItem.ToString() != "")
                {

                    Attribute inputAttribute;
                    inputAttribute = new Attribute(ModifyNameBox.Text, ModifyTypeBox.Text,
                        ModifyIndexTBox.Text, int.Parse(ModifyLenghtBox.Text));
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
            ModifySelectBox.Items.Clear();
            DeleteSeletBox.Items.Clear();
            foreach (Attribute iterator in MainForm.EntityList[SelectEntityBox.SelectedIndex].AttributeList)
            {
                ModifySelectBox.Items.Add(iterator.Name);
                DeleteSeletBox.Items.Add(iterator.Name);
            }
        }

        private void CreateTypeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CreateTypeBox.SelectedItem.ToString() == "STRING")
                CreateLenghtBox.ReadOnly = false;
            else
                CreateLenghtBox.ReadOnly = true;
        }

        private void ModifyTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModifyTypeBox.SelectedItem.ToString() == "STRING")
                ModifyLenghtBox.ReadOnly = false;
            else
                ModifyLenghtBox.ReadOnly = true;
        }            
    }
}
