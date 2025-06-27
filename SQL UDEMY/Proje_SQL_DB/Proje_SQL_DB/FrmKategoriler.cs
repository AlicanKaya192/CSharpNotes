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

namespace Proje_SQL_DB
{
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ALICAN\SQLEXPRESS;Initial Catalog=SatisVT;Integrated Security=True");

        private void FrmUrunler_Load(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlCommand kategoriListelemekomut = new SqlCommand("Select * From TBLKATEGORI", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kategoriListelemekomut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKategoriID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtKategoriAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Btnkaydet = new SqlCommand("insert into TBLKATEGORI (KATEGORIAD) values (@p1)", baglanti);
            Btnkaydet.Parameters.AddWithValue("@p1", TxtKategoriAD.Text);
            Btnkaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Kaydetme İşlemi Başarılı.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand BtnSil = new SqlCommand("Delete From TBLKATEGORI where KATEGORIID=@p1", baglanti);
            BtnSil.Parameters.AddWithValue("@p1", TxtKategoriID.Text);
            BtnSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Silme İşlemi Başarılı.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand BtnGuncelle = new SqlCommand("Update TBLKATEGORI set KATEGORIAD=@p1 where KATEGORIID=@p2", baglanti);
            BtnGuncelle.Parameters.AddWithValue("@p1", TxtKategoriAD.Text);
            BtnGuncelle.Parameters.AddWithValue("@p2", TxtKategoriID.Text);
            BtnGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Güncelleme İşlemi Başarılı.");
        }
    }
}

// Data Source=ALICAN\SQLEXPRESS;Initial Catalog=SatisVT;Integrated Security=True;
