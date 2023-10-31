namespace Presentacion
{
    partial class frmModuloUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIdentificacion = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContacto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSapellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPapellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.tblsexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbs_prestamos_deportivosDataSet = new Presentacion.dbs_prestamos_deportivosDataSet();
            this.tbl_sexoTableAdapter = new Presentacion.dbs_prestamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            this.cbxSexo = new MaterialSkin.Controls.MaterialComboBox();
            this.dbs_prestamos_deportivosSexo = new Presentacion.dbs_prestamos_deportivosSexo();
            this.tblsexoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sexoTableAdapter1 = new Presentacion.dbs_prestamos_deportivosSexoTableAdapters.tbl_sexoTableAdapter();
            this.dbs_prestamos_deportivosDataSet2 = new Presentacion.dbs_prestamos_deportivosDataSet2();
            this.tblsexoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sexoTableAdapter2 = new Presentacion.dbs_prestamos_deportivosDataSet2TableAdapters.tbl_sexoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.AnimateReadOnly = false;
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Depth = 0;
            this.txtIdentificacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentificacion.Hint = "Identificación";
            this.txtIdentificacion.LeadingIcon = null;
            this.txtIdentificacion.Location = new System.Drawing.Point(46, 68);
            this.txtIdentificacion.MaxLength = 50;
            this.txtIdentificacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentificacion.Multiline = false;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(170, 50);
            this.txtIdentificacion.TabIndex = 0;
            this.txtIdentificacion.Text = "";
            this.txtIdentificacion.TrailingIcon = null;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(179, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(246, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Formulario de registro de personas";
            // 
            // txtPnombre
            // 
            this.txtPnombre.AnimateReadOnly = false;
            this.txtPnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPnombre.Depth = 0;
            this.txtPnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPnombre.Hint = "Primer nombre";
            this.txtPnombre.LeadingIcon = null;
            this.txtPnombre.Location = new System.Drawing.Point(222, 68);
            this.txtPnombre.MaxLength = 50;
            this.txtPnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPnombre.Multiline = false;
            this.txtPnombre.Name = "txtPnombre";
            this.txtPnombre.Size = new System.Drawing.Size(170, 50);
            this.txtPnombre.TabIndex = 2;
            this.txtPnombre.Text = "";
            this.txtPnombre.TrailingIcon = null;
            this.txtPnombre.TextChanged += new System.EventHandler(this.txtPnombre_TextChanged);
            // 
            // txtSnombre
            // 
            this.txtSnombre.AnimateReadOnly = false;
            this.txtSnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSnombre.Depth = 0;
            this.txtSnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSnombre.Hint = "Segundo nombre";
            this.txtSnombre.LeadingIcon = null;
            this.txtSnombre.Location = new System.Drawing.Point(398, 67);
            this.txtSnombre.MaxLength = 50;
            this.txtSnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSnombre.Multiline = false;
            this.txtSnombre.Name = "txtSnombre";
            this.txtSnombre.Size = new System.Drawing.Size(170, 50);
            this.txtSnombre.TabIndex = 3;
            this.txtSnombre.Text = "";
            this.txtSnombre.TrailingIcon = null;
            this.txtSnombre.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // txtContacto
            // 
            this.txtContacto.AnimateReadOnly = false;
            this.txtContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContacto.Depth = 0;
            this.txtContacto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContacto.Hint = "Contacto";
            this.txtContacto.LeadingIcon = null;
            this.txtContacto.Location = new System.Drawing.Point(398, 123);
            this.txtContacto.MaxLength = 50;
            this.txtContacto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContacto.Multiline = false;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(170, 50);
            this.txtContacto.TabIndex = 6;
            this.txtContacto.Text = "";
            this.txtContacto.TrailingIcon = null;
            // 
            // txtSapellido
            // 
            this.txtSapellido.AnimateReadOnly = false;
            this.txtSapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSapellido.Depth = 0;
            this.txtSapellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSapellido.Hint = "Segundo apellido";
            this.txtSapellido.LeadingIcon = null;
            this.txtSapellido.Location = new System.Drawing.Point(222, 124);
            this.txtSapellido.MaxLength = 50;
            this.txtSapellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSapellido.Multiline = false;
            this.txtSapellido.Name = "txtSapellido";
            this.txtSapellido.Size = new System.Drawing.Size(170, 50);
            this.txtSapellido.TabIndex = 5;
            this.txtSapellido.Text = "";
            this.txtSapellido.TrailingIcon = null;
            // 
            // txtPapellido
            // 
            this.txtPapellido.AnimateReadOnly = false;
            this.txtPapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPapellido.Depth = 0;
            this.txtPapellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPapellido.Hint = "Primer apellido";
            this.txtPapellido.LeadingIcon = null;
            this.txtPapellido.Location = new System.Drawing.Point(46, 124);
            this.txtPapellido.MaxLength = 50;
            this.txtPapellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPapellido.Multiline = false;
            this.txtPapellido.Name = "txtPapellido";
            this.txtPapellido.Size = new System.Drawing.Size(170, 50);
            this.txtPapellido.TabIndex = 4;
            this.txtPapellido.Text = "";
            this.txtPapellido.TrailingIcon = null;
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(304, 235);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(264, 50);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.Hint = "Correo";
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(46, 235);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(252, 50);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            // 
            // tblsexoBindingSource
            // 
            this.tblsexoBindingSource.DataMember = "tbl_sexo";
            this.tblsexoBindingSource.DataSource = this.dbs_prestamos_deportivosDataSet;
            // 
            // dbs_prestamos_deportivosDataSet
            // 
            this.dbs_prestamos_deportivosDataSet.DataSetName = "dbs_prestamos_deportivosDataSet";
            this.dbs_prestamos_deportivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_sexoTableAdapter
            // 
            this.tbl_sexoTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(157, 294);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(253, 294);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.HighEmphasis = true;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(370, 294);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(70, 36);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevo.UseAccentColor = false;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // cbxSexo
            // 
            this.cbxSexo.AutoResize = false;
            this.cbxSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxSexo.DataSource = this.tblsexoBindingSource2;
            this.cbxSexo.Depth = 0;
            this.cbxSexo.DisplayMember = "Nombre";
            this.cbxSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxSexo.DropDownHeight = 174;
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.DropDownWidth = 121;
            this.cbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Hint = "Sexo";
            this.cbxSexo.IntegralHeight = false;
            this.cbxSexo.ItemHeight = 43;
            this.cbxSexo.Location = new System.Drawing.Point(46, 180);
            this.cbxSexo.MaxDropDownItems = 4;
            this.cbxSexo.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(522, 49);
            this.cbxSexo.StartIndex = 0;
            this.cbxSexo.TabIndex = 13;
            this.cbxSexo.ValueMember = "PkId";
            // 
            // dbs_prestamos_deportivosSexo
            // 
            this.dbs_prestamos_deportivosSexo.DataSetName = "dbs_prestamos_deportivosSexo";
            this.dbs_prestamos_deportivosSexo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsexoBindingSource1
            // 
            this.tblsexoBindingSource1.DataMember = "tbl_sexo";
            this.tblsexoBindingSource1.DataSource = this.dbs_prestamos_deportivosSexo;
            // 
            // tbl_sexoTableAdapter1
            // 
            this.tbl_sexoTableAdapter1.ClearBeforeFill = true;
            // 
            // dbs_prestamos_deportivosDataSet2
            // 
            this.dbs_prestamos_deportivosDataSet2.DataSetName = "dbs_prestamos_deportivosDataSet2";
            this.dbs_prestamos_deportivosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsexoBindingSource2
            // 
            this.tblsexoBindingSource2.DataMember = "tbl_sexo";
            this.tblsexoBindingSource2.DataSource = this.dbs_prestamos_deportivosDataSet2;
            // 
            // tbl_sexoTableAdapter2
            // 
            this.tbl_sexoTableAdapter2.ClearBeforeFill = true;
            // 
            // frmModuloUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 370);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtSapellido);
            this.Controls.Add(this.txtPapellido);
            this.Controls.Add(this.txtSnombre);
            this.Controls.Add(this.txtPnombre);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtIdentificacion);
            this.Name = "frmModuloUsuarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmModuloUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtIdentificacion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtPnombre;
        private MaterialSkin.Controls.MaterialTextBox txtSnombre;
        private MaterialSkin.Controls.MaterialTextBox txtContacto;
        private MaterialSkin.Controls.MaterialTextBox txtSapellido;
        private MaterialSkin.Controls.MaterialTextBox txtPapellido;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private dbs_prestamos_deportivosDataSet dbs_prestamos_deportivosDataSet;
        private System.Windows.Forms.BindingSource tblsexoBindingSource;
        private dbs_prestamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter tbl_sexoTableAdapter;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialButton btnNuevo;
        private MaterialSkin.Controls.MaterialComboBox cbxSexo;
        private dbs_prestamos_deportivosSexo dbs_prestamos_deportivosSexo;
        private System.Windows.Forms.BindingSource tblsexoBindingSource1;
        private dbs_prestamos_deportivosSexoTableAdapters.tbl_sexoTableAdapter tbl_sexoTableAdapter1;
        private dbs_prestamos_deportivosDataSet2 dbs_prestamos_deportivosDataSet2;
        private System.Windows.Forms.BindingSource tblsexoBindingSource2;
        private dbs_prestamos_deportivosDataSet2TableAdapters.tbl_sexoTableAdapter tbl_sexoTableAdapter2;
    }
}

