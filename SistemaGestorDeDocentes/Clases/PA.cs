using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaGestorDeDocentes.Clases 
{
    internal class PA : conexion
    {
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        public void cmbDepartamento(ComboBox cmbDpto) { 
            cmd = new MySqlCommand("Cargar_Cmb_Dpto",cn);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            cmbDpto.ValueMember = "PKId_Dpto";
            cmbDpto.DisplayMember = "Nombre_Dpto";
            cmbDpto.DataSource = dt;
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.ExecuteNonQuery();
        }
        public void cmbMunicipio(ComboBox cmbMuni, ComboBox cmbDepto)
        {
            cmd = new MySqlCommand("Cargar_Cmb_Muni", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Dpto",cmbDepto.SelectedValue);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            cmbMuni.ValueMember = "PKId_Muni";
            cmbMuni.DisplayMember = "Nombre_Muni";
            cmbMuni.DataSource = dt;
        }
        public void cmbAldea(ComboBox cmbAldea, ComboBox cmbMunicipio)
        {
            cmd = new MySqlCommand("Cargar_Cmb_Aldea", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Muni", cmbMunicipio.SelectedValue);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            cmbAldea.ValueMember = "PKId_Aldea";
            cmbAldea.DisplayMember = "Nombre_Aldea";
            cmbAldea.DataSource = dt;
        }
    }
}
