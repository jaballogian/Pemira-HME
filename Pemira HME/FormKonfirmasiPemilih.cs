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
    public partial class FormKonfirmasiPemilih : Form
    {
        public FormKonfirmasiPemilih()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void masukButton_Click_1(object sender, EventArgs e)
        {
            new DialogKonfirmasiPemilih().Show();
            this.Close();
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            new FormPilihTipeUser().Show();
            this.Hide();
        }
    }
}
