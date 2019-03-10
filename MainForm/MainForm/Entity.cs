using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Entity
    {

        public string Name { get; set; }
        public List<Attribute> AttributeList;
        public DataHandler DataHandler { get; set; }

        /// <summary>
        /// Entity constructor.
        /// </summary>
        /// <param name="inputname"></param>
        public Entity(string inputname)
        {
            Name = inputname;
            AttributeList = new List<Attribute>();
            DataHandler = new DataHandler();
        }
    }
}
