using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms___form_using_Regex_class
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailInputField = new System.Windows.Forms.TextBox();
            this.passwordInputField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordSubmitField = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rejestruj konto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj email:";
            // 
            // emailInputField
            // 
            this.emailInputField.Location = new System.Drawing.Point(127, 84);
            this.emailInputField.Name = "emailInputField";
            this.emailInputField.Size = new System.Drawing.Size(114, 22);
            this.emailInputField.TabIndex = 2;
            // 
            // passwordInputField
            // 
            this.passwordInputField.Location = new System.Drawing.Point(126, 162);
            this.passwordInputField.Name = "passwordInputField";
            this.passwordInputField.Size = new System.Drawing.Size(114, 22);
            this.passwordInputField.TabIndex = 3;
            this.passwordInputField.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Podaj hasło:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Powtórz hasło:";
            // 
            // passwordSubmitField
            // 
            this.passwordSubmitField.Location = new System.Drawing.Point(126, 226);
            this.passwordSubmitField.Name = "passwordSubmitField";
            this.passwordSubmitField.Size = new System.Drawing.Size(114, 22);
            this.passwordSubmitField.TabIndex = 6;
            this.passwordSubmitField.UseSystemPasswordChar = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(138, 271);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(86, 25);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Zatwierdź";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.Location = new System.Drawing.Point(127, 318);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(69, 16);
            this.greetingsLabel.TabIndex = 8;
            this.greetingsLabel.Text = "Komunikat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordSubmitField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordInputField);
            this.Controls.Add(this.emailInputField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
