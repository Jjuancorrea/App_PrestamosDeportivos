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
    public partial class frmModuloUsuarios : Form
    {
        public frmModuloUsuarios()
        {
            InitializeComponent();
        }

        private void frmModuloUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter.Fill(this.dbs_prestamos_deportivosDataSet.tbl_sexo);

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Negocio.clsModuloUsuarios obj_cls_credito_agregar = new Negocio.clsModuloUsuarios();
            obj_cls_credito_agregar.fnt_guardar
                (
                txtIdentificacion.Text,
                txtPnombre.Text,
                txtSnombre.Text,
                txtPapellido.Text,
                txtSapellido.Text,
                txtContacto.Text,
                cbxSexo.SelectedText,
                txtCorreo.Text,
                txtDireccion.Text
                
                );
        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
