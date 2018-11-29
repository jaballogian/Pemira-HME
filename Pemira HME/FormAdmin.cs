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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void tambahDPTBUtton_Click(object sender, EventArgs e)
        {
            new DialogTambahDPT().Show();
            this.Close();
        
        }

        private void lihatDatabaseButton_Click(object sender, EventArgs e)
        {
            new FormLihatDatabase().Show();
            this.Close();
           
        }

        private void lihatHasilPemiluButton_Click(object sender, EventArgs e)
        {
            new DialogKonfirmasiHasil().Show();
            this.Close();
        }
    }
}
