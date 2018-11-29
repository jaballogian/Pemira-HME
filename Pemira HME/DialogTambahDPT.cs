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
    public partial class DialogTambahDPT : Form
    {
        public DialogTambahDPT()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormAdmin().Show();
        }

        private void tambahButton_Click(object sender, EventArgs e)
        {
            new FormAdmin().Show();
            this.Close();
            

        }
    }
}
