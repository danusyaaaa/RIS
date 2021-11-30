using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public static class ExtensionMethods
    {
        public static (bool,int) isNumber(string val)
        {
            int number;
            return (int.TryParse(val, out number), number); 
        }
    }
}
