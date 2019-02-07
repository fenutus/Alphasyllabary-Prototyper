using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace abugidaTypist
{
    internal static class InternalTools
    {
        #region Attributes
        [FlagsAttribute]
        internal enum Property : int
        {
            WordDirection,
            SentenceDirection,
            Sizing,
            Kerning,
            FillBlanks,
            CharacterForms,
            CropAspect
        };

        [FlagsAttribute]
        internal enum Kerning : short
        {
            Tight = 0,
            Wide = 30,
            Monospace = -1
        };
        [FlagsAttribute]
        internal enum CharacterForms : short
        {
            Single,
            Multiple
        };
        [FlagsAttribute]
        internal enum FormType : short
        {
            Isolated,
            Initial,
            Medial,
            Final
        };
        [FlagsAttribute]
        internal enum CropAspect : short
        {
            Horizontal,
            Vertical,
            Both,
            MatchedToWord,
            None
        };
        #endregion Attributes

        #region Dictionaries
        internal static readonly Dictionary<string, CropAspect> dictCropAspects = new Dictionary<string, CropAspect>()
        {
            {"b", CropAspect.Both },
            {"h", CropAspect.Horizontal },
            {"v", CropAspect.Vertical },
            {"m", CropAspect.MatchedToWord },
            {"n", CropAspect.None },
        };
        internal static readonly Dictionary<string, CharacterForms> dictCharacterForms = new Dictionary<string, CharacterForms>()
        {
            {"s", CharacterForms.Single },
            {"m", CharacterForms.Multiple },
        };
        internal static readonly Dictionary<string, Kerning> dictKerning = new Dictionary<string, Kerning>()
        {
            {"t", Kerning.Tight },
            {"m", Kerning.Monospace },
            {"w", Kerning.Wide },
        };
        internal static readonly Dictionary<string, Size> dictSizing = new Dictionary<string, Size>()
        {
            {"3", new Size(32,32) },
            {"4", new Size(48,48) },
            {"6", new Size(60,60) },
            {"8", new Size(80,80) },
        };

        internal static readonly Dictionary<FlowDirection, string> dictFlowDirection = new Dictionary<FlowDirection, string>()
        {
            {FlowDirection.BottomUp, "btt" },
            {FlowDirection.TopDown, "ttb" },
            {FlowDirection.LeftToRight, "ltr" },
            {FlowDirection.RightToLeft, "rtl" },
        };
        #endregion Dictionaries

        internal static Rectangle GetLetterMargins(string indexFile, string repository, string glyph, Dictionary<Property, object> languageSettings)
        {
            Rectangle r = new Rectangle(0, 0, 500, 500);

            List<string> lines = File.ReadAllLines(indexFile).ToList<string>();
            IEnumerable<string> temp = lines.Where(x => x.StartsWith("‡" + glyph + ";"));
            if (temp.Count() > 0)
            {
                string line = temp.First();
                string pointsString = line.Trim().Split(';')[1];
                List<int> points = pointsString.Split(',').Select(x => Int32.Parse(x)).ToList();

                r = new Rectangle(points[0], points[1], points[2], points[3]);
            }
            return (r);
        }

        internal static Rectangle GetLetterMargins(string line)
        {
            Rectangle r = new Rectangle(0, 0, 500, 500);

            string pointsString = line.Trim().Split(';')[1];
            List<int> points = pointsString.Split(',').Select(x => Int32.Parse(x)).ToList();

            r = new Rectangle(points[0], points[1], points[2], points[3]);
            return (r);
        }

        internal static Rectangle GetLetterCropping(string indexFile, string repository, string glyph, Dictionary<Property, object> languageSettings)
        {
            Rectangle rr = GetLetterMargins(indexFile, repository, glyph, languageSettings);
            //List<string> lines = File.ReadAllLines(indexFile).ToList<string>();
            //IEnumerable<string> temp = lines.Where(x => x.StartsWith("‡" + glyph + ";"));
            //if (temp.Count() > 0)
            if (!rr.Equals(new Rectangle(0, 0, 500, 500)))
            {
                //string line = temp.First();
                //List<int> points = line.Trim().Substring(line.IndexOf(";") + 1).Split(',').Select(x => Int32.Parse(x)).ToList();


                Rectangle r = new Rectangle();
                CropAspect c = (CropAspect)languageSettings[Property.CropAspect];
                if ((Kerning)languageSettings[Property.Kerning] != Kerning.Monospace)
                {
                    if (c == CropAspect.Vertical || c == CropAspect.Both)
                    {
                        r = new Rectangle(0, rr.Y, 500, rr.Width);
                    }
                    else if (c == CropAspect.Horizontal || c == CropAspect.Both)
                    {
                        r = new Rectangle(rr.Width, 0, rr.Width, 500);
                    }
                    else if (c == CropAspect.Both)
                    {
                        r = new Rectangle(rr.X, rr.Y, rr.Width, rr.Height);
                    }
                    else if (c == CropAspect.MatchedToWord)
                    {
                        if (languageSettings[Property.WordDirection].Equals(FlowDirection.TopDown) ||
                            languageSettings[Property.WordDirection].Equals(FlowDirection.BottomUp))
                        {
                            r = new Rectangle(0, rr.Y, 500, rr.Height);
                        }
                        else
                        {
                            r = new Rectangle(rr.X, 0, rr.Width, 500);
                        }
                    }

                    return (r);
                }
                else
                {
                    return (rr);
                }
            }
            else
            {
                return (rr);
            }
        }
        internal static Rectangle GetLetterCropping(string line, Dictionary<Property, object> languageSettings)
        {
            Rectangle rr = GetLetterMargins(line);
            if (!rr.Equals(new Rectangle(0, 0, 500, 500)))
            {
                Rectangle r = new Rectangle();
                CropAspect c = (CropAspect)languageSettings[Property.CropAspect];
                if ((Kerning)languageSettings[Property.Kerning] != Kerning.Monospace)
                {
                    if (c == CropAspect.Vertical || c == CropAspect.Both)
                    {
                        r = new Rectangle(0, rr.Y, 500, rr.Width);
                    }
                    else if (c == CropAspect.Horizontal || c == CropAspect.Both)
                    {
                        r = new Rectangle(rr.Width, 0, rr.Width, 500);
                    }
                    else if (c == CropAspect.Both)
                    {
                        r = new Rectangle(rr.X, rr.Y, rr.Width, rr.Height);
                    }
                    else if (c == CropAspect.MatchedToWord)
                    {
                        if (languageSettings[Property.WordDirection].Equals(FlowDirection.TopDown) ||
                            languageSettings[Property.WordDirection].Equals(FlowDirection.BottomUp))
                        {
                            r = new Rectangle(0, rr.Y, 500, rr.Height);
                        }
                        else
                        {
                            r = new Rectangle(rr.X, 0, rr.Width, 500);
                        }
                    }

                    return (r);
                }
                else
                {
                    return (rr);
                }
            }
            else
            {
                return (rr);
            }
        }


        internal static void UpdateIndexFile(string indexFile, int lineNumber, int index, char newData)
        {
            List<string> lines = File.ReadAllLines(indexFile, Encoding.UTF8).ToList();
            StringBuilder sb = new StringBuilder(lines[lineNumber]);
            sb[index] = Convert.ToChar(newData);
            lines[lineNumber] = sb.ToString();
            File.WriteAllLines(indexFile, lines, Encoding.UTF8);
        }
        internal static void UpdateIndexFile(string indexFile, int lineNumber, string newData)
        {
            List<string> lines = File.ReadAllLines(indexFile, Encoding.UTF8).ToList();
            lines[lineNumber] = newData;
            File.WriteAllLines(indexFile, lines, Encoding.UTF8);
        }
        internal static void UpdateIndexFile(string indexFile, string glyph, string newData)
        {
            List<string> lines = File.ReadAllLines(indexFile, Encoding.UTF8).ToList();
            List<string> temp = lines.Where(x => x.StartsWith("‡" + glyph + ";")).ToList();

            if (temp.Count() > 0)
            {
                string line = temp.First();
                int lineNumber = lines.IndexOf(line);
                if (newData != null)
                {
                    lines[lineNumber] = newData;
                }
                else
                {
                    lines.RemoveAt(lineNumber);
                }
            }
            else if (newData != null)
            {
                lines.Add(newData);
            }

            File.WriteAllLines(indexFile, lines, Encoding.UTF8);
        }
    }
}
