using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic.Logging;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;
using System.Reflection.Metadata;

namespace LabMenu
{

    public partial class Decoder : Form
    {

        string myKey;
        public Decoder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == String.Empty)
            {

                MessageBox.Show(
                    "Введите ключ!",
                    "Информация",
                    MessageBoxButtons.OK,
                   //MessageBoxIcon.Warning // for Warning  
                   //MessageBoxIcon.Error // for Error 
                   MessageBoxIcon.Information  // for Information
                                               //MessageBoxIcon.Question // for Question
                );
                return;

            }

            else if (comboBox1.Text == "XOR")
            {
                if (MessageBox.Show(
                    "В случае ввода неверного ключа или выбора неверного метода расшифровки есть риск утерять данные. Продолжить?",
                    "Предупреждение!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning // for Warning  
                                           //MessageBoxIcon.Error // for Error 
                                           //MessageBoxIcon.Information  // for Information
                                           //MessageBoxIcon.Question // for Question
                ) == DialogResult.Yes)
                    Liner(textBox1.Text);
                else
                {

                    return;

                }

            }
            else if (comboBox1.Text == "AES")
            {
                if(MessageBox.Show(
                    "В случае ввода неверного ключа или выбора неверного метода расшифровки есть риск утерять данные. Продолжить?",
                    "Предупреждение!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning // for Warning  
                           //MessageBoxIcon.Error // for Error 
                           //MessageBoxIcon.Information  // for Information
                           //MessageBoxIcon.Question // for Question
                ) == DialogResult.Yes)
                    AESdeliner(textBox1.Text);
                else
                {

                    return;

                }

            }
            else
                MessageBox.Show(
            "Выберите алгоритм расшифровки",
            "Ошибка!",
            MessageBoxButtons.OKCancel,
           MessageBoxIcon.Warning // for Warning  
                                  //MessageBoxIcon.Error // for Error 
                                  //MessageBoxIcon.Information  // for Information
                                  //MessageBoxIcon.Question // for Question
    );

        }

        protected string Coder(int type)
        {
            if (type == 0)
            {
                Guid guid = Guid.NewGuid();
                string gamma = Convert.ToBase64String(guid.ToByteArray());
                gamma = gamma.Replace("=", ""); //remove '='
                return gamma;
            }

            else if (type == 1)
            {


                string sourceFileName = @"D:\Logger\log.txt"; //файл, который будем шифровать
                string outputFileName = @"D:\Logger\logtemp.txt"; //файл, который будет содержать зашифрованные данные

                using Aes aes = Aes.Create();

                using FileStream inStream = new FileStream(sourceFileName, FileMode.Open); //создаем файловый поток на чтение
                using FileStream outStream = new FileStream(outputFileName, FileMode.Create);//создаем файловый поток на запись

                CryptoStream encStream = new CryptoStream(outStream, aes.CreateEncryptor(aes.Key, aes.IV), CryptoStreamMode.Write);

                long readTotal = 0;

                int len;
                int tempSize = 10; //размер временного хранилища
                byte[] bin = new byte[tempSize];    //временное Хранилище для зашифрованной информации
                while (readTotal < inStream.Length)
                {
                    len = inStream.Read(bin, 0, tempSize);
                    encStream.Write(bin, 0, len);
                    readTotal = readTotal + len;
                    Console.WriteLine($"{readTotal} байт обработано");
                }
                string gamma = System.Text.Encoding.Unicode.GetString(aes.Key) + "\t" + System.Text.Encoding.Unicode.GetString(aes.IV);

                encStream.Close();
                outStream.Close();
                inStream.Close();

                File.Delete(@"D:\Logger\log.txt");
                System.IO.File.Move(@"D:\Logger\logtemp.txt", @"D:\Logger\log.txt");
                return gamma;

            }
            else
            {

                Guid guid = Guid.NewGuid();
                string gamma = Convert.ToBase64String(guid.ToByteArray());
                gamma = gamma.Replace("=", ""); //remove '='
                MessageBox.Show(
                            "По умолчанию выбрано шифрование XOR",
                            "Уведомление",
                            MessageBoxButtons.OK,
                            //MessageBoxIcon.Warning // for Warning  
                           //MessageBoxIcon.Error // for Error 
                           MessageBoxIcon.Information  // for Information
                           //MessageBoxIcon.Question // for Question
                    );
                return gamma;

            }

        }

        protected void Sender(string code)
        {

            MailAddress from = new MailAddress("wildflame921@gmail.com", "Decoder");
            MailAddress to = new MailAddress("wildflame921@gmail.com");
            MailMessage message = new MailMessage(from, to);
            message.Body = "Код дешифратора: " + code;


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("wildflame921@gmail.com", Environment.GetEnvironmentVariable("token", EnvironmentVariableTarget.Machine));
            smtpClient.Send(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "XOR")
            {
                myKey = Coder(0);
                Sender(myKey);
                Liner(myKey);
            }
            else if (comboBox1.Text == "AES")
            {
                
                myKey = Coder(1);
                Sender(myKey);

            }
            else
            {
                myKey = Coder(2);
                Sender(myKey);
                Liner(myKey);
            }
        }



        public void Liner(string gamma)
        {
            using (Stream source = File.OpenRead(@"D:\Logger\log.txt"))
            using (Stream dest = File.Create(@"D:\Logger\templog.txt"))
            {
                byte[] buffer = new byte[source.Length];
                byte[] ciphered = new byte[source.Length];
                int bytesRead;
                while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                {
                    int gammer = 0;
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        if (i >= gamma.Length + gammer * gamma.Length)
                            gammer += 1;
                        ciphered[i] = (byte)((int)buffer[i] ^ Convert.ToInt32(gamma[i - (gammer * gamma.Length)]));

                    }
                    dest.Write(ciphered, 0, ciphered.Length);
                }
            }


            File.Delete(@"D:\Logger\log.txt");
            System.IO.File.Move(@"D:\Logger\templog.txt", @"D:\Logger\log.txt");
            // StreamWriter file = new StreamWriter(@"D:\Logger\templog.txt");
            //string cipheredline = "";

            //foreach (string line in System.IO.File.ReadLines(@"D:\Logger\log.txt"))
            //{
            //    cipheredline = "";
            //    int gammer = 0;
            //    for (int i = 0; i < line.Length; i++)
            //    {
            //        if (i >= gamma.Length + gammer * gamma.Length)
            //            gammer += 1;
            //        cipheredline += (char)(System.Convert.ToInt16(line[i]) ^ System.Convert.ToInt16(gamma[i - gammer * gamma.Length]));

            //    }

            //    file.WriteLine(cipheredline);
            //}

            //file.Close();
            //File.Delete("D:\\Logger\\log.txt");
            //System.IO.File.Move("D:\\Logger\\templog.txt", "D:\\Logger\\log.txt");
        }





        private void Decoder_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "AES")
            {

                //code for key and iv textboxes.

            }

        }

        public void AESdeliner(string key)
        {


            
            string[] keyIV = key.Split("       ");
            using FileStream fileStream = new(@"D:\Logger\log.txt", FileMode.Open);
            using Aes aes = Aes.Create();

            string tempKey = keyIV[0];
            string tempIV = keyIV[1];

            byte[] IV = System.Text.Encoding.Unicode.GetBytes(tempIV);
            byte[] Key = System.Text.Encoding.Unicode.GetBytes(tempKey);

            using CryptoStream cryptoStream = new(fileStream, aes.CreateDecryptor(Key, IV), CryptoStreamMode.Read); //создаем поток для чтения (расшифровки) данных
            using FileStream outStream = new FileStream(@"D:\Logger\logtemp.txt", FileMode.Create);//создаем поток для расшифрованных данных

            using BinaryReader decryptReader = new(cryptoStream);
            int tempSize = 10;  //размер временного хранилища
            byte[] data;        //временное хранилище для зашифрованной информации
            while (true)
            {
                data = decryptReader.ReadBytes(tempSize);
                if (data.Length == 0)
                    break;
                outStream.Write(data, 0, data.Length);
            }
            
            fileStream.Close();
            cryptoStream.Close();
            outStream.Close();
            File.Delete(@"D:\Logger\log.txt");
            System.IO.File.Move(@"D:\Logger\logtemp.txt", @"D:\Logger\log.txt");
        }
    }
}
