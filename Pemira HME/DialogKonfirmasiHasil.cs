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
    public partial class DialogKonfirmasiHasil : Form
    {
        public DialogKonfirmasiHasil()
        {
            InitializeComponent();
        }


        private void lihatButton_Click_1(object sender, EventArgs e)
        {

            if (berakhirnyaPemiraHMECheckBox.CheckState == CheckState.Unchecked || berakhirnyaPemiraHMECheckBox.CheckState == CheckState.Indeterminate)
            {

                MessageBox.Show("Anda harus menyetujui pernyataan");
            }
            else {

                if (usernameTextBox.Text == "jangan" && passwordTextBox.Text == "jangan")
                {

                    new FormLihatHasil().Show();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Mohon maaf username dan password salah");
                }
            }

            
            
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            new FormAdmin().Show();
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

        private void lihatButton_MouseHover(object sender, EventArgs e)
        {
            this.lihatButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.lihat_blue));
        }

        private void lihatButton_MouseLeave(object sender, EventArgs e)
        {
            this.lihatButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.lihat));
        }

        private void berakhirnyaPemiraHMECheckBox_MouseHover(object sender, EventArgs e)
        {
            this.berakhirnyaPemiraHMECheckBox.BackColor = ColorTranslator.FromHtml("#2f5597");
            this.berakhirnyaPemiraHMECheckBox.ForeColor = ColorTranslator.FromHtml("#ffda44");
        }

        private void berakhirnyaPemiraHMECheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.berakhirnyaPemiraHMECheckBox.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.berakhirnyaPemiraHMECheckBox.ForeColor = ColorTranslator.FromHtml("#000000");
        }
    }
}
