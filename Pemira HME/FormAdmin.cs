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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        
        
        private void tambahDPTBUtton_Click_1(object sender, EventArgs e)
        {
            new DialogTambahDPT().Show();
            this.Close();
        }

        private void lihatDatabaseButton_Click_1(object sender, EventArgs e)
        {
            new FormLihatDatabase().Show();
            this.Close();
        }

        private void lihatHasilPemiluButton_Click_1(object sender, EventArgs e)
        {
            new DialogKonfirmasiHasil().Show();
            this.Close();
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            new FormPilihTipeUser().Show();
            this.Close();
        }

        private void tambahDPTBUtton_MouseHover(object sender, EventArgs e)
        {
            this.tambahDPTBUtton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tambah_dpt_blue));
        }

        private void tambahDPTBUtton_MouseLeave(object sender, EventArgs e)
        {
            this.tambahDPTBUtton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tambah_dpt));
        }

        private void lihatDatabaseButton_MouseHover(object sender, EventArgs e)
        {
            this.lihatDatabaseButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.lihat_database_blue));
        }

        private void lihatDatabaseButton_MouseLeave(object sender, EventArgs e)
        {
            this.lihatDatabaseButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.lihat_database));
        }

        private void lihatHasilPemiluButton_MouseHover(object sender, EventArgs e)
        {
            this.lihatHasilPemiluButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.lihat_hasil_blue));
        }

        private void lihatHasilPemiluButton_MouseLeave(object sender, EventArgs e)
        {
            this.lihatHasilPemiluButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.lihat_hasil));
        }

        private void kembaliButton_MouseHover(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali_besar_blue));
        }

        private void kembaliButton_MouseLeave(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali_besar));
        }
    }
}
