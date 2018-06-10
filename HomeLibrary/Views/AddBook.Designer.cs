namespace HomeLibrary.Views
{
    partial class AddBook
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxAuthorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorLastName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorFrom = new System.Windows.Forms.TextBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelAuthorLastName = new System.Windows.Forms.Label();
            this.labelAuthorFrom = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(95, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(120, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(95, 29);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(120, 20);
            this.textBoxPublisher.TabIndex = 1;
            // 
            // textBoxAuthorFirstName
            // 
            this.textBoxAuthorFirstName.Location = new System.Drawing.Point(95, 55);
            this.textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
            this.textBoxAuthorFirstName.Size = new System.Drawing.Size(120, 20);
            this.textBoxAuthorFirstName.TabIndex = 2;
            // 
            // textBoxAuthorLastName
            // 
            this.textBoxAuthorLastName.Location = new System.Drawing.Point(95, 81);
            this.textBoxAuthorLastName.Name = "textBoxAuthorLastName";
            this.textBoxAuthorLastName.Size = new System.Drawing.Size(120, 20);
            this.textBoxAuthorLastName.TabIndex = 3;
            // 
            // textBoxAuthorFrom
            // 
            this.textBoxAuthorFrom.Location = new System.Drawing.Point(95, 107);
            this.textBoxAuthorFrom.Name = "textBoxAuthorFrom";
            this.textBoxAuthorFrom.Size = new System.Drawing.Size(120, 20);
            this.textBoxAuthorFrom.TabIndex = 4;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(95, 133);
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYear.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(57, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Tytuł";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(34, 36);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(55, 13);
            this.labelPublisher.TabIndex = 7;
            this.labelPublisher.Text = "Wydawca";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(30, 62);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(59, 13);
            this.labelAuthorName.TabIndex = 8;
            this.labelAuthorName.Text = "Imie autora";
            // 
            // labelAuthorLastName
            // 
            this.labelAuthorLastName.AutoSize = true;
            this.labelAuthorLastName.Location = new System.Drawing.Point(3, 88);
            this.labelAuthorLastName.Name = "labelAuthorLastName";
            this.labelAuthorLastName.Size = new System.Drawing.Size(86, 13);
            this.labelAuthorLastName.TabIndex = 9;
            this.labelAuthorLastName.Text = "Nazwisko autora";
            // 
            // labelAuthorFrom
            // 
            this.labelAuthorFrom.AutoSize = true;
            this.labelAuthorFrom.Location = new System.Drawing.Point(20, 114);
            this.labelAuthorFrom.Name = "labelAuthorFrom";
            this.labelAuthorFrom.Size = new System.Drawing.Size(69, 13);
            this.labelAuthorFrom.TabIndex = 10;
            this.labelAuthorFrom.Text = "Pochodzenie";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(17, 140);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(72, 13);
            this.labelYear.TabIndex = 11;
            this.labelYear.Text = "Rok Wydania";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 171);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(95, 170);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
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
            this.Name = "AddBook";
            this.Size = new System.Drawing.Size(225, 203);
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxAuthorFirstName;
        private System.Windows.Forms.TextBox textBoxAuthorLastName;
        private System.Windows.Forms.TextBox textBoxAuthorFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelAuthorLastName;
        private System.Windows.Forms.Label labelAuthorFrom;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}
