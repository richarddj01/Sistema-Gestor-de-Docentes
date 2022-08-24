using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaGestorDeDocentes
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if(PanelVertical.Width == 183)
            {
                PanelVertical.Width = 60;
            }
            else
            {
                PanelVertical.Width = 183;
            }
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

       

        private void Panel_Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);

        }

        private void PanelCentral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(Object FormHijo)
        {
            if (this.PanelCentral.Controls.Count > 0)
                this.PanelCentral.Controls.RemoveAt(0);
            {
                Form FO = FormHijo as Form;
                FO.TopLevel = false;
                FO.Dock = DockStyle.Fill;
                this.PanelCentral.Controls.Add(FO);
                this.PanelCentral.Tag = FO;
                FO.Show();
            }
          
        }

        private void BtnDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmDocentes());
        }

        private void BtnColegio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmColegio());
        }

        private void BtnCentroEdu_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmCentroEducativo());
        }

        private void BtnCargo_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmCargo());
        }

        private void BtnDocentesEnCE_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmDocentesEnCE());
        }

        private void BtnZonaGeografica_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmZonaGeografica());
        }

        private void PanelVertical_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
