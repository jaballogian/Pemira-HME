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
    public partial class DialogKonfirmasiHasil : Form
    {
        public DialogKonfirmasiHasil()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormAdmin().Show();
        }

        
        private void lihatButton_Click_1(object sender, EventArgs e)
        {
            new FormAdmin().Close();
            new FormLihatHasil().Show();
            this.Close();
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormAdmin().Show();
        }
    }
}
