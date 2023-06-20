namespace LabMenu
{
    partial class Form4
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
            siglabel = new Label();
            sigcb = new ComboBox();
            regcb = new CheckBox();
            filebt = new Button();
            sigbt = new Button();
            dopbt = new Button();
            clrbt = new Button();
            rcb = new RichTextBox();
            sigtb = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // siglabel
            // 
            siglabel.AutoSize = true;
            siglabel.Location = new Point(38, 35);
            siglabel.Name = "siglabel";
            siglabel.Size = new Size(126, 32);
            siglabel.TabIndex = 0;
            siglabel.Text = "Сигнатура";
            // 
            // sigcb
            // 
            sigcb.FormattingEnabled = true;
            sigcb.Location = new Point(38, 86);
            sigcb.Name = "sigcb";
            sigcb.Size = new Size(242, 40);
            sigcb.TabIndex = 1;
            sigcb.SelectedIndexChanged += sigcb_SelectedIndexChanged;
            sigcb.TextChanged += sigcb_TextChanged;
            // 
            // regcb
            // 
            regcb.AutoSize = true;
            regcb.Location = new Point(314, 88);
            regcb.Name = "regcb";
            regcb.Size = new Size(289, 36);
            regcb.TabIndex = 2;
            regcb.Text = "Не учитывать регистр";
            regcb.UseVisualStyleBackColor = true;
            regcb.CheckedChanged += regcb_CheckedChanged;
            // 
            // filebt
            // 
            filebt.Location = new Point(38, 167);
            filebt.Name = "filebt";
            filebt.Size = new Size(242, 68);
            filebt.TabIndex = 3;
            filebt.Text = "Открыть файл";
            filebt.UseVisualStyleBackColor = true;
            filebt.Click += filebt_Click;
            // 
            // sigbt
            // 
            sigbt.Location = new Point(314, 167);
            sigbt.Name = "sigbt";
            sigbt.Size = new Size(289, 68);
            sigbt.TabIndex = 4;
            sigbt.Text = "Выделить исключения";
            sigbt.UseVisualStyleBackColor = true;
            sigbt.Click += sigbt_Click;
            // 
            // dopbt
            // 
            dopbt.Location = new Point(664, 68);
            dopbt.Name = "dopbt";
            dopbt.Size = new Size(208, 74);
            dopbt.TabIndex = 5;
            dopbt.Text = "Доп.Задание";
            dopbt.UseVisualStyleBackColor = true;
            dopbt.Click += dopbt_Click;
            // 
            // clrbt
            // 
            clrbt.Location = new Point(664, 167);
            clrbt.Name = "clrbt";
            clrbt.Size = new Size(208, 68);
            clrbt.TabIndex = 6;
            clrbt.Text = "Очистить";
            clrbt.UseVisualStyleBackColor = true;
            // 
            // rcb
            // 
            rcb.Location = new Point(12, 549);
            rcb.Name = "rcb";
            rcb.Size = new Size(899, 287);
            rcb.TabIndex = 7;
            rcb.Text = "";
            rcb.TextChanged += rcb_TextChanged;
            // 
            // sigtb
            // 
            sigtb.Location = new Point(12, 274);
            sigtb.MinimumSize = new Size(899, 39);
            sigtb.Multiline = true;
            sigtb.Name = "sigtb";
            sigtb.ReadOnly = true;
            sigtb.Size = new Size(899, 269);
            sigtb.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(923, 849);
            Controls.Add(sigtb);
            Controls.Add(rcb);
            Controls.Add(clrbt);
            Controls.Add(dopbt);
            Controls.Add(sigbt);
            Controls.Add(filebt);
            Controls.Add(regcb);
            Controls.Add(sigcb);
            Controls.Add(siglabel);
            Name = "Form4";
            Text = "Лаб4_Смертин_3135";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label siglabel;
        private ComboBox sigcb;
        private CheckBox regcb;
        private Button filebt;
        private Button sigbt;
        private Button dopbt;
        private Button clrbt;
        private RichTextBox rcb;
        private TextBox sigtb;
        private OpenFileDialog openFileDialog1;
    }
}