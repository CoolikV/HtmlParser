using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParser_0._1.Objects
{
    public class ArticleData
    {
        private List<AuthorData> _authors = new List<AuthorData>();

        public ArticleData(List<AuthorData> authors, string doi, string pagesCount, int refCount, string url, string ukr, string engl, string rus)
        {
            _authors = authors;
            Doi = doi;
            PagesRange = pagesCount;
            RefCount = refCount;
            URL = url;
            UkraineTitle = ukr;
            EnglishTitle = engl;
            RussianTitle = rus;
        }

        public List<AuthorData> Authors { get; set; }
        public int RefCount { get; set; }
        public string Doi { get; set; }
        public string PagesRange { get; set; }
        public string URL { get; set; }
        public string UkraineTitle { get; set; }
        public string RussianTitle { get; set; }
        public string EnglishTitle { get; set; }
    }
}
