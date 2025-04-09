namespace WinForms___design_formularz_cwiczenie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.labelImie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelHobby = new System.Windows.Forms.Label();
            this.labelProgres = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(54, 26);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 1;
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(54, 67);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiek.TabIndex = 2;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(19, 29);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(29, 13);
            this.labelImie.TabIndex = 3;
            this.labelImie.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wiek:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "piłka nożna",
            "pływanie",
            "czytanie"});
            this.checkedListBox1.Location = new System.Drawing.Point(54, 119);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labelProgres);
            this.groupBox1.Controls.Add(this.labelHobby);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxImie);
            this.groupBox1.Controls.Add(this.labelImie);
            this.groupBox1.Controls.Add(this.textBoxWiek);
            this.groupBox1.Location = new System.Drawing.Point(267, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 392);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(59, 242);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(121, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // labelHobby
            // 
            this.labelHobby.AutoSize = true;
            this.labelHobby.Location = new System.Drawing.Point(7, 119);
            this.labelHobby.Name = "labelHobby";
            this.labelHobby.Size = new System.Drawing.Size(41, 13);
            this.labelHobby.TabIndex = 7;
            this.labelHobby.Text = "Hobby:";
            // 
            // labelProgres
            // 
            this.labelProgres.AutoSize = true;
            this.labelProgres.Location = new System.Drawing.Point(7, 242);
            this.labelProgres.Name = "labelProgres";
            this.labelProgres.Size = new System.Drawing.Size(46, 13);
            this.labelProgres.TabIndex = 8;
            this.labelProgres.Text = "Progres:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rodzaj:";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(85, 354);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelHobby;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelProgres;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

