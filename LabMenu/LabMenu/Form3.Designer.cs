namespace LabMenu
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            Timer = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            label1 = new Label();
            num = new NumericUpDown();
            label2 = new Label();
            rbyourself = new RadioButton();
            rbrand = new RadioButton();
            randfreqrb = new RadioButton();
            freqlbl = new Label();
            freqtb = new TextBox();
            createbt = new Button();
            clearbt = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Tick += timer1_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 45);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 32);
            label1.TabIndex = 0;
            label1.Text = "Введите длину массива:";
            // 
            // num
            // 
            num.Location = new Point(56, 105);
            num.Margin = new Padding(6, 6, 6, 6);
            num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num.Name = "num";
            num.Size = new Size(67, 39);
            num.TabIndex = 1;
            num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            num.ValueChanged += num_ValueChanged;
            num.KeyPress += num_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1116, 45);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(265, 32);
            label2.TabIndex = 2;
            label2.Text = "Способ ввода массива";
            // 
            // rbyourself
            // 
            rbyourself.AutoSize = true;
            rbyourself.Location = new Point(1116, 105);
            rbyourself.Margin = new Padding(6, 6, 6, 6);
            rbyourself.Name = "rbyourself";
            rbyourself.Size = new Size(145, 36);
            rbyourself.TabIndex = 3;
            rbyourself.TabStop = true;
            rbyourself.Text = "Вручную";
            rbyourself.UseVisualStyleBackColor = true;
            rbyourself.CheckedChanged += rbyourself_CheckedChanged;
            rbyourself.Click += rbyourself_Click;
            // 
            // rbrand
            // 
            rbrand.AutoSize = true;
            rbrand.Location = new Point(1116, 158);
            rbrand.Margin = new Padding(6, 6, 6, 6);
            rbrand.Name = "rbrand";
            rbrand.Size = new Size(153, 36);
            rbrand.TabIndex = 4;
            rbrand.TabStop = true;
            rbrand.Text = "Случайно";
            rbrand.UseVisualStyleBackColor = true;
            rbrand.CheckedChanged += rbrand_CheckedChanged;
            rbrand.Click += rbrand_Click;
            // 
            // randfreqrb
            // 
            randfreqrb.AutoSize = true;
            randfreqrb.Location = new Point(1116, 211);
            randfreqrb.Margin = new Padding(6, 6, 6, 6);
            randfreqrb.Name = "randfreqrb";
            randfreqrb.Size = new Size(277, 36);
            randfreqrb.TabIndex = 5;
            randfreqrb.TabStop = true;
            randfreqrb.Text = "Случайно с частотой";
            randfreqrb.UseVisualStyleBackColor = true;
            randfreqrb.CheckedChanged += randfreqrb_CheckedChanged;
            randfreqrb.Click += randfreqrb_Click;
            // 
            // freqlbl
            // 
            freqlbl.AutoSize = true;
            freqlbl.Location = new Point(1116, 286);
            freqlbl.Margin = new Padding(6, 0, 6, 0);
            freqlbl.Name = "freqlbl";
            freqlbl.Size = new Size(146, 32);
            freqlbl.TabIndex = 6;
            freqlbl.Text = "Частота(мс):";
            // 
            // freqtb
            // 
            freqtb.Location = new Point(1268, 277);
            freqtb.Margin = new Padding(6, 6, 6, 6);
            freqtb.Name = "freqtb";
            freqtb.Size = new Size(108, 39);
            freqtb.TabIndex = 7;
            freqtb.TextChanged += freqtb_TextChanged;
            freqtb.KeyPress += freqtb_KeyPress;
            // 
            // createbt
            // 
            createbt.Location = new Point(56, 277);
            createbt.Margin = new Padding(6, 6, 6, 6);
            createbt.Name = "createbt";
            createbt.Size = new Size(208, 49);
            createbt.TabIndex = 8;
            createbt.Text = "Сформировать";
            createbt.UseVisualStyleBackColor = true;
            createbt.Click += createbt_Click;
            // 
            // clearbt
            // 
            clearbt.Location = new Point(306, 277);
            clearbt.Margin = new Padding(6, 6, 6, 6);
            clearbt.Name = "clearbt";
            clearbt.Size = new Size(208, 49);
            clearbt.TabIndex = 9;
            clearbt.Text = "Очистить";
            clearbt.UseVisualStyleBackColor = true;
            clearbt.Click += clearbt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 365);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1482, 599);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            dataGridView1.KeyPress += dataGridView1_KeyPress;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(dataGridView1);
            Controls.Add(clearbt);
            Controls.Add(createbt);
            Controls.Add(freqtb);
            Controls.Add(freqlbl);
            Controls.Add(randfreqrb);
            Controls.Add(rbrand);
            Controls.Add(rbyourself);
            Controls.Add(label2);
            Controls.Add(num);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form3";
            Text = "Формирование массивов.3135_Смертин";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)num).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private ErrorProvider errorProvider1;
        private DataGridView dataGridView1;
        private Button clearbt;
        private Button createbt;
        private TextBox freqtb;
        private Label freqlbl;
        private RadioButton randfreqrb;
        private RadioButton rbrand;
        private RadioButton rbyourself;
        private Label label2;
        private NumericUpDown num;
        private Label label1;
        private ErrorProvider errorProvider2;
    }
}