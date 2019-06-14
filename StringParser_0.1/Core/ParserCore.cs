using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.Text.RegularExpressions;

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
            var next = Regex.Replace(formattedString, @"^, ", String.Empty).Replace(", ,",",");
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

            return titleNode.First().InnerText;
        }

        public string GetEnglishAnnotation()
        {
            var annotationNode = GetDivsByClassName("accordion");

            var innerText = annotationNode.First().InnerText;

            var annotation = innerText.Replace("Abstract", String.Empty).Trim().Split(new[] { "Keywords" }, StringSplitOptions.None)[0];

            return annotation.TrimEnd();
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

            return title;
        }

        public string GetAnnotation(string lang)
        {
            var annotationNode = lang == "uk" ? GetAnotherLanguagePage("uk").DocumentNode.SelectNodes($"//div[@class='accordion']") :
                GetAnotherLanguagePage("ru").DocumentNode.SelectNodes($"//div[@class='accordion']");

            var innerText = annotationNode.First().InnerText;
            var annotation = innerText.Replace("Abstract", String.Empty).Trim().Split(new[] { "Keywords" }, StringSplitOptions.None)[0];

            return annotation.TrimEnd();
        }
    }
}
