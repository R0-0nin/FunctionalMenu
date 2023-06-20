using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LabMenu
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void ��������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "������� �.�., 2 ����, �������� ��������������� ������, ������ 3135." + Environment.NewLine;
        }

        private void ���1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("D:\\Logger\\log.txt", Encoding.UTF8))
            {
                richTextBox1.Text = "";

                string text = sr.ReadToEnd();
                richTextBox1.AppendText(text);
            }
        }

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void ���21ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.dbcheck = this.autodb;
            f3.ShowDialog();

        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void �������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TableEditor f5 = new TableEditor();
            f5.ShowDialog();

        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ���������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decoder f6 = new Decoder();
            f6.ShowDialog();
        }

        private void autodb_CheckedChanged(object sender, EventArgs e)
        {

            if (!autodb.Checked)
            {

                File.Delete(@"D:\Logger\atemp.txt");
                File.WriteAllText(@"D:\Logger\atemp.txt", "False", Encoding.Default);
                


            }

            else
            {

                File.Delete(@"D:\Logger\atemp.txt");
                File.WriteAllText(@"D:\Logger\atemp.txt", "True", Encoding.Default);


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.Delete(@"D:\Logger\atemp.txt");
            File.WriteAllText(@"D:\Logger\atemp.txt", "False", Encoding.Default);
        }
    }
}