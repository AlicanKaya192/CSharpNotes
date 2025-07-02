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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALICAN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {

            // Toplam Personel Sayısı
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader(); // Sorgu çalıştırılır ve SqlDataReader ile sonuç okunur
            while (dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString(); // İlk sütundaki değeri alır ve LblPersonelSayisi etiketine atar
            }

            baglanti.Close();

            // Toplam Evli Personel Sayısı
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel WHERE PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader(); // Sorgu çalıştırılır ve SqlDataReader ile sonuç okunur
            while (dr2.Read())
            {
                LblEvliPersonel.Text = dr2[0].ToString(); // İlk sütundaki değeri alır ve LblEvliPersonel etiketine atar
            }

            baglanti.Close();

            // Toplam Bekar Personel Sayısı
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel WHERE PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader(); // Sorgu çalıştırılır ve SqlDataReader ile sonuç okunur
            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString(); // İlk sütundaki değeri alır ve LblEvliPersonel etiketine atar
            }

            baglanti.Close();

            // Toplam Şehir Sayısı
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("SELECT Count(Distinct(PerSehir)) from Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader(); // Sorgu çalıştırılır ve SqlDataReader ile sonuç okunur
            while (dr4.Read())
            {
                LblSehirSayisi.Text = dr4[0].ToString(); // İlk sütundaki değeri alır ve LblEvliPersonel etiketine atar
            }

            baglanti.Close();
            
            // Toplam Maaş Sayısı
            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("SELECT Sum(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader(); // Sorgu çalıştırılır ve SqlDataReader ile sonuç okunur
            while (dr5.Read())
            {
                LblToplamMaas.Text = dr5[0].ToString(); // İlk sütundaki değeri alır ve LblEvliPersonel etiketine atar
            }

            baglanti.Close();

            // Ortalama Maaş Sayısı
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("SELECT Avg(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader(); // Sorgu çalıştırılır ve SqlDataReader ile sonuç okunur
            while (dr6.Read())
            {
                LblOrtalamaMaas.Text = dr6[0].ToString(); // İlk sütundaki değeri alır ve LblEvliPersonel etiketine atar
            }

            baglanti.Close();
        }
    }
}
