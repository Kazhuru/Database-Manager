using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class DataHandler
    {
        private FileStream fStream;
        public List<Register> DataRegisters { get; set; }
        public string DataURL { get; set; }
        public Entity CurrentEntity { get; set; }
        public string IdxURL { get; set; }

        public DataHandler()
        {
            DataURL = null;
            DataRegisters = new List<Register>();
        }

        /// <summary>
        /// Set the Data Handler ready to interact with it
        /// </summary>
        /// <param name="DicUrl"></param>
        /// <param name="ent"></param>
        /// <param name="inFh"></param>
        public void EnableDataHandler(string DicUrl, Entity ent)
        {
            if (DataURL == null)
            {
                DataURL = DicUrl;
                fStream = new FileStream(DataURL, FileMode.Create);
                fStream.Close();
                CurrentEntity = ent;
            }
        }

        /// <summary>
        /// Method that Create a new Register
        /// </summary>
        /// <param name="DataBuffer"></param>
        public void Create(List<string> DataBuffer)
        {
            int PKIndx = CurrentEntity.AttributeList.FindIndex(item => item.IndexType == "PRIMARY KEY" );
            List<Attribute> FKIndx = CurrentEntity.AttributeList.FindAll(item => item.IndexType == "FOREING KEY");
            //Sequential
                   
        }

        /// <summary>
        /// Method that Modify a new Register to the Entity File .dat
        /// </summary>
        /// <param name="RegToModify"></param>
        /// <param name="DataBuffer"></param>
        public void Modify(Register RegToModify, List<string> DataBuffer)
        {
            int PKIndx = CurrentEntity.AttributeList.FindIndex(item => item.IndexType == "PRIMARY KEY");
            List<Attribute> FKIndx = CurrentEntity.AttributeList.FindAll(item => item.IndexType == "FOREING KEY");
            bool repeated = CheckRepeated(PKIndx, DataBuffer, RegToModify);
            if (!repeated && !RegToModify.RegisterItems.Equals(DataBuffer.ToArray()))
            {

            }
        }

        /// <summary>
        /// Method that delete a new Register to the Entity File .dat
        /// </summary>
        /// <param name="RegToDel"></param>
        public void Delete(Register RegToDel)
        {
            //INDEX TO DELETE
            DeleteIndexHandler(RegToDel);
            DataRegisters.Remove(RegToDel);
            
        }

        /// <summary>
        /// method that handles the index destruction of the current Register
        /// </summary>
        /// <param name="RegToDel"></param>
        private void DeleteIndexHandler(Register RegToDel)
        {
            int PKIndx = CurrentEntity.AttributeList.FindIndex(item => item.IndexType == "PRIMARY KEY");
            if (PKIndx >= 0)
            {
                Attribute SelectedAtt = CurrentEntity.AttributeList[PKIndx];

            }
            
        }
    
        /// <summary>
        /// method that gets the new Register to insert in sequencial order
        /// </summary>
        /// <param name="SearchIndx"></param>
        /// <param name="inputReg"></param>
        private void SequentialUpdateRegAdrs(int SearchIndx, Register inputReg)
        {
            int IdxMaxminor =  GetLocationInsert(SearchIndx, inputReg);
            //If IdxMaxminor is "-1" first , else also modify the penultimate Register                                 
            if (IdxMaxminor == -1)
            {

            }
            else
            {

            }

        }

        /// <summary>
        /// method that gets the location to instert of a new Register, if return -1 is the first position
        /// </summary>
        /// <param name="SearchIndx"></param>
        /// <param name="inputReg"></param>
        /// <returns></returns>
        private int GetLocationInsert(int SearchIndx, Register inputReg)
        {
            int IdxMaxminor = -1;
            for (int i = 0; i < DataRegisters.Count(); i++) //Reads all registers
            {
                if (DataRegisters[i] != inputReg)
                    if (CurrentEntity.AttributeList[SearchIndx].DataType == "STRING")
                    {
                        if (DataRegisters[i].RegisterItems[SearchIndx].CompareTo
                            (inputReg.RegisterItems[SearchIndx]) < 0) //Current Register SK minor to Input SK
                            if (IdxMaxminor == -1)
                                IdxMaxminor = i;
                            else
                                if (DataRegisters[i].RegisterItems[SearchIndx].CompareTo
                                (DataRegisters[IdxMaxminor].RegisterItems[SearchIndx]) > 0) //Current Register SK mayor to Saved SK
                                IdxMaxminor = i;
                    }
                    else
                    {
                        if (int.Parse(DataRegisters[i].RegisterItems[SearchIndx]).CompareTo
                            (int.Parse(inputReg.RegisterItems[SearchIndx])) < 0) //Current Register SK minor to Input SK
                            if (IdxMaxminor == -1)
                                IdxMaxminor = i;
                            else
                                if (int.Parse(DataRegisters[i].RegisterItems[SearchIndx]).CompareTo
                                (int.Parse(DataRegisters[IdxMaxminor].RegisterItems[SearchIndx])) > 0) //Current Register SK mayor to Saved SK
                                IdxMaxminor = i;
                    }
            }
            return IdxMaxminor;
        }

        /// <summary>
        /// method thatd checks if the register has a Pk or SK repeated
        /// </summary>
        /// <param name="SearchIndx"></param>
        /// <param name="PKIndx"></param>
        /// <param name="DataBuffer"></param>
        /// <returns></returns>
        private bool CheckRepeated(int SearchIndx, int PKIndx, List<string> DataBuffer)
        {
            bool find = false;
            if(SearchIndx >= 0)
                foreach(Register itReg in DataRegisters)
                    if(itReg.RegisterItems.Contains(DataBuffer[SearchIndx]))         
                        if (itReg.RegisterItems.ToList().IndexOf(DataBuffer[SearchIndx]) == SearchIndx)
                            find = true;
            if (PKIndx >= 0)
                foreach (Register itReg in DataRegisters)
                    if (itReg.RegisterItems.Contains(DataBuffer[PKIndx]))
                        if (itReg.RegisterItems.ToList().IndexOf(DataBuffer[PKIndx]) == PKIndx)
                            find = true;
            return find;
        }

        /// <summary>
        /// method thatd checks if the register has a Pk or SK repeated compared to another Register
        /// </summary>
        /// <param name="SearchIndx"></param>
        /// <param name="PKIndx"></param>
        /// <param name="DataBuffer"></param>
        /// <returns></returns>
        private bool CheckRepeated( int PKIndx, List<string> DataBuffer,Register RegToCompare)
        {
            bool find = false;
            if (PKIndx >= 0)
                foreach (Register itReg in DataRegisters)
                    if (itReg.RegisterItems.Contains(DataBuffer[PKIndx]) && itReg != RegToCompare)
                        if (itReg.RegisterItems.ToList().IndexOf(DataBuffer[PKIndx]) == PKIndx)
                            find = true;
            return find;
        }


        /// <summary>
        /// Reads the file.dat to Restore the information and show it
        /// </summary>
        public void RestoreData()
        {
            //TODO
        }
    }
}
