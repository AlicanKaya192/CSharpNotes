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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ALICAN\SQLEXPRESS;Initial Catalog=SatisVT;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLMUSTERI", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            Listele();
            baglanti.Open();
            SqlCommand sehirKomut = new SqlCommand("Select * From TBLSEHIRLER", baglanti);
            SqlDataReader dr = sehirKomut.ExecuteReader();
            while (dr.Read())
            {
                CmbSehir.Items.Add(dr["SEHIRAD"].ToString());
            }
            baglanti.Close();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAD.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtBakiye.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kaydetMusteri = new SqlCommand("INSERT INTO TBLMUSTERI (MUSTERIAD,MUSTERISOYAD,MUSTERISEHIR,MUSTERIBAKIYE) VALUES (@P1,@P2,@P3,@P4)", baglanti);
            kaydetMusteri.Parameters.AddWithValue("@P1", TxtAD.Text);
            kaydetMusteri.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            kaydetMusteri.Parameters.AddWithValue("@P3", CmbSehir.Text.ToUpper());
            kaydetMusteri.Parameters.AddWithValue("@P4", decimal.Parse(TxtBakiye.Text));
            kaydetMusteri.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Sisteme Kaydetme İşlemi Başarılı.");
            Listele(); 
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand silMusteri = new SqlCommand("Delete From TBLMUSTERI where MUSTERIID=@p1", baglanti);
            silMusteri.Parameters.AddWithValue("@p1", TxtID.Text);
            silMusteri.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Silme İşlemi Başarılı.");
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelleMusteri = new SqlCommand("Update TBLMUSTERI set MUSTERIAD=@p1,MUSTERISOYAD=@p2,MUSTERISEHIR=@p3,MUSTERIBAKIYE=@p4 where MUSTERIID=@p5", baglanti);
            guncelleMusteri.Parameters.AddWithValue("@p1", TxtAD.Text);
            guncelleMusteri.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            guncelleMusteri.Parameters.AddWithValue("@p3", CmbSehir.Text.ToUpper());
            guncelleMusteri.Parameters.AddWithValue("@p4", decimal.Parse(TxtBakiye.Text));
            guncelleMusteri.Parameters.AddWithValue("@p5", TxtID.Text);
            guncelleMusteri.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Güncelleme İşlemi Başarılı.");
            Listele();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlCommand araKomut = new SqlCommand("Select * From TBLMUSTERI where MUSTERIAD=@p1", baglanti);
            araKomut.Parameters.AddWithValue("@p1", TxtAD.Text);
            SqlDataAdapter da = new SqlDataAdapter(araKomut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
