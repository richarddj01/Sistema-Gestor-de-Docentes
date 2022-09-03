using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaGestorDeDocentes.Clases
{
    internal class conexion
    {
        public MySqlConnection cn = new MySqlConnection("datasource = rdjp.net;port=3306;username=richarddj;password=xD.Rdj01;database=Sistema_Gestor_De_Docentes;");
        public void abrircn()
        {
            try
            {
                cn.Open();
            }
            catch (Exception e) {
                MessageBox.Show("Error al conectar a base de datos: "+e);
            }
        }   
    }
}
