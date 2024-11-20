namespace WinForms___TODO2
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
            this.nameInputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.inputField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.showListButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameInputField
            // 
            this.nameInputField.Location = new System.Drawing.Point(85, 68);
            this.nameInputField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameInputField.Name = "nameInputField";
            this.nameInputField.Size = new System.Drawing.Size(76, 20);
            this.nameInputField.TabIndex = 0;
            this.nameInputField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj dane o sobie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Płeć:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.femaleRadioButton);
            this.panel1.Controls.Add(this.maleRadioButton);
            this.panel1.Location = new System.Drawing.Point(85, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 73);
            this.panel1.TabIndex = 4;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(10, 42);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(61, 17);
            this.femaleRadioButton.TabIndex = 1;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Kobieta";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(10, 12);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(78, 17);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Mężczyzna";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(85, 222);
            this.inputField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputField.Multiline = true;
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(99, 71);
            this.inputField.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "O sobie:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(304, 322);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(56, 19);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(45, 322);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 19);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showListButton
            // 
            this.showListButton.Location = new System.Drawing.Point(138, 322);
            this.showListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showListButton.Name = "showListButton";
            this.showListButton.Size = new System.Drawing.Size(80, 19);
            this.showListButton.TabIndex = 10;
            this.showListButton.Text = "Wyświetl listę";
            this.showListButton.UseVisualStyleBackColor = true;
            this.showListButton.Click += new System.EventHandler(this.showListButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(218, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(293, 269);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 366);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.showListButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInputField);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showListButton;
        private System.Windows.Forms.ListView listView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

