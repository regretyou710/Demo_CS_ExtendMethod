using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CS_ExtendMethod
{
    //發明者類
    public class Inventor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return string.Format("{0}({3}{1},{2})", Name, City, State, Country);
        }
    }
}
