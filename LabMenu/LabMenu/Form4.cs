using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LabMenu
{

    public partial class Form4 : Form
    {
        Regex regex;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dopbt_Click(object sender, EventArgs e)
        {

        }

        private void filebt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {

                return;

            }

            sigtb.Text = string.Empty;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            rcb.Text = fileText;

            string s = fileText;
            string signature = sigcb.Text;

            Regex regex = new Regex(@signature);
            MatchCollection matches = regex.Matches(s);

            if (matches.Count > 0 && sigcb.Text != string.Empty)
            {

                foreach (Match match in matches)
                {

                    sigtb.Text += match.Index + "-ая позиция" + "\t" + match.Value + "\r\n";

                }

            }

            else
            {

                sigtb.Text = "Cовпадений не найдено";

            }

        }

        private void sigcb_TextChanged(object sender, EventArgs e)
        {

            sigtb.Text = string.Empty;
            string s = rcb.Text;
            string signature = sigcb.Text;

            if (regcb.Checked)
                regex = new Regex(@signature, RegexOptions.IgnoreCase);
            else
                regex = new Regex(@signature);

            MatchCollection matches = regex.Matches(s);

            if (matches.Count > 0 && sigcb.Text != string.Empty)
            {

                foreach (Match match in matches)
                {

                    sigtb.Text += match.Index + "-ая позиция" + "\t" + match.Value + "\r\n";

                }

            }

            else
            {

                sigtb.Text = "Cовпадений не найдено";

            }

        }

        private void sigcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void regcb_CheckedChanged(object sender, EventArgs e)
        {

            sigtb.Text = string.Empty;
            string s = rcb.Text;
            string signature = sigcb.Text;

            if (regcb.Checked)
                regex = new Regex(@signature, RegexOptions.IgnoreCase);
            else
                regex = new Regex(@signature);

            MatchCollection matches = regex.Matches(s);

            if (matches.Count > 0 && sigcb.Text != string.Empty)
            {

                foreach (Match match in matches)
                {

                    sigtb.Text += match.Index + "-ая позиция" + "\t" + match.Value + "\r\n";

                }

            }

            else
            {

                sigtb.Text = "Cовпадений не найдено";

            }


        }

        private void rcb_TextChanged(object sender, EventArgs e)
        {

            sigtb.Text = string.Empty;
            string s = rcb.Text;
            string signature = sigcb.Text;

            if (regcb.Checked)
                regex = new Regex(@signature, RegexOptions.IgnoreCase);
            else
                regex = new Regex(@signature);

            MatchCollection matches = regex.Matches(s);

            if (matches.Count > 0 && sigcb.Text != string.Empty)
            {

                foreach (Match match in matches)
                {

                    sigtb.Text += match.Index + "-ая позиция" + "\t" + match.Value + "\r\n";

                }

            }

            else
            {

                sigtb.Text = "Cовпадений не найдено";

            }



        }

        private void sigbt_Click(object sender, EventArgs e)
        {

        }
    }
}
