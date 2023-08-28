
namespace PryGDI_Cantallops
{
    partial class frmGDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contenedor = new System.Windows.Forms.PictureBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.picNave = new System.Windows.Forms.PictureBox();
            this.picPelota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(1, 1);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(798, 449);
            this.contenedor.TabIndex = 0;
            this.contenedor.TabStop = false;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(713, 12);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 1;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // temporizador
            // 
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picNave.Location = new System.Drawing.Point(12, 413);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(134, 25);
            this.picNave.TabIndex = 2;
            this.picNave.TabStop = false;
            // 
            // picPelota
            // 
            this.picPelota.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picPelota.Location = new System.Drawing.Point(307, 231);
            this.picPelota.Name = "picPelota";
            this.picPelota.Size = new System.Drawing.Size(17, 18);
            this.picPelota.TabIndex = 3;
            this.picPelota.TabStop = false;
            // 
            // frmGDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPelota);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.contenedor);
            this.Name = "frmGDI";
            this.Text = "frmGDI";
            this.Load += new System.EventHandler(this.frmGDI_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmGDI_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox contenedor;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.PictureBox picPelota;
    }
}