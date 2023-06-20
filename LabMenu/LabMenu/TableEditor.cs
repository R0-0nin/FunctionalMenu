using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace LabMenu
{
    public partial class TableEditor : Form
    {

        public string msg;
        public string TargetSite;
        public string dateTimeExc;
        public string indexForm;
        public int str = 0;
        public bool flag = false;
        public string filename = "D:\\Logger\\log.txt";

        public TableEditor()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Host=192.168.1.40;Database=MyDB;Username=postgres;Password=admin");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from UserException";
            cmd.Connection = conn;
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

            }
            conn.Dispose();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var connString = "Host=192.168.1.40;Database=MyDB;Username=postgres;Password=admin";
            NpgsqlConnection conn = new NpgsqlConnection("Host=192.168.1.40;Database=MyDB;Username=postgres;Password=admin");

            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            if (!checkBox1.Checked)
            {

                cmd.CommandText = "ALTER TABLE metadata DROP CONSTRAINT id_ue_md;";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "TRUNCATE TABLE userexception;";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "ALTER TABLE metadata ADD CONSTRAINT id_ue_md FOREIGN KEY (id_ue) REFERENCES userexception(id)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT setval('userexception_id_seq', 1, false);";

                cmd.ExecuteNonQuery();

                ((DataTable)dataGridView1.DataSource).Rows.Clear();
            }

            else if(checkBox1.Checked)
            {

               // cmd.CommandText = "ALTER TABLE metadata DROP CONSTRAINT id_ue_md;";
                //cmd.ExecuteNonQuery();



                int idToDelete = (int)numericUpDown1.Value;
                string sql = "DELETE FROM userexception WHERE id = @id";
                NpgsqlCommand delid = new NpgsqlCommand(sql, conn);
                delid.Parameters.AddWithValue("id", idToDelete);
                delid.ExecuteNonQuery();



                //int myId = (int)numericUpDown1.Value;
                //cmd.CommandText = "DELETE FROM userexception WHERE id = @myId;";
                // cmd.ExecuteNonQuery();
                /*cmd.CommandText = "ALTER TABLE metadata ADD CONSTRAINT id_ue_md FOREIGN KEY (id_ue) REFERENCES userexception(id)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT setval('userexception_id_seq', 1, false);";

                cmd.ExecuteNonQuery();
                */
            }

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from UserException";
            cmd.Connection = conn;
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

            }
            conn.Dispose();
            conn.Close();



        }

        private async void button1_Click(object sender, EventArgs e)
        {

            int counter = 0;
            
            foreach (string line in System.IO.File.ReadLines(@"D:\Logger\log.txt"))
            {
                

                if (str == 1)
                {

                    msg = line;
                    str++;
                }

                else if (str == 2)
                {

                    TargetSite = line;
                    str++;
                }

                else if (str == 3)
                {

                    TargetSite += line;
                    str++;
                }

                else if (str == 4)
                {

                    indexForm = line;
                    str++;

                }

                else if (str == 5)
                {

                    str = 0;
                    await MyPGSQLSender.Main(msg, TargetSite, dateTimeExc, indexForm);



                }

                if (line.Contains("Date") && str == 0)
                {
                    str = 1;
                    flag = true;
                    counter++;
                    if (!checkBox1.Checked)
                    {

                        dateTimeExc = line.Substring(0, 19);

                    }


                }

            }

            System.IO.File.WriteAllText(@"D:\Logger\log.txt", string.Empty);

            NpgsqlConnection conn = new NpgsqlConnection("Host=192.168.1.40;Database=MyDB;Username=postgres;Password=admin");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from UserException";
            cmd.Connection = conn;
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

            }
            conn.Dispose();
            conn.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (!label1.Visible)
            {
                label1.Visible = true;
                numericUpDown1.Visible = true;
            }

            else if (label1.Visible)
            {

                label1.Visible = false;
                numericUpDown1.Visible = false;

            }

        }

        private void TableEditor_Load(object sender, EventArgs e)
        {
                
                label1.Visible = false;
                numericUpDown1.Visible = false;

            
        }
    }


    public class MyPGSQLSender
    {
        public static async Task Main(string msg, string ts, string dte, string iF)
        {

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseNpgsql("Host=192.168.1.40;Database=MyDB;Username=postgres;Password=admin");

            using (var dbContext = new MyDbContext(optionsBuilder.Options))
            {
                // Создание нового объекта
                var newObject = new userexception
                {
                    message = msg,
                    targetsite = ts,
                    datetimeexc = dte,
                    indexform = iF
                };

                // Добавление нового объекта в контекст
                dbContext.userexception.Add(newObject);

                // Сохранение изменений в базе данных
                await dbContext.SaveChangesAsync();

                Console.WriteLine("Данные успешно сохранены");
            }
        }
    }

    public class MyDbContext : DbContext
    {
        public DbSet<userexception> userexception { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<userexception>()
                .HasKey(e => e.id);
        }
    }

    public class userexception // Создание шаблона нашего класса, который будем заносить в таблицу UserException
    {
        public int id { get; set; }
        public string message { get; set; }
        public string targetsite { get; set; }
        public string datetimeexc { get; set; }
        public string indexform { get; set; }
    }
}
