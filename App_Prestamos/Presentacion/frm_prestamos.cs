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
    }
}
