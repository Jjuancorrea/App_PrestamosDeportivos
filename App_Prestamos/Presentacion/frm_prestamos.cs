using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class dtg_prestamos : Form
    {
        public dtg_prestamos()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtExistencias_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtCodigoImplemento.Clear();
            txtDescripcion.Clear();
            txtExistencias.Clear();
            txtDescripcionImplemento.Clear();
            txtCantidadPrestamo.Clear();
            dtg_prestamo.DataSource = null;
            txtIdentificacion.Focus();
        }

        private void txtIdentificacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Negocio.clsPrestamo objPrestamo = new Negocio.clsPrestamo();
                objPrestamo.fnt_consultar
                    (
                    txtIdentificacion.Text
                    );
                txtNombre.Text = objPrestamo.getNombre();
            }
        }
    }
}
