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
    public partial class Frmuyeol : Form
    {
        public Frmuyeol()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-7EM7F9I\\SQLEXPRESS;Initial Catalog=Db_KargoTakip;Integrated Security=True");

        private void Frmuyeol_Load(object sender, EventArgs e)
        {

        }

        private void btnokey_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Insert into Tbl_Uye(Uye_AD,Uye_Soyad,TC_kimlik,Telefon_No,Doğum_Tarihi,Kullanici_adi,sifre,Adres)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",baglantı);
            komut.Parameters.AddWithValue("@p1", txtUyeAd.Text);
            komut.Parameters.AddWithValue("@p2", txtUyeSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbtc.Text);
            komut.Parameters.AddWithValue("@p4", mtbtelefon.Text);
            komut.Parameters.AddWithValue("@p5", mtbdogum.Text);
            komut.Parameters.AddWithValue("@p6", txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p7", txtsifre.Text);
            komut.Parameters.AddWithValue("@p8", rtbaladres.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Üyeliğiniz Başarıyla Eklendi.");
            baglantı.Close();
            
                
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
