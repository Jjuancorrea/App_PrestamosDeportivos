using Negocio;
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
    public partial class frm_prestamos : Form
    {
        public frm_prestamos()
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
            txtNombreImplemento.Clear();
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

        private void txtCodigoImplemento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Negocio.clsPrestamo objPrestamoo = new Negocio.clsPrestamo();
                objPrestamoo.fnt_consultarImplemento
                    (
                    txtCodigoImplemento.Text
                    );
                txtDescripcion.Text = objPrestamoo.getEspecificaciones();
                txtNombreImplemento.Text = objPrestamoo.getImplemento();
                txtExistencias.Text=""+objPrestamoo.getCantidad();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(txtCantidadPrestamo.Text)<= Convert.ToInt16(txtExistencias.Text))
            {
                dtg_prestamo.Rows.Add(
                    txtCodigoImplemento.Text, txtCantidadPrestamo.Text
                );
            }
            else
            {
                MessageBox.Show("No puedes superar la cantidad de existencias", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_prestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            clsPrestamo obj_prestar=new clsPrestamo();
            obj_prestar.fnt_prestamo(txtIdentificacion.Text, "1007.JuanCorrea");
            for(int i = 0;i < dtg_prestamo.RowCount; i++)
            {
                obj_prestar.fnt_Det_prestamo(Convert.ToString(dtg_prestamo.Rows[i].Cells[0].Value),
                    Convert.ToInt16(dtg_prestamo.Rows[i].Cells[1].Value));
            }
        }
    }
}
