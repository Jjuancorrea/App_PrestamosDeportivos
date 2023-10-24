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
    public class clsEstado
    {
        public void fnt_guardar(string codigo,string nombre, string nomenclatura)
        {
            if ((codigo == "") || (nombre == "") || (nomenclatura == ""))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(nombre +" "+ nomenclatura, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    clsConexion objConecta = new clsConexion();
                    SqlCommand con = new SqlCommand("SP_RegistrarEstado", objConecta.connection);
                    con.CommandType = CommandType.StoredProcedure;
                    con.Parameters.AddWithValue("@codigo", codigo);
                    con.Parameters.AddWithValue("@nombre", nombre);
                    con.Parameters.AddWithValue("@nomenclatura", nomenclatura);

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
