namespace abugidaTypist
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.panelPicker = new System.Windows.Forms.Panel();
            this.buttonPrimary = new System.Windows.Forms.Button();
            this.textBoxBreakdown = new System.Windows.Forms.TextBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStripOutput = new System.Windows.Forms.MenuStrip();
            this.directionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordDirectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.word_ltr = new System.Windows.Forms.ToolStripMenuItem();
            this.word_rtl = new System.Windows.Forms.ToolStripMenuItem();
            this.word_ttb = new System.Windows.Forms.ToolStripMenuItem();
            this.word_btt = new System.Windows.Forms.ToolStripMenuItem();
            this.sentenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentence_ltr = new System.Windows.Forms.ToolStripMenuItem();
            this.sentence_rtl = new System.Windows.Forms.ToolStripMenuItem();
            this.sentence_ttb = new System.Windows.Forms.ToolStripMenuItem();
            this.sentence_btt = new System.Windows.Forms.ToolStripMenuItem();
            this.displayFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useMultipleFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useSingleFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillNullCharactersWithXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letterSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size32 = new System.Windows.Forms.ToolStripMenuItem();
            this.x40ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x80ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spacingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monospacedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spacingAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToWordDirectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInputExtras = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisSyllabaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGridHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.menuStripOutput.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxInput.Location = new System.Drawing.Point(0, 0);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(468, 110);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // panelPicker
            // 
            this.panelPicker.BackColor = System.Drawing.Color.White;
            this.panelPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicker.Controls.Add(this.buttonPrimary);
            this.panelPicker.Location = new System.Drawing.Point(1, 1);
            this.panelPicker.Name = "panelPicker";
            this.panelPicker.Size = new System.Drawing.Size(413, 355);
            this.panelPicker.TabIndex = 3;
            this.panelPicker.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPicker_Paint);
            this.panelPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPicker_MouseClick);
            this.panelPicker.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelPicker_MouseDoubleClick);
            // 
            // buttonPrimary
            // 
            this.buttonPrimary.BackgroundImage = global::abugidaTypist.Properties.Resources.prim2;
            this.buttonPrimary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrimary.FlatAppearance.BorderSize = 0;
            this.buttonPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimary.Location = new System.Drawing.Point(8, 3);
            this.buttonPrimary.Name = "buttonPrimary";
            this.buttonPrimary.Size = new System.Drawing.Size(70, 43);
            this.buttonPrimary.TabIndex = 0;
            this.buttonPrimary.UseVisualStyleBackColor = true;
            this.buttonPrimary.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBreakdown
            // 
            this.textBoxBreakdown.BackColor = System.Drawing.Color.White;
            this.textBoxBreakdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxBreakdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxBreakdown.Location = new System.Drawing.Point(0, 144);
            this.textBoxBreakdown.Multiline = true;
            this.textBoxBreakdown.Name = "textBoxBreakdown";
            this.textBoxBreakdown.ReadOnly = true;
            this.textBoxBreakdown.Size = new System.Drawing.Size(468, 110);
            this.textBoxBreakdown.TabIndex = 4;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelOutput);
            this.splitContainerMain.Panel1.Controls.Add(this.menuStripOutput);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxBreakdown);
            this.splitContainerMain.Panel1.Controls.Add(this.panelInputExtras);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxInput);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.AutoScroll = true;
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerMain.Panel2.Controls.Add(this.panelPicker);
            this.splitContainerMain.Size = new System.Drawing.Size(946, 595);
            this.splitContainerMain.SplitterDistance = 468;
            this.splitContainerMain.TabIndex = 5;
            // 
            // panelOutput
            // 
            this.panelOutput.AutoScroll = true;
            this.panelOutput.BackColor = System.Drawing.Color.White;
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(0, 278);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Padding = new System.Windows.Forms.Padding(30);
            this.panelOutput.Size = new System.Drawing.Size(468, 317);
            this.panelOutput.TabIndex = 5;
            // 
            // menuStripOutput
            // 
            this.menuStripOutput.BackColor = System.Drawing.Color.Transparent;
            this.menuStripOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directionsToolStripMenuItem,
            this.displayFormsToolStripMenuItem,
            this.sizingToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStripOutput.Location = new System.Drawing.Point(0, 254);
            this.menuStripOutput.Name = "menuStripOutput";
            this.menuStripOutput.Size = new System.Drawing.Size(468, 24);
            this.menuStripOutput.TabIndex = 6;
            this.menuStripOutput.Text = "menuStrip1";
            // 
            // directionsToolStripMenuItem
            // 
            this.directionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordDirectionToolStripMenuItem,
            this.sentenceToolStripMenuItem});
            this.directionsToolStripMenuItem.Name = "directionsToolStripMenuItem";
            this.directionsToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.directionsToolStripMenuItem.Text = "Directions";
            // 
            // wordDirectionToolStripMenuItem
            // 
            this.wordDirectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.word_ltr,
            this.word_rtl,
            this.word_ttb,
            this.word_btt});
            this.wordDirectionToolStripMenuItem.Name = "wordDirectionToolStripMenuItem";
            this.wordDirectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordDirectionToolStripMenuItem.Text = "Word";
            // 
            // word_ltr
            // 
            this.word_ltr.Name = "word_ltr";
            this.word_ltr.Size = new System.Drawing.Size(151, 22);
            this.word_ltr.Text = "Left to Right";
            // 
            // word_rtl
            // 
            this.word_rtl.Name = "word_rtl";
            this.word_rtl.Size = new System.Drawing.Size(151, 22);
            this.word_rtl.Text = "Right to Left";
            // 
            // word_ttb
            // 
            this.word_ttb.Name = "word_ttb";
            this.word_ttb.Size = new System.Drawing.Size(151, 22);
            this.word_ttb.Text = "Top to Bottom";
            // 
            // word_btt
            // 
            this.word_btt.Name = "word_btt";
            this.word_btt.Size = new System.Drawing.Size(151, 22);
            this.word_btt.Text = "Bottom to Top";
            // 
            // sentenceToolStripMenuItem
            // 
            this.sentenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sentence_ltr,
            this.sentence_rtl,
            this.sentence_ttb,
            this.sentence_btt});
            this.sentenceToolStripMenuItem.Name = "sentenceToolStripMenuItem";
            this.sentenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sentenceToolStripMenuItem.Text = "Sentence";
            // 
            // sentence_ltr
            // 
            this.sentence_ltr.Name = "sentence_ltr";
            this.sentence_ltr.Size = new System.Drawing.Size(151, 22);
            this.sentence_ltr.Text = "Left to Right";
            // 
            // sentence_rtl
            // 
            this.sentence_rtl.Name = "sentence_rtl";
            this.sentence_rtl.Size = new System.Drawing.Size(151, 22);
            this.sentence_rtl.Text = "Right to Left";
            // 
            // sentence_ttb
            // 
            this.sentence_ttb.Name = "sentence_ttb";
            this.sentence_ttb.Size = new System.Drawing.Size(151, 22);
            this.sentence_ttb.Text = "Top to Bottom";
            // 
            // sentence_btt
            // 
            this.sentence_btt.Name = "sentence_btt";
            this.sentence_btt.Size = new System.Drawing.Size(151, 22);
            this.sentence_btt.Text = "Bottom to Top";
            // 
            // displayFormsToolStripMenuItem
            // 
            this.displayFormsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useMultipleFormsToolStripMenuItem,
            this.useSingleFormToolStripMenuItem,
            this.fillNullCharactersWithXToolStripMenuItem});
            this.displayFormsToolStripMenuItem.Name = "displayFormsToolStripMenuItem";
            this.displayFormsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.displayFormsToolStripMenuItem.Text = "Display Forms";
            // 
            // useMultipleFormsToolStripMenuItem
            // 
            this.useMultipleFormsToolStripMenuItem.Name = "useMultipleFormsToolStripMenuItem";
            this.useMultipleFormsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.useMultipleFormsToolStripMenuItem.Text = "Use multiple forms";
            this.useMultipleFormsToolStripMenuItem.Click += new System.EventHandler(this.useMultipleFormsToolStripMenuItem_Click);
            // 
            // useSingleFormToolStripMenuItem
            // 
            this.useSingleFormToolStripMenuItem.Name = "useSingleFormToolStripMenuItem";
            this.useSingleFormToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.useSingleFormToolStripMenuItem.Text = "Use single form";
            this.useSingleFormToolStripMenuItem.Click += new System.EventHandler(this.useSingleFormToolStripMenuItem_Click);
            // 
            // fillNullCharactersWithXToolStripMenuItem
            // 
            this.fillNullCharactersWithXToolStripMenuItem.Name = "fillNullCharactersWithXToolStripMenuItem";
            this.fillNullCharactersWithXToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.fillNullCharactersWithXToolStripMenuItem.Text = "Fill null characters with X";
            this.fillNullCharactersWithXToolStripMenuItem.Click += new System.EventHandler(this.fillNullCharactersWithXToolStripMenuItem_Click);
            // 
            // sizingToolStripMenuItem
            // 
            this.sizingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letterSizeToolStripMenuItem,
            this.spacingToolStripMenuItem,
            this.spacingAspectToolStripMenuItem});
            this.sizingToolStripMenuItem.Name = "sizingToolStripMenuItem";
            this.sizingToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sizingToolStripMenuItem.Text = "Sizing";
            // 
            // letterSizeToolStripMenuItem
            // 
            this.letterSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.size32,
            this.x40ToolStripMenuItem,
            this.x60ToolStripMenuItem,
            this.x80ToolStripMenuItem});
            this.letterSizeToolStripMenuItem.Name = "letterSizeToolStripMenuItem";
            this.letterSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.letterSizeToolStripMenuItem.Text = "Letter size";
            // 
            // size32
            // 
            this.size32.Name = "size32";
            this.size32.Size = new System.Drawing.Size(103, 22);
            this.size32.Text = "32x32";
            // 
            // x40ToolStripMenuItem
            // 
            this.x40ToolStripMenuItem.Name = "x40ToolStripMenuItem";
            this.x40ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.x40ToolStripMenuItem.Text = "40x40";
            // 
            // x60ToolStripMenuItem
            // 
            this.x60ToolStripMenuItem.Name = "x60ToolStripMenuItem";
            this.x60ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.x60ToolStripMenuItem.Text = "60x60";
            // 
            // x80ToolStripMenuItem
            // 
            this.x80ToolStripMenuItem.Name = "x80ToolStripMenuItem";
            this.x80ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.x80ToolStripMenuItem.Text = "80x80";
            // 
            // spacingToolStripMenuItem
            // 
            this.spacingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monospacedToolStripMenuItem,
            this.tightToolStripMenuItem,
            this.wideToolStripMenuItem});
            this.spacingToolStripMenuItem.Name = "spacingToolStripMenuItem";
            this.spacingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spacingToolStripMenuItem.Text = "Spacing/Kerning";
            // 
            // monospacedToolStripMenuItem
            // 
            this.monospacedToolStripMenuItem.Name = "monospacedToolStripMenuItem";
            this.monospacedToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.monospacedToolStripMenuItem.Text = "Monospaced";
            // 
            // tightToolStripMenuItem
            // 
            this.tightToolStripMenuItem.Name = "tightToolStripMenuItem";
            this.tightToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.tightToolStripMenuItem.Text = "Tight";
            // 
            // wideToolStripMenuItem
            // 
            this.wideToolStripMenuItem.Name = "wideToolStripMenuItem";
            this.wideToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.wideToolStripMenuItem.Text = "Wide";
            // 
            // spacingAspectToolStripMenuItem
            // 
            this.spacingAspectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalOnlyToolStripMenuItem,
            this.verticalOnlyToolStripMenuItem,
            this.bothToolStripMenuItem,
            this.matchToWordDirectionToolStripMenuItem});
            this.spacingAspectToolStripMenuItem.Name = "spacingAspectToolStripMenuItem";
            this.spacingAspectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spacingAspectToolStripMenuItem.Text = "Kerning Aspect";
            // 
            // horizontalOnlyToolStripMenuItem
            // 
            this.horizontalOnlyToolStripMenuItem.Name = "horizontalOnlyToolStripMenuItem";
            this.horizontalOnlyToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.horizontalOnlyToolStripMenuItem.Text = "Horizontal only";
            // 
            // verticalOnlyToolStripMenuItem
            // 
            this.verticalOnlyToolStripMenuItem.Name = "verticalOnlyToolStripMenuItem";
            this.verticalOnlyToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.verticalOnlyToolStripMenuItem.Text = "Vertical only";
            // 
            // bothToolStripMenuItem
            // 
            this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
            this.bothToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.bothToolStripMenuItem.Text = "Both";
            // 
            // matchToWordDirectionToolStripMenuItem
            // 
            this.matchToWordDirectionToolStripMenuItem.Name = "matchToWordDirectionToolStripMenuItem";
            this.matchToWordDirectionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.matchToWordDirectionToolStripMenuItem.Text = "Match to word direction";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // panelInputExtras
            // 
            this.panelInputExtras.BackColor = System.Drawing.SystemColors.Control;
            this.panelInputExtras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputExtras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInputExtras.Font = new System.Drawing.Font("Arial", 12F);
            this.panelInputExtras.Location = new System.Drawing.Point(0, 110);
            this.panelInputExtras.Name = "panelInputExtras";
            this.panelInputExtras.Size = new System.Drawing.Size(468, 34);
            this.panelInputExtras.TabIndex = 7;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.thisSyllabaryToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(946, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // thisSyllabaryToolStripMenuItem
            // 
            this.thisSyllabaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGridHeadersToolStripMenuItem});
            this.thisSyllabaryToolStripMenuItem.Name = "thisSyllabaryToolStripMenuItem";
            this.thisSyllabaryToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.thisSyllabaryToolStripMenuItem.Text = "This Syllabary";
            // 
            // editGridHeadersToolStripMenuItem
            // 
            this.editGridHeadersToolStripMenuItem.Name = "editGridHeadersToolStripMenuItem";
            this.editGridHeadersToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editGridHeadersToolStripMenuItem.Text = "Edit grid headers";
            this.editGridHeadersToolStripMenuItem.Click += new System.EventHandler(this.editGridHeadersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(946, 619);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripOutput;
            this.Name = "Form1";
            this.Text = "Alphasyllabary Prototyper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPicker.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.menuStripOutput.ResumeLayout(false);
            this.menuStripOutput.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Panel panelPicker;
        private System.Windows.Forms.TextBox textBoxBreakdown;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.FlowLayoutPanel panelOutput;
        private System.Windows.Forms.MenuStrip menuStripOutput;
        private System.Windows.Forms.ToolStripMenuItem directionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordDirectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentence_ltr;
        private System.Windows.Forms.ToolStripMenuItem sentence_rtl;
        private System.Windows.Forms.ToolStripMenuItem sentence_ttb;
        private System.Windows.Forms.ToolStripMenuItem sentence_btt;
        private System.Windows.Forms.ToolStripMenuItem word_ltr;
        private System.Windows.Forms.ToolStripMenuItem word_rtl;
        private System.Windows.Forms.ToolStripMenuItem word_ttb;
        private System.Windows.Forms.ToolStripMenuItem word_btt;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Panel panelInputExtras;
        private System.Windows.Forms.Button buttonPrimary;
        private System.Windows.Forms.ToolStripMenuItem displayFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useMultipleFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useSingleFormToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisSyllabaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGridHeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letterSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size32;
        private System.Windows.Forms.ToolStripMenuItem x40ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x60ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x80ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spacingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monospacedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillNullCharactersWithXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spacingAspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchToWordDirectionToolStripMenuItem;
    }
}

