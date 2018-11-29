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
    public partial class FormLihatDatabase : Form
    {
        public FormLihatDatabase()
        {
            InitializeComponent();
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            new FormAdmin().Show();
            this.Close();
            
        }
    }
}
