using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Pemira_HME
{
    public partial class FormKonfirmasiPemilih : Form
    {
        public FormKonfirmasiPemilih()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "cQOwBdt0Ep4K2IyU6wwzkW8wAMOTXz78Qqo1FmRG",
            BasePath = "https://proyek-pemira-hme.firebaseio.com/"
        };
        IFirebaseClient client;

        public static string nim;
        public static string nama;
        public static string pass;
       
        private async void masukButton_Click_1(object sender, EventArgs e)
        {
            
            string nim = nimTextBox.Text;
            string password = passwordTextBox.Text;
            

            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("DatabaseHME/" + nim);

            try
            {

                Data data = response.ResultAs<Data>();

                if (nim == data.NIM)
                {

                    if (password == data.Password)
                    {
                        nama = data.Nama;
                        pass = data.Password;
                        DialogKonfirmasiPemilih dialogKonfirmasiPemilih = new DialogKonfirmasiPemilih(nim, nama, pass);
                        dialogKonfirmasiPemilih.Show();
                        this.Close();

                        FormPilihPemimpin formPilihPemimpin = new FormPilihPemimpin(nim, nama, pass);
                    }
                    else
                    {

                        checkLabel.Text = "Mohon maaf NIM dan password Anda tidak cocok";
                    }
                }
                else
                {

                    checkLabel.Text = "Mohon maaf NIM Anda tidak terdaftar pada DPT";
                }
            }
            catch (NullReferenceException) {

                checkLabel.Text = "Mohon maaf NIM Anda tidak terdaftar pada DPT";
            }
            
            
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            new FormPilihTipeUser().Show();
            this.Hide();
        }

        private void kembaliButton_MouseHover(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali_blue));
        }

        private void kembaliButton_MouseLeave(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali));
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
