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
    public partial class DialogKonfirmasiAdmin : Form
    {
        public DialogKonfirmasiAdmin()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormPilihTipeUser().Show();
        }

        private void masukButton_Click(object sender, EventArgs e)
        {
            new FormPilihTipeUser().Close();
            new FormAdmin().Show();
            this.Close();
            
            
        }
    }
}
