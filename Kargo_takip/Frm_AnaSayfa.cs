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
    public partial class Frm_AnaSayfa : Form
    {
        public Frm_AnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-7EM7F9I\\SQLEXPRESS;Initial Catalog=Db_KargoTakip;Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_PerListele listele = new Frm_PerListele();
            listele.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_PerEkleme ekle = new Frm_PerEkleme();
            ekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Kargoekle fr = new Frm_Kargoekle();
            fr.Show();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kargo1 where Kargo_ID  =" + txtkargoıd.Text + "", baglantı);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            baglantı.Close();
        }

        

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
