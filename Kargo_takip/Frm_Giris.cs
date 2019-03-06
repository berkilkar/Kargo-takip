using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kargo_takip
{
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7EM7F9I\\SQLEXPRESS;Initial Catalog=Db_KargoTakip;Integrated Security=True");

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmuyeol fr = new Frmuyeol();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * From Tbl_Uye where Kullanici_adi=@p1 and sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_AnaSayfa fr = new Frm_AnaSayfa();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Lütfen  geçerli kullanıcı adı şifre giriniz.");
            }


            baglanti.Close();
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
