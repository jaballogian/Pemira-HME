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
    public partial class DialogTambahDPT : Form
    {
        public DialogTambahDPT()
        {
            InitializeComponent();

            
        }

        //connect to firebase
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "cQOwBdt0Ep4K2IyU6wwzkW8wAMOTXz78Qqo1FmRG",
            BasePath = "https://proyek-pemira-hme.firebaseio.com/"
        };
        IFirebaseClient client;

        //create random password method
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "qwertyuiopasdfghjklzxcvbnm0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private async void tambahButton_Click_1(object sender, EventArgs e)
        {
            string nama = namaTextBox.Text;
            
            string nim = nimTextBox.Text;

            if (nama != "")
            {
                if (nim != "")
                {
                    int value;


                    if (int.TryParse(nim, out value))
                    {
                        if (value >= 13214000 && value <= 18317999)
                        {
                            tambahButton.Enabled = false;

                            client = new FireSharp.FirebaseClient(config);

                            if (client != null)
                            {
                                string password = RandomString(5);
                                var data = new Data
                                {
                                    NIM = nim,
                                    Nama = nama,
                                    Password = password,
                                    Cakahim = 0,
                                    Casenator = 0
                                };
                                
                                SetResponse response = await client.SetTaskAsync("DatabaseHME/" + nim, data);
                                try
                                {
                                    Data result = response.ResultAs<Data>();
                                    new FormAdmin().Show();
                                    this.Close();
                                }
                                catch (NullReferenceException)
                                {
                                    tambahButton.Enabled = true;
                                    checkLabel.Text = "CEK KONEKSI";
                                }
                            }
                        }
                        else
                        {
                            checkLabel.Text = "NIM SALAH";
                        }
                    }
                    else
                    {
                        checkLabel.Text = "NIM HARUS ANGKA";
                    }
                }
                else
                {
                    checkLabel.Text = "NIM MASIH KOSONG";
                }
            }
            else
            {
                checkLabel.Text = "NAMA MASIH KOSONG";
            }
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormAdmin().Show();
        }

        private void kembaliButton_MouseHover(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali_blue));
        }

        private void kembaliButton_MouseLeave(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali));
        }

        private void tambahButton_MouseHover(object sender, EventArgs e)
        {
            this.tambahButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tambahkan_blue));
        }

        private void tambahButton_MouseLeave(object sender, EventArgs e)
        {
            this.tambahButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tambahkan));
        }
        
    }
}
