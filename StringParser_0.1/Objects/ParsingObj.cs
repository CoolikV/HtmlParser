using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParser_0._1.Objects
{
    class ParsingObj
    {
        public ParsingObj(string surn, string init)
        {
            Surname = surn;
            Initials = init;
        }
        public ParsingObj()
        {

        }

        public string Surname { get; set; }
        public string Initials { get; set; }
    }
}
