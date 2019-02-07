using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace abugidaTypist
{
    public partial class ThisSyllabary : Form
    {
        string indexFile;

        public ThisSyllabary(List<string> cols, List<string> rows, string filename)
        {
            InitializeComponent();
            this.indexFile = filename;

            textBoxCols.Text = String.Join(Environment.NewLine, cols);
            textBoxRows.Text = String.Join(Environment.NewLine, rows);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ///with the file sizes used in this program,FileStream is too clunky...
            ///whole file read as text, modified, then written out again.

            List<string> lines = File.ReadAllLines(indexFile).ToList<string>();
            //should always be line 2, so no checks
            lines[1] = String.Format("¬{0}¬{1}", textBoxCols.Text.Replace(Environment.NewLine,""), textBoxRows.Text.Replace(Environment.NewLine, ""));
            File.WriteAllLines(indexFile, lines, Encoding.Unicode);

            string repository = indexFile.Substring(0, indexFile.LastIndexOf("\\"));
            string[] dir = Directory.GetFiles(repository);
            foreach (string file in dir.Where(x => x != indexFile))
            {
                string ordinal = file.Substring(file.LastIndexOf("\\") + 1)[0].ToString();
                if (!textBoxCols.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Contains(ordinal)
                        && !textBoxRows.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Contains(ordinal))
                {
                    File.Delete(file);
                }
            }

            DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
