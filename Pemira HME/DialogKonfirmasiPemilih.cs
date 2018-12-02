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
    public partial class DialogKonfirmasiPemilih : Form
    {

        string nim, nama, pass;

        public DialogKonfirmasiPemilih(string nimDariFormKonfirmasiPemilih, string namaDariFormKonfirmasiPemilih, string passwordDariFormKonfirmasiPemilih)
        {
            InitializeComponent();
            nim = nimDariFormKonfirmasiPemilih;
            nama = namaDariFormKonfirmasiPemilih;
            pass = passwordDariFormKonfirmasiPemilih;

            nimLabel.Text = nim;
            namaLabel.Text = nama;
        }

        
        private void masukButton_Click_1(object sender, EventArgs e)
        {

            if (identitasSaya.CheckState == CheckState.Unchecked || identitasSaya.CheckState == CheckState.Indeterminate)
            {

                checkLabel.Text = "Anda harus menyetujui pernyataan";
            }
            else {

                FormPilihPemimpin formPilihPemimpin = new FormPilihPemimpin(nim, nama, pass);
                formPilihPemimpin.Show();
                this.Close();
            }
            
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            new FormKonfirmasiPemilih().Show();
            this.Close();
        }

        private void kembaliButton_MouseHover(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali_blue));
        }

        private void kembaliButton_MouseLeave(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali));
        }

        private void identitasSaya_MouseHover(object sender, EventArgs e)
        {
            this.identitasSaya.BackColor = ColorTranslator.FromHtml("#2f5597");
            this.identitasSaya.ForeColor = ColorTranslator.FromHtml("#ffda44");
        }

        private void identitasSaya_MouseLeave(object sender, EventArgs e)
        {
            this.identitasSaya.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.identitasSaya.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        

        private void masukButton_MouseHover(object sender, EventArgs e)
        {
            this.masukButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.masuk_blue));
        }

        private void masukButton_MouseLeave(object sender, EventArgs e)
        {
            this.masukButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.masuk));
        }
    }
}
