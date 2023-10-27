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
 
    public class clsImplementos
    {
        private string str_nombre;
        private string str_descripcion;
        private int int_cantidad;
        private double flt_valor;

        clsConexion objConecta = new clsConexion();
        public void fnt_guardar(string codigo, string nombre, string descripcion, int cantidad, double valor)
        {
            if ((codigo == "") || (nombre == "") || (descripcion == "") || (cantidad == 0) || (valor == 0))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(nombre + " " + descripcion + " " + cantidad + " " + valor, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    
                    SqlCommand con = new SqlCommand("SP_RegistrarImplemento", objConecta.connection);
                    con.CommandType = CommandType.StoredProcedure;
                    con.Parameters.AddWithValue("@codigo", codigo);
                    con.Parameters.AddWithValue("@nombre", nombre);
                    con.Parameters.AddWithValue("@especificaciones", descripcion);
                    con.Parameters.AddWithValue("@cantidad", cantidad);
                    con.Parameters.AddWithValue("@valor", valor);

                    objConecta.connection.Open();
                    con.ExecuteNonQuery();
                    objConecta.connection.Close();
                    MessageBox.Show("Registro exitoso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception) { MessageBox.Show("Faltan campos / este registro ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        }
        public void fnt_consultar(string codigo)
        {
            //MessageBox.Show(codigo, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_BuscarImplemento", objConecta.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", codigo);
            objConecta.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                str_nombre = Convert.ToString(Lectura[0]);
                str_descripcion = Convert.ToString(Lectura[1]);
                int_cantidad = Convert.ToInt32(Lectura[2]);
                flt_valor = Convert.ToDouble(Lectura[3]);
            }
            objConecta.connection.Close();
        }
        public string getNombre() { return this.str_nombre; }
        public string getDescripcion() {  return this.str_descripcion; }
        public int getCantidad() { return this.int_cantidad; }
        public double getValor() { return this.flt_valor; }
    }
}
