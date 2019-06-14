using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringParser_0._1.Core;

namespace ParserTests
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void GetAuthorsTag_ReturnsCollectionOfDivTags()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/149/";
            var core = new ParserCore(url);

            var divs = core.GetDivsByClassName("refnum");

            Console.WriteLine(divs);
        }

        [TestMethod]
        public void GetAuthorStings_ReturnsCollectionOf_AuthorNames()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/118/";
            var core = new ParserCore(url);

            var names = core.GetAuthorsOnPage();
        }

        [TestMethod]
        public void GetDOITest()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/149/";
            var core = new ParserCore(url);

            var doi = core.GetDoi();
        }

        [TestMethod]
        public void GetPageRangeTest()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/149/";
            var core = new ParserCore(url);

            var pageRange = core.GetPageRange();
        }

        [TestMethod]
        public void GetRefernceCountTest()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/129/";
            var core = new ParserCore(url);

            var refCount = core.GetReferenceCount();
        }

        [TestMethod]
        public void GetTitleTest()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/149/";
            var core = new ParserCore(url);

            var title = core.GetEnglishTitle();
        }

        [TestMethod]
        public void GetAnotherTitleLink()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/149/";
            var core = new ParserCore(url);

            var title = core.GetTitle("uk");
        }

        [TestMethod]
        public void GetAnnotation()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/149/";
            var core = new ParserCore(url);

            var annotation = core.GetAnnotation("ru");
        }
    }
}
