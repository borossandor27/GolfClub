using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        Tag KivalasztottTag = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "Golf";
            //sb.Port = 3307;
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            sql = conn.CreateCommand(); //-- a későbbiekben mindig ezen az objektumon keresztül küldjük a parancsot
            LIstbox_Update();
        }

        void LIstbox_Update()
        {
            sql.CommandText = "SELECT `id`,`Nev`,`Szuletett` FROM `Tagok` ORDER BY `Nev`";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                listBox_Tagok.Items.Clear();
                while (dr.Read())
                {
                    listBox_Tagok.Items.Add(new Tag(dr.GetInt32("id"), dr.GetString("Nev"), dr.GetDateTime("Szuletett")));
                }
            }
        }

         private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (textBox_Nev.Text.Trim().Length < 3)
            {
                MessageBox.Show("Kérem, adja meg a nevet!");
                textBox_Nev.Focus();
                textBox_Nev.Select(textBox_Nev.Text.Length, 0);
                return;
            }
            sql.CommandText = "INSERT INTO `tagok` (`id`, `Nev`, `Szuletett`) VALUES (NULL, @Nev, @Szuletett);";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@Nev", textBox_Nev.Text.Trim());
            sql.Parameters.AddWithValue("@Szuletett", dateTimePicker_Szuletett.Value.ToString("yyyy-MM-dd"));
            try
            {
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Adatrögzítés sikertelen\n\n" + ex.Message);
                return;
            }
            LIstbox_Update();
            textBox_Nev.Text = "";
            dateTimePicker_Szuletett.Value = DateTime.Today.AddYears(-35);
        }

        private void listBox_Tagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Tagok.SelectedIndex == -1)
            {
                KivalasztottTag = null;
                textBox_Id.Text = "";
                textBox_Nev.Text = "";
                dateTimePicker_Szuletett.Value = DateTime.Today.AddYears(-35);
                button_Delete.Enabled = false;
                button_Update.Enabled = false;
            }
            else
            {
                KivalasztottTag = (Tag)listBox_Tagok.SelectedItem;
                textBox_Id.Text = KivalasztottTag.Id.ToString("000000000");
                textBox_Nev.Text = KivalasztottTag.Nev;
                dateTimePicker_Szuletett.Value = KivalasztottTag.Szuletett;
                button_Update.Enabled = true;
                button_Delete.Enabled = true;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (listBox_Tagok.SelectedIndex == -1)
            {
                MessageBox.Show("Nem választotta ki a módosítandó tagot!");
                return;
            }
            if (textBox_Nev.Text.Trim().Length < 3)
            {
                MessageBox.Show("Kérem, adja meg a nevet!");
                textBox_Nev.Focus();
                textBox_Nev.Select(textBox_Nev.Text.Length, 0);
                return;
            }
            sql.CommandText = "UPDATE `tagok` SET `Nev`=@nev,`Szuletett`=@szuletett WHERE `id`= @id;";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@id", KivalasztottTag.Id);
            sql.Parameters.AddWithValue("@nev", textBox_Nev.Text.Trim());
            sql.Parameters.AddWithValue("@szuletett", dateTimePicker_Szuletett.Value.ToString("yyyy-MM-dd"));
            try
            {
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            KivalasztottTag = null;
            textBox_Id.Text = "";
            textBox_Nev.Text = "";
            dateTimePicker_Szuletett.Value = DateTime.Today.AddYears(-35);
            LIstbox_Update();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Tagok.SelectedIndex == -1)
            {
                return;
            }
            sql.CommandText = "DELETE FROM `tagok` WHERE `id`= @id;";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@id", KivalasztottTag.Id);
            try
            {
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            KivalasztottTag = null;
            textBox_Id.Text = "";
            textBox_Nev.Text = "";
            dateTimePicker_Szuletett.Value = DateTime.Today.AddYears(-35);
            LIstbox_Update();
        }
    }
}
