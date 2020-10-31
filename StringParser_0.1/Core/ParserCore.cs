using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.Text.RegularExpressions;
using StringParser_0._1.Objects;

namespace StringParser_0._1.Core
{
    public class ParserCore
    {
        private string _url { get; set; }
        private HtmlDocument _webDoc { get; set; }
        public ParserCore(string URL)
        {
            _url = URL;
            _webDoc = new HtmlWeb().Load(URL);
        }

        public IEnumerable<HtmlNode> GetDivsByClassName(string crit)
        {
            HtmlNodeCollection divs = _webDoc.DocumentNode.SelectNodes($"//div[@class='{crit}']");

            return divs;
        }

        public string GetAuthorsOnPage()
        {
            IEnumerable<HtmlNode> authorNode = GetDivsByClassName("authors");
            var authorStrings = authorNode.FirstOrDefault().InnerText;
            //replace regex like this : ,, and ,[A-Z]
            var formattedString = Regex.Replace(authorStrings, @"[\d-]", String.Empty);
            var next = Regex.Replace(formattedString, @"^, ", String.Empty).Replace(", ,",",").Replace(", ,", ",");
            //var nextNext = Regex.Replace(next, @", ,", ",");
            return next;
        }
        public string GetDoi()
        {
            var doiNode = GetDivsByClassName("doi");

            return "DOI: " + doiNode.First().InnerText;
        }

        public string GetPageRange()
        {
            var citationNode = GetDivsByClassName("citation");

            var pageRange = citationNode.First().InnerText;

            var formattedpageRange = pageRange.Substring(pageRange.IndexOf(":") + 1);

            return formattedpageRange;
        }

        public string GetReferenceCount()
        {
            HtmlNodeCollection refSpans = _webDoc.DocumentNode.SelectNodes($"//span[@class='refnum']");

            return refSpans.Count.ToString();
        }

        public string GetEnglishTitle()
        {
            var titleNode = GetDivsByClassName("title");

            return WebUtility.HtmlDecode(titleNode.First().InnerText);
        }

        public string GetEnglishAnnotation()
        {
            var annotationNode = GetDivsByClassName("accordion");

            var innerText = annotationNode.First().InnerText;

            var annotation = innerText.Replace("Abstract", String.Empty).Trim().Split(new[] { "Keywords" }, StringSplitOptions.None)[0];

            return WebUtility.HtmlDecode(annotation.TrimEnd());
        }

        public HtmlDocument GetAnotherLanguagePage(string lang)
        {
            var anotherLangUrl = _url.Insert(_url.LastIndexOf("content/") + 8, $"{lang}/");
            var anotherPage = new HtmlWeb().Load(anotherLangUrl);

            return anotherPage;
        }

        public string GetTitle(string lang)
        {
            HtmlDocument doc = null;
            switch (lang)
            {
                case ("uk"):
                    doc = GetAnotherLanguagePage("uk");
                    break;
                case ("ru"):
                    doc = GetAnotherLanguagePage("ru");
                    break;
            }

            //var titleNode = lang == "uk" ? GetAnotherLanguagePage("uk").DocumentNode.SelectNodes($"//div[@class='title']") : 
            //GetAnotherLanguagePage("ru").DocumentNode.SelectNodes($"//div[@class='title']");
            var titleNode = doc.DocumentNode.SelectNodes($"//div[@class='title']");

            var title = titleNode.First().InnerText;

            return WebUtility.HtmlDecode(title);
        }

        public string GetAnnotation(string lang)
        {
            var annotationNode = lang == "uk" ? GetAnotherLanguagePage("uk").DocumentNode.SelectNodes($"//div[@class='accordion']") :
                GetAnotherLanguagePage("ru").DocumentNode.SelectNodes($"//div[@class='accordion']");

            var innerText = annotationNode.First().InnerText;
            var annotation = innerText.Replace("Abstract", String.Empty).Trim().Split(new[] { "Keywords" }, StringSplitOptions.None)[0];

            return WebUtility.HtmlDecode(annotation.TrimEnd());
        }

        public string GenerateFIOBibliography()
        {
            var parsings = CreateAuthorsList();
            StringBuilder sb = new StringBuilder();

            foreach (var obj in parsings)
            {
                sb.Append($"{obj.Initials} {obj.Surname}, ");
            }
            string result = sb.ToString();
            result = result.Remove(result.LastIndexOf(','), 1);

            return result.Trim();
        }

        public string GenerateBibliograpy(string pattern)
        {
            var authors = GenerateFIOBibliography();

            string bibliography = pattern.Replace("Название", GetEnglishTitle()).Replace("ИОФамилия", authors).
                Replace("ХХ-ХХ.", GetPageRange()).Replace(@"ХХ", GetReferenceCount());

            return bibliography.Replace("\n",String.Empty);
        }

        public List<AuthorData> CreateAuthorsList()
        {
            var authors = GetAuthorsOnPage();
            var authorsList = new List<AuthorData>();
            string[] removedComma = authors.Split(',');

            for (int i = 0; i < removedComma.Length; i++)
            {
                removedComma[i] = removedComma[i].Trim();

                authorsList.Add(CreateParseObj(removedComma[i]));
            }

            return authorsList;
        }

        private AuthorData CreateParseObj(string fio)
        {
            string[] res = fio.Split(' ');

            string initials = res.Length == 3 ? res[1] + res[2] : res[1];

            return new AuthorData(res[0], initials);
        }

        public string GetPageTopic()
        {
            var topicNode = GetDivsByClassName("topic");

            var topic = topicNode.FirstOrDefault().InnerText;

            return topic;
        }

        public List<ContentElement> GetCollectionOfContentElements()
        {
            var collection = new List<ContentElement>();
            var authorNodes = GetDivsByClassName("authors");
            var titleNodes = GetDivsByClassName("title");
            string[] authors = new string[authorNodes.Count()];
            string[] titles = new string[titleNodes.Count()];

            int i = 0;
            foreach(var node in authorNodes)
            {
                authors[i++] = node.InnerText;
            }
            i = 0;
            foreach(var node in titleNodes)
            {
                titles[i++] = node.InnerText;
            }

            for(var k = 0; k < authorNodes.Count(); k++)
            {
                collection.Add(new ContentElement(authors[k], titles[k]));
            }

            return collection;
        }

        public IEnumerable<HtmlNode> GetDivsByClassContains(string crit)
        {
            HtmlNodeCollection divs = _webDoc.DocumentNode.SelectNodes($"//div[contains(@class, '{crit}')]");

            return divs;
        }

        public string[] GetTopicsList()
        {
            var topicsDivs = GetDivsByClassContains("topic");
            var topics = new string[topicsDivs.Count()];
            int i = 0;

            foreach(var div in topicsDivs)
            {
                topics[i++] = WebUtility.HtmlDecode(div.InnerText);
            }
            return topics;
        }

        public string GetArticleTitle()
        {
            var artDiv = GetDivsByClassName("citation");

            return WebUtility.HtmlDecode(artDiv.FirstOrDefault().InnerText);
        }
    }
}
