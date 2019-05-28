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
    public partial class sqlCommand : Form
    {
        private string txtInput = "";
        private List<string> ReservedWords;
        private List<string> Operators;
        private List<string> SELECT;
        private List<string> FROM;
        private List<string> WHERE;
        private Form1 MainForm = null;

        public sqlCommand(Form callingForm)
        {
            MainForm = callingForm as Form1;
            InitializeComponent();
            txtInput = "";
            ReservedWords = new List<string>() { "SELECT", "FROM", "WHERE" };
            Operators = new List<string>() { "==", "<>", ">", "<", ">=", "<=", "*"};
            SELECT = new List<string>();
            FROM = new List<string>();
            WHERE = new List<string>();

        }

        private void GoInput_Click(object sender, EventArgs e)
        {
            txtInput = richTextBox1.Text;
            if(txtInput.Trim() != "")
            {
                List<string> parsedTxt = ParseInput();
                GetCommand(parsedTxt);
            }
        }

        private List<string> ParseInput()
        {
            List<string> splitInput = txtInput.Split(' ').ToList();
            splitInput.RemoveAll(pred => pred == "");
            for (int i = 0; i < splitInput.Count; i++)
            {
                splitInput[i] = splitInput[i].Trim();
                if(splitInput[i][0] == ',' && splitInput[i].Count() > 1)
                {
                    splitInput[i] = splitInput[i].Remove(0,1);
                    splitInput.Insert(i,",");
                }
                else if(splitInput[i].Last() == ',' && splitInput[i].Count() > 1)
                {
                    splitInput[i] = splitInput[i].Remove(splitInput[i].Count() -1, 1);
                    splitInput.Insert(i +1, ",");
                }
            }

            return splitInput;
        }

        private void GetCommand(List<string> parsedTxt)
        {
            bool correctInput = true;
            //List<string> sqlSpecs = new List<string>();
            string CurrentReserved = "";


            if(parsedTxt.Contains("SELECT") && parsedTxt.Contains("FROM"))
            {
                for (int i = 0; i < parsedTxt.Count; i++)
                {
                    switch (parsedTxt[i])
                    {
                        case "SELECT":
                            if (CurrentReserved == "")
                                CurrentReserved = "SELECT";
                            else
                                correctInput = false;
                            break;
                        case "FROM":
                            if (CurrentReserved == "SELECT")
                            {
                                CurrentReserved = "FROM";
                                //sqlSpecs.Add("@");
                            }
                            else
                                correctInput = false;
                            break;
                        case "WHERE":
                            if (CurrentReserved == "FROM")
                            {
                                CurrentReserved = "WHERE";
                                //sqlSpecs.Add("@");
                            }
                            else
                                correctInput = false;
                            break;
                        case ",":
                            if (CurrentReserved == "SELECT")
                            {
                                if(parsedTxt[i] == parsedTxt.Last())
                                    correctInput = false;
                                else if (Operators.Contains(parsedTxt[i - 1]) || ReservedWords.Contains(parsedTxt[i + 1]))
                                    correctInput = false;
                            }
                            else
                                correctInput = false;
                            break;
                        case "*":
                            if (CurrentReserved == "SELECT")
                            {
                                if(SELECT.Count > 0)
                                    correctInput = false;
                                else
                                    SELECT.Add(parsedTxt[i]);
                            }
                            else
                                correctInput = false;
                            break;
                        case "==":
                        case ">":
                        case "<":
                        case ">=":
                        case "<=":
                        case "<>":
                            if (CurrentReserved == "WHERE")
                            {
                                if (parsedTxt[i] == parsedTxt.Last())
                                    correctInput = false;
                                else if (Operators.Contains(parsedTxt[i - 1]) || ReservedWords.Contains(parsedTxt[i + 1]))
                                    correctInput = false;
                                else
                                    WHERE.Add(parsedTxt[i]);
                            }
                            else
                                correctInput = false;
                            break;
                        default:
                            //ID's de Entidades, Atributos  
                            if (CurrentReserved == "SELECT")
                            {
                                if(SELECT.Contains("*"))
                                    correctInput = false;
                                else
                                    SELECT.Add(parsedTxt[i]);
                            }
                            else if(CurrentReserved == "FROM")
                            {
                                if(FROM.Count > 0)
                                    correctInput = false;
                                else
                                    FROM.Add(parsedTxt[i]);
                            }
                            else if (CurrentReserved == "WHERE")
                            {
                                WHERE.Add(parsedTxt[i]);
                            }
                            break;
                    } 
                    //end switch here
                    if(correctInput == false)
                    {
                        i = parsedTxt.Count();
                        SELECT.Clear();
                        FROM.Clear();
                        WHERE.Clear();
                    }
                        

                }//end for here
            }
            else
            {
                correctInput = false;
            }

            //========== UPDATE or ERROR ===========
            if(correctInput)
            {
                bool okData = CheckCorrectData();
                if (okData)
                {
                    MainForm.SELECT = SELECT;
                    MainForm.FROM = FROM;
                    MainForm.WHERE = WHERE;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect command input, Try again", "SQL Syntax Error");
            }

        }

        private bool CheckCorrectData()
        {
            if (SELECT.Count > 0 && FROM.Count > 0)
            {
                int idx = MainForm.EntityList.FindIndex(pred => pred.Name == FROM.First());
                if (idx >= 0)
                {
                    bool okSelectSearch = true;
                    if(!SELECT.Contains("*"))
                        foreach (var item in SELECT)
                            if (MainForm.EntityList[idx].AttributeList.Any(pred => pred.Name == item) == false)
                                okSelectSearch = false;
                    if (okSelectSearch)
                    {
                        if(WHERE.Count > 0 )
                        {
                            bool FirstItem = MainForm.EntityList[idx].AttributeList.Any(pred => pred.Name == WHERE.First());
                            bool LastItem = MainForm.EntityList[idx].AttributeList.Any(pred => pred.Name == WHERE.Last());

                            if (!FirstItem && !LastItem) //No se encontro los atributos seleccionados en Where
                                MessageBox.Show("WHERE: Attribute not found, Try again", "SQL Syntax Error");
                            else   //Todo Correcto! 
                                return true;
                        }
                        else //Todo Correcto! 
                            return true;
                    }
                    else
                    {
                        //No se encontro los atributos seleccionados en Select
                        MessageBox.Show("SELECT: Attribute not found, Try again", "SQL Syntax Error");
                        return false;
                    }
                }
                else
                {
                    //No se encontro la entidad seleccionada
                    MessageBox.Show("FROM: Entity not found, Try again", "SQL Syntax Error");
                    return false;
                }
            }
            return false;
        }
    }
}
