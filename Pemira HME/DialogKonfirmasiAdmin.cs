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
    public partial class DialogKonfirmasiAdmin : Form
    {
        public DialogKonfirmasiAdmin()
        {
            InitializeComponent();
        }
        
        private void masukButton_Click_1(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {

                new FormAdmin().Show();
                this.Close();
            }
            else {

                checkLabel.Text = "Mohon maaf username dan password salah";
            }           
            
        }

        private void batalButton_Click(object sender, EventArgs e)
        {
            new FormPilihTipeUser().Show();
            this.Close();
            
        }

        private void batalButton_MouseHover(object sender, EventArgs e)
        {
            this.batalButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali_blue));
        }

        private void batalButton_MouseLeave(object sender, EventArgs e)
        {
            this.batalButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali));
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
