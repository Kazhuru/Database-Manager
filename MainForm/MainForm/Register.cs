using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Register
    {
        public List<string> RegisterItems { get; set; }

        /// <summary>
        /// Register constructor.
        /// </summary>
        /// <param name="RAdrs"></param>
        /// <param name="items"></param>
        /// <param name="NRAdrs"></param>
        public Register( List<string> items)
        {
            RegisterItems = items;
        }
    }
}
