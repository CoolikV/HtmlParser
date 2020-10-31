using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParser_0._1.Objects
{
    public class AuthorData
    {
        public AuthorData(string surn, string init)
        {
            Surname = surn;
            Initials = init;
        }
        public AuthorData()
        {

        }

        public string Surname { get; set; }
        public string Initials { get; set; }
    }
}
