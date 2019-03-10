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
    public partial class EntityWindow : Form
    {
        private Form1 MainForm = null;

        /// <summary>
        /// EntityWindow constructor.
        /// </summary>
        /// <param name="callingForm"></param>
        public EntityWindow(Form callingForm)
        {
            MainForm = callingForm as Form1;
            InitializeComponent();
            if (MainForm.FileURL != "")
            {
                foreach (Entity iterator in MainForm.EntityList)
                {
                   ModifySelectBox.Items.Add(iterator.Name);
                   DeleteSelectBox.Items.Add(iterator.Name);
                }
            }
        }

        /// <summary>
        /// creates a new Entity with the input data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateEnt_Click(object sender, EventArgs e)
        {
            if (CreateNameBox.Text.Trim() != "")
            {
                CreateEntity(new Entity(CreateNameBox.Text));
            }
            this.Close();    
        }

        /// <summary>
        /// deletes a Entity with the input data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteEnt_Click(object sender, EventArgs e)
        {
            if(DeleteSelectBox.SelectedItem.ToString()  != "")
            {
                DeleteEntity(DeleteSelectBox.SelectedItem.ToString());
            }
            this.Close();
        }

        /// <summary>
        /// method that receives a entity and stores it in the List and File dictionary.
        /// </summary>
        /// <param name="inputEnt"></param>
        public void CreateEntity(Entity inputEnt)
        {
            if (!MainForm.EntityList.Any(query => query.Name == inputEnt.Name))
            {
                if (MainForm.EntityList.Count() == 0)
                {
                    //First entity to insert 
                    MainForm.EntityList.Add(inputEnt);
                }
                else
                {
                    int idx = CheckEntityPos(inputEnt);
                    if(idx != -1)
                        MainForm.EntityList.Insert(idx, inputEnt);
                    else
                        MainForm.EntityList.Add(inputEnt);
                }
            }
        }

        /// <summary>
        /// method that receives the entity name and removes it in the List and File dictionary.
        /// </summary>
        /// <param name="inputEntityName"></param>
        public void DeleteEntity(string inputEntityName)
        {
            //get index of the input
            int index = MainForm.EntityList.FindIndex(query => query.Name == inputEntityName);
            MainForm.EntityList.RemoveAt(index);

        }

        /// <summary>
        /// modify a Entity with the input data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyEnt_Click(object sender, EventArgs e)
        {
            if (ModifySelectBox.SelectedItem.ToString() != "" && ModifyNameBox.Text.Trim() != "")
            {
                Entity inputEntity = new Entity(ModifyNameBox.Text);
                inputEntity.AttributeList = MainForm.EntityList[ModifySelectBox.SelectedIndex].AttributeList;
                DeleteEntity(ModifySelectBox.SelectedItem.ToString());
                CreateEntity(inputEntity);
            }
            this.Close();
        }


        /// <summary>
        /// Returns the new entity insert index or -1 if is the last.
        /// </summary>
        /// <param name="inputEntity"></param>
        /// <returns></returns>
        private int CheckEntityPos(Entity inputEntity)
        {
            for (int i = 0; i < MainForm.EntityList.Count(); i++)
                if (MainForm.EntityList[i].Name.CompareTo(inputEntity.Name) == 1)
                    return i;
            //last in the list = -1
            return -1;
        }
    }
}
