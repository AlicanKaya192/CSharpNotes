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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALICAN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // Grafik 1 - Şehirler

            baglanti.Open();

            SqlCommand komutg1 = new SqlCommand("SELECT PerSehir, COUNT(*) FROM Tbl_Personel GROUP BY PerSehir", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();

            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0].ToString(), dr1[1]);
            }

            baglanti.Close();

            // Grafik 2 - Meslekler

            baglanti.Open();

            SqlCommand komutg2 = new SqlCommand("SELECT PerMeslek, Avg(PerMaas) FROM Tbl_Personel GROUP BY PerMeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();

            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0].ToString(), dr2[1]);
            }

            baglanti.Close();
        }
    }
}
