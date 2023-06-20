namespace LabMenu
{
    partial class Decoder
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(379, 36);
            button1.Name = "button1";
            button1.Size = new Size(210, 52);
            button1.TabIndex = 0;
            button1.Text = "Расшифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 52);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 2;
            label1.Text = "Ключ";
            // 
            // button2
            // 
            button2.Location = new Point(36, 128);
            button2.Name = "button2";
            button2.Size = new Size(300, 52);
            button2.TabIndex = 3;
            button2.Text = "Сгенерировать код";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "XOR", "AES" });
            comboBox1.Location = new Point(379, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 40);
            comboBox1.TabIndex = 4;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // Decoder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 229);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Decoder";
            Text = "Дешифровка лог-журнала";
            Load += Decoder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private ComboBox comboBox1;
    }
}