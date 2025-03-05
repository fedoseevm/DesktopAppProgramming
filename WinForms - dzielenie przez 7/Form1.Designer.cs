namespace WinForms___dzielenie_przez_7
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
            inputField = new TextBox();
            confirmButton = new Button();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // inputField
            // 
            inputField.Location = new Point(190, 64);
            inputField.Name = "inputField";
            inputField.Size = new Size(100, 23);
            inputField.TabIndex = 0;
            inputField.TextChanged += inputField_TextChanged;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(142, 138);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(193, 23);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Czy liczba jest podzielna przez 7";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(213, 221);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(38, 15);
            outputLabel.TabIndex = 2;
            outputLabel.Text = "label1";
            outputLabel.Click += outputLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputLabel);
            Controls.Add(confirmButton);
            Controls.Add(inputField);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputField;
        private Button confirmButton;
        private Label outputLabel;
    }
}
