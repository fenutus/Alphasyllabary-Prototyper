using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using static abugidaTypist.InternalTools;

namespace abugidaTypist
{
    public partial class GlyphEdit : Form
    {
        #region Initialise variables
        string glyph;
        string currentForm;
        bool drawingMargins = false;
        Pen p;
        Rectangle viewWindow;
        bool formsMultiple = false;
        Image[] pages = new Image[4];
        int page = 0;
        List<string> forms = new List<string> { "", "_initial", "_medial", "_final" };
        List<Panel> formPanels;
        Form1 parent;
        #endregion Initialise variables

        public GlyphEdit()
        {
            InitializeComponent();
        }

        public GlyphEdit(Form1 f, string glyph)
        {
            InitializeComponent();
            labelTitle.Text = glyph;
            this.glyph = glyph;
            parent = f;

            formPanels = new List<Panel> { panel_g, panel_g_initial, panel_g_medial, panel_g_final };
            currentForm = "";

            foreach (string s in forms)
            {
                string image = String.Format("{0}\\{1}{2}.png", f.repository, glyph, s);
                if (File.Exists(image))
                {
                    using (Image im = Image.FromFile(image))
                    {
                        int i = forms.IndexOf(s);
                        pages[i] = im;
                        groupBoxGlyphForms.Controls.OfType<Panel>().Where(x => x.Name.Replace("panel_g", "") == s).First().BackgroundImage = im.GetThumbnailImage(500, 500, null, IntPtr.Zero);
                    }
                }
            }
            
            radioButtonFormSingle.CheckedChanged += delegate
            {
                if (radioButtonFormSingle.Checked)
                {
                    //TODO: move blue box
                    page = 0;
                    glyphBox.BackgroundImage = panel_g.BackgroundImage;
                }
            };

            //main image
            string fil = String.Format("{0}\\{1}.png", f.repository, glyph);
            if (File.Exists(fil))
            {
                using (Image im = Image.FromFile(fil))
                {
                    glyphBox.BackgroundImage = im.GetThumbnailImage(500, 500, null, IntPtr.Zero); //handles images not 500px
                }
            }

            viewWindow = new Rectangle(0, 0, 500, 500);
            p = new Pen(new SolidBrush(Color.Blue), 3);

            string indexFile = f.repository + "\\" + f.repository.Substring(f.repository.LastIndexOf("\\") + 1) + ".apt";
            viewWindow = GetLetterMargins(indexFile, f.repository, glyph, f.languageSettings);

            //when done drawing margin
            glyphBox.SelectionFinish += delegate (object sender, EventArgs e)
            {
                Rectangle r = (Rectangle)sender;
                string identifier = glyph + currentForm;
                if ((new int[] { r.Width, r.Height }).Any(x => x > 5))
                {
                    viewWindow = new Rectangle(Math.Max(r.Left, 0), Math.Max(0, r.Top), Math.Min(r.Width, 497 - Math.Max(r.Left, 0)), Math.Min(r.Height, 497 - Math.Max(0, r.Top)));
                    UpdateIndexFile(indexFile, identifier, String.Format("‡{0};{1},{2},{3},{4};", identifier,viewWindow.Left,viewWindow.Top, viewWindow.Width, viewWindow.Height));
                }
                else
                {
                    glyphBox.Invalidate();
                    viewWindow = new Rectangle(0, 0, 500, 500);
                    UpdateIndexFile(indexFile, identifier, null);
                }
                glyphBox_Paint(null, null);
                
                drawingMargins = false;
                glyphBox.Cursor = Cursors.Default;
                glyphBox.canMargin = false;
            };


            #region multiples initialisation

            //feature disabled: of each individual glyph haveing single/multiple switch
            radioButtonFormsMultiple.Checked = true;
            radioButtonFormSingle.Visible = false;
            radioButtonFormsMultiple.Visible = false;
            //

            List<Panel> boxes = new List<Panel>() { panel_g, panel_g_initial, panel_g_medial, panel_g_final };
            foreach (Panel p in boxes)
            {
                p.Click += delegate
                {
                    if (formsMultiple == true)
                    {
                        page = boxes.IndexOf(p);
                        Graphics gg = groupBoxGlyphForms.CreateGraphics();
                        gg.Clear(groupBoxGlyphForms.BackColor); //TODO: stop the box disappearing
                        gg.DrawRectangle(new Pen(new SolidBrush(Color.Blue), 6), p.Bounds);
                        glyphBox.BackgroundImage = p.BackgroundImage == null ? new Bitmap(500, 500) : p.BackgroundImage.GetThumbnailImage(500, 500, null, IntPtr.Zero);
                        currentForm = p.Name.Replace("panel_g", "");
                        viewWindow = GetLetterMargins(indexFile, f.repository, glyph +  currentForm, f.languageSettings);
                    }
                };
            }
            if (formsMultiple) //get is multiform from script settings
            {
                radioButtonFormsMultiple.Checked = true;
                Graphics gg = groupBoxGlyphForms.CreateGraphics();
                gg.DrawRectangle(new Pen(new SolidBrush(Color.Blue), 6), panel_g.Bounds);
            }

            #endregion multiples initialisation

            toolStripButtonCommit_Click(null, null); // ?? why is this needed??? 
        }

        #region Drawing
        private void glyphBox_Paint(object sender, PaintEventArgs e)
        {
            if ((MouseButtons & MouseButtons.Left) != MouseButtons.Left)
            {
                Graphics gg = glyphBox.CreateGraphics();
                gg.DrawRectangle(p, viewWindow);
            }
        }

        private void glyphBox_MouseDown(object sender, MouseEventArgs e)
        {
            viewWindow = new Rectangle(-5, -5, 900, 900);
            glyphBox.Refresh();
        }
        #endregion Drawing

        #region Right Panel Clicks
        private void toolStripButtonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.CheckFileExists = true;
            openFile.DefaultExt = "Portable Network Graphics|*.png";
            openFile.Filter = "Portable Network Graphics|*.png|JPEG|*.jpg";
            openFile.Multiselect = true;
            openFile.RestoreDirectory = true;
            openFile.Title = "Import glyph";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<string> names = openFile.FileNames.ToList();
                using (Image im = Image.FromFile(names[0]))
                {
                    glyphBox.BackgroundImage = im.GetThumbnailImage(500,500,null,IntPtr.Zero);
                }
            }
        }

        private void radioButtonFormsMultiple_CheckedChanged(object sender, EventArgs e)
        {
            formsMultiple = radioButtonFormsMultiple.Checked;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Panel> l = groupBoxGlyphForms.Controls.OfType<Panel>().OrderBy(x => x.TabIndex).ToList();
            for (int n = 0; n < 4; n++)
            {
                string nam = String.Format("{0}\\{1}{2}.png", parent.repository, labelTitle.Text, forms[n]);

                if (l[n].BackgroundImage != null)
                {
                    pages[n] = l[n].BackgroundImage;
                    Bitmap ppp = (Bitmap)pages[n].GetThumbnailImage(500, 500, null, IntPtr.Zero);
                    ppp.MakeTransparent(Color.White);
                    ppp.Save(nam, ImageFormat.Png);
                }
                else
                {
                    if (File.Exists(nam))
                        File.Delete(nam);
                }
            }
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        //clone
        private void buttonCopyToAll_Click(object sender, EventArgs e)
        {
            if (!panel_g.BackgroundImage.Equals(new Bitmap(500, 500)))
            {
                foreach (string s in new string[] { "_initial", "_medial", "_final" })
                {
                    var a = groupBoxGlyphForms.Controls.OfType<Panel>().Where(x => x.Name.Contains(s));
                    if (a.Count() > 0)
                    {
                        ((Panel)a.First()).BackgroundImage = panel_g.BackgroundImage;
                        ((Panel)a.First()).Invalidate();
                    }
                }
            }
        }

        #region > margins
        private void buttonSetMargins_Click(object sender, EventArgs e)
        {
            drawingMargins = true;
            glyphBox.Cursor = Cursors.Cross;
            glyphBox.canMargin = true;
        }

        private void buttonSetMargins_MouseEnter(object sender, EventArgs e)
        {
            glyphBox.window = viewWindow;
            glyphBox.isHover = true;
            glyphBox.Invalidate();
        }

        private void buttonSetMargins_MouseLeave(object sender, EventArgs e)
        {
            glyphBox.isHover = false;
            glyphBox.Invalidate();
        }

        private void buttonResetMargins_Click(object sender, EventArgs e)
        {
            glyphBox.Invalidate();
            viewWindow = new Rectangle(0, 0, 500, 500);
            string identifier = glyph + currentForm;
            UpdateIndexFile(parent.indexFile, identifier, null);
        }
        #endregion > margins

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all forms of this glyph?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (string s in forms)
                {
                    string image = String.Format("{0}\\{1}{2}.png", parent.repository, glyph, s);
                    if (File.Exists(image))
                    {
                        File.Delete(image);
                    }
                }
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
        #endregion Right Panel Clicks        

        #region menu items
        private void inkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glyphBox.soft = true;
            toolStripSplitButtonType.Text = "(Ink)";
        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glyphBox.soft = false;
            toolStripSplitButtonType.Text = "(Pen)";
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            glyphBox.BackgroundImage = new Bitmap(500,500);
        }

        private void toolStripButtonCommit_Click(object sender, EventArgs e)
        {
            if (radioButtonFormsMultiple.Checked)
            {
                pages[page] = glyphBox.BackgroundImage;
                Panel p = formPanels[page];
                p.BackgroundImage = glyphBox.BackgroundImage;
                p.Invalidate();
            }
            else
            {
                //page = 0;
                pages[0] = glyphBox.BackgroundImage;
                panel_g.BackgroundImage = glyphBox.BackgroundImage;
                panel_g.Invalidate();
            }

            glyphBox.canDraw = false;
            glyphBox.isErasing = false;
            DeselectItems(null); // = all
        }

        private void toolStripDraw_Click(object sender, EventArgs e)
        {
            if (glyphBox.isErasing)
            {
                glyphBox.isErasing = false;
            }
            else
            {
                glyphBox.canDraw = !glyphBox.canDraw;
            }
            toolStripDraw.BackColor = glyphBox.canDraw ? Color.Black : Color.Transparent;
            toolStripDraw.ForeColor = glyphBox.canDraw ? Color.White : Color.Black;
            DeselectItems(sender);
        }

        private void toolStripErase_Click(object sender, EventArgs e)
        {
            glyphBox.canDraw = true;
            glyphBox.isErasing = true;
            toolStripErase.BackColor = glyphBox.canDraw ? Color.Black : Color.Transparent;
            toolStripErase.ForeColor = glyphBox.canDraw ? Color.White : Color.Black;
            DeselectItems(sender);
        }
        #endregion menu items

        #region Functions
        private void DeselectItems(object sender)
        {
            foreach (ToolStripButton t in toolStripDrawingTools.Items.OfType<ToolStripButton>().Where(x => !x.Equals(sender)))
            {
                t.BackColor = Color.Transparent;
                t.ForeColor = Color.Black;
            }
            glyphBox.Invalidate();
        }

        #endregion Functions        
    }
}
