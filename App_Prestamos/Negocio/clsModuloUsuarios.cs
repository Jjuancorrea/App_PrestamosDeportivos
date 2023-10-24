using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class clsModuloUsuarios
    {
        public void fnt_guardar(string id, string pnombre, string snombre, string papellido, string sapellido, string contacto, string correo,
            string direccion, string sexo)
        {
            if ((id == "") || (pnombre == "") || (snombre == "") || (papellido == "") || (sapellido == "") || (contacto == "") ||
                (correo == "") || (direccion == "") || (sexo == ""))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(id + pnombre + snombre + papellido + sapellido + contacto + correo + direccion + sexo, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    clsConexion objConecta = new clsConexion();
                    SqlCommand con = new SqlCommand("SP_RegistrarPersonas", objConecta.connection);
                    con.CommandType = CommandType.StoredProcedure;
                    con.Parameters.AddWithValue("@id", id);
                    con.Parameters.AddWithValue("@pnombre", pnombre);
                    con.Parameters.AddWithValue("@snombre", snombre);
                    con.Parameters.AddWithValue("@papellido", papellido);
                    con.Parameters.AddWithValue("@sapellido", sapellido);
                    con.Parameters.AddWithValue("@contacto", contacto);
                    con.Parameters.AddWithValue("@correo", correo);
                    con.Parameters.AddWithValue("@direccion", direccion);
                    con.Parameters.AddWithValue("@fksexo", sexo);

                    objConecta.connection.Open();
                    con.ExecuteNonQuery();
                    objConecta.connection.Close();
                    MessageBox.Show("Registro exitoso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception) { MessageBox.Show("Faltan campos / este registro ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        }
    }
}
