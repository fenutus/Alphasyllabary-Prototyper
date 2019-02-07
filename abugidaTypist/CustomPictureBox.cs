using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace abugidaTypist
{
    internal partial class CustomPictureBox : PictureBox
    {
        internal event EventHandler SelectionFinish;
        internal bool canMargin = false;
        internal bool canDraw = false;
        internal bool isErasing = false;
        internal bool soft = false;
        internal bool isHover = false;

        string shape = "circle";
        int fatness = 40;

        bool mouseDown = false;
        Point mouseDownPoint = Point.Empty;
        Point mousePoint = Point.Empty;
        Point mouseLast = Point.Empty;
        internal Rectangle window;
        SolidBrush b = new SolidBrush(Color.Black);

        internal Bitmap exportMe;
        internal Graphics g;
        Graphics drawForTansparency;
        Bitmap bitmapForTransparency;

        internal CustomPictureBox()
        {
            InitializeComponent();
            exportMe = new Bitmap(500, 500);
            BackgroundImage = exportMe;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            bitmapForTransparency = new Bitmap(Width, Height);
            drawForTansparency = Graphics.FromImage(bitmapForTransparency);
        }

        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            base.OnBackgroundImageChanged(e);
            if (BackgroundImage == null)
            {
                exportMe = new Bitmap(500, 500);
                g = Graphics.FromImage(new Bitmap(500, 500)); //Graphics.FromImage(BackgroundImage == null ? new Bitmap(500, 500) : new Bitmap(BackgroundImage));
            }
            else
            {
                exportMe = new Bitmap(BackgroundImage);
                //BackgroundImage = exportMe;
                g = Graphics.FromImage(BackgroundImage);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            mouseDown = true;
            mousePoint = mouseDownPoint = mouseLast = e.Location;

            if (canMargin)
            {
                Invalidate();
            }
            else if (canDraw)
            {
                //g = this.CreateGraphics();
                if (soft)
                {
                    bitmapForTransparency = new Bitmap(Width, Height);
                    drawForTansparency = Graphics.FromImage(bitmapForTransparency);
                }

                b = new SolidBrush(isErasing ? Color.White : Color.FromArgb(255, Color.Black));
                switch (shape)
                {
                    case "circle":
                        if (soft)
                            drawForTansparency.FillEllipse(b, e.X - fatness / 2, e.Y - fatness / 2, fatness, fatness);
                        else
                            g.FillEllipse(b, e.X - fatness / 2, e.Y - fatness / 2, fatness, fatness);
                        break;

                    case "square":
                        g.FillRectangle(b, e.X - fatness / 2, e.Y - fatness / 2, fatness, fatness);
                        break;
                }
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (canMargin)
            {
                base.OnMouseUp(e);
                if (mouseDown)
                {
                    //Invalidate();
                    SelectionFinish(window, null);
                }
            }
            mouseDown = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (canMargin)
            {    
                mousePoint = e.Location;
                if (mouseDown)
                    Invalidate();
            }
            else if (canDraw && mouseDown)
            {
                if (soft)
                    drawForTansparency.DrawLine(new Pen(b, fatness), mouseLast, e.Location);
                else
                    g.DrawLine(new Pen(b, fatness), mouseLast, e.Location);

                switch (shape)
                {
                    case "circle":
                        if (soft)
                            drawForTansparency.FillEllipse(b, e.X - fatness / 2, e.Y - fatness / 2, fatness, fatness);
                        else
                            g.FillEllipse(b, e.X - fatness / 2, e.Y - fatness / 2, fatness, fatness);
                        break;

                    case "square":
                        g.FillRectangle(b, e.X - fatness / 2, e.Y - fatness / 2, fatness, fatness);
                        break;
                }
                mouseLast = e.Location;

                if (soft)
                {
                    ColorMatrix matrix = new ColorMatrix();
                    matrix.Matrix33 = 0.03f;
                    ImageAttributes ia = new ImageAttributes();
                    ia.SetColorMatrix(matrix);
                    g.DrawImage(bitmapForTransparency, new Rectangle(0,0,Width,Height),0,0,Width,Height, GraphicsUnit.Pixel, ia);
                }
                else
                {
                    g.DrawImage(bitmapForTransparency, new Rectangle(0, 0, Width, Height));
                }

                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (canMargin && mouseDown)
            {
                Region r = new Region(this.ClientRectangle);
                window = new Rectangle(
                    Math.Min(mouseDownPoint.X, mousePoint.X),
                    Math.Min(mouseDownPoint.Y, mousePoint.Y),
                    Math.Abs(mouseDownPoint.X - mousePoint.X),
                    Math.Abs(mouseDownPoint.Y - mousePoint.Y));
                r.Xor(window);
                e.Graphics.FillRegion(new SolidBrush(Color.FromArgb(100, Color.Black)), r);
            }
            else if (isHover)
            {
                Region r = new Region(this.ClientRectangle);
                r.Xor(window);
                e.Graphics.FillRegion(new SolidBrush(Color.FromArgb(100, Color.Black)), r);
            }
        }
    }
}
