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
    public partial class frm_rol : Form
    {
        public frm_rol()
        {
            InitializeComponent();
        }



        private void frm_rol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDTG_Rol.tbl_rol' Puede moverla o quitarla según sea necesario.
            this.tbl_rolTableAdapter.Fill(this.dbs_prestamos_deportivosDTG_Rol.tbl_rol);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Negocio.clsRol obj_cls_agregarRol = new Negocio.clsRol();
            obj_cls_agregarRol.fnt_guardar
                (
                txtNombre.Text,
                txtCodigo.Text,
                txtNomenclatura.Text
                );
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtNomenclatura.Clear();
            txtCodigo.Focus();
        }
    }
}
