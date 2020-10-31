using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringParser_0._1.Core;
using StringParser_0._1.Objects;

namespace StringParser_0._1
{
    public partial class ContentGenerator : Form
    {
        ParserCore core;
        string newLine = Environment.NewLine;
        int prevCount;
        bool globalFlag = true;

        public ContentGenerator()
        {
            InitializeComponent();
        }

        private void ContentGenerator_Load(object sender, EventArgs e)
        {
            contentTextBox.Text = $"<h3>ЗМІСТ</h3>{newLine}";
            prevCount = 0;
            contentTextBox.ScrollBars = ScrollBars.Vertical;
            contentTextBox.WordWrap = false;
        }

        private void loadPageBtn_Click(object sender, EventArgs e)
        {
            core = new ParserCore(urlTextBox.Text);
            articleTitle.Text = core.GetArticleTitle();
            topicComboBox.DataSource = core.GetTopicsList();
            prevCount = 0;
        }

        private void insertNewTBtn_Click(object sender, EventArgs e)
        {
            contentTextBox.Text += GenerateNewTopic();
        }

        private string GenerateNewTopic()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(topicComboBox.Text) && !String.IsNullOrEmpty(articlesCountTextBox.Text))
            {
                int artCount = Int32.Parse(articlesCountTextBox.Text);
                if (globalFlag)
                {
                    sb.AppendLine($"{newLine}<b>{topicComboBox.Text.ToUpper()}</b>{newLine}");
                    sb.AppendLine("<ul>");
                }
                else
                {
                    sb.AppendLine($"<b>{topicComboBox.Text.ToUpper()}</b>");
                    sb.AppendLine($"<ul>{newLine}");
                }

                var elemCollection = core.GetCollectionOfContentElements();
                var takeSome = new List<ContentElement>();
                var check = artCount + prevCount;

                if(check > elemCollection.Count)
                {
                    MessageBox.Show($"You out of range of coleection!/n Elements in collection {elemCollection.Count}, you try to get on {check} index",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return "";
                }

                if(prevCount == 0)
                {
                    takeSome.AddRange(elemCollection.Take(artCount));
                    prevCount += artCount;
                    globalFlag = false;
                }
                else
                {
                    takeSome.AddRange(elemCollection.Skip(prevCount).Take(artCount));
                    prevCount += artCount;
                }

                foreach(var elem in takeSome)
                {
                    
                    sb.AppendLine($"<b>{elem.Authors}</b></br />");
                    sb.AppendLine("<a href="+'"'+"INSERTREFENCEHERE"+'"'+$">{elem.Title}</a><br /><br />");
                    sb.AppendLine(String.Empty);
                }
                sb.AppendLine("</ul>");

            }
            return sb.ToString();
        }
    }
}
