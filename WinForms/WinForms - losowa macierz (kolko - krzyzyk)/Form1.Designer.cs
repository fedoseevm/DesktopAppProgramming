namespace WinForms___losowa_macierz__kolko___krzyzyk_
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
            components = new System.ComponentModel.Container();
            randomButton = new Button();
            imageList1 = new ImageList(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // randomButton
            // 
            randomButton.Location = new Point(363, 58);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(75, 23);
            randomButton.TabIndex = 1;
            randomButton.Text = "Losuj";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(250, 99);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(325, 325);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 208);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Wynik";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(randomButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button randomButton;
        private ImageList imageList1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}
