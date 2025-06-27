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
    public partial class Form1: Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=ALICAN\SQLEXPRESS;Initial Catalog=SatisVT;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ürünlerin Durum Seviyesi
            SqlCommand kritikUrun = new SqlCommand("Execute Test4", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kritikUrun);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Grafiğe Veri Çekme

            //chart1.Series["Akdeniz"].Points.AddXY("Adana", 24);
            //chart1.Series["Akdeniz"].Points.AddXY("Isparta", 21);

            baglanti.Open();
            SqlCommand veriCekme = new SqlCommand("Select KATEGORIAD,COUNT(*) FROM TBLKATEGORI INNER JOIN TBLURUNLER ON TBLKATEGORI.KATEGORIID=TBLURUNLER.KATEGORI GROUP BY KATEGORIAD", baglanti);
            SqlDataReader dr = veriCekme.ExecuteReader();
            while(dr.Read())
            {
                chart1.Series["Kategoriler"].Points.AddXY(dr[0].ToString(), dr[1]);
            }
            baglanti.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnKategori_Click(object sender, EventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.Show();
        }

        private void kapatma_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMüsteriler = new FrmMusteri();
            frmMüsteriler.Show();
        }
    }
}
