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
    public partial class frmGDI : Form
    {
        Pen lapiz = new Pen(Color.Blue);
        Graphics lienzo;
        public frmGDI()
        {
            InitializeComponent();
        }

        private void frmGDI_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            btnDibujar.Hide();
            temporizador.Enabled = true;
        }

        int ejeX, ejeY = 0;
        Random aleatorioX = new Random();
        Random aleatorioY = new Random();

        private void frmGDI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            ejeX = aleatorioX.Next(0, 798);
            ejeY = aleatorioY.Next(0, 449);
            picNave.Location = new Point(ejeX, 449);
            picPelota.Location = new Point(ejeX, ejeY);
        }

        

    }
}
