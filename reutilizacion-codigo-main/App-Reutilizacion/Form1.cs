using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Reutilizacion
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btnWindowsMedia_Click(object sender, EventArgs e)
        {
            Windows_Media_Player player = new Windows_Media_Player();
           player.Show();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PDF_Reader reader = new PDF_Reader();
            reader.Show();
        }
    }
}
