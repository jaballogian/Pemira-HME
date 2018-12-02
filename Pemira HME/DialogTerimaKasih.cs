using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemira_HME
{
    public partial class DialogTerimaKasih : Form
    {
        public DialogTerimaKasih()
        {
            InitializeComponent();
        }

        

        private void selesaiButton_Click_1(object sender, EventArgs e)
        {
            new FormKonfirmasiPemilih().Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selesaiButton_MouseHover(object sender, EventArgs e)
        {
            this.selesaiButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.selesai_blue));
        }

        private void selesaiButton_MouseLeave(object sender, EventArgs e)
        {
            this.selesaiButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.selesai));
        }
    }
}
