namespace WinForms___Wyniki_wyborow
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
            sqliteConnection1 = new Microsoft.Data.Sqlite.SqliteConnection();
            loadDBbtn = new Button();
            dataGridViewResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // sqliteConnection1
            // 
            sqliteConnection1.DefaultTimeout = 30;
            // 
            // loadDBbtn
            // 
            loadDBbtn.Location = new Point(353, 12);
            loadDBbtn.Name = "loadDBbtn";
            loadDBbtn.Size = new Size(90, 23);
            loadDBbtn.TabIndex = 0;
            loadDBbtn.Text = "Załaduj bazę";
            loadDBbtn.UseVisualStyleBackColor = true;
            loadDBbtn.Click += loadDBbtn_Click;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(275, 142);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new Size(240, 150);
            dataGridViewResults.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewResults);
            Controls.Add(loadDBbtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.Sqlite.SqliteConnection sqliteConnection1;
        private Button loadDBbtn;
        private DataGridView dataGridViewResults;
    }
}
