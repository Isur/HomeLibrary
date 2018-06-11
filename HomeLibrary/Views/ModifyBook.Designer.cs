namespace HomeLibrary.Views
{
    partial class ModifyBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelAuthorFrom = new System.Windows.Forms.Label();
            this.labelAuthorLastName = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.textBoxAuthorFrom = new System.Windows.Forms.TextBox();
            this.textBoxAuthorLastName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(97, 170);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(8, 171);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 26;
            this.buttonModify.Text = "Modyfikuj";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(19, 140);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(72, 13);
            this.labelYear.TabIndex = 25;
            this.labelYear.Text = "Rok Wydania";
            // 
            // labelAuthorFrom
            // 
            this.labelAuthorFrom.AutoSize = true;
            this.labelAuthorFrom.Location = new System.Drawing.Point(22, 114);
            this.labelAuthorFrom.Name = "labelAuthorFrom";
            this.labelAuthorFrom.Size = new System.Drawing.Size(69, 13);
            this.labelAuthorFrom.TabIndex = 24;
            this.labelAuthorFrom.Text = "Pochodzenie";
            // 
            // labelAuthorLastName
            // 
            this.labelAuthorLastName.AutoSize = true;
            this.labelAuthorLastName.Location = new System.Drawing.Point(5, 88);
            this.labelAuthorLastName.Name = "labelAuthorLastName";
            this.labelAuthorLastName.Size = new System.Drawing.Size(86, 13);
            this.labelAuthorLastName.TabIndex = 23;
            this.labelAuthorLastName.Text = "Nazwisko autora";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(32, 62);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(59, 13);
            this.labelAuthorName.TabIndex = 22;
            this.labelAuthorName.Text = "Imie autora";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(36, 36);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(55, 13);
            this.labelPublisher.TabIndex = 21;
            this.labelPublisher.Text = "Wydawca";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(59, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 13);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "Tytuł";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(97, 133);
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYear.TabIndex = 19;
            // 
            // textBoxAuthorFrom
            // 
            this.textBoxAuthorFrom.Location = new System.Drawing.Point(97, 107);
            this.textBoxAuthorFrom.Name = "textBoxAuthorFrom";
            this.textBoxAuthorFrom.Size = new System.Drawing.Size(120, 20);
            this.textBoxAuthorFrom.TabIndex = 18;
            // 
            // textBoxAuthorLastName
            // 
            this.textBoxAuthorLastName.Location = new System.Drawing.Point(97, 81);
            this.textBoxAuthorLastName.Name = "textBoxAuthorLastName";
            this.textBoxAuthorLastName.Size = new System.Drawing.Size(120, 20);
            this.textBoxAuthorLastName.TabIndex = 17;
            // 
            // textBoxAuthorFirstName
            // 
            this.textBoxAuthorFirstName.Location = new System.Drawing.Point(97, 55);
            this.textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
            this.textBoxAuthorFirstName.Size = new System.Drawing.Size(120, 20);
            this.textBoxAuthorFirstName.TabIndex = 16;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(97, 29);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(120, 20);
            this.textBoxPublisher.TabIndex = 15;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(97, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(120, 20);
            this.textBoxTitle.TabIndex = 14;
            // 
            // ModifyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelAuthorFrom);
            this.Controls.Add(this.labelAuthorLastName);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.textBoxAuthorFrom);
            this.Controls.Add(this.textBoxAuthorLastName);
            this.Controls.Add(this.textBoxAuthorFirstName);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "ModifyBook";
            this.Size = new System.Drawing.Size(219, 197);
            this.Load += new System.EventHandler(this.ModifyBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelAuthorFrom;
        private System.Windows.Forms.Label labelAuthorLastName;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.TextBox textBoxAuthorFrom;
        private System.Windows.Forms.TextBox textBoxAuthorLastName;
        private System.Windows.Forms.TextBox textBoxAuthorFirstName;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}
