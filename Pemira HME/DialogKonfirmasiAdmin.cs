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

      
        

        private void masukButton_Click_1(object sender, EventArgs e)
        {
            new FormPilihTipeUser().Close();
            new FormAdmin().Show();
            this.Close();
        }

        private void batalButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormPilihTipeUser().Show();
        }
    }
}
