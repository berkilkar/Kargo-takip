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
    public partial class Frm_Kargoekle : Form
    {
        public Frm_Kargoekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7EM7F9I\\SQLEXPRESS;Initial Catalog=Db_KargoTakip;Integrated Security=True");




        private void btnokey_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "insert into Tbl_Kargo1(Gön_ad,Gön_Soyad,Gön_TC,Gön_Tel,Gön_il,Al_ad,Al_Soyad,Al_Tc,Al_tel,Al_Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@p1", txtgönad.Text);
            komut.Parameters.AddWithValue("@p2", txtgönsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbgöntc.Text);
            komut.Parameters.AddWithValue("@p4", mtbgöntel.Text);
            komut.Parameters.AddWithValue("@p5", txtgönil.Text);
            komut.Parameters.AddWithValue("@p6", txtalad.Text);
            komut.Parameters.AddWithValue("@p7", txtalsoyad.Text);
            komut.Parameters.AddWithValue("@p8", mtbaltc.Text);
            komut.Parameters.AddWithValue("@p9", mtbaltel.Text);

            komut.Parameters.AddWithValue("@p10", rtbaladres.Text);





            komut.ExecuteNonQuery();
            
            

            baglanti.Close();
            MessageBox.Show("Kargonuz Başarıyla Kaydedildi ,Bizi tercih ettiğiniz için Teşekkürler :)");

        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
