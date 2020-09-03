using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CS_ExtendMethod
{
    //專利類
    public class Patent
    {
        public string Title { get; set; }
        public string YearOfPublication { get; set; }
        public string ApplicationNumber { get; set; }
        public long[] InventorIds { get; set; }
        public override string ToString()
        {
            return string.Format("{0}({1})", Title, YearOfPublication);
        }
    }
}
