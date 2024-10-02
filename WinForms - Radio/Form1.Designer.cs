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
            this.radioButton_BubbleSort = new System.Windows.Forms.RadioButton();
            this.radioButton_LomutoSort = new System.Windows.Forms.RadioButton();
            this.radioButton_HoareSort = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSort
            // 
            this.panelSort.Controls.Add(this.radioButton_HoareSort);
            this.panelSort.Controls.Add(this.radioButton_LomutoSort);
            this.panelSort.Controls.Add(this.radioButton_BubbleSort);
            this.panelSort.Location = new System.Drawing.Point(631, 152);
            this.panelSort.Name = "panelSort";
            this.panelSort.Size = new System.Drawing.Size(249, 198);
            this.panelSort.TabIndex = 0;
            // 
            // radioButton_BubbleSort
            // 
            this.radioButton_BubbleSort.AutoSize = true;
            this.radioButton_BubbleSort.Location = new System.Drawing.Point(37, 33);
            this.radioButton_BubbleSort.Name = "radioButton_BubbleSort";
            this.radioButton_BubbleSort.Size = new System.Drawing.Size(78, 17);
            this.radioButton_BubbleSort.TabIndex = 0;
            this.radioButton_BubbleSort.TabStop = true;
            this.radioButton_BubbleSort.Text = "Bąbelkowe";
            this.radioButton_BubbleSort.UseVisualStyleBackColor = true;
            // 
            // radioButton_LomutoSort
            // 
            this.radioButton_LomutoSort.AutoSize = true;
            this.radioButton_LomutoSort.Location = new System.Drawing.Point(37, 87);
            this.radioButton_LomutoSort.Name = "radioButton_LomutoSort";
            this.radioButton_LomutoSort.Size = new System.Drawing.Size(60, 17);
            this.radioButton_LomutoSort.TabIndex = 1;
            this.radioButton_LomutoSort.TabStop = true;
            this.radioButton_LomutoSort.Text = "Lomuto";
            this.radioButton_LomutoSort.UseVisualStyleBackColor = true;
            // 
            // radioButton_HoareSort
            // 
            this.radioButton_HoareSort.AutoSize = true;
            this.radioButton_HoareSort.Location = new System.Drawing.Point(37, 134);
            this.radioButton_HoareSort.Name = "radioButton_HoareSort";
            this.radioButton_HoareSort.Size = new System.Drawing.Size(54, 17);
            this.radioButton_HoareSort.TabIndex = 2;
            this.radioButton_HoareSort.TabStop = true;
            this.radioButton_HoareSort.Text = "Hoare";
            this.radioButton_HoareSort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sortowanie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSort);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

