﻿namespace Presentacion
{
    partial class frm_estado
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNomenclatura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbs_prestamos_deportivosDTG_Estado = new Presentacion.dbs_prestamos_deportivosDTG_Estado();
            this.tblestadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_estadoTableAdapter = new Presentacion.dbs_prestamos_deportivosDTG_EstadoTableAdapters.tbl_estadoTableAdapter();
            this.pkCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomenclaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDTG_Estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblestadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(156, 227);
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
            this.btnIngresar.Location = new System.Drawing.Point(57, 227);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(210, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 42;
            this.materialLabel1.Text = "Ingresar estado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.Hint = "Código";
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(57, 56);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(419, 50);
            this.txtCodigo.TabIndex = 40;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            // 
            // txtNomenclatura
            // 
            this.txtNomenclatura.AnimateReadOnly = false;
            this.txtNomenclatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomenclatura.Depth = 0;
            this.txtNomenclatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomenclatura.Hint = "Nomenclatura";
            this.txtNomenclatura.LeadingIcon = null;
            this.txtNomenclatura.Location = new System.Drawing.Point(57, 168);
            this.txtNomenclatura.MaxLength = 50;
            this.txtNomenclatura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomenclatura.Multiline = false;
            this.txtNomenclatura.Name = "txtNomenclatura";
            this.txtNomenclatura.Size = new System.Drawing.Size(419, 50);
            this.txtNomenclatura.TabIndex = 45;
            this.txtNomenclatura.Text = "";
            this.txtNomenclatura.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(57, 112);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(419, 50);
            this.txtNombre.TabIndex = 46;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(54, 281);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(133, 19);
            this.materialLabel2.TabIndex = 47;
            this.materialLabel2.Text = "Estados existentes";
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
            this.dataGridView1.DataSource = this.tblestadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(419, 114);
            this.dataGridView1.TabIndex = 48;
            // 
            // dbs_prestamos_deportivosDTG_Estado
            // 
            this.dbs_prestamos_deportivosDTG_Estado.DataSetName = "dbs_prestamos_deportivosDTG_Estado";
            this.dbs_prestamos_deportivosDTG_Estado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblestadoBindingSource
            // 
            this.tblestadoBindingSource.DataMember = "tbl_estado";
            this.tblestadoBindingSource.DataSource = this.dbs_prestamos_deportivosDTG_Estado;
            // 
            // tbl_estadoTableAdapter
            // 
            this.tbl_estadoTableAdapter.ClearBeforeFill = true;
            // 
            // pkCodigoDataGridViewTextBoxColumn
            // 
            this.pkCodigoDataGridViewTextBoxColumn.DataPropertyName = "PkCodigo";
            this.pkCodigoDataGridViewTextBoxColumn.HeaderText = "PkCodigo";
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
            // frm_estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNomenclatura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frm_estado";
            this.Text = "frm_estado";
            this.Load += new System.EventHandler(this.frm_estado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDTG_Estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblestadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtNomenclatura;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbs_prestamos_deportivosDTG_Estado dbs_prestamos_deportivosDTG_Estado;
        private System.Windows.Forms.BindingSource tblestadoBindingSource;
        private dbs_prestamos_deportivosDTG_EstadoTableAdapters.tbl_estadoTableAdapter tbl_estadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomenclaturaDataGridViewTextBoxColumn;
    }
}