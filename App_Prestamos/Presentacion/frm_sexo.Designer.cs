namespace Presentacion
{
    partial class frm_sexo
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
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNomenclatura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dbs_prestamos_deportivosDataSet1 = new Presentacion.dbs_prestamos_deportivosDataSet1();
            this.tblsexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sexoTableAdapter = new Presentacion.dbs_prestamos_deportivosDataSet1TableAdapters.tbl_sexoTableAdapter();
            this.pkIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomenclaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(141, 224);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(42, 224);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(91, 36);
            this.btnIngresar.TabIndex = 43;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nomenclaturaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblsexoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(419, 114);
            this.dataGridView1.TabIndex = 63;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(38, 278);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 62;
            this.materialLabel2.Text = "Sexos existentes";
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(41, 109);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(419, 50);
            this.txtNombre.TabIndex = 61;
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
            this.txtNomenclatura.Location = new System.Drawing.Point(41, 165);
            this.txtNomenclatura.MaxLength = 50;
            this.txtNomenclatura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomenclatura.Multiline = false;
            this.txtNomenclatura.Name = "txtNomenclatura";
            this.txtNomenclatura.Size = new System.Drawing.Size(419, 50);
            this.txtNomenclatura.TabIndex = 60;
            this.txtNomenclatura.Text = "";
            this.txtNomenclatura.TrailingIcon = null;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.Hint = "Código";
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(41, 53);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(419, 50);
            this.txtCodigo.TabIndex = 57;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(205, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 56;
            this.materialLabel1.Text = "Ingresar sexo";
            // 
            // dbs_prestamos_deportivosDataSet1
            // 
            this.dbs_prestamos_deportivosDataSet1.DataSetName = "dbs_prestamos_deportivosDataSet1";
            this.dbs_prestamos_deportivosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsexoBindingSource
            // 
            this.tblsexoBindingSource.DataMember = "tbl_sexo";
            this.tblsexoBindingSource.DataSource = this.dbs_prestamos_deportivosDataSet1;
            // 
            // tbl_sexoTableAdapter
            // 
            this.tbl_sexoTableAdapter.ClearBeforeFill = true;
            // 
            // pkIdDataGridViewTextBoxColumn
            // 
            this.pkIdDataGridViewTextBoxColumn.DataPropertyName = "PkId";
            this.pkIdDataGridViewTextBoxColumn.HeaderText = "PkId";
            this.pkIdDataGridViewTextBoxColumn.Name = "pkIdDataGridViewTextBoxColumn";
            this.pkIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frm_sexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNomenclatura);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Name = "frm_sexo";
            this.Text = "frm_sexo";
            this.Load += new System.EventHandler(this.frm_sexo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtNomenclatura;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private dbs_prestamos_deportivosDataSet1 dbs_prestamos_deportivosDataSet1;
        private System.Windows.Forms.BindingSource tblsexoBindingSource;
        private dbs_prestamos_deportivosDataSet1TableAdapters.tbl_sexoTableAdapter tbl_sexoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomenclaturaDataGridViewTextBoxColumn;
    }
}