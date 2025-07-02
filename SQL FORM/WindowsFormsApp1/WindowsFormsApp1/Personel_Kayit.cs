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

namespace WindowsFormsApp1
{
    public partial class Personel_Kayit : Form
    {
        public Personel_Kayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALICAN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        void temizle()
        {
            Txtid.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CmbSehir.Text = "";
            MskMaas.Text = "";
            TxtMeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtAd.Focus();
        }

        private void Personel_Kayit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Personel (PerAd, PerSoyad, PerSehir, PerMaas, PerDurum, PerMeslek) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", MskMaas.Text);
            komut.Parameters.AddWithValue("@p5", label8.Text); 
            komut.Parameters.AddWithValue("@p6", TxtMeslek.Text);

            komut.ExecuteNonQuery(); // Tablo sonucunda etki olduğunda kullanılır yani INSERT, UPDATE, DELETE işlemlerinde kullanılır.

            baglanti.Close();
            MessageBox.Show("Personel kaydı başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True"; // Eğer radioButton1 seçiliyse label8'in metni "True" olarak ayarlanır.
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "false"; // Eğer radioButton1 seçiliyse label8'in metni "True" olarak ayarlanır.
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // Seçilen satırın indeksini alır.

            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); // Seçilen satırın ilk hücresindeki değeri alır.
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); // Seçilen satırın ikinci hücresindeki değeri alır.
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString(); // Seçilen satırın üçüncü hücresindeki değeri alır.
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString(); // Seçilen satırın dördüncü hücresindeki değeri alır.
            MskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); // Seçilen satırın beşinci hücresindeki değeri alır.
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString(); // Seçilen satırın altıncı hücresindeki değeri alır.
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString(); // Seçilen satırın altıncı hücresindeki değeri alır.
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true; // Eğer label8'in metni "True" ise radioButton1 seçilir.
            }
            else if (label8.Text == "False")
            {
                radioButton2.Checked = true; // Eğer label8'in metni "False" ise radioButton2 seçilir.
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("DELETE FROM Tbl_Personel WHERE Perid=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", Txtid.Text); // Silinecek personelin ID'sini alır.
            komutsil.ExecuteNonQuery(); // Silme işlemini gerçekleştirir.

            baglanti.Close();
            MessageBox.Show("Personel kaydı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_Personel SET PerAd=@p1, PerSoyad=@p2, PerSehir=@p3, PerMaas=@p4, PerDurum=@p5, PerMeslek=@p6 WHERE Perid=@p7", baglanti);
            komutguncelle.Parameters.AddWithValue("@p1", TxtAd.Text); // Güncellenecek personelin adı.
            komutguncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text); // Güncellenecek personelin soyadı.
            komutguncelle.Parameters.AddWithValue("@p3", CmbSehir.Text); // Güncellenecek personelin şehri.
            komutguncelle.Parameters.AddWithValue("@p4", MskMaas.Text); // Güncellenecek personelin maaşı.
            komutguncelle.Parameters.AddWithValue("@p5", label8.Text); // Güncellenecek personelin durumu (True/False).
            komutguncelle.Parameters.AddWithValue("@p6", TxtMeslek.Text); // Güncellenecek personelin mesleği.
            komutguncelle.Parameters.AddWithValue("@p7", Txtid.Text); // Güncellenecek personelin ID'si.

            komutguncelle.ExecuteNonQuery(); // Güncelleme işlemini gerçekleştirir.
            MessageBox.Show("Personel kaydı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglanti.Close();
        }

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik frmİstatistik = new Frmİstatistik(); // İstatistik formunu oluşturur.
            frmİstatistik.Show(); // İstatistik formunu gösterir.
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler(); // Grafik formunu oluşturur.
            frmGrafikler.Show(); // Grafik formunu gösterir.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Raporlama aracını bir türlü bulamadığım ve ekleyemediğim için bu sayfa şuanlık yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
