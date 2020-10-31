using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringParser_0._1.Core;
using StringParser_0._1.Objects;

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

        [TestMethod]
        public void CreateAuthorsList()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/149/";
            var core = new ParserCore(url);

            var authorsList = core.CreateAuthorsList();
        }

        [TestMethod]
        public void GetnerateBibliography()
        {
            var url = "https://www.biopolymers.org.ua/content/30/2/149/";
            var core = new ParserCore(url);
            var pattern = "Название / ИОФамилия // Вiopolymers and Cell. — 2014. — Т. 30, № 3. — С. ХХ-ХХ. — Бібліогр.: ХХ назв. — англ.";

            var bibliography = core.GenerateBibliograpy(pattern);
        }

        [TestMethod]
        public void GetPageTopic()
        {
            var url = "https://www.biopolymers.org.ua/content/30/3/184/";
            var core = new ParserCore(url);

            var topic = core.GetPageTopic() ;
        }

        [TestMethod]
        public void GetCollectionOfContenElements()
        {
            var url = "https://www.biopolymers.org.ua/content/29/1/";
            var core = new ParserCore(url);

            var collection = core.GetCollectionOfContentElements();
        }

        [TestMethod]
        public void GetTopicsDivs()
        {
            var url = "https://www.biopolymers.org.ua/content/29/1/";
            var core = new ParserCore(url);

            var topicsDivs = core.GetDivsByClassContains("topic");
        }

        [TestMethod]
        public void GetArtTitle()
        {
            var url = "https://www.biopolymers.org.ua/content/29/1/";
            var core = new ParserCore(url);

            var title = core.GetArticleTitle();
        }

        [TestMethod]
        public void RemoveSpaces()
        {
            var elem = new ContentElement("Matvienko M. G., Pustovalov A. S., Dzerzhinsky N. E.", "BKBGj");

            var noSpacec = elem.RemoveWhitespaces("Matvienko M. G., Pustovalov A. S., Dzerzhinsky N. E.");
        }
    }
}
