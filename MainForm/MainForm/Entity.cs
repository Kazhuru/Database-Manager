using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Entity
    {
        public string Name;
        public List<Attribute> AttributeList;
        public SortedList<string, List<string>> Data;

        /// <summary>
        /// Entity constructor without parameters.
        /// </summary>
        /// <param name="inputname"></param>
        public Entity()
        {
            //int numrand = Random.Next(1000);
            Name = "EntityNull";
            AttributeList = new List<Attribute>(); 
            Data = new SortedList<string, List<string>>();
        }

        /// <summary>
        /// Entity constructor.
        /// </summary>
        /// <param name="inputname"></param>
        public Entity(string inputname)
        {
            Name = inputname;
            AttributeList = new List<Attribute>();
            Data = new SortedList<string, List<string>>();
        }

        public void AddRegister(List<string> DataBuffer)
        {
            //Find the Entity's PK and FK location
            int PKIndx = AttributeList.FindIndex(item => item.IndexType == "PRIMARY KEY");
            //check if already exist the key
            if(CheckIsRepeatedKey(DataBuffer,PKIndx,-1) == false)
            {
                //Sorted insert
                Data.Add(DataBuffer[PKIndx], DataBuffer);
            }
        }

        public void ModifyRegister(List<string> DataBuffer, int RegisterIndex)
        {
            int PKIndx = AttributeList.FindIndex(item => item.IndexType == "PRIMARY KEY");
            //Remove the old register
            //check if already exist the key
            if (CheckIsRepeatedKey(DataBuffer, PKIndx, RegisterIndex) == false)
            {
                RemoveRegister(RegisterIndex);
                Data.Add(DataBuffer[PKIndx], DataBuffer);
            }
        }

        public void RemoveRegister(int RegisterIndex)
        {
            Data.Remove(Data.Keys[RegisterIndex]);
        }

        /// <summary>
        /// method thatd checks if the register has a Pk on the data repeated
        /// </summary>
        /// <param name="DataBuffer"></param>
        /// <param name="PrimKeyIndex"></param>
        /// <param name="RegisterIndex"></param>
        /// <returns></returns>
        private bool CheckIsRepeatedKey(List<string> DataBuffer, int PrimKeyIndex, int RegisterIndex)
        {
            bool find = false;
            for (int i = 0; i < Data.Count; i++)
            {
                if(Data[Data.Keys[i]].Contains(DataBuffer[PrimKeyIndex]))
                {   //founded same Key
                    if (Data[Data.Keys[i]].IndexOf(DataBuffer[PrimKeyIndex]) == PrimKeyIndex)
                    {   //in the same PK spot 
                        if (RegisterIndex == -1)
                        {   //just adding a register
                            find = true;
                        }
                        else
                        {   //modifying a register
                            if(RegisterIndex != i)
                            {   //repeated key but in diferent register that the chosen to modify
                                find = true;
                            }
                        }
                    }
                }
            }
            return find;
        }
    }
}
