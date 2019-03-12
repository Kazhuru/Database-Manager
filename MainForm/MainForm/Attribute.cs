using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    [Serializable]
    public class Attribute
    {
        public string Name;
        public string DataType; // 0 - STRING,   1 - INT,   2 - LONG,   3 - BOOL
        public string IndexType; // 0 - NONE KEY,   1 - PRIMARY KEY,   2 - FOREING KEY
        public int LengthDataType;
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

        /// <summary>
        /// Attribute constructor without parameters.
        /// </summary>
        /// <param name="inName"></param>
        /// <param name="inDtype"></param>
        /// <param name="inIdxType"></param>
        /// <param name="inLength"></param>
        public Attribute()
        {
            Name = "NullName";
            DataType = "INT";
            LengthDataType = 4;
            IndexType = "NONE KEY";
        }
    }
}
