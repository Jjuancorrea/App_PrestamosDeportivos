namespace Presentacion
{
    partial class frm_rol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNomenclatura = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.dbs_prestamos_deportivosDTG_Rol = new Presentacion.dbs_prestamos_deportivosDTG_Rol();
            this.tblrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_rolTableAdapter = new Presentacion.dbs_prestamos_deportivosDTG_RolTableAdapters.tbl_rolTableAdapter();
            this.pkCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomenclaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDTG_Rol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(210, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "Ingresar rol";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkCodigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nomenclaturaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblrolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(419, 114);
            this.dataGridView1.TabIndex = 55;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(43, 288);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 19);
            this.materialLabel2.TabIndex = 54;
            this.materialLabel2.Text = "Roles existentes";
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(46, 119);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(419, 50);
            this.txtNombre.TabIndex = 53;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtNomenclatura
            // 
            this.txtNomenclatura.AnimateReadOnly = false;
            this.txtNomenclatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomenclatura.Depth = 0;
            this.txtNomenclatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomenclatura.Hint = "Nomenclatura";
            this.txtNomenclatura.LeadingIcon = null;
            this.txtNomenclatura.Location = new System.Drawing.Point(46, 175);
            this.txtNomenclatura.MaxLength = 50;
            this.txtNomenclatura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomenclatura.Multiline = false;
            this.txtNomenclatura.Name = "txtNomenclatura";
            this.txtNomenclatura.Size = new System.Drawing.Size(419, 50);
            this.txtNomenclatura.TabIndex = 52;
            this.txtNomenclatura.Text = "";
            this.txtNomenclatura.TrailingIcon = null;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(145, 234);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(46, 234);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(91, 36);
            this.btnIngresar.TabIndex = 50;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.Hint = "Código";
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(46, 63);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(419, 50);
            this.txtCodigo.TabIndex = 49;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            // 
            // dbs_prestamos_deportivosDTG_Rol
            // 
            this.dbs_prestamos_deportivosDTG_Rol.DataSetName = "dbs_prestamos_deportivosDTG_Rol";
            this.dbs_prestamos_deportivosDTG_Rol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblrolBindingSource
            // 
            this.tblrolBindingSource.DataMember = "tbl_rol";
            this.tblrolBindingSource.DataSource = this.dbs_prestamos_deportivosDTG_Rol;
            // 
            // tbl_rolTableAdapter
            // 
            this.tbl_rolTableAdapter.ClearBeforeFill = true;
            // 
            // pkCodigoDataGridViewTextBoxColumn
            // 
            this.pkCodigoDataGridViewTextBoxColumn.DataPropertyName = "PkCodigo";
            this.pkCodigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.pkCodigoDataGridViewTextBoxColumn.Name = "pkCodigoDataGridViewTextBoxColumn";
            this.pkCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomenclaturaDataGridViewTextBoxColumn
            // 
            this.nomenclaturaDataGridViewTextBoxColumn.DataPropertyName = "Nomenclatura";
            this.nomenclaturaDataGridViewTextBoxColumn.HeaderText = "Nomenclatura";
            this.nomenclaturaDataGridViewTextBoxColumn.Name = "nomenclaturaDataGridViewTextBoxColumn";
            this.nomenclaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNomenclatura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frm_rol";
            this.Text = "frm_rol";
            this.Load += new System.EventHandler(this.frm_rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDTG_Rol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtNomenclatura;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private dbs_prestamos_deportivosDTG_Rol dbs_prestamos_deportivosDTG_Rol;
        private System.Windows.Forms.BindingSource tblrolBindingSource;
        private dbs_prestamos_deportivosDTG_RolTableAdapters.tbl_rolTableAdapter tbl_rolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomenclaturaDataGridViewTextBoxColumn;
    }
}