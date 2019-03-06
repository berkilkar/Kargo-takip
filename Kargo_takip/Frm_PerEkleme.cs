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
    public partial class Frm_PerEkleme : Form
    {
        public Frm_PerEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7EM7F9I\\SQLEXPRESS;Initial Catalog=Db_KargoTakip;Integrated Security=True");

        private void btnexit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void btnokey_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel(Per_AD,Per_Soyad,Per_Tc,Per_Tel,Per_Cinsiyet)values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtperad.Text);
            komut.Parameters.AddWithValue("@p2", txtpersoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbpertc.Text);
            komut.Parameters.AddWithValue("@p4", mtbtel.Text);
            komut.Parameters.AddWithValue("@p5", cmbPerCinsiyet.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Başarıyla Eklendi");
        }
    }
}
