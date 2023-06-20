using System.Windows.Forms;
using System;
using Npgsql;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;
using System.Data;


namespace WinFormsDesign
{
    public partial class Form1 : Form
    {
        int flag = -1;

        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost; Port=5432; Database=test; User Id=postgres; Password=040304");
        }


        public Form1()
        {
            InitializeComponent();
        }
        //private Form1.User user;

        //public WinFormsDesign(Form1.User user)
        //{
        //    InitializeComponent();
        //    this.user = user;
        //}



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Category = new string[] { "Urutkan berdasarkan tanggal tebaru diubah", "Urutkan berdasarkan tanggal terlama diubah", "Urutkan berdasarkan rating pengguna" };
            filter.DataSource = Category;
            using (NpgsqlConnection conn = GetConnection())
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                NpgsqlCommand command1 = new NpgsqlCommand();
                command.Connection = conn;
                command1.Connection = conn;
                //command1.CommandText = "SELECT ulasan.isi_ulasan, ulasan.rating, ulasan.tanggal, akun.username_akun FROM ulasan INNER JOIN akun ON ulasan.id_ulasan = akun.id_akun ORDER BY ulasan.id_ulasan DESC";
                command1.CommandText = "SELECT isi_ulasan,rating,tanggal FROM ulasan ORDER BY id_ulasan DESC";
                NpgsqlDataReader reader = command1.ExecuteReader();
                string result = "";

                if (reader.Read())
                {
                    result = reader.GetString(0);
                    label4.Text = result;
                }

                reader.Close();

                command.CommandText = "SELECT AVG(rating) FROM ulasan";
                object averageRating = command.ExecuteScalar();
                if (averageRating != null)
                {
                    label4.Text = averageRating.ToString();
                }

                command.CommandText = "SELECT COUNT(id_ulasan) FROM ulasan";
                object countUlasan = command.ExecuteScalar();
                if (countUlasan != null)
                {
                    label23.Text = countUlasan.ToString() + " ulasan";
                }

                reader = command1.ExecuteReader();

                int i = 1;
                while (reader.Read())
                {
                    //string username = reader["username"].ToString();
                    string ulasan = reader["isi_ulasan"].ToString();
                    string rating = reader["rating"].ToString();
                    string tanggal = reader["tanggal"].ToString();

                    //System.Windows.Forms.Label labelusername = this.Controls.Find("labelUsername" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                    //if (labelusername != null)
                    //    labelusername.Text = username;
                    //labelusername.Visible = true;

                    System.Windows.Forms.Label labelulasan = this.Controls.Find("isi_ulasan" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                    if (labelulasan != null)
                    {
                        labelulasan.Text = ulasan;
                        labelulasan.Visible = true;
                    }

                    System.Windows.Forms.Label labelrating = this.Controls.Find("rating" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                    if (labelrating != null)
                    {
                        labelrating.Text = rating + " Dari 5";
                        labelrating.Visible = true;
                    }

                    System.Windows.Forms.Label labeltanggal = this.Controls.Find("tanggal" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                    if (labeltanggal != null)
                    {
                        labeltanggal.Text = "Ulasan diupload tanggal " + tanggal;
                        labeltanggal.Visible = true;
                    }

                    System.Windows.Forms.PictureBox bgulasan = this.Controls.Find("bgulasan" + i, true).FirstOrDefault() as System.Windows.Forms.PictureBox;
                    if (bgulasan != null)
                    {
                        bgulasan.Visible = true;
                    }

                    i++;
                }

                reader.Close();
                conn.Close();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            label3.ForeColor = Color.Red;
            label3.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            label3.ForeColor = Color.Black;
            label3.Font = new Font(label1.Font, FontStyle.Regular);
        }

        //private DateTime

        public void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = GetConnection())
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand();
                    DateTime currentDate = DateTime.Now;
                    string formattedDate = currentDate.ToString("yyyy-MM-dd HH:mm:ss");

                    command.Connection = conn;
                    //command.CommandText = "INSERT INTO ulasan (id_ulasan, isi_ulasan, rating, tanggal, id_akun) VALUES (DEFAULT, @isi_ulasan, @rating, @tanggal, @id_akun)";
                    command.CommandText = "INSERT INTO ulasan (id_ulasan, isi_ulasan, rating, tanggal) VALUES (DEFAULT, @isi_ulasan, @rating, @tanggal)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@isi_ulasan", textBox1.Text);
                    command.Parameters.AddWithValue("@tanggal", formattedDate);
                    //command.Parameters.AddWithValue("@id_akun", user.id_user);
                    textBox1.Text = "";

                    int ratingValue = 0;

                    if (radioButton1.Checked)
                    {
                        ratingValue = 5;
                        radioButton1.Checked = false;
                    }
                    else if (radioButton2.Checked)
                    {
                        ratingValue = 4;
                        radioButton2.Checked = false;
                    }
                    else if (radioButton3.Checked)
                    {
                        ratingValue = 3;
                        radioButton3.Checked = false;
                    }
                    else if (radioButton4.Checked)
                    {
                        ratingValue = 2;
                        radioButton4.Checked = false;
                    }
                    else if (radioButton5.Checked)
                    {
                        ratingValue = 1;
                        radioButton5.Checked = false;
                    }

                    command.Parameters.AddWithValue("@rating", ratingValue);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    panel6.Hide();
                    Refreshing();
                }

                MessageBox.Show("Terimakasih telah memberikan kami ulasan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak berhasil memasukkan data. Error: " + ex.Message);
            }
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panel6.Hide();
            else
                panel6.Show();
        }

        private void Refreshing()
        {
            string[] Category = new string[] { "Urutkan berdasarkan tanggal tebaru diubah", "Urutkan berdasarkan tanggal terlama diubah", "Urutkan berdasarkan rating pengguna" };
            filter.DataSource = Category;
            using (NpgsqlConnection conn = GetConnection())
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                NpgsqlCommand command1 = new NpgsqlCommand();
                command.Connection = conn;
                command1.Connection = conn;
                command1.CommandText = "SELECT isi_ulasan, rating, tanggal FROM ulasan ORDER BY id_ulasan DESC";
                NpgsqlDataReader reader = command1.ExecuteReader();
                string result = "";
                if (reader.Read())
                {
                    result = reader.GetString(0);
                    label4.Text = result;
                }

                reader.Close();

                command.CommandText = "SELECT AVG(rating) FROM ulasan";
                object averageRating = command.ExecuteScalar();
                if (averageRating != null)
                {
                    label4.Text = averageRating.ToString();
                }

                command.CommandText = "SELECT COUNT(id_ulasan) FROM ulasan";
                object countUlasan = command.ExecuteScalar();
                if (countUlasan != null)
                {
                    label23.Text = countUlasan.ToString() + " ulasan";
                }

                reader = command1.ExecuteReader();

                int i = 1;
                while (reader.Read())
                {
                    string ulasan = reader["isi_ulasan"].ToString();
                    string rating = reader["rating"].ToString();
                    string tanggal = reader["tanggal"].ToString();

                    System.Windows.Forms.Label labelulasan = this.Controls.Find("isi_ulasan" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                    if (labelulasan != null)
                    {
                        labelulasan.Text = ulasan;
                        labelulasan.Visible = true;
                    }

                    System.Windows.Forms.Label labelrating = this.Controls.Find("rating" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                    if (labelrating != null)
                    {
                        labelrating.Text = rating + " Dari 5";
                        labelrating.Visible = true;
                    }

                    System.Windows.Forms.Label labeltanggal = this.Controls.Find("tanggal" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                    if (labeltanggal != null)
                    {
                        labeltanggal.Text = "Ulasan diupload tanggal " + tanggal;
                        labeltanggal.Visible = true;
                    }

                    System.Windows.Forms.PictureBox bgulasan = this.Controls.Find("bgulasan" + i, true).FirstOrDefault() as System.Windows.Forms.PictureBox;
                    if (bgulasan != null)
                    {
                        bgulasan.Visible = true;
                    }

                    i++;
                }
                reader.Close();
                conn.Close();
            }
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (filter.SelectedIndex == 0)
            {
                Refreshing();
            }
            else if (filter.SelectedIndex == 1)
            {
                string[] Category = new string[] { "Urutkan berdasarkan tanggal tebaru diubah", "Urutkan berdasarkan tanggal terlama diubah", "Urutkan berdasarkan rating pengguna" };
                filter.DataSource = Category;
                using (NpgsqlConnection conn = GetConnection())
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand();
                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command.Connection = conn;
                    command1.Connection = conn;
                    command1.CommandText = "SELECT isi_ulasan, rating, tanggal FROM ulasan ORDER BY id_ulasan ASC";
                    NpgsqlDataReader reader = command1.ExecuteReader();
                    string result = "";
                    if (reader.Read())
                    {
                        result = reader.GetString(0);
                        label4.Text = result;
                    }

                    reader.Close();

                    command.CommandText = "SELECT AVG(rating) FROM ulasan";
                    object averageRating = command.ExecuteScalar();
                    if (averageRating != null)
                    {
                        label4.Text = averageRating.ToString();
                    }

                    command.CommandText = "SELECT COUNT(id_ulasan) FROM ulasan";
                    object countUlasan = command.ExecuteScalar();
                    if (countUlasan != null)
                    {
                        label23.Text = countUlasan.ToString() + " ulasan";
                    }

                    reader = command1.ExecuteReader();

                    int i = 1;
                    while (reader.Read())
                    {
                        string ulasan = reader["isi_ulasan"].ToString();
                        string rating = reader["rating"].ToString();
                        string tanggal = reader["tanggal"].ToString();

                        System.Windows.Forms.Label labelulasan = this.Controls.Find("isi_ulasan" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                        if (labelulasan != null)
                        {
                            labelulasan.Text = ulasan;
                            labelulasan.Visible = true;
                        }

                        System.Windows.Forms.Label labelrating = this.Controls.Find("rating" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                        if (labelrating != null)
                        {
                            labelrating.Text = rating + " Dari 5";
                            labelrating.Visible = true;
                        }

                        System.Windows.Forms.Label labeltanggal = this.Controls.Find("tanggal" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                        if (labeltanggal != null)
                        {
                            labeltanggal.Text = "Ulasan diupload tanggal " + tanggal;
                            labeltanggal.Visible = true;
                        }

                        System.Windows.Forms.PictureBox bgulasan = this.Controls.Find("bgulasan" + i, true).FirstOrDefault() as System.Windows.Forms.PictureBox;
                        if (bgulasan != null)
                        {
                            bgulasan.Visible = true;
                        }

                        i++;
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            else if (filter.SelectedIndex == 2)
            {
                string[] Category = new string[] { "Urutkan berdasarkan tanggal tebaru diubah", "Urutkan berdasarkan tanggal terlama diubah", "Urutkan berdasarkan rating pengguna" };
                filter.DataSource = Category;
                using (NpgsqlConnection conn = GetConnection())
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand();
                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command.Connection = conn;
                    command1.Connection = conn;
                    command1.CommandText = "SELECT isi_ulasan, rating, tanggal FROM ulasan ORDER BY rating DESC";
                    NpgsqlDataReader reader = command1.ExecuteReader();
                    string result = "";
                    if (reader.Read())
                    {
                        result = reader.GetString(0);
                        label4.Text = result;
                    }

                    reader.Close();

                    command.CommandText = "SELECT AVG(rating) FROM ulasan";
                    object averageRating = command.ExecuteScalar();
                    if (averageRating != null)
                    {
                        label4.Text = averageRating.ToString();
                    }

                    command.CommandText = "SELECT COUNT(id_ulasan) FROM ulasan";
                    object countUlasan = command.ExecuteScalar();
                    if (countUlasan != null)
                    {
                        label23.Text = countUlasan.ToString() + " ulasan";
                    }

                    reader = command1.ExecuteReader();

                    int i = 1;
                    while (reader.Read())
                    {
                        string ulasan = reader["isi_ulasan"].ToString();
                        string rating = reader["rating"].ToString();
                        string tanggal = reader["tanggal"].ToString();

                        System.Windows.Forms.Label labelulasan = this.Controls.Find("isi_ulasan" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                        if (labelulasan != null)
                        {
                            labelulasan.Text = ulasan;
                            labelulasan.Visible = true;
                        }

                        System.Windows.Forms.Label labelrating = this.Controls.Find("rating" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                        if (labelrating != null)
                        {
                            labelrating.Text = rating + " Dari 5";
                            labelrating.Visible = true;
                        }

                        System.Windows.Forms.Label labeltanggal = this.Controls.Find("tanggal" + i, true).FirstOrDefault() as System.Windows.Forms.Label;
                        if (labeltanggal != null)
                        {
                            labeltanggal.Text = "Ulasan diupload tanggal " + tanggal;
                            labeltanggal.Visible = true;
                        }

                        System.Windows.Forms.PictureBox bgulasan = this.Controls.Find("bgulasan" + i, true).FirstOrDefault() as System.Windows.Forms.PictureBox;
                        if (bgulasan != null)
                        {
                            bgulasan.Visible = true;
                        }

                        i++;
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Filter tidak dapat diproses!");
            }
        }
    }
}