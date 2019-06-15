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

            List<AuthorData> objects = core.CreateAuthorsList();

           try
           {
                parsingResultGrid.DataSource = objects;
                if(!String.IsNullOrEmpty(biblPatternTextBox.Text))
                    bibliographTextBox.Text = core.GenerateBibliograpy(biblPatternTextBox.Text);
                pageRangeTextBox.Text = core.GetPageRange();
                doiTextBox.Text = core.GetDoi();
                refsCountTextBox.Text = core.GetReferenceCount();
                engTitleBtn_Click(this, null);
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            parsingResultGrid.ClearSelection();
            parsingResultGrid.DataSource = null;
            urlTextBox.Clear();
            bibliographTextBox.Clear();
            pageRangeTextBox.Clear();
            doiTextBox.Clear();
            refsCountTextBox.Clear();
            titleTextBox.Clear();
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

        private void engAnnotBtn_Click(object sender, EventArgs e)
        {
            var annotation = core.GetEnglishAnnotation();

            Clipboard.SetText(annotation);
        }

        private void ukrAnnotBtn_Click(object sender, EventArgs e)
        {
            var annotation = core.GetAnnotation("uk");

            Clipboard.SetText(annotation);
        }

        private void rusAnnotBtn_Click(object sender, EventArgs e)
        {
            var annotation = core.GetAnnotation("ru");

            Clipboard.SetText(annotation);
        }

        private void doiTextBox_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(doiTextBox.Text))
                Clipboard.SetText(doiTextBox.Text);
        }

        private void bibliographTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(bibliographTextBox.Text))
                Clipboard.SetText(bibliographTextBox.Text);
        }

    }
}
