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
        public DialogKonfirmasiPemilih()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormKonfirmasiPemilih().Show();
        }

        private void masukButton_Click(object sender, EventArgs e)
        {
            new FormKonfirmasiPemilih().Close();
            new FormPilihPemimpin().Show();
            this.Close();
            
        }
    }
}
