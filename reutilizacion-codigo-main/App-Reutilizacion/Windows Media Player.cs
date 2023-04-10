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
    public partial class Windows_Media_Player : Form
    {
        public Windows_Media_Player()
        {
            InitializeComponent();
        }

        private void btnCargarVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtBoxbuscar.Text = openFileDialog1.FileName;
            }
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            axWMP.URL = txtBoxbuscar.Text;
            axWMP.Ctlcontrols.play();
            
        }

        private void btnpausa_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause();
        }
    }

}
