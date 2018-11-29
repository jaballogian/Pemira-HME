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
    public partial class FormPilihTipeUser : Form
    {
        public FormPilihTipeUser()
        {
            InitializeComponent();
        }



        private void masukSebagaiAdminButton_Click(object sender, EventArgs e)
        {
            new DialogKonfirmasiAdmin().Show();
            this.Hide();
        }

        private void keluarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tentangButton_Click(object sender, EventArgs e)
        {
            new DialogTerimaKasih().Show();
            this.Hide();
        }

        private void masukSebagaiPemilihButton_Click(object sender, EventArgs e)
        {
            new FormKonfirmasiPemilih().Show();
            this.Hide();
        }



        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            new DialogTerimaKasih().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
