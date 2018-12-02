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
    public partial class FormLihatDatabase : Form
    {
        public FormLihatDatabase()
        {
            InitializeComponent();
        }

        

        private void kembaliButton_Click_1(object sender, EventArgs e)
        {
            new FormAdmin().Show();
            this.Close();
        }

        private void kembaliButton_MouseHover(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali_panjang_blue));
        }

        private void kembaliButton_MouseLeave(object sender, EventArgs e)
        {
            this.kembaliButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kembali_panjang));
        }

       

        private async void FormLihatDatabase_Load_1(object sender, EventArgs e)
        {
            var auth = "cQOwBdt0Ep4K2IyU6wwzkW8wAMOTXz78Qqo1FmRG";
            var firebase = new FirebaseClient(
              "https://proyek-pemira-hme.firebaseio.com/",
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(auth)
              });

            DataTable data = new DataTable();

            var pemilih = await firebase
              .Child("DatabaseHME")
              .OrderByKey()
              .LimitToFirst(1000)
              .OnceAsync<Data>();

            data.Columns.Add("Nama");
            data.Columns.Add("NIM");
            data.Columns.Add("Password");

            foreach (var massa in pemilih)
            {
                DataRow row = data.NewRow();
                row["Nama"] = massa.Object.Nama;
                row["NIM"] = massa.Object.NIM;
                row["Password"] = massa.Object.Password;
                data.Rows.Add(row);
            }

            databaseHME.DataSource = data;
            this.databaseHME.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.databaseHME.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.databaseHME.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
    
}
