namespace WinForms___ToDo_Lista
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
            TimeInputBox = new TextBox();
            label1 = new Label();
            TaskDescInputBox = new TextBox();
            label2 = new Label();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            NotificationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TimeInputBox
            // 
            TimeInputBox.Location = new Point(226, 60);
            TimeInputBox.Name = "TimeInputBox";
            TimeInputBox.Size = new Size(100, 23);
            TimeInputBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 63);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 1;
            label1.Text = "Podaj godzinę wykonania zadania:";
            // 
            // TaskDescInputBox
            // 
            TaskDescInputBox.Location = new Point(226, 108);
            TaskDescInputBox.Name = "TaskDescInputBox";
            TaskDescInputBox.Size = new Size(100, 23);
            TaskDescInputBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 111);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "Podaj opis zadania:";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(37, 161);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 4;
            AddButton.Text = "Dodaj";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(471, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 5;
            // 
            // NotificationLabel
            // 
            NotificationLabel.AutoSize = true;
            NotificationLabel.Location = new Point(216, 165);
            NotificationLabel.Name = "NotificationLabel";
            NotificationLabel.Size = new Size(38, 15);
            NotificationLabel.TabIndex = 6;
            NotificationLabel.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NotificationLabel);
            Controls.Add(dataGridView1);
            Controls.Add(AddButton);
            Controls.Add(label2);
            Controls.Add(TaskDescInputBox);
            Controls.Add(label1);
            Controls.Add(TimeInputBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TimeInputBox;
        private Label label1;
        private TextBox TaskDescInputBox;
        private Label label2;
        private Button AddButton;
        private DataGridView dataGridView1;
        private Label NotificationLabel;
    }
}
