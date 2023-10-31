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
    public partial class frm_implementos : Form
    {
        public frm_implementos()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCantidad.Clear();
            txtDescripcion.Clear();
            txtNombre.Clear();
            txtValor.Clear();
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Negocio.clsImplementos obj_cls_agregarImplemento = new Negocio.clsImplementos();
            obj_cls_agregarImplemento.fnt_guardar
                (
                txtCodigo.Text,
                txtNombre.Text,
                txtDescripcion.Text,
                Convert.ToInt16(txtCantidad.Text),
                Convert.ToDouble(txtValor.Text)
                );
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frm_implementos_Load(object sender, EventArgs e)
        {

        }

    

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Negocio.clsImplementos obj_cls_buscarImplemento = new Negocio.clsImplementos();
                obj_cls_buscarImplemento.fnt_consultar
                    (
                    txtCodigo.Text
                    );
                txtNombre.Text = obj_cls_buscarImplemento.getNombre();
                txtDescripcion.Text = obj_cls_buscarImplemento.getDescripcion();
                txtCantidad.Text = Convert.ToString(obj_cls_buscarImplemento.getCantidad());
                txtValor.Text = Convert.ToString(obj_cls_buscarImplemento.getValor());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Negocio.clsImplementos obj_Actualizar= new Negocio.clsImplementos();
            obj_Actualizar.fnt_actualizar
                (
                txtCodigo.Text,
                txtNombre.Text,
                txtDescripcion.Text,
                Convert.ToInt16(txtCantidad.Text),
                Convert.ToDouble(txtValor.Text)
                );
        }
    }
}
