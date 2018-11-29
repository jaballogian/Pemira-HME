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
    public partial class DialogTerimaKasih : Form
    {
        public DialogTerimaKasih()
        {
            InitializeComponent();
        }

        private void selesaiButton_Click(object sender, EventArgs e)
        {
            new FormPilihPemimpin().Close();
            new FormKonfirmasiPemilih().Show() ;
            this.Close();
            
        }
    }
}
