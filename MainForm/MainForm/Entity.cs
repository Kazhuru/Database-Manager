using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{   [Serializable]
    public class Entity
    {
        public string Name;
        public List<Attribute> AttributeList;
        public List<DataRegister> Registers;

        /// <summary>
        /// Entity constructor without parameters.
        /// </summary>
        /// <param name="inputname"></param>
        public Entity()
        {
            Name = "EntityNull";
            AttributeList = new List<Attribute>(); 
            Registers = new List<DataRegister>();
        }

        /// <summary>
        /// Entity constructor.
        /// </summary>
        /// <param name="inputname"></param>
        public Entity(string inputname)
        {
            Name = inputname;
            AttributeList = new List<Attribute>();
            Registers = new List<DataRegister>();
        }

        public void AddRegister(List<string> DataBuffer)
        {
            //Find the Entity's PK and FK location
            int PKIndx = AttributeList.FindIndex(item => item.IndexType == "PRIMARY KEY");
            //check if already exist the key
            if(CheckIsRepeatedKey(DataBuffer,PKIndx,-1) == false)
            {
                //Sorted insert TODO ???
                Registers.Add(new DataRegister(DataBuffer,DataBuffer[PKIndx]));
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

                //Sorted insert TODO ???
                Registers.Add(new DataRegister(DataBuffer, DataBuffer[PKIndx]));
            }
        }

        public void RemoveRegister(int RegisterIndex)
        {
            Registers.Remove(Registers[RegisterIndex]);
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
            for (int i = 0; i < Registers.Count; i++)
            {
                if(Registers[i].PrimaryKey == DataBuffer[PrimKeyIndex])
                {   //founded same PKey
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
            return find;
        }
    }
}
