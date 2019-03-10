using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Attribute
    {
        public string Name { get; set; }
        public string DataType { get; set; } // 0 - STRING,   1 - INT,   2 - LONG,   3 - BOOL
        public string IndexType { get; set; } // 0 - NONE KEY,   1 - PRIMARY KEY,   2 - FOREING KEY
        public int LengthDataType { get; set; }
        /// <summary>
        /// Attribute constructor.
        /// </summary>
        /// <param name="inName"></param>
        /// <param name="inDtype"></param>
        /// <param name="inIdxType"></param>
        /// <param name="inLength"></param>
        public Attribute(string inName, string inDtype, string inIdxType, int inLength)
        {
            Name = inName;
            DataType = inDtype;
            LengthDataType = inLength;
            IndexType = inIdxType;
        }   
    }
}
