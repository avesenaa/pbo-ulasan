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
        // -----------------------------------------------------------------------------------------------------------------
        //                                                  CONNECTION                                                      |
        // -----------------------------------------------------------------------------------------------------------------
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost; Port=5432; Database=test; User Id=postgres; Password=040304");
        }


        // -----------------------------------------------------------------------------------------------------------------
        //                                                  RESPONSIVE                                                      |
        // -----------------------------------------------------------------------------------------------------------------
        private Size formOriginalSize;
        private Rectangle recbtnfiltersearch;
        private Rectangle recbtnkirimulasan;
        private Rectangle recpnlgambar1;
        private Rectangle recpnlgambar2;
        private Rectangle recpcboxprevious;
        private Rectangle recpcboxnext;
        private Rectangle reclbljudululasan;
        private Rectangle reclblsubjudululasan;
        private Rectangle recpnlpemisahjudululasandenganrating;
        private Rectangle reclblrating;
        private Rectangle reclblavgrating;
        private Rectangle reclbldari;
        private Rectangle reclblsumrating;
        private Rectangle recpcboxpemisahkanankiri;
        private Rectangle reclbljudululasanpengunjung;
        private Rectangle recpnlpemisahjudululasanpengunjungdenganisiulasan;
        private Rectangle reccboxfilter;
        private Rectangle reclblpilihrating;
        private Rectangle recpnlbackgroundpilihrating;
        private Rectangle recpilihrating1;
        private Rectangle recpilihrating2;
        private Rectangle recpilihrating3;
        private Rectangle recpilihrating4;
        private Rectangle recpilihrating5;
        private Rectangle recpcboxpensil;
        private Rectangle rectboxulasan;
        private Rectangle recpcboxbackgroundinputulasan;
        private Rectangle recpbox;
        private Rectangle recflp;
        private Rectangle recpnlulasan1;
        private Rectangle recpnlulasan2;
        private Rectangle recpnlulasan3;
        private Rectangle recpnlulasan4;
        private Rectangle recpnlulasan5;
        private Rectangle recpnlulasan6;
        private Rectangle recpnlulasan7;
        private Rectangle recbgulasan1;
        private Rectangle recbgulasan2;
        private Rectangle recbgulasan3;
        private Rectangle recbgulasan4;
        private Rectangle recbgulasan5;
        private Rectangle recbgulasan6;
        private Rectangle recbgulasan7;
        private Rectangle recuser1;
        private Rectangle recuser2;
        private Rectangle recuser3;
        private Rectangle recuser4;
        private Rectangle recuser5;
        private Rectangle recuser6;
        private Rectangle recuser7;
        private Rectangle recrating1;
        private Rectangle recrating2;
        private Rectangle recrating3;
        private Rectangle recrating4;
        private Rectangle recrating5;
        private Rectangle recrating6;
        private Rectangle recrating7;
        private Rectangle rectanggal1;
        private Rectangle rectanggal2;
        private Rectangle rectanggal3;
        private Rectangle rectanggal4;
        private Rectangle rectanggal5;
        private Rectangle rectanggal6;
        private Rectangle rectanggal7;
        private Rectangle recisi_ulasan1;
        private Rectangle recisi_ulasan2;
        private Rectangle recisi_ulasan3;
        private Rectangle recisi_ulasan4;
        private Rectangle recisi_ulasan5;
        private Rectangle recisi_ulasan6;
        private Rectangle recisi_ulasan7;




        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recbtnfiltersearch = new Rectangle(btnfiltersearch.Location, btnfiltersearch.Size);
            recbtnkirimulasan = new Rectangle(btnkirimulasan.Location, btnkirimulasan.Size);
            recpnlgambar1 = new Rectangle(pnlgambar1.Location, pnlgambar1.Size);
            recpnlgambar2 = new Rectangle(pnlgambar2.Location, pnlgambar2.Size);
            recpcboxprevious = new Rectangle(pcboxprevious.Location, pcboxprevious.Size);
            recpcboxnext = new Rectangle(pcboxnext.Location, pcboxnext.Size);
            reclbljudululasan = new Rectangle(lbljudululasan.Location, lbljudululasan.Size);
            reclblsubjudululasan = new Rectangle(lblsubjudululasan.Location, lblsubjudululasan.Size);
            recpnlpemisahjudululasandenganrating = new Rectangle(pnlpemisahjudululasandenganrating.Location, pnlpemisahjudululasandenganrating.Size);
            reclblrating = new Rectangle(lblrating.Location, lblrating.Size);
            reclblavgrating = new Rectangle(lblavgrating.Location, lblavgrating.Size);
            reclbldari = new Rectangle(lbldari.Location, lbldari.Size);
            reclblsumrating = new Rectangle(lblsumrating.Location, lblsumrating.Size);
            recpcboxpemisahkanankiri = new Rectangle(pcboxpemisahkanankiri.Location, pcboxpemisahkanankiri.Size);
            reclbljudululasanpengunjung = new Rectangle(lbljudululasanpengunjung.Location, lbljudululasanpengunjung.Size);
            recpnlpemisahjudululasanpengunjungdenganisiulasan = new Rectangle(pnlpemisahjudululasanpengunjungdenganisiulasan.Location, pnlpemisahjudululasanpengunjungdenganisiulasan.Size);
            reccboxfilter = new Rectangle(cboxfilter.Location, cboxfilter.Size);
            reclblpilihrating = new Rectangle(lblpilihrating.Location, lblpilihrating.Size);
            recpnlbackgroundpilihrating = new Rectangle(pnlbackgroundpilihrating.Location, pnlbackgroundpilihrating.Size);
            recpilihrating1 = new Rectangle(pilihrating1.Location, pilihrating1.Size);
            recpilihrating2 = new Rectangle(pilihrating2.Location, pilihrating2.Size);
            recpilihrating3 = new Rectangle(pilihrating3.Location, pilihrating3.Size);
            recpilihrating4 = new Rectangle(pilihrating4.Location, pilihrating4.Size);
            recpilihrating5 = new Rectangle(pilihrating5.Location, pilihrating5.Size);
            recpcboxpensil = new Rectangle(pcboxpensil.Location, pcboxpensil.Size);
            rectboxulasan = new Rectangle(tboxulasan.Location, tboxulasan.Size);
            recpcboxbackgroundinputulasan = new Rectangle(pcboxbackgroundinputulasan.Location, pcboxbackgroundinputulasan.Size);
            recpbox = new Rectangle(pbox.Location, pbox.Size);
            recflp = new Rectangle(flp.Location, flp.Size);
            recpnlulasan1 = new Rectangle(pnlulasan1.Location, pnlulasan1.Size);
            recpnlulasan2 = new Rectangle(pnlulasan2.Location, pnlulasan2.Size);
            recpnlulasan3 = new Rectangle(pnlulasan3.Location, pnlulasan3.Size);
            recpnlulasan4 = new Rectangle(pnlulasan4.Location, pnlulasan4.Size);
            recpnlulasan5 = new Rectangle(pnlulasan5.Location, pnlulasan5.Size);
            recpnlulasan6 = new Rectangle(pnlulasan6.Location, pnlulasan6.Size);
            recpnlulasan7 = new Rectangle(pnlulasan7.Location, pnlulasan7.Size);
            recbgulasan1 = new Rectangle(bgulasan1.Location, bgulasan1.Size);
            recbgulasan2 = new Rectangle(bgulasan2.Location, bgulasan2.Size);
            recbgulasan3 = new Rectangle(bgulasan3.Location, bgulasan3.Size);
            recbgulasan4 = new Rectangle(bgulasan4.Location, bgulasan4.Size);
            recbgulasan5 = new Rectangle(bgulasan5.Location, bgulasan5.Size);
            recbgulasan6 = new Rectangle(bgulasan6.Location, bgulasan6.Size);
            recbgulasan7 = new Rectangle(bgulasan7.Location, bgulasan7.Size);
            recuser1 = new Rectangle(user1.Location, user1.Size);
            recuser2 = new Rectangle(user2.Location, user2.Size);
            recuser3 = new Rectangle(user3.Location, user3.Size);
            recuser4 = new Rectangle(user4.Location, user4.Size);
            recuser5 = new Rectangle(user5.Location, user5.Size);
            recuser6 = new Rectangle(user6.Location, user6.Size);
            recuser7 = new Rectangle(user7.Location, user7.Size);
            recrating1 = new Rectangle(rating1.Location, rating1.Size);
            recrating2 = new Rectangle(rating2.Location, rating2.Size);
            recrating3 = new Rectangle(rating3.Location, rating3.Size);
            recrating4 = new Rectangle(rating4.Location, rating4.Size);
            recrating5 = new Rectangle(rating5.Location, rating5.Size);
            recrating6 = new Rectangle(rating6.Location, rating6.Size);
            recrating7 = new Rectangle(rating7.Location, rating7.Size);
            rectanggal1 = new Rectangle(tanggal1.Location, tanggal1.Size);
            rectanggal2 = new Rectangle(tanggal2.Location, tanggal2.Size);
            rectanggal3 = new Rectangle(tanggal3.Location, tanggal3.Size);
            rectanggal4 = new Rectangle(tanggal4.Location, tanggal4.Size);
            rectanggal5 = new Rectangle(tanggal5.Location, tanggal5.Size);
            rectanggal6 = new Rectangle(tanggal6.Location, tanggal6.Size);
            rectanggal7 = new Rectangle(tanggal7.Location, tanggal7.Size);
            recisi_ulasan1 = new Rectangle(isi_ulasan1.Location, isi_ulasan1.Size);
            recisi_ulasan2 = new Rectangle(isi_ulasan2.Location, isi_ulasan2.Size);
            recisi_ulasan3 = new Rectangle(isi_ulasan3.Location, isi_ulasan3.Size);
            recisi_ulasan4 = new Rectangle(isi_ulasan4.Location, isi_ulasan4.Size);
            recisi_ulasan5 = new Rectangle(isi_ulasan5.Location, isi_ulasan5.Size);
            recisi_ulasan6 = new Rectangle(isi_ulasan6.Location, isi_ulasan6.Size);
            recisi_ulasan7 = new Rectangle(isi_ulasan7.Location, isi_ulasan7.Size);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(btnfiltersearch, recbtnfiltersearch);
            resize_Control(btnkirimulasan, recbtnkirimulasan);
            resize_Control(pnlgambar1, recpnlgambar1);
            resize_Control(pnlgambar2, recpnlgambar2);
            resize_Control(pcboxprevious, recpcboxprevious);
            resize_Control(pcboxnext, recpcboxnext);
            resize_Control(lbljudululasan, reclbljudululasan);
            resize_Control(lblsubjudululasan, reclblsubjudululasan);
            resize_Control(pnlpemisahjudululasandenganrating, recpnlpemisahjudululasandenganrating);
            resize_Control(lblrating, reclblrating);
            resize_Control(lblavgrating, reclblavgrating);
            resize_Control(lbldari, reclbldari);
            resize_Control(lblsumrating, reclblsumrating);
            resize_Control(pcboxpemisahkanankiri, recpcboxpemisahkanankiri);
            resize_Control(lbljudululasanpengunjung, reclbljudululasanpengunjung);
            resize_Control(pnlpemisahjudululasanpengunjungdenganisiulasan, recpnlpemisahjudululasanpengunjungdenganisiulasan);
            resize_Control(cboxfilter, reccboxfilter);
            resize_Control(lblpilihrating, reclblpilihrating);
            resize_Control(pnlbackgroundpilihrating, recpnlbackgroundpilihrating);
            resize_Control(pilihrating1, recpilihrating1);
            resize_Control(pilihrating2, recpilihrating2);
            resize_Control(pilihrating3, recpilihrating3);
            resize_Control(pilihrating4, recpilihrating4);
            resize_Control(pilihrating5, recpilihrating5);
            resize_Control(pcboxpensil, recpcboxpensil);
            resize_Control(tboxulasan, rectboxulasan);
            resize_Control(pcboxbackgroundinputulasan, recpcboxbackgroundinputulasan);
            resize_Control(pbox, recpbox);
            resize_Control(flp, recflp);
            resize_Control(pnlulasan1, recpnlulasan1);
            resize_Control(pnlulasan2, recpnlulasan2);
            resize_Control(pnlulasan3, recpnlulasan3);
            resize_Control(pnlulasan4, recpnlulasan4);
            resize_Control(pnlulasan5, recpnlulasan5);
            resize_Control(pnlulasan6, recpnlulasan6);
            resize_Control(pnlulasan7, recpnlulasan7);
            resize_Control(bgulasan1, recbgulasan1);
            resize_Control(bgulasan2, recbgulasan2);
            resize_Control(bgulasan3, recbgulasan3);
            resize_Control(bgulasan4, recbgulasan4);
            resize_Control(bgulasan5, recbgulasan5);
            resize_Control(bgulasan6, recbgulasan6);
            resize_Control(bgulasan7, recbgulasan7);
            resize_Control(user1, recuser1);
            resize_Control(user2, recuser2);
            resize_Control(user3, recuser3);
            resize_Control(user4, recuser4);
            resize_Control(user5, recuser5);
            resize_Control(user6, recuser6);
            resize_Control(user7, recuser7);
            resize_Control(rating1, recrating1);
            resize_Control(rating2, recrating2);
            resize_Control(rating3, recrating3);
            resize_Control(rating4, recrating4);
            resize_Control(rating5, recrating5);
            resize_Control(rating6, recrating6);
            resize_Control(rating7, recrating7);
            resize_Control(tanggal1, rectanggal1);
            resize_Control(tanggal2, rectanggal2);
            resize_Control(tanggal3, rectanggal3);
            resize_Control(tanggal4, rectanggal4);
            resize_Control(tanggal5, rectanggal5);
            resize_Control(tanggal6, rectanggal6);
            resize_Control(tanggal7, rectanggal7);
            resize_Control(isi_ulasan1, recisi_ulasan1);
            resize_Control(isi_ulasan2, recisi_ulasan2);
            resize_Control(isi_ulasan3, recisi_ulasan3);
            resize_Control(isi_ulasan4, recisi_ulasan4);
            resize_Control(isi_ulasan5, recisi_ulasan5);
            resize_Control(isi_ulasan6, recisi_ulasan6);
            resize_Control(isi_ulasan7, recisi_ulasan7);
        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        // -----------------------------------------------------------------------------------------------------------------
        //                                                CONNECTION USER                                                   |
        // -----------------------------------------------------------------------------------------------------------------
        //private Form1.User user;

        //public WinFormsDesign(Form1.User user)
        //{
        //    InitializeComponent();
        //    this.user = user;
        //}



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Category = new string[] { "Urutkan berdasarkan tanggal tebaru diubah", "Urutkan berdasarkan tanggal terlama diubah", "Urutkan berdasarkan rating pengguna" };
            cboxfilter.DataSource = Category;
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
                    lblavgrating.Text = result;
                }

                reader.Close();

                command.CommandText = "SELECT AVG(rating) FROM ulasan";
                object averageRating = command.ExecuteScalar();
                if (averageRating != null)
                {
                    lblavgrating.Text = averageRating.ToString();
                }

                command.CommandText = "SELECT COUNT(id_ulasan) FROM ulasan";
                object countUlasan = command.ExecuteScalar();
                if (countUlasan != null)
                {
                    lblsumrating.Text = countUlasan.ToString() + " ulasan";
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

        // -----------------------------------------------------------------------------------------------------------------
        //                                                  GANTI FOTO                                                      |
        // -----------------------------------------------------------------------------------------------------------------
        private void pcboxprevious_Click(object sender, EventArgs e)
        {
            pnlgambar2.Hide();
            pnlgambar1.Show();
        }

        private void pcboxnext_Click(object sender, EventArgs e)
        {
            pnlgambar1.Hide();
            pnlgambar2.Show();
        }



        public void btnkirimulasan_Click_1(object sender, EventArgs e)
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
                    command.Parameters.AddWithValue("@isi_ulasan", tboxulasan.Text);
                    command.Parameters.AddWithValue("@tanggal", formattedDate);
                    //command.Parameters.AddWithValue("@id_akun", user.id_user);
                    tboxulasan.Text = "";

                    int ratingValue = 0;

                    if (pilihrating5.Checked)
                    {
                        ratingValue = 5;
                        pilihrating5.Checked = false;
                    }
                    else if (pilihrating4.Checked)
                    {
                        ratingValue = 4;
                        pilihrating4.Checked = false;
                    }
                    else if (pilihrating3.Checked)
                    {
                        ratingValue = 3;
                        pilihrating3.Checked = false;
                    }
                    else if (pilihrating2.Checked)
                    {
                        ratingValue = 2;
                        pilihrating2.Checked = false;
                    }
                    else if (pilihrating1.Checked)
                    {
                        ratingValue = 1;
                        pilihrating1.Checked = false;
                    }

                    command.Parameters.AddWithValue("@rating", ratingValue);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    pnlbackgroundpilihrating.Hide();
                    Refreshing();
                }

                MessageBox.Show("Terimakasih telah memberikan kami ulasan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak berhasil memasukkan data. Error: " + ex.Message);
            }
        }

        // -----------------------------------------------------------------------------------------------------------------
        //                                                  SHOW & HIDE                                                     |
        // -----------------------------------------------------------------------------------------------------------------
        int flag = -1;
        private void pcboxpensil_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                pnlbackgroundpilihrating.Hide();
            else
                pnlbackgroundpilihrating.Show();
        }

        private void Refreshing()
        {
            string[] Category = new string[] { "Urutkan berdasarkan tanggal tebaru diubah", "Urutkan berdasarkan tanggal terlama diubah", "Urutkan berdasarkan rating pengguna" };
            cboxfilter.DataSource = Category;
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
                    lblavgrating.Text = result;
                }

                reader.Close();

                command.CommandText = "SELECT AVG(rating) FROM ulasan";
                object averageRating = command.ExecuteScalar();
                if (averageRating != null)
                {
                    lblavgrating.Text = averageRating.ToString();
                }

                command.CommandText = "SELECT COUNT(id_ulasan) FROM ulasan";
                object countUlasan = command.ExecuteScalar();
                if (countUlasan != null)
                {
                    lblsumrating.Text = countUlasan.ToString() + " ulasan";
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


        private void btnfiltersearch_Click(object sender, EventArgs e)
        {
            if (cboxfilter.SelectedIndex == 0)
            {
                Refreshing();
            }
            else if (cboxfilter.SelectedIndex == 1)
            {
                string[] Category = new string[] { "Urutkan berdasarkan tanggal tebaru diubah", "Urutkan berdasarkan tanggal terlama diubah", "Urutkan berdasarkan rating pengguna" };
                cboxfilter.DataSource = Category;
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
                        lblavgrating.Text = result;
                    }

                    reader.Close();

                    command.CommandText = "SELECT AVG(rating) FROM ulasan";
                    object averageRating = command.ExecuteScalar();
                    if (averageRating != null)
                    {
                        lblavgrating.Text = averageRating.ToString();
                    }

                    command.CommandText = "SELECT COUNT(id_ulasan) FROM ulasan";
                    object countUlasan = command.ExecuteScalar();
                    if (countUlasan != null)
                    {
                        lblsumrating.Text = countUlasan.ToString() + " ulasan";
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
            else if (cboxfilter.SelectedIndex == 2)
            {
                string[] Category = new string[] { "Urutkan berdasarkan tanggal tebaru diubah", "Urutkan berdasarkan tanggal terlama diubah", "Urutkan berdasarkan rating pengguna" };
                cboxfilter.DataSource = Category;
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
                        lblavgrating.Text = result;
                    }

                    reader.Close();

                    command.CommandText = "SELECT AVG(rating) FROM ulasan";
                    object averageRating = command.ExecuteScalar();
                    if (averageRating != null)
                    {
                        lblavgrating.Text = averageRating.ToString();
                    }

                    command.CommandText = "SELECT COUNT(id_ulasan) FROM ulasan";
                    object countUlasan = command.ExecuteScalar();
                    if (countUlasan != null)
                    {
                        lblsumrating.Text = countUlasan.ToString() + " ulasan";
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