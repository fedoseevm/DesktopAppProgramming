namespace WinForms___challenge_liczby_binarne
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextBox = new TextBox();
            button1 = new Button();
            outputLabel = new Label();
            inputTextBox2 = new TextBox();
            button2 = new Button();
            outputLabel2 = new Label();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(142, 98);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(100, 23);
            inputTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(142, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "n -> J(n)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(160, 206);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(38, 15);
            outputLabel.TabIndex = 2;
            outputLabel.Text = "label1";
            // 
            // inputTextBox2
            // 
            inputTextBox2.Location = new Point(539, 96);
            inputTextBox2.Name = "inputTextBox2";
            inputTextBox2.Size = new Size(100, 23);
            inputTextBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(549, 167);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "J(n) -> n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // outputLabel2
            // 
            outputLabel2.AutoSize = true;
            outputLabel2.Location = new Point(568, 206);
            outputLabel2.Name = "outputLabel2";
            outputLabel2.Size = new Size(38, 15);
            outputLabel2.TabIndex = 5;
            outputLabel2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputLabel2);
            Controls.Add(button2);
            Controls.Add(inputTextBox2);
            Controls.Add(outputLabel);
            Controls.Add(button1);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Button button1;
        private Label outputLabel;
        private TextBox inputTextBox2;
        private Button button2;
        private Label outputLabel2;
    }
}
