namespace WinForms___Radio
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelSort = new System.Windows.Forms.Panel();
            this.radioButton_HoareSort = new System.Windows.Forms.RadioButton();
            this.radioButton_LomutoSort = new System.Windows.Forms.RadioButton();
            this.radioButton_BubbleSort = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LosujButton = new System.Windows.Forms.Button();
            this.SizeInputField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberList = new System.Windows.Forms.Label();
            this.SortujButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SortedNumberList = new System.Windows.Forms.Label();
            this.panelSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSort
            // 
            this.panelSort.Controls.Add(this.SortujButton);
            this.panelSort.Controls.Add(this.radioButton_HoareSort);
            this.panelSort.Controls.Add(this.radioButton_LomutoSort);
            this.panelSort.Controls.Add(this.radioButton_BubbleSort);
            this.panelSort.Location = new System.Drawing.Point(96, 149);
            this.panelSort.Margin = new System.Windows.Forms.Padding(4);
            this.panelSort.Name = "panelSort";
            this.panelSort.Size = new System.Drawing.Size(184, 244);
            this.panelSort.TabIndex = 0;
            // 
            // radioButton_HoareSort
            // 
            this.radioButton_HoareSort.AutoSize = true;
            this.radioButton_HoareSort.Location = new System.Drawing.Point(49, 165);
            this.radioButton_HoareSort.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_HoareSort.Name = "radioButton_HoareSort";
            this.radioButton_HoareSort.Size = new System.Drawing.Size(66, 20);
            this.radioButton_HoareSort.TabIndex = 2;
            this.radioButton_HoareSort.TabStop = true;
            this.radioButton_HoareSort.Text = "Hoare";
            this.radioButton_HoareSort.UseVisualStyleBackColor = true;
            this.radioButton_HoareSort.CheckedChanged += new System.EventHandler(this.radioButton_HoareSort_CheckedChanged);
            // 
            // radioButton_LomutoSort
            // 
            this.radioButton_LomutoSort.AutoSize = true;
            this.radioButton_LomutoSort.Location = new System.Drawing.Point(49, 107);
            this.radioButton_LomutoSort.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_LomutoSort.Name = "radioButton_LomutoSort";
            this.radioButton_LomutoSort.Size = new System.Drawing.Size(72, 20);
            this.radioButton_LomutoSort.TabIndex = 1;
            this.radioButton_LomutoSort.TabStop = true;
            this.radioButton_LomutoSort.Text = "Lomuto";
            this.radioButton_LomutoSort.UseVisualStyleBackColor = true;
            this.radioButton_LomutoSort.CheckedChanged += new System.EventHandler(this.radioButton_LomutoSort_CheckedChanged);
            // 
            // radioButton_BubbleSort
            // 
            this.radioButton_BubbleSort.AutoSize = true;
            this.radioButton_BubbleSort.Location = new System.Drawing.Point(49, 41);
            this.radioButton_BubbleSort.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_BubbleSort.Name = "radioButton_BubbleSort";
            this.radioButton_BubbleSort.Size = new System.Drawing.Size(96, 20);
            this.radioButton_BubbleSort.TabIndex = 0;
            this.radioButton_BubbleSort.TabStop = true;
            this.radioButton_BubbleSort.Text = "Bąbelkowe";
            this.radioButton_BubbleSort.UseVisualStyleBackColor = true;
            this.radioButton_BubbleSort.CheckedChanged += new System.EventHandler(this.radioButton_BubbleSort_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sortowanie:";
            // 
            // LosujButton
            // 
            this.LosujButton.Location = new System.Drawing.Point(914, 149);
            this.LosujButton.Name = "LosujButton";
            this.LosujButton.Size = new System.Drawing.Size(75, 23);
            this.LosujButton.TabIndex = 2;
            this.LosujButton.Text = "LOSUJ";
            this.LosujButton.UseVisualStyleBackColor = true;
            this.LosujButton.Click += new System.EventHandler(this.LosujButton_Click);
            // 
            // SizeInputField
            // 
            this.SizeInputField.Location = new System.Drawing.Point(798, 149);
            this.SizeInputField.Name = "SizeInputField";
            this.SizeInputField.Size = new System.Drawing.Size(100, 22);
            this.SizeInputField.TabIndex = 3;
            this.SizeInputField.TextChanged += new System.EventHandler(this.SizeInputField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj rozmiar losowanej tablicy:";
            // 
            // NumberList
            // 
            this.NumberList.AutoSize = true;
            this.NumberList.Location = new System.Drawing.Point(396, 236);
            this.NumberList.MaximumSize = new System.Drawing.Size(700, 0);
            this.NumberList.Name = "NumberList";
            this.NumberList.Size = new System.Drawing.Size(75, 16);
            this.NumberList.TabIndex = 5;
            this.NumberList.Text = "[ lista liczb ]";
            // 
            // SortujButton
            // 
            this.SortujButton.Location = new System.Drawing.Point(49, 209);
            this.SortujButton.Name = "SortujButton";
            this.SortujButton.Size = new System.Drawing.Size(75, 23);
            this.SortujButton.TabIndex = 6;
            this.SortujButton.Text = "SORTUJ";
            this.SortujButton.UseVisualStyleBackColor = true;
            this.SortujButton.Click += new System.EventHandler(this.SortujButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wylosowane liczby: ";
            // 
            // SortedNumberList
            // 
            this.SortedNumberList.AutoSize = true;
            this.SortedNumberList.Location = new System.Drawing.Point(93, 473);
            this.SortedNumberList.Name = "SortedNumberList";
            this.SortedNumberList.Size = new System.Drawing.Size(156, 16);
            this.SortedNumberList.TabIndex = 7;
            this.SortedNumberList.Text = "[ posortowana lista liczb ]";
            this.SortedNumberList.Click += new System.EventHandler(this.SortedNumberList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 578);
            this.Controls.Add(this.SortedNumberList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeInputField);
            this.Controls.Add(this.LosujButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSort);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSort.ResumeLayout(false);
            this.panelSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelSort;
        private System.Windows.Forms.RadioButton radioButton_HoareSort;
        private System.Windows.Forms.RadioButton radioButton_LomutoSort;
        private System.Windows.Forms.RadioButton radioButton_BubbleSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LosujButton;
        private System.Windows.Forms.TextBox SizeInputField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumberList;
        private System.Windows.Forms.Button SortujButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SortedNumberList;
    }
}

