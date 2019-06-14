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
using HtmlAgilityPack;

namespace StringParser_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void parseBtn_Click(object sender, EventArgs e)
        {
            List<ParsingObj> objects = new List<ParsingObj>();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] noCommas = namesTextBox.Text.Split(',');
            try
            {
                for (int i = 0; i < noCommas.Length; i++)
                {
                    noCommas[i] = noCommas[i].Trim();

                    objects.Add(CreateParseObj(noCommas[i]));
                }

                parsingResultGrid.DataSource = objects;

                bibliographTextBox.Text = GenerateFIOBibliography(objects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            namesTextBox.Clear();
        }

        static ParsingObj CreateParseObj(string fio)
        {
            string[] res = fio.Split(' ');

            string initials = res.Length == 3 ? res[1] + res[2] : res[1];

            return new ParsingObj(res[0], initials);
        }

        static string GenerateFIOBibliography(IList<ParsingObj> parsings)
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
            namesTextBox.Clear();
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
    }
}
