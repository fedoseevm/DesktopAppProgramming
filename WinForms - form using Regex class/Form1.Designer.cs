namespace WinForms___form_using_Regex_class
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
            label1 = new Label();
            label2 = new Label();
            emailInputField = new TextBox();
            passwordInputField = new TextBox();
            label3 = new Label();
            label4 = new Label();
            passwordSubmitField = new TextBox();
            submitButton = new Button();
            greetingsLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 30);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Rejestruj konto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 61);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Podaj email:";
            // 
            // emailInputField
            // 
            emailInputField.Location = new Point(111, 79);
            emailInputField.Name = "emailInputField";
            emailInputField.Size = new Size(100, 23);
            emailInputField.TabIndex = 2;
            emailInputField.TextChanged += emailInputField_TextChanged;
            // 
            // passwordInputField
            // 
            passwordInputField.Location = new Point(110, 152);
            passwordInputField.Name = "passwordInputField";
            passwordInputField.Size = new Size(100, 23);
            passwordInputField.TabIndex = 3;
            passwordInputField.TextChanged += passwordInputField_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 134);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "Podaj hasło:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 194);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 5;
            label4.Text = "Powtórz hasło:";
            // 
            // passwordSubmitField
            // 
            passwordSubmitField.Location = new Point(110, 212);
            passwordSubmitField.Name = "passwordSubmitField";
            passwordSubmitField.Size = new Size(100, 23);
            passwordSubmitField.TabIndex = 6;
            passwordSubmitField.TextChanged += passwordSubmitField_TextChanged;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(121, 254);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 7;
            submitButton.Text = "Zatwierdź";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // greetingsLabel
            // 
            greetingsLabel.AutoSize = true;
            greetingsLabel.Location = new Point(111, 298);
            greetingsLabel.Name = "greetingsLabel";
            greetingsLabel.Size = new Size(34, 15);
            greetingsLabel.TabIndex = 8;
            greetingsLabel.Text = "Witaj";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(greetingsLabel);
            Controls.Add(submitButton);
            Controls.Add(passwordSubmitField);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passwordInputField);
            Controls.Add(emailInputField);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailInputField;
        private TextBox passwordInputField;
        private Label label3;
        private Label label4;
        private TextBox passwordSubmitField;
        private Button submitButton;
        private Label greetingsLabel;
    }
}
