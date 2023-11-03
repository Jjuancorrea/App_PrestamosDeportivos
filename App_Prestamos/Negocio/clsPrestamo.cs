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
        private string str_implemento;
        private string str_especificaciones;
        private int int_cantidad;
        private double flt_valor;

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
        }
        public void fnt_consultarImplemento(string codigo)
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
                str_implemento = Convert.ToString(Lectura[0]);
                str_especificaciones = Convert.ToString(Lectura[1]);
                int_cantidad = Convert.ToInt16(Lectura[2]);
                flt_valor = Convert.ToDouble(Lectura[3]);
            }
            objConecta.connection.Close();
        }
        public void fnt_prestamo(string id,string user)
        {
            SqlCommand con = new SqlCommand("SP_GenerarPrestamo", objConecta.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id_persona", id);
            con.Parameters.AddWithValue("@user", user);
            objConecta.connection.Open();
            con.ExecuteNonQuery();
            objConecta.connection.Close();
            MessageBox.Show("Prestamo registrado con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void fnt_Det_prestamo(string cod_implement, int cantidad)
        {
            SqlCommand con = new SqlCommand("SP_GenerarDetallePrestamo", objConecta.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@cod_implemento", cod_implement);
            con.Parameters.AddWithValue("@cantidad", cantidad);
            objConecta.connection.Open();
            con.ExecuteNonQuery();
            objConecta.connection.Close();
        }
        public string getNombre() { return this.str_nombre; }
        public string getImplemento() { return this.str_implemento; }
        public string getEspecificaciones() { return this.str_especificaciones; }
        public int getCantidad() { return this.int_cantidad; }
        public double getValor() { return this.flt_valor; }

    }
}
