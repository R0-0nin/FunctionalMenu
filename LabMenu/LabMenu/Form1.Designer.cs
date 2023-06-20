namespace LabMenu
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
            menuStrip1 = new MenuStrip();
            лаб1ToolStripMenuItem = new ToolStripMenuItem();
            лаб2ToolStripMenuItem = new ToolStripMenuItem();
            лаб11ToolStripMenuItem = new ToolStripMenuItem();
            лаб12ToolStripMenuItem = new ToolStripMenuItem();
            допЗаданиеToolStripMenuItem = new ToolStripMenuItem();
            обАвтореToolStripMenuItem = new ToolStripMenuItem();
            лаб21ToolStripMenuItem = new ToolStripMenuItem();
            допЗаданиеToolStripMenuItem1 = new ToolStripMenuItem();
            лаб3ToolStripMenuItem = new ToolStripMenuItem();
            лабToolStripMenuItem = new ToolStripMenuItem();
            обАвтореToolStripMenuItem1 = new ToolStripMenuItem();
            журналЛоговToolStripMenuItem = new ToolStripMenuItem();
            отправитьИсключенияToolStripMenuItem = new ToolStripMenuItem();
            расшифровкаЛогжурналаToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            autodb = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { лаб1ToolStripMenuItem, лаб2ToolStripMenuItem, обАвтореToolStripMenuItem, лаб3ToolStripMenuItem, лабToolStripMenuItem, обАвтореToolStripMenuItem1, журналЛоговToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1486, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // лаб1ToolStripMenuItem
            // 
            лаб1ToolStripMenuItem.Name = "лаб1ToolStripMenuItem";
            лаб1ToolStripMenuItem.Size = new Size(103, 36);
            лаб1ToolStripMenuItem.Text = "Выйти";
            лаб1ToolStripMenuItem.Click += лаб1ToolStripMenuItem_Click;
            // 
            // лаб2ToolStripMenuItem
            // 
            лаб2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { лаб11ToolStripMenuItem, лаб12ToolStripMenuItem, допЗаданиеToolStripMenuItem });
            лаб2ToolStripMenuItem.Name = "лаб2ToolStripMenuItem";
            лаб2ToolStripMenuItem.Size = new Size(99, 36);
            лаб2ToolStripMenuItem.Text = "Лаб_1";
            // 
            // лаб11ToolStripMenuItem
            // 
            лаб11ToolStripMenuItem.Name = "лаб11ToolStripMenuItem";
            лаб11ToolStripMenuItem.Size = new Size(288, 44);
            лаб11ToolStripMenuItem.Text = "Лаб1_1";
            // 
            // лаб12ToolStripMenuItem
            // 
            лаб12ToolStripMenuItem.Name = "лаб12ToolStripMenuItem";
            лаб12ToolStripMenuItem.Size = new Size(288, 44);
            лаб12ToolStripMenuItem.Text = "Лаб1_2";
            // 
            // допЗаданиеToolStripMenuItem
            // 
            допЗаданиеToolStripMenuItem.Name = "допЗаданиеToolStripMenuItem";
            допЗаданиеToolStripMenuItem.Size = new Size(288, 44);
            допЗаданиеToolStripMenuItem.Text = "Доп.Задание";
            // 
            // обАвтореToolStripMenuItem
            // 
            обАвтореToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { лаб21ToolStripMenuItem, допЗаданиеToolStripMenuItem1 });
            обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            обАвтореToolStripMenuItem.Size = new Size(99, 36);
            обАвтореToolStripMenuItem.Text = "Лаб_2";
            обАвтореToolStripMenuItem.Click += обАвтореToolStripMenuItem_Click;
            // 
            // лаб21ToolStripMenuItem
            // 
            лаб21ToolStripMenuItem.Name = "лаб21ToolStripMenuItem";
            лаб21ToolStripMenuItem.Size = new Size(288, 44);
            лаб21ToolStripMenuItem.Text = "Лаб2_1";
            лаб21ToolStripMenuItem.Click += лаб21ToolStripMenuItem_Click;
            // 
            // допЗаданиеToolStripMenuItem1
            // 
            допЗаданиеToolStripMenuItem1.Name = "допЗаданиеToolStripMenuItem1";
            допЗаданиеToolStripMenuItem1.Size = new Size(288, 44);
            допЗаданиеToolStripMenuItem1.Text = "Доп.Задание";
            допЗаданиеToolStripMenuItem1.Click += допЗаданиеToolStripMenuItem1_Click;
            // 
            // лаб3ToolStripMenuItem
            // 
            лаб3ToolStripMenuItem.Name = "лаб3ToolStripMenuItem";
            лаб3ToolStripMenuItem.Size = new Size(99, 36);
            лаб3ToolStripMenuItem.Text = "Лаб_3";
            // 
            // лабToolStripMenuItem
            // 
            лабToolStripMenuItem.Name = "лабToolStripMenuItem";
            лабToolStripMenuItem.Size = new Size(99, 36);
            лабToolStripMenuItem.Text = "Лаб_4";
            лабToolStripMenuItem.Click += лабToolStripMenuItem_Click;
            // 
            // обАвтореToolStripMenuItem1
            // 
            обАвтореToolStripMenuItem1.Name = "обАвтореToolStripMenuItem1";
            обАвтореToolStripMenuItem1.Size = new Size(149, 36);
            обАвтореToolStripMenuItem1.Text = "Об авторе";
            обАвтореToolStripMenuItem1.Click += обАвтореToolStripMenuItem1_Click;
            // 
            // журналЛоговToolStripMenuItem
            // 
            журналЛоговToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отправитьИсключенияToolStripMenuItem, расшифровкаЛогжурналаToolStripMenuItem });
            журналЛоговToolStripMenuItem.Name = "журналЛоговToolStripMenuItem";
            журналЛоговToolStripMenuItem.Size = new Size(190, 36);
            журналЛоговToolStripMenuItem.Text = "Журнал логов";
            журналЛоговToolStripMenuItem.Click += журналЛоговToolStripMenuItem_Click;
            // 
            // отправитьИсключенияToolStripMenuItem
            // 
            отправитьИсключенияToolStripMenuItem.Name = "отправитьИсключенияToolStripMenuItem";
            отправитьИсключенияToolStripMenuItem.Size = new Size(487, 44);
            отправитьИсключенияToolStripMenuItem.Text = "Меню обработки исключений";
            отправитьИсключенияToolStripMenuItem.Click += отправитьИсключенияToolStripMenuItem_Click;
            // 
            // расшифровкаЛогжурналаToolStripMenuItem
            // 
            расшифровкаЛогжурналаToolStripMenuItem.Name = "расшифровкаЛогжурналаToolStripMenuItem";
            расшифровкаЛогжурналаToolStripMenuItem.Size = new Size(487, 44);
            расшифровкаЛогжурналаToolStripMenuItem.Text = "Расшифровка лог-журнала";
            расшифровкаЛогжурналаToolStripMenuItem.Click += расшифровкаЛогжурналаToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 129);
            richTextBox1.Margin = new Padding(6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1482, 831);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // autodb
            // 
            autodb.AutoSize = true;
            autodb.Location = new Point(28, 65);
            autodb.Name = "autodb";
            autodb.Size = new Size(258, 36);
            autodb.TabIndex = 2;
            autodb.Text = "Вести запись в БД?";
            autodb.UseVisualStyleBackColor = true;
            autodb.CheckedChanged += autodb_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(autodb);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Лаб.Меню.3135_Смертин";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem лаб1ToolStripMenuItem;
        private ToolStripMenuItem лаб2ToolStripMenuItem;
        private ToolStripMenuItem лаб11ToolStripMenuItem;
        private ToolStripMenuItem лаб12ToolStripMenuItem;
        private ToolStripMenuItem допЗаданиеToolStripMenuItem;
        private ToolStripMenuItem обАвтореToolStripMenuItem;
        private ToolStripMenuItem лаб21ToolStripMenuItem;
        private ToolStripMenuItem допЗаданиеToolStripMenuItem1;
        private ToolStripMenuItem обАвтореToolStripMenuItem1;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem журналЛоговToolStripMenuItem;
        private ToolStripMenuItem лаб3ToolStripMenuItem;
        private ToolStripMenuItem лабToolStripMenuItem;
        private ToolStripMenuItem отправитьИсключенияToolStripMenuItem;
        private ToolStripMenuItem расшифровкаЛогжурналаToolStripMenuItem;
        private CheckBox autodb;
    }
}