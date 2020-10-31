using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParser_0._1.Objects
{
    public class ContentElement
    {
        public string Authors { get; set; }
        public string Title { get; set; }

        public ContentElement(string authors, string title)
        {
            Authors = RemoveWhitespaces(authors);
            Title = title;
        }

        public string RemoveWhitespaces(string fio)
        {
            StringBuilder sb = new StringBuilder();

            string[] fios = fio.Split(',');
            //wrong work!!!!
            foreach(var f in fios)
            {
                if (String.IsNullOrEmpty(f))
                {
                    return String.Empty;
                }
                string[] res = f.Trim().Split(' ');
                string initials = res.Length == 3 ? res[1] + res[2] : res[1];
                sb.Append($"{res[0]} {initials}, ");
            }
            var result = sb.ToString();

            return result.Substring(0, result.LastIndexOf(","));
        }
    }
}
