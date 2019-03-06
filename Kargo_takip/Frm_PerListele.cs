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
    public partial class Frm_PerListele : Form
    {
        public Frm_PerListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7EM7F9I\\SQLEXPRESS;Initial Catalog=Db_KargoTakip;Integrated Security=True");

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void btnara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Personel where per_Id=" + txtperarama.Text + "", baglanti);

            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            baglanti.Close();
        }
    }
}
