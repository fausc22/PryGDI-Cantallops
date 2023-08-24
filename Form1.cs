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
    public partial class Form1 : Form
    {
        PictureBox basePapel = new PictureBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            
            Graphics papel;
            papel = basePapel.CreateGraphics();
            Pen lapiz = new Pen(Color.White);
            papel.DrawRectangle(lapiz, 10, 10, 100, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Controls.Add(basePapel);
            basePapel.BackColor = Color.Black;
            basePapel.Location = new Point(150, 150);
            basePapel.Size = new Size(300, 300);
        }
    }
}
