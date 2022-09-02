using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeDocentes
{
    public partial class FrmDocentes : Form
    {
        public FrmDocentes()
        {
            InitializeComponent();
        }
        Clases.PA PA = new Clases.PA();
        private void limpiar() {
            cmbDepto.SelectedIndex = -1;
            cmbMunicipio.SelectedIndex = -1;
            cmbAldea.SelectedIndex = -1;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDocentes_Load(object sender, EventArgs e)
        {
            PA.cmbDepartamento(cmbDepto);
            limpiar();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepto.SelectedIndex != -1) {
                PA.cmbMunicipio(cmbMunicipio, cmbDepto); // Se envía el combobox municipio para ejecutar el proc, el cmbDepto se envía para obtener el departamento seleccionado
                cmbMunicipio.SelectedIndex = -1;
                cmbAldea.SelectedIndex = -1;
            }
        }

        private void cmbAldea_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMunicipio.SelectedIndex != -1)
            {
                PA.cmbAldea(cmbAldea, cmbMunicipio);
                cmbAldea.SelectedIndex = -1;
            }
        }
    }
}
