namespace abugidaTypist
{
    partial class ThisSyllabary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThisSyllabary));
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCols = new System.Windows.Forms.TextBox();
            this.labelColumnsTitle = new System.Windows.Forms.Label();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.labelRowsTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(529, 484);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 28);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCols
            // 
            this.textBoxCols.Font = new System.Drawing.Font("Arial", 14F);
            this.textBoxCols.Location = new System.Drawing.Point(96, 38);
            this.textBoxCols.Multiline = true;
            this.textBoxCols.Name = "textBoxCols";
            this.textBoxCols.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCols.Size = new System.Drawing.Size(72, 475);
            this.textBoxCols.TabIndex = 1;
            // 
            // labelColumnsTitle
            // 
            this.labelColumnsTitle.AutoSize = true;
            this.labelColumnsTitle.Location = new System.Drawing.Point(93, 19);
            this.labelColumnsTitle.Name = "labelColumnsTitle";
            this.labelColumnsTitle.Size = new System.Drawing.Size(63, 16);
            this.labelColumnsTitle.TabIndex = 2;
            this.labelColumnsTitle.Text = "Columns";
            // 
            // textBoxRows
            // 
            this.textBoxRows.Font = new System.Drawing.Font("Arial", 14F);
            this.textBoxRows.Location = new System.Drawing.Point(15, 38);
            this.textBoxRows.Multiline = true;
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRows.Size = new System.Drawing.Size(72, 474);
            this.textBoxRows.TabIndex = 3;
            // 
            // labelRowsTitle
            // 
            this.labelRowsTitle.AutoSize = true;
            this.labelRowsTitle.Location = new System.Drawing.Point(12, 19);
            this.labelRowsTitle.Name = "labelRowsTitle";
            this.labelRowsTitle.Size = new System.Drawing.Size(42, 16);
            this.labelRowsTitle.TabIndex = 4;
            this.labelRowsTitle.Text = "Rows";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(183, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 120);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(183, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 73);
            this.label2.TabIndex = 6;
            this.label2.Text = "Any unicode character - Latin with modifiers, Cyrillic, Hebrew, IPA extensions - " +
    "can be used, or even a letter followed by a number. Capitals and non-capitals ar" +
    "e treated separately.";
            // 
            // ThisSyllabary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRowsTitle);
            this.Controls.Add(this.textBoxRows);
            this.Controls.Add(this.labelColumnsTitle);
            this.Controls.Add(this.textBoxCols);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThisSyllabary";
            this.ShowIcon = false;
            this.Text = "Settings: This Syllabary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCols;
        private System.Windows.Forms.Label labelColumnsTitle;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.Label labelRowsTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}