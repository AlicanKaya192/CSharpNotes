using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_String
{
    public partial class Sinema_Bufe_Satis : Form
    {
        public Sinema_Bufe_Satis()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;

            misir = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);

            toplam = misir * 150 + cay * 40 + su * 10 + bilet * 340;
            LblToplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = "";
            TxtBilet.Text = "";
            TxtSu.Text = "";
            TxtCay.Text = "";
            TxtMisir.Focus();
        }
    }
}
