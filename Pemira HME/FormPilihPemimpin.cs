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
    public partial class FormPilihPemimpin : Form
    {
        public FormPilihPemimpin()
        {
            InitializeComponent();
        }

        
        private void kirimButton_Click_1(object sender, EventArgs e)
        {
            new DialogTerimaKasih().Show();
            this.Close();
        }
    }
}
