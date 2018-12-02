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
    public partial class FormPilihPemimpin : Form
    {
        string nim, nama, pass;
        int pilihanCakahim, pilihanSenator;

        public FormPilihPemimpin(string nimDariFormKonfirmasiPemilih, string namaDariFormKonfirmasiPemilih, string passwordDariFormKonfirmasiPemilih)
        {
            InitializeComponent();
            nim = nimDariFormKonfirmasiPemilih;
            nama = namaDariFormKonfirmasiPemilih;
            pass = passwordDariFormKonfirmasiPemilih;
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "cQOwBdt0Ep4K2IyU6wwzkW8wAMOTXz78Qqo1FmRG",
            BasePath = "https://proyek-pemira-hme.firebaseio.com/"
        };
        IFirebaseClient client;

        private void pilihan1RadioButton_MouseHover(object sender, EventArgs e)
        {
            this.pilihan1RadioButton.BackColor = ColorTranslator.FromHtml("#2f5597");
            this.pilihan1RadioButton.ForeColor = ColorTranslator.FromHtml("#ffda44");
        }

        private void pilihan1RadioButton_MouseLeave(object sender, EventArgs e)
        {
            this.pilihan1RadioButton.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.pilihan1RadioButton.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void pilihan2RadioButton_MouseHover(object sender, EventArgs e)
        {
            this.pilihan2RadioButton.BackColor = ColorTranslator.FromHtml("#2f5597");
            this.pilihan2RadioButton.ForeColor = ColorTranslator.FromHtml("#ffda44");
        }

        private void pilihan2RadioButton_MouseLeave(object sender, EventArgs e)
        {
            this.pilihan2RadioButton.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.pilihan2RadioButton.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void yaRadioButton_MouseHover(object sender, EventArgs e)
        {
            this.yaRadioButton.BackColor = ColorTranslator.FromHtml("#2f5597");
            this.yaRadioButton.ForeColor = ColorTranslator.FromHtml("#ffda44");
        }

        private void yaRadioButton_MouseLeave(object sender, EventArgs e)
        {
            this.yaRadioButton.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.yaRadioButton.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void tidakRadioButton_MouseHover(object sender, EventArgs e)
        {
            this.tidakRadioButton.BackColor = ColorTranslator.FromHtml("#2f5597");
            this.tidakRadioButton.ForeColor = ColorTranslator.FromHtml("#ffda44");
        }

        private void tidakRadioButton_MouseLeave(object sender, EventArgs e)
        {
            this.tidakRadioButton.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.tidakRadioButton.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private async void kirimButton_Click_1(object sender, EventArgs e)
        {

            if ((pilihan1RadioButton.Checked == false && pilihan2RadioButton.Checked == false) || (yaRadioButton.Checked == false && tidakRadioButton.Checked == false))
            {

                checkLabel.Text = "Mohon maaf, tidak boleh ada data yang kosong";
            }
            else {

                if (pilihan1RadioButton.Checked == true) {

                    pilihanCakahim = 1;
                }
                else if(pilihan2RadioButton.Checked == true){

                    pilihanCakahim = 2;
                }

                if (yaRadioButton.Checked == true)
                {

                    pilihanSenator = 1;
                }
                else if (tidakRadioButton.Checked == true) {

                    pilihanSenator = 2;
                }

                client = new FireSharp.FirebaseClient(config);
                FirebaseResponse responseRead = await client.GetTaskAsync("DatabaseHME/" + nim);

                try
                {

                    var data = new Data
                    {
                        NIM = nim,
                        Nama = nama,
                        Password = pass,
                        Cakahim = pilihanCakahim,
                        Casenator = pilihanSenator
                    };

                    SetResponse responseWrite = await client.SetTaskAsync("DatabaseHME/" + nim, data);

                    try
                    {

                        Data result = responseWrite.ResultAs<Data>();
                        new DialogTerimaKasih().Show();
                        this.Close();
                    }
                    catch (NullReferenceException) {

                        checkLabel.Text = "Mohon maaf, silahkan coba lagi";
                    }

                }
                catch (NullReferenceException) {

                    checkLabel.Text = "Mohon maaf, silahkan coba lagi";
                }
            }

            
        }

        private void kirimButton_MouseHover(object sender, EventArgs e)
        {
            this.kirimButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kirim_blue));
        }

        private void kirimButton_MouseLeave(object sender, EventArgs e)
        {
            this.kirimButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kirim));
        }
    }
}
