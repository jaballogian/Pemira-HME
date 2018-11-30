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

        

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            new DialogTerimaKasih().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Test().Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void masukSebagaiAdminButton_Click_1(object sender, EventArgs e)
        {
            new DialogKonfirmasiAdmin().Show();
            this.Hide();
        }

        private void masukSebagaiPemilihButton_Click_1(object sender, EventArgs e)
        {
            new FormKonfirmasiPemilih().Show();
            this.Hide();
        }

        private void tentangButton_Click_1(object sender, EventArgs e)
        {
            new DialogTerimaKasih().Show();
            this.Hide();
        }

        private void keluarButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
