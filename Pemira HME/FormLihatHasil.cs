using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Firebase.Database;
using Firebase.Database.Query;

namespace Pemira_HME
{
    public partial class FormLihatHasil : Form
    {

        Bunifu.DataViz.DataPoint datapoint1;
        Bunifu.DataViz.DataPoint datapoint2;

        public FormLihatHasil()
        {
            InitializeComponent();
        }
        
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void FormLihatHasil_Load(object sender, EventArgs e)
        {

            var auth = "cQOwBdt0Ep4K2IyU6wwzkW8wAMOTXz78Qqo1FmRG";
            var firebase = new FirebaseClient(
              "https://proyek-pemira-hme.firebaseio.com/",
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(auth)
              });

            var pemilih = await firebase
              .Child("DatabaseHME")
              .OrderByKey()
              .LimitToFirst(1000)
              .OnceAsync<Data>();

            int pilihan1cakahim = 0;
            int pilihan2cakahim = 0;
            int pilihan3cakahim = 0;
            int pilihan1casenator = 0;
            int pilihan2casenator = 0;
            int pilihan3casenator = 0;

            foreach (var massa in pemilih)
            {
                int value = massa.Object.Cakahim;
                int value2 = massa.Object.Casenator;

                if (value == 0)
                {
                    pilihan3cakahim += 1;
                }
                else if (value == 1)
                {
                    pilihan1cakahim += 1;
                }
                else if (value == 2)
                {
                    pilihan2cakahim += 1;
                }

                if (value2 == 0)
                {
                    pilihan3casenator += 1;
                }
                else if (value2 == 1)
                {
                    pilihan1casenator += 1;
                }
                else if (value2 == 2)
                {
                    pilihan2casenator += 1;
                }
            }

            pemilihNo1.Text = "PILIHAN 1: " + pilihan1cakahim.ToString();
            pemilihNo2.Text = "PILIHAN 2: " + pilihan2cakahim.ToString();
            tidakDatangCakahim.Text = "TIDAK DATANG: " + pilihan3cakahim.ToString();
            pemilihYa.Text = "PEMILIH YA: " + pilihan1casenator.ToString();
            pemilihTidak.Text = "PEMILIH TIDAK: " + pilihan2casenator.ToString();
            tidakDatangCasenator.Text = "TIDAK DATANG: " + pilihan3casenator.ToString();
            Bunifupie(pilihan1cakahim, pilihan2cakahim, pilihan3cakahim, pilihan1casenator, pilihan2casenator, pilihan3casenator);
        }

        private void Bunifupie(int pilihan1cakahim, int pilihan2cakahim, int pilihan3cakahim,
            int pilihan1casenator, int pilihan2casenator, int pilihan3casenator)
        {
            datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_pie);
            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            int total1;
            total1 = pilihan1cakahim + pilihan2cakahim + pilihan3cakahim;
            datapoint1.addLabely("PILIHAN 1: " + Math.Round(((double)pilihan1cakahim * 100 / total1), 2).ToString() + "%", pilihan1cakahim.ToString());
            datapoint1.addLabely("PILIHAN 2: " + Math.Round(((double)pilihan2cakahim * 100 / total1), 2).ToString() + "%", pilihan2cakahim.ToString());
            datapoint1.addLabely("TIDAK DATANG: " + Math.Round(((double)pilihan3cakahim * 100 / total1), 2).ToString() + "%", pilihan3cakahim.ToString());
            canvas.addData(datapoint1);
            diagramPieCakahim.Render(canvas);
            datapoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_pie);
            Bunifu.DataViz.Canvas canvas2 = new Bunifu.DataViz.Canvas();
            int total2;
            total2 = pilihan1casenator + pilihan2casenator + pilihan3casenator;
            datapoint2.addLabely("YA : " + Math.Round(((double)pilihan1casenator * 100 / total2), 2).ToString() + "%", pilihan1casenator.ToString());
            datapoint2.addLabely("TIDAK: " + Math.Round(((double)pilihan2casenator * 100 / total2), 2).ToString() + "%", pilihan2casenator.ToString());
            datapoint2.addLabely("TIDAK DATANG: " + Math.Round(((double)pilihan3casenator * 100 / total2), 2).ToString() + "%", pilihan3casenator.ToString());
            canvas2.addData(datapoint2);
            diagramPieCasenator.Render(canvas2);
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            this.exit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.door_orange));
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            this.exit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.door));
        }
    }
}
