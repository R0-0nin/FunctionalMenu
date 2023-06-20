namespace LabMenu
{
    partial class TableEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(146, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1077, 487);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(146, 599);
            button1.Name = "button1";
            button1.Size = new Size(304, 83);
            button1.TabIndex = 1;
            button1.Text = "Отправить исключения";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(944, 599);
            button2.Name = "button2";
            button2.Size = new Size(304, 83);
            button2.TabIndex = 2;
            button2.Text = "Удалить исключения";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(586, 687);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(619, 623);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 36);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "По ID";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(654, 685);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(129, 39);
            numericUpDown1.TabIndex = 5;
            // 
            // TableEditor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 803);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "TableEditor";
            Text = "TableEditor";
            Load += TableEditor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
    }
}