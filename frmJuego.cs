using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGDI_Cantallops
{
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
        }
        private int pictureBoxSpeed = 5;

        private void frmJuego_Load(object sender, EventArgs e)
        {

        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (picNave.Left > 0)
                {
                    picNave.Left -= pictureBoxSpeed;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (picNave.Right < ClientSize.Width)
                {
                    picNave.Left += pictureBoxSpeed;
                }
            }
        }
    }
}








