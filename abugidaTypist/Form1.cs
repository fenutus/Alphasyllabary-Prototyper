using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.IO;
using static abugidaTypist.InternalTools;

namespace abugidaTypist
{
    public partial class Form1 : Form 
    {
        int[] active = new int[2];
        Bitmap[] pages = new Bitmap[2];
        Bitmap nullimage = (Bitmap)(Properties.Resources._null).GetThumbnailImage(500, 500, null, IntPtr.Zero);

        #region language scope variables
        int w = 80;
        int h = 50;
        int marginLeft = 90;
        int marginTop = 50;

        List<string> headersCol = new List<string>(); //initialise needed for first open/no file
        List<string> headersRow = new List<string>();
        int rows = 0;
        int cols = 0;

        internal string repository;
        internal string indexFile;
        List<string> languageInfo;

        internal Dictionary<Property, object> languageSettings = new Dictionary<Property, object>()
        {
            {Property.SentenceDirection, FlowDirection.LeftToRight },
            {Property.WordDirection, FlowDirection.LeftToRight },
            {Property.Kerning, Kerning.Tight },
            {Property.FillBlanks, false },
            {Property.Sizing, new Size(32,32) },
            {Property.CharacterForms, CharacterForms.Multiple },
        };
        #endregion language scope variables

        public Form1()
        {
            InitializeComponent();

            buttonPrimary.Tag = false;

            #region menu event handlers
            //TODO: crop aspect, export
            //word
            foreach (ToolStripMenuItem m in wordDirectionToolStripMenuItem.DropDownItems)
            {
                m.Click += delegate
                {
                    string direction = m.Name.Replace("word_", "");
                    languageSettings[Property.WordDirection] = TextToFlow(direction);
                    UpdateIndexFile(indexFile, 2,String.Format("‰{0}‰{1}", direction,dictFlowDirection[(FlowDirection)languageSettings[Property.SentenceDirection]]));

                    foreach (ToolStripMenuItem mm in wordDirectionToolStripMenuItem.DropDownItems)
                    {
                        mm.Image = null;
                    }
                    m.Image = Properties.Resources.tick;

                    foreach (FlowLayoutPanel f in panelOutput.Controls.OfType<FlowLayoutPanel>())
                    {
                        textBoxInput_TextChanged(null, null);
                    }
                };
            }

            //Sentence
            foreach (ToolStripMenuItem m in sentenceToolStripMenuItem.DropDownItems)
            {
                m.Click += delegate
                {
                    string direction = m.Name.Replace("sentence_", "");
                    languageSettings[Property.SentenceDirection] = TextToFlow(direction);
                    UpdateIndexFile(indexFile, 2, String.Format("‰{0}‰{1}", dictFlowDirection[(FlowDirection)languageSettings[Property.WordDirection]], direction));

                    //remove tick from all
                    foreach (ToolStripMenuItem mm in sentenceToolStripMenuItem.DropDownItems)
                    {
                        mm.Image = null;
                    }
                    m.Image = Properties.Resources.tick;

                    languageSettings[Property.SentenceDirection] = TextToFlow(m.Name.Replace("sentence_", ""));
                    FlowPanelDirection((FlowDirection)languageSettings[Property.SentenceDirection], panelOutput);
                };
            }

            //menues
            foreach (ToolStripMenuItem m in spacingToolStripMenuItem.DropDownItems)
            {
                string hook = m.Text.Substring(0, 1).ToLower();
                Kerning k = dictKerning[hook];
                m.Click += delegate
                {
                    UpdateIndexFile(indexFile, 3, 1, Convert.ToChar(hook));
                    languageSettings[Property.Kerning] = k;
                    textBoxInput_TextChanged(null, null);
                };
            }
            foreach (ToolStripMenuItem m in letterSizeToolStripMenuItem.DropDownItems)
            {
                Size s = dictSizing[m.Text.Substring(0, 1).ToLower()];
                m.Click += delegate
                {
                    UpdateIndexFile(indexFile, 3, 5, Convert.ToChar(s.Height.ToString().Substring(0, 1)));
                    languageSettings[Property.Sizing] = s;
                    textBoxInput_TextChanged(null, null);
                };
            }
            #endregion menu event handlers

            //unimplemented
            spacingAspectToolStripMenuItem.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            active[0] = -1;
            active[1] = -1;

            ResizePicker();
            RedrawPicker();

            try
            {
                if (File.Exists(Properties.Settings.Default.lastFile))
                {
                    InitialiseLanguage(Properties.Settings.Default.lastFile);
                }
            }
            catch { }
        }

        private void InitialiseLanguage(string languageFile)
        {
            indexFile = languageFile;

            languageInfo = File.ReadAllLines(languageFile).ToList();

            if (languageInfo.Count > 0 && languageInfo[0].Length > 2 && languageInfo[0].Substring(0, 3) == "APT")
            {
                try
                {
                    repository = indexFile.Substring(0, indexFile.LastIndexOf("\\"));

                    //letters
                    List<string> temp = languageInfo.Where(x => x[0] == '¬').FirstOrDefault().Substring(1).Split('¬').ToList();
                    headersCol = Regex.Matches(temp[0], "\\w\\d?").OfType<Match>().Select(x => x.Value).ToList<string>();
                    headersRow = Regex.Matches(temp[1], "\\w\\d?").OfType<Match>().Select(x => x.Value).ToList<string>();
                    rows = headersRow.Count();
                    cols = headersCol.Count();

                    //directions
                    temp = languageInfo.Where(x => x[0] == '‰').FirstOrDefault().Substring(1).Split('‰').ToList();
                    languageSettings[Property.WordDirection] = TextToFlow(temp[0]);
                    languageSettings[Property.SentenceDirection] = TextToFlow(temp[1]);

                    FlowPanelDirection((FlowDirection)languageSettings[Property.SentenceDirection], panelOutput);

                    //kerning
                    string kern = languageInfo.Where(x => x[0] == '⁞').FirstOrDefault().Substring(1);
                    languageSettings[Property.Kerning] = dictKerning[kern.Substring(0, 1)];
                    languageSettings[Property.CharacterForms] = dictCharacterForms[kern.Substring(1, 1)];
                    languageSettings[Property.CropAspect] = dictCropAspects[kern.Substring(2, 1)];
                    languageSettings[Property.FillBlanks] = kern.Substring(3, 1) == "1";
                    languageSettings[Property.Sizing] = dictSizing[kern.Substring(4, 1)];

                    //insert buttons for non-base characters
                    panelInputExtras.Controls.Clear();
                    foreach (List<string> headers in new List<List<string>>() { headersCol, headersRow })
                    {
                        foreach (string c in headers)
                        {
                            if (c.ToCharArray()[0] > 255)
                            {
                                Button b = new Button()
                                {
                                    Text = c,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Width = panelInputExtras.Height - 3,
                                    Dock = DockStyle.Left
                                };

                                b.Click += delegate
                                {
                                    int s = textBoxInput.SelectionStart;
                                    textBoxInput.Text = textBoxInput.Text.Insert(s, b.Text);
                                    textBoxInput.Focus();
                                    textBoxInput.SelectionLength = 0;
                                    textBoxInput.SelectionStart = s + 1;
                                };

                                panelInputExtras.Controls.Add(b);
                            }
                        }
                    }

                    //resets if not first open
                    active = new int[] { -1, -1 };
                    pages = new Bitmap[2];
                    RedrawPicker();

                }
                catch
                {
                    MessageBox.Show("Sorry - unknown file error - is file corrupt?");
                }
            }
            else //not a valid file
            {
                MessageBox.Show("Bad file");
            }
        }

        #region Text Input
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxBreakdown.Clear();
            panelOutput.Controls.Clear();

            string regCol = String.Join("|", headersCol);
            string regRow = String.Join("|", headersRow);

            List<string> output = new List<string>();
            foreach (string block in Regex.Matches(textBoxInput.Text, "[^|\\b].*?\\b|.").OfType<Match>().Where(x => x.Value != " ").Select(x => x.Value))
            {
                if (Regex.Matches(block, "\\W").Count > 0)
                {
                    if (block != " ")
                        output.Add(block);
                }
                else
                {
                    MatchCollection match = Regex.Matches(block, String.Format("([{0}]\\d?[{1}]\\d?)|([{1}]\\d?[{0}]\\d?)", regCol, regRow));
                    List<string> l = match.OfType<Match>().Select(x => x.Value).ToList();
                    output.Add("(" + String.Join("-", l) + ")");

                    ///This whole flowPanel thing might be better done with calculations and drawing straight to the canvas
                    ///It would allow for glyph overlaps but more calcs will be needed for wrapping

                    FlowLayoutPanel flowPanel = new FlowLayoutPanel();
                    //for not foreach because of importance of glyph position
                    
                    for (int i = 0; i < l.Count; i++)
                    {
                        object tag = FormType.Isolated;
                        string fil = String.Format("{0}\\{1}.png", repository, l[i]);

                        if (languageSettings[Property.CharacterForms].Equals(CharacterForms.Multiple))
                        {
                            if (l.Count != 1)
                            {
                                if (i == 0)
                                {
                                    if (File.Exists(String.Format("{0}\\{1}_initial.png", repository, l[i])))
                                    {
                                        fil = String.Format("{0}\\{1}_initial.png", repository, l[i]);
                                        tag = FormType.Initial;
                                    }
                                }
                                else if (i == l.Count - 1)
                                {
                                    if (File.Exists(String.Format("{0}\\{1}_final.png", repository, l[i])))
                                    {
                                        fil = String.Format("{0}\\{1}_final.png", repository, l[i]);
                                        tag = FormType.Final;
                                    }
                                }
                                else
                                {
                                    if (File.Exists(String.Format("{0}\\{1}_medial.png", repository, l[i])))
                                    {
                                        fil = String.Format("{0}\\{1}_medial.png", repository, l[i]);
                                        tag = FormType.Medial;
                                    }
                                }
                            }
                        }

                        if (File.Exists(fil) || (bool)languageSettings[Property.FillBlanks])
                        {
                            Size s = (Size)languageSettings[Property.Sizing];
                            
                            Bitmap im;
                            if (File.Exists(fil))
                            {
                                using (Image image = Image.FromFile(fil))
                                {
                                    im = (Bitmap)image.GetThumbnailImage(500, 500, null, IntPtr.Zero);
                                }
                            }
                            else
                            {
                                im = nullimage;
                            }
                            Size characterSize = (Size)languageSettings[Property.Sizing];

                            //get crop data
                            Kerning k = (Kerning)languageSettings[Property.Kerning];

                            string extender = tag.Equals(FormType.Isolated) ? "" : "_" + tag.ToString().ToLower();
                            string glyph = l[i] + extender;
                            string line = languageInfo.Where(x => x.StartsWith("‡" + glyph +";")).FirstOrDefault();
                            if (line != null && k != Kerning.Monospace)
                            {
                                Rectangle r = GetLetterCropping(line, languageSettings);

                                Bitmap cropped = new Bitmap(r.Width, r.Height);

                                using (Graphics g = Graphics.FromImage(cropped))
                                {
                                    g.DrawImage(im, new Rectangle(0, 0, r.Width, r.Height), r, GraphicsUnit.Pixel);
                                }
                                im = cropped;
                            }
                            im.MakeTransparent(Color.White);
                            Panel p = new Panel() { BackgroundImage = im, BackgroundImageLayout = ImageLayout.Zoom, Size = characterSize, Tag = tag };
                            /// pfuture feature - on hover, highlight original in text box ///
                            
                            if (k != Kerning.Monospace)
                            {
                                FlowDirection f = (FlowDirection)languageSettings[Property.WordDirection];
                                if (f == FlowDirection.LeftToRight || f == FlowDirection.RightToLeft)
                                {
                                    p.Margin = new Padding((int)k / 2, 3, (int)k / 2, 3);
                                }
                                else
                                {
                                    p.Margin = new Padding(3,(int)k / 2, 3, (int)k / 2);
                                }

                                CropAspect aspect = (CropAspect)languageSettings[Property.CropAspect];
                                if (aspect != CropAspect.None)
                                {
                                    //v,b, or ttb
                                    if (aspect == CropAspect.Vertical || aspect == CropAspect.Both || (aspect == CropAspect.MatchedToWord && p.Margin.Left == 3))
                                    {
                                        p.Height = (int)(p.Height * p.BackgroundImage.Height / 500f);
                                    }
                                    if (aspect == CropAspect.Horizontal || aspect == CropAspect.Both || (aspect == CropAspect.MatchedToWord && p.Margin.Left != 3))
                                    {
                                        p.Width = (int)(p.Width * p.BackgroundImage.Width / 500f);
                                    }
                                }
                            }
                            flowPanel.Controls.Add(p);
                        }
                    }
                    FlowPanelDirection((FlowDirection)languageSettings[Property.WordDirection], flowPanel);
                    panelOutput.Controls.Add(flowPanel);
                }
            }
            textBoxBreakdown.Text = String.Join(" ", output);
        }
        #endregion END Text Input 

        private void FlowPanelDirection(FlowDirection direction, FlowLayoutPanel flowLayoutPanel)
        {
            Size characterSize = (Size)languageSettings[Property.Sizing];
            flowLayoutPanel.FlowDirection = direction;

            if (flowLayoutPanel != panelOutput)
            {
                int a = ((Size)languageSettings[Property.Sizing]).Height;
                flowLayoutPanel.Height = direction.ToString().Contains("L") ? characterSize.Height + 6 : flowLayoutPanel.Controls.OfType<Control>().Sum(x => x.Height + x.Margin.Vertical) + 30;
                flowLayoutPanel.Width = direction.ToString().Contains("L") ? flowLayoutPanel.Controls.OfType<Control>().Sum(x => x.Width + x.Margin.Horizontal) + 30 : characterSize.Width + 6;
                
            }
        }

        private void panelPicker_Paint(object sender, PaintEventArgs e)
        {
            if (active != null && active.All(x => x != -1))
            {
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 3), active[0] * w + marginLeft, active[1] * h + marginTop, w, h);
            }
        }

        private FlowDirection TextToFlow(string w)
        {
            switch (w)
            {
                case "ltr":
                default:
                    return (FlowDirection.LeftToRight);

                case "rtl":
                    return (FlowDirection.RightToLeft);

                case "ttb":
                    return(FlowDirection.TopDown);

                case "btt":
                    return (FlowDirection.BottomUp);
            }
        }

        private void RedrawPicker()
        {
            Bitmap bit = new Bitmap(cols * w + marginLeft + 6, rows * h + marginTop + 6);
            Graphics g = Graphics.FromImage(bit);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Font font = new Font("Arial", 23.5f);

            g.DrawLine(new Pen(Color.Black, 3), new Point(marginLeft, 0), new Point(marginLeft, rows * h + marginTop));
            g.DrawLine(new Pen(Color.Black, 3), new Point(0, marginTop), new Point(cols * w + marginLeft, marginTop));

            for (int i = 0; i < cols; i++)
            {
                int x = marginLeft + (i + 1) * w;

                //column headers
                if (i < headersCol.Count)
                {
                    g.DrawString(headersCol[i], font, b, x - (w / 2), marginTop / 2, format);
                }
                g.DrawLine(p, new Point(x, 0), new Point(x, rows * h + marginTop));

                for (int j = 0; j < rows; j++)
                {
                    int y = marginTop + (j + 1) * h;
                    g.DrawLine(p, new Point(0, y), new Point(cols * w + marginLeft, y));

                    //draw characters
                    if (j < headersRow.Count)
                    {
                        string fil = String.Format(((bool)buttonPrimary.Tag == false) ? "{0}\\{1}{2}.png" : "{0}\\{2}{1}.png", repository, headersRow[j], headersCol[i]);
                        if (File.Exists(fil))
                        {
                            using (Image im = Image.FromFile(fil))
                            {
                                float newWidth = (float)h / (float)im.Width * (float)im.Height;
                                g.DrawImage(im, i * w + marginLeft + (w - newWidth)/2, j * h + marginTop, newWidth, h);

                                if (File.Exists(fil.Substring(0,fil.Length-4) + "_final.png"))
                                {
                                    g.FillEllipse(new SolidBrush(Color.Blue), (i + 1) * w + marginLeft - 9, (j + 1) * h + marginTop - 9, 6, 6);
                                }
                                if (File.Exists(fil.Substring(0, fil.Length - 4) + "_medial.png"))
                                {
                                    g.FillEllipse(new SolidBrush(Color.Red), (i + 1) * w + marginLeft - 9, (j + 1) * h + marginTop - 18, 6, 6);
                                }
                                if (File.Exists(fil.Substring(0, fil.Length - 4) + "_initial.png"))
                                {
                                    g.FillEllipse(new SolidBrush(Color.Green), (i + 1) * w + marginLeft - 9, (j + 1) * h + marginTop - 27, 6, 6);
                                }
                            }
                        }
                    }
                }  
            }

            //row headers
            for (int j = 0; j < rows; j++)
            {
                int y = marginTop + (j + 1) * h;
                g.DrawLine(p, new Point(0, y), new Point(cols * w + marginLeft, y));

                if (j < headersRow.Count)
                {
                    g.DrawString(headersRow[j], font, b, marginLeft / 2, y - h / 2, format);
                }
            }

            panelPicker.BackgroundImageLayout = ImageLayout.None;
            panelPicker.BackgroundImage = bit;
            if (pages[((bool)buttonPrimary.Tag == true) ? 1 : 0] == null)
            {
                pages[((bool)buttonPrimary.Tag == true) ? 1 : 0] = bit;
            }
            ResizePicker();
        }

        #region Picker panel
        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: have a paging thing for things like initial, medial, final - or have in the edit popup?
            //would need graphical indicator on table  - coloured circles in bottim right?

            if ((bool)buttonPrimary.Tag == false)
            {
                buttonPrimary.Tag = true;
                buttonPrimary.BackgroundImage = Properties.Resources.prim;
                if (pages[1] == null)
                {
                    RedrawPicker();
                }
                else
                {
                    panelPicker.BackgroundImage = pages[1];
                }
            }
            else
            {
                buttonPrimary.Tag = false;
                buttonPrimary.BackgroundImage = Properties.Resources.prim2;

                if (pages[0] == null)
                {
                    RedrawPicker();
                }
                else
                {
                    panelPicker.BackgroundImage = pages[0];
                }
            }
            //panelPicker.Refresh();
            //RefreshPicker();
        }

        private void ResizePicker()
        {
            panelPicker.Width = cols * w + marginLeft + 2;
            panelPicker.Height = rows * h + marginTop + 2;
        }
        #endregion Picker panel

        #region mouse clicks
        private int[] ItemCoords(Point p)
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Rectangle r = new Rectangle(i * w + marginLeft, j * h + marginTop, w, h);
                    if (r.Contains(p))
                    {
                        return (new int[2] { i,j } );
                    }
                }
            }
            return (null);
        }

        private void panelPicker_MouseClick(object sender, MouseEventArgs e)
        {
            int[] temp = ItemCoords(e.Location);
            if (temp != null && !Enumerable.SequenceEqual(temp, active))
            {
                active = temp;
                panelPicker.Refresh();
            }
        }

        private void panelPicker_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GlyphEdit form = new GlyphEdit(this, String.Format((bool)buttonPrimary.Tag ? "{1}{0}" : "{0}{1}", headersRow[active[1]], headersCol[active[0]]));
            if (form.ShowDialog() == DialogResult.Yes)
            {
                RedrawPicker(); 
            }
            languageInfo = File.ReadAllLines(indexFile).ToList();
            textBoxInput_TextChanged(null, null);
        }
        #endregion mouse clicks

        #region MENUES
        #region main menu
        //new
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Abugida ProtoType|*.apt";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string folder = sfd.FileName.Replace(".apt", "");
                string name = sfd.FileName;
                string aptSaveFile = folder + "\\" + name.Substring(name.LastIndexOf("\\") + 1);
                Directory.CreateDirectory(folder);
                using (StreamWriter writer = new StreamWriter(aptSaveFile, false, Encoding.UTF8)) //unicode??
                {
                    writer.WriteLine("APT");
                    writer.WriteLine("¬¬");
                    writer.WriteLine("‰ltr‰ltr");
                    writer.WriteLine("⁞mst04");
                }
                Properties.Settings.Default.lastFile = aptSaveFile;
                Properties.Settings.Default.Save();
                InitialiseLanguage(aptSaveFile);
            }
        }
        //open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Abugida ProtoType|*.apt";
            ofd.Multiselect = false;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    Properties.Settings.Default.lastFile = ofd.FileName;
                    Properties.Settings.Default.Save();
                    InitialiseLanguage(ofd.FileName);
                }
            }
        }
        //exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #region This Syllabary
        private void editGridHeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(indexFile))
            {
                ThisSyllabary syllabary = new ThisSyllabary(headersCol, headersRow, indexFile);
                if (syllabary.ShowDialog() == DialogResult.Yes)
                {
                    InitialiseLanguage(indexFile);
                    //TODO: delete files of removed letters
                }
            }
            else
            {
                MessageBox.Show("Syllabary index file not found. Before using this menu, you must open or create an alphasyllabary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion This Syllabary
        #endregion main menu

        #region > output menus
        #region >> display forms
        private void useMultipleFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateIndexFile(indexFile, 3, 2, 'm');
            languageSettings[Property.CharacterForms] = CharacterForms.Multiple;
            textBoxInput_TextChanged(null, null);
        }

        private void useSingleFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateIndexFile(indexFile, 3, 2, 's');
            languageSettings[Property.CharacterForms] = CharacterForms.Single;
            textBoxInput_TextChanged(null, null);
        }

        private void fillNullCharactersWithXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languageSettings[Property.FillBlanks] = !(bool)languageSettings[Property.FillBlanks];
            UpdateIndexFile(indexFile, 3, 4, Convert.ToInt16(languageSettings[Property.FillBlanks]).ToString()[0]);
            textBoxInput_TextChanged(null, null);
        }
        #endregion >>display forms

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Portable Network Graphic (*.png)|*.png";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int maxX = panelOutput.Controls.OfType<Panel>().Max(i => i.Location.X + i.Width);
                int maxY = panelOutput.Controls.OfType<Panel>().Max(i => i.Location.Y + i.Height);
                int minX = panelOutput.Controls.OfType<Panel>().Min(i => i.Location.X);
                int minY = panelOutput.Controls.OfType<Panel>().Min(i => i.Location.Y);
                int width = maxX - minX;
                int height = maxY - minY;

                Bitmap fullPanelImage = new Bitmap(panelOutput.Width, panelOutput.Height);
                panelOutput.BorderStyle = BorderStyle.None;
                panelOutput.DrawToBitmap(fullPanelImage, new Rectangle(0, 0, panelOutput.Width, panelOutput.Height));
                Bitmap outputImage = new Bitmap(width + panelOutput.Padding.Horizontal, height + panelOutput.Padding.Vertical);
                using (Graphics gg = Graphics.FromImage(outputImage))
                {
                    gg.FillRectangle(new SolidBrush(Color.White), 0, 0, outputImage.Width, outputImage.Height);
                    gg.DrawImage(fullPanelImage,
                        new Rectangle(panelOutput.Padding.Left, panelOutput.Padding.Top, outputImage.Width - panelOutput.Padding.Horizontal, outputImage.Height - panelOutput.Padding.Vertical),
                        new Rectangle(minX, minY, width, height),
                        GraphicsUnit.Pixel);
                }
                panelOutput.BorderStyle = BorderStyle.FixedSingle;


                outputImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        #endregion >output menus

        #endregion MENUES

    }
}
