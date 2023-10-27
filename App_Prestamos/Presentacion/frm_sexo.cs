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
    public partial class frm_sexo : Form
    {
        public frm_sexo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNomenclatura.Clear();
            txtNombre.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Negocio.clsSexo obj_cls_agregarRol = new Negocio.clsSexo();
            obj_cls_agregarRol.fnt_guardar
                (
                txtCodigo.Text,
                txtNombre.Text,
                txtNomenclatura.Text
                );
        }

        private void frm_sexo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet1.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter.Fill(this.dbs_prestamos_deportivosDataSet1.tbl_sexo);

        }
    }
}
