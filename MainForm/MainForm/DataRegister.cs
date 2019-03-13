using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    [Serializable]
    public class DataRegister
    {
        public List<string> RegisterData { get; set; }
        public string PrimaryKey;

        /// <summary>
        /// DataRegister constructor without parameters.
        /// </summary>
        /// <param name="RAdrs"></param>
        /// <param name="items"></param>
        /// <param name="NRAdrs"></param>
        public DataRegister()
        {
            RegisterData = new List<string>();
            PrimaryKey = "NullPK";
        }

        public DataRegister(List<string> inData, string inKey)
        {
            RegisterData = inData;
            PrimaryKey = inKey;
        }
    }
}
