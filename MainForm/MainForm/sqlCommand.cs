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

        public sqlCommand()
        {
            InitializeComponent();
            txtInput = "";
            ReservedWords = new List<string>() { "SELECT", "FROM", "WHERE" };
            Operators = new List<string>() { "==", "<>", ">", "<", ">=", "<=", "*"};

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
            List<string> sqlSpecs = new List<string>();
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
                                sqlSpecs.Add("@");
                            }
                            else
                                correctInput = false;
                            break;
                        case "WHERE":
                            if (CurrentReserved == "FROM")
                            {
                                CurrentReserved = "WHERE";
                                sqlSpecs.Add("@");
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
                        case "==":
                        case ">":
                        case "<":
                        case ">=":
                        case "<=":
                        case "<>":
                        case "*":
                            if (CurrentReserved == "WHERE")
                            {
                                if (parsedTxt[i] == parsedTxt.Last())
                                    correctInput = false;
                                else if (Operators.Contains(parsedTxt[i - 1]) || ReservedWords.Contains(parsedTxt[i + 1]))
                                    correctInput = false;
                                else
                                    sqlSpecs.Add(parsedTxt[i]);
                            }
                            else
                                correctInput = false;
                            break;
                        default:
                            //ID's de Entidades, Atributos  
                            if (CurrentReserved == "SELECT")
                            {
                                    sqlSpecs.Add(parsedTxt[i]);
                            }
                            else if(CurrentReserved == "FROM")
                            {
                                sqlSpecs.Add(parsedTxt[i]);
                            }
                            else if (CurrentReserved == "WHERE")
                            {
                                sqlSpecs.Add(parsedTxt[i]);
                            }
                            break;
                    } 
                    //end switch here
                    if(correctInput == false)
                    {
                        i = parsedTxt.Count();
                        sqlSpecs.Clear();
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
                //TODO
            }
            else
            {
                //TODO
            }

        }
    }
}
