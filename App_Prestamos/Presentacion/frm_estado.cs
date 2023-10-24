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
    public partial class frm_estado : Form
    {
        public frm_estado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtNomenclatura.Clear();
            txtCodigo.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Negocio.clsEstado obj_cls_agregarEstado = new Negocio.clsEstado();
            obj_cls_agregarEstado.fnt_guardar
                (
                txtNombre.Text,
                txtCodigo.Text,
                txtNomenclatura.Text
                );
        }

        private void frm_estado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDTG_Estado.tbl_estado' Puede moverla o quitarla según sea necesario.
            this.tbl_estadoTableAdapter.Fill(this.dbs_prestamos_deportivosDTG_Estado.tbl_estado);

        }
    }
}
