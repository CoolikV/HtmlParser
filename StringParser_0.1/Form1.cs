using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringParser_0._1.Objects;
using StringParser_0._1.Core;

namespace StringParser_0._1
{
    public partial class Form1 : Form
    {
        private ParserCore core;

        public Form1()
        {
            InitializeComponent();
        }

        private void parseBtn_Click(object sender, EventArgs e)
        {
            core = new ParserCore(urlTextBox.Text);

            List<AuthorData> objects = new List<AuthorData>();
            string authorsString = core.GetAuthorsOnPage();

            string[] noCommas = authorsString.Split(',');

           try
           {
                for (int i = 0; i < noCommas.Length; i++)
                {
                    noCommas[i] = noCommas[i].Trim();

                    objects.Add(CreateParseObj(noCommas[i]));
                }

                parsingResultGrid.DataSource = objects;

                bibliographTextBox.Text = GenerateFIOBibliography(objects);

                pageRangeTextBox.Text = core.GetPageRange();

                doiTextBox.Text = core.GetDoi();

                refsCountTextBox.Text = core.GetReferenceCount();
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //urlTextBox.Clear();
        }

        static AuthorData CreateParseObj(string fio)
        {
            string[] res = fio.Split(' ');
           
            string initials = res.Length == 3 ? res[1] + res[2] : res[1];

            return new AuthorData(res[0], initials);
        }

        static string GenerateFIOBibliography(IList<AuthorData> parsings)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var obj in parsings)
            {
                sb.Append($"{obj.Initials} {obj.Surname}, ");
            }
            string result = sb.ToString();
            result = result.Remove(result.LastIndexOf(','), 1);

            return result.Trim();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            parsingResultGrid.ClearSelection();
            parsingResultGrid.DataSource = null;
            urlTextBox.Clear();
            bibliographTextBox.Clear();
        }

        private void bibliographTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(bibliographTextBox.Text))
                Clipboard.SetText(bibliographTextBox.Text);
        }

        private void parsingResultGrid_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = parsingResultGrid.CurrentCell.RowIndex;
            int columnindex = parsingResultGrid.CurrentCell.ColumnIndex;

            var cellValue = parsingResultGrid.Rows[rowindex].Cells[columnindex].Value.ToString();

            Clipboard.SetText(cellValue);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            parsingResultGrid.ClearSelection();
        }

        private void bibliographTextBox_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(bibliographTextBox.Text))
                Clipboard.SetText(bibliographTextBox.Text);
        }

        private void engTitleBtn_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = core.GetEnglishTitle();
            if (!String.IsNullOrEmpty(bibliographTextBox.Text))
                Clipboard.SetText(titleTextBox.Text);
        }

        private void ukrTitleBtn_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = core.GetTitle("uk");
            if (!String.IsNullOrEmpty(bibliographTextBox.Text))
                Clipboard.SetText(titleTextBox.Text);
        }

        private void rusTitleBtn_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = core.GetTitle("ru");
            if (!String.IsNullOrEmpty(bibliographTextBox.Text))
                Clipboard.SetText(titleTextBox.Text);
        }
    }
}
