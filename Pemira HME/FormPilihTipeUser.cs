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

        private void masukSebagaiAdminButton_MouseHover(object sender, EventArgs e)
        {
            this.masukSebagaiAdminButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.masuk_sebagai_admin_blue));
        }

        private void masukSebagaiAdminButton_MouseLeave(object sender, EventArgs e)
        {
            this.masukSebagaiAdminButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.masuk_sebagai_admin6));
        }

        private void masukSebagaiPemilihButton_MouseHover(object sender, EventArgs e)
        {
            this.masukSebagaiPemilihButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.masuk_sebagai_pemilih_blue));
        }

        private void masukSebagaiPemilihButton_MouseLeave(object sender, EventArgs e)
        {
            this.masukSebagaiPemilihButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.masuk_sebagai_pemilih3));
        }

        private void tentangButton_MouseHover(object sender, EventArgs e)
        {
            this.tentangButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tentang_blue));
        }

        private void tentangButton_MouseLeave(object sender, EventArgs e)
        {
            this.tentangButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tentang));
        }

        private void keluarButton_MouseHover(object sender, EventArgs e)
        {
            this.keluarButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.keluar_biru));
        }

        private void keluarButton_MouseLeave(object sender, EventArgs e)
        {
            this.keluarButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.keluar1));
        }
    }
}
