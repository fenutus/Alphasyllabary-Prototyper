namespace abugidaTypist
{
    partial class GlyphEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlyphEdit));
            this.labelTitle = new System.Windows.Forms.Label();
            this.radioButtonFormSingle = new System.Windows.Forms.RadioButton();
            this.groupBoxGlyphForms = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_g_final = new System.Windows.Forms.Panel();
            this.panel_g_initial = new System.Windows.Forms.Panel();
            this.panel_g_medial = new System.Windows.Forms.Panel();
            this.panel_g = new System.Windows.Forms.Panel();
            this.radioButtonFormsMultiple = new System.Windows.Forms.RadioButton();
            this.groupBoxMargins = new System.Windows.Forms.GroupBox();
            this.buttonResetMargins = new System.Windows.Forms.Button();
            this.buttonSetMargins = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStripDrawingTools = new System.Windows.Forms.ToolStrip();
            this.toolStripDraw = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonType = new System.Windows.Forms.ToolStripSplitButton();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripErase = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCommit = new System.Windows.Forms.ToolStripButton();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glyphBox = new CustomPictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxGlyphForms.SuspendLayout();
            this.groupBoxMargins.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStripDrawingTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glyphBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 24F);
            this.labelTitle.Location = new System.Drawing.Point(534, 15);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(97, 36);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Glyph";
            // 
            // radioButtonFormSingle
            // 
            this.radioButtonFormSingle.AutoSize = true;
            this.radioButtonFormSingle.Checked = true;
            this.radioButtonFormSingle.Location = new System.Drawing.Point(6, 23);
            this.radioButtonFormSingle.Name = "radioButtonFormSingle";
            this.radioButtonFormSingle.Size = new System.Drawing.Size(102, 20);
            this.radioButtonFormSingle.TabIndex = 5;
            this.radioButtonFormSingle.TabStop = true;
            this.radioButtonFormSingle.Text = "Single Form";
            this.radioButtonFormSingle.UseVisualStyleBackColor = true;
            // 
            // groupBoxGlyphForms
            // 
            this.groupBoxGlyphForms.Controls.Add(this.button1);
            this.groupBoxGlyphForms.Controls.Add(this.label4);
            this.groupBoxGlyphForms.Controls.Add(this.label3);
            this.groupBoxGlyphForms.Controls.Add(this.label2);
            this.groupBoxGlyphForms.Controls.Add(this.label1);
            this.groupBoxGlyphForms.Controls.Add(this.panel_g_final);
            this.groupBoxGlyphForms.Controls.Add(this.panel_g_initial);
            this.groupBoxGlyphForms.Controls.Add(this.panel_g_medial);
            this.groupBoxGlyphForms.Controls.Add(this.panel_g);
            this.groupBoxGlyphForms.Controls.Add(this.radioButtonFormsMultiple);
            this.groupBoxGlyphForms.Controls.Add(this.radioButtonFormSingle);
            this.groupBoxGlyphForms.Location = new System.Drawing.Point(540, 70);
            this.groupBoxGlyphForms.Name = "groupBoxGlyphForms";
            this.groupBoxGlyphForms.Size = new System.Drawing.Size(211, 331);
            this.groupBoxGlyphForms.TabIndex = 6;
            this.groupBoxGlyphForms.TabStop = false;
            this.groupBoxGlyphForms.Text = "Glyph Forms";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Copy Isolated Form to All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCopyToAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Medial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Initial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Isolated";
            // 
            // panel_g_final
            // 
            this.panel_g_final.BackColor = System.Drawing.Color.White;
            this.panel_g_final.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_g_final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_g_final.Location = new System.Drawing.Point(31, 238);
            this.panel_g_final.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_g_final.Name = "panel_g_final";
            this.panel_g_final.Size = new System.Drawing.Size(46, 46);
            this.panel_g_final.TabIndex = 33;
            // 
            // panel_g_initial
            // 
            this.panel_g_initial.BackColor = System.Drawing.Color.White;
            this.panel_g_initial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_g_initial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_g_initial.Location = new System.Drawing.Point(31, 130);
            this.panel_g_initial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_g_initial.Name = "panel_g_initial";
            this.panel_g_initial.Size = new System.Drawing.Size(46, 46);
            this.panel_g_initial.TabIndex = 31;
            // 
            // panel_g_medial
            // 
            this.panel_g_medial.BackColor = System.Drawing.Color.White;
            this.panel_g_medial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_g_medial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_g_medial.Location = new System.Drawing.Point(31, 184);
            this.panel_g_medial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_g_medial.Name = "panel_g_medial";
            this.panel_g_medial.Size = new System.Drawing.Size(46, 46);
            this.panel_g_medial.TabIndex = 32;
            // 
            // panel_g
            // 
            this.panel_g.BackColor = System.Drawing.Color.White;
            this.panel_g.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_g.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_g.Location = new System.Drawing.Point(31, 76);
            this.panel_g.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_g.Name = "panel_g";
            this.panel_g.Size = new System.Drawing.Size(46, 46);
            this.panel_g.TabIndex = 30;
            // 
            // radioButtonFormsMultiple
            // 
            this.radioButtonFormsMultiple.AutoSize = true;
            this.radioButtonFormsMultiple.Location = new System.Drawing.Point(6, 49);
            this.radioButtonFormsMultiple.Name = "radioButtonFormsMultiple";
            this.radioButtonFormsMultiple.Size = new System.Drawing.Size(118, 20);
            this.radioButtonFormsMultiple.TabIndex = 6;
            this.radioButtonFormsMultiple.Text = "Multiple Forms";
            this.radioButtonFormsMultiple.UseVisualStyleBackColor = true;
            this.radioButtonFormsMultiple.CheckedChanged += new System.EventHandler(this.radioButtonFormsMultiple_CheckedChanged);
            // 
            // groupBoxMargins
            // 
            this.groupBoxMargins.Controls.Add(this.buttonResetMargins);
            this.groupBoxMargins.Controls.Add(this.buttonSetMargins);
            this.groupBoxMargins.Location = new System.Drawing.Point(540, 407);
            this.groupBoxMargins.Name = "groupBoxMargins";
            this.groupBoxMargins.Size = new System.Drawing.Size(211, 94);
            this.groupBoxMargins.TabIndex = 7;
            this.groupBoxMargins.TabStop = false;
            this.groupBoxMargins.Text = "Margins";
            // 
            // buttonResetMargins
            // 
            this.buttonResetMargins.Location = new System.Drawing.Point(6, 56);
            this.buttonResetMargins.Name = "buttonResetMargins";
            this.buttonResetMargins.Size = new System.Drawing.Size(199, 29);
            this.buttonResetMargins.TabIndex = 4;
            this.buttonResetMargins.Text = "Reset Margins";
            this.buttonResetMargins.UseVisualStyleBackColor = true;
            this.buttonResetMargins.Click += new System.EventHandler(this.buttonResetMargins_Click);
            // 
            // buttonSetMargins
            // 
            this.buttonSetMargins.Location = new System.Drawing.Point(6, 22);
            this.buttonSetMargins.Name = "buttonSetMargins";
            this.buttonSetMargins.Size = new System.Drawing.Size(199, 28);
            this.buttonSetMargins.TabIndex = 3;
            this.buttonSetMargins.Text = "Draw Margins";
            this.buttonSetMargins.UseVisualStyleBackColor = true;
            this.buttonSetMargins.Click += new System.EventHandler(this.buttonSetMargins_Click);
            this.buttonSetMargins.MouseEnter += new System.EventHandler(this.buttonSetMargins_MouseEnter);
            this.buttonSetMargins.MouseLeave += new System.EventHandler(this.buttonSetMargins_MouseLeave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(676, 521);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 26);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.toolStripDrawingTools);
            this.panel4.Controls.Add(this.glyphBox);
            this.panel4.Location = new System.Drawing.Point(12, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 532);
            this.panel4.TabIndex = 9;
            // 
            // toolStripDrawingTools
            // 
            this.toolStripDrawingTools.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDrawingTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripDrawingTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDraw,
            this.toolStripSplitButtonType,
            this.toolStripErase,
            this.toolStripButtonClear,
            this.toolStripButtonImport,
            this.toolStripButtonCommit});
            this.toolStripDrawingTools.Location = new System.Drawing.Point(0, 500);
            this.toolStripDrawingTools.Name = "toolStripDrawingTools";
            this.toolStripDrawingTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripDrawingTools.Size = new System.Drawing.Size(500, 25);
            this.toolStripDrawingTools.TabIndex = 0;
            this.toolStripDrawingTools.Text = "toolStrip1";
            // 
            // toolStripDraw
            // 
            this.toolStripDraw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDraw.Name = "toolStripDraw";
            this.toolStripDraw.Size = new System.Drawing.Size(41, 22);
            this.toolStripDraw.Text = "Draw";
            this.toolStripDraw.Click += new System.EventHandler(this.toolStripDraw_Click);
            // 
            // toolStripSplitButtonType
            // 
            this.toolStripSplitButtonType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penToolStripMenuItem,
            this.inkToolStripMenuItem});
            this.toolStripSplitButtonType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonType.Image")));
            this.toolStripSplitButtonType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonType.Name = "toolStripSplitButtonType";
            this.toolStripSplitButtonType.Size = new System.Drawing.Size(55, 22);
            this.toolStripSplitButtonType.Text = "(Pen)";
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.penToolStripMenuItem.Text = "Pen";
            this.penToolStripMenuItem.Click += new System.EventHandler(this.penToolStripMenuItem_Click);
            // 
            // inkToolStripMenuItem
            // 
            this.inkToolStripMenuItem.Name = "inkToolStripMenuItem";
            this.inkToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.inkToolStripMenuItem.Text = "Ink";
            this.inkToolStripMenuItem.Click += new System.EventHandler(this.inkToolStripMenuItem_Click);
            // 
            // toolStripErase
            // 
            this.toolStripErase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripErase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripErase.Name = "toolStripErase";
            this.toolStripErase.Size = new System.Drawing.Size(46, 22);
            this.toolStripErase.Text = "Erase";
            this.toolStripErase.Click += new System.EventHandler(this.toolStripErase_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(42, 22);
            this.toolStripButtonClear.Text = "Clear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripButtonImport
            // 
            this.toolStripButtonImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonImport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImport.Image")));
            this.toolStripButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImport.Name = "toolStripButtonImport";
            this.toolStripButtonImport.Size = new System.Drawing.Size(48, 22);
            this.toolStripButtonImport.Text = "Import";
            this.toolStripButtonImport.Click += new System.EventHandler(this.toolStripButtonImport_Click);
            // 
            // toolStripButtonCommit
            // 
            this.toolStripButtonCommit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCommit.Name = "toolStripButtonCommit";
            this.toolStripButtonCommit.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCommit.Text = "Commit";
            this.toolStripButtonCommit.Click += new System.EventHandler(this.toolStripButtonCommit_Click);
            // 
            // glyphBox
            // 
            this.glyphBox.BackColor = System.Drawing.Color.White;
            this.glyphBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("glyphBox.BackgroundImage")));
            this.glyphBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.glyphBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glyphBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.glyphBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.glyphBox.ErrorImage = null;
            this.glyphBox.Location = new System.Drawing.Point(0, 0);
            this.glyphBox.Margin = new System.Windows.Forms.Padding(4);
            this.glyphBox.Name = "glyphBox";
            this.glyphBox.Size = new System.Drawing.Size(500, 500);
            this.glyphBox.TabIndex = 0;
            this.glyphBox.TabStop = false;
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.squareToolStripMenuItem.Text = "Square";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(540, 521);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 26);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // GlyphEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 561);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBoxMargins);
            this.Controls.Add(this.groupBoxGlyphForms);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlyphEdit";
            this.Text = "Glyph Edit";
            this.groupBoxGlyphForms.ResumeLayout(false);
            this.groupBoxGlyphForms.PerformLayout();
            this.groupBoxMargins.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStripDrawingTools.ResumeLayout(false);
            this.toolStripDrawingTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glyphBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomPictureBox glyphBox;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonFormSingle;
        private System.Windows.Forms.GroupBox groupBoxGlyphForms;
        private System.Windows.Forms.RadioButton radioButtonFormsMultiple;
        private System.Windows.Forms.GroupBox groupBoxMargins;
        private System.Windows.Forms.Button buttonSetMargins;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonResetMargins;
        private System.Windows.Forms.Panel panel_g_final;
        private System.Windows.Forms.Panel panel_g_initial;
        private System.Windows.Forms.Panel panel_g_medial;
        private System.Windows.Forms.Panel panel_g;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStripDrawingTools;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripDraw;
        private System.Windows.Forms.ToolStripButton toolStripErase;
        private System.Windows.Forms.ToolStripButton toolStripButtonCommit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonType;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inkToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonImport;
    }
}