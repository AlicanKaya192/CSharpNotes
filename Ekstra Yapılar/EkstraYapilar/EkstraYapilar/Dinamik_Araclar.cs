using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraYapilar
{
    public partial class Dinamik_Araclar : Form
    {
        public Dinamik_Araclar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20, 10);

            btn.Location = btnkonum;
            btn.Name = "Button1";
            btn.Text = "Tikla";
            btn.BackColor = Color.Red;
            btn.Height = 50;
            btn.Width = 75;

            Label lb = new Label();
            Point lbkonum = new Point(20, 75);
            lb.Location = lbkonum;
            lb.Name = "Label1";
            lb.Text = "Merhaba";
            lb.BackColor = Color.Yellow;
            lb.AutoSize = true;

            for (int i =1; i <= 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(400, i * 30);
                txt.Location = txtkonum;
                txt.Name = "TextBox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }

            this.Controls.Add(btn);
            this.Controls.Add(lb);
        }
    }
}
