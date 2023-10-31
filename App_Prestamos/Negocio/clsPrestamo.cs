using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{

    public class clsPrestamo
    {
        private string str_nombre;

        clsConexion objConecta = new clsConexion();
        public void fnt_consultar(string codigo)
        {
            //MessageBox.Show(codigo, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_BuscarPersona", objConecta.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", codigo);
            objConecta.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                str_nombre = Convert.ToString(Lectura[0]);
            }
            objConecta.connection.Close();
            MessageBox.Show(str_nombre, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public string getNombre() { return this.str_nombre; }
    }
}
