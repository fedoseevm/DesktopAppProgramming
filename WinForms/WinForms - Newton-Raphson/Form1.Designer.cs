namespace WinForms___Newton_Raphson
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
            trackBar1 = new TrackBar();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            WindowsOutput = new Label();
            NROutput = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(210, 79);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(100, 23);
            inputTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(210, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "GOGOGO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(210, 144);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 154);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Precyzja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 87);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 4;
            label3.Text = "Wynik Windows'a: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(376, 154);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 5;
            label4.Text = "Wynik Newton-Raphson: ";
            // 
            // WindowsOutput
            // 
            WindowsOutput.AutoSize = true;
            WindowsOutput.Location = new Point(524, 87);
            WindowsOutput.Name = "WindowsOutput";
            WindowsOutput.Size = new Size(40, 15);
            WindowsOutput.TabIndex = 6;
            WindowsOutput.Text = "Liczba";
            // 
            // NROutput
            // 
            NROutput.AutoSize = true;
            NROutput.Location = new Point(533, 157);
            NROutput.Name = "NROutput";
            NROutput.Size = new Size(37, 15);
            NROutput.TabIndex = 7;
            NROutput.Text = "liczba";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NROutput);
            Controls.Add(WindowsOutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Button button1;
        private TrackBar trackBar1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label WindowsOutput;
        private Label NROutput;
    }
}
