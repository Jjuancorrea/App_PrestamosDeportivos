namespace Presentacion
{
    partial class frm_prestamos
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
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnPrestamo = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdentificacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigoImplemento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCantidadPrestamo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtObservaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.dtg_prestamo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreImplemento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtExistencias = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.HighEmphasis = true;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(140, 287);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(70, 36);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevo.UseAccentColor = false;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(218, 287);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(64, 36);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "+";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrestamo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrestamo.Depth = 0;
            this.btnPrestamo.HighEmphasis = true;
            this.btnPrestamo.Icon = null;
            this.btnPrestamo.Location = new System.Drawing.Point(47, 287);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrestamo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrestamo.Size = new System.Drawing.Size(85, 36);
            this.btnPrestamo.TabIndex = 24;
            this.btnPrestamo.Text = "Prestar";
            this.btnPrestamo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrestamo.UseAccentColor = false;
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(197, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(267, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Formulario de registro de prestamos\r\n";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.AnimateReadOnly = false;
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Depth = 0;
            this.txtIdentificacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentificacion.Hint = "Identificación";
            this.txtIdentificacion.LeadingIcon = null;
            this.txtIdentificacion.Location = new System.Drawing.Point(47, 60);
            this.txtIdentificacion.MaxLength = 50;
            this.txtIdentificacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentificacion.Multiline = false;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(235, 50);
            this.txtIdentificacion.TabIndex = 28;
            this.txtIdentificacion.Text = "";
            this.txtIdentificacion.TrailingIcon = null;
            this.txtIdentificacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdentificacion_KeyUp);
            // 
            // txtCodigoImplemento
            // 
            this.txtCodigoImplemento.AnimateReadOnly = false;
            this.txtCodigoImplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoImplemento.Depth = 0;
            this.txtCodigoImplemento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoImplemento.Hint = "Código del implemento";
            this.txtCodigoImplemento.LeadingIcon = null;
            this.txtCodigoImplemento.Location = new System.Drawing.Point(47, 116);
            this.txtCodigoImplemento.MaxLength = 50;
            this.txtCodigoImplemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoImplemento.Multiline = false;
            this.txtCodigoImplemento.Name = "txtCodigoImplemento";
            this.txtCodigoImplemento.Size = new System.Drawing.Size(235, 50);
            this.txtCodigoImplemento.TabIndex = 30;
            this.txtCodigoImplemento.Text = "";
            this.txtCodigoImplemento.TrailingIcon = null;
            this.txtCodigoImplemento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoImplemento_KeyUp);
            // 
            // txtCantidadPrestamo
            // 
            this.txtCantidadPrestamo.AnimateReadOnly = false;
            this.txtCantidadPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadPrestamo.Depth = 0;
            this.txtCantidadPrestamo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidadPrestamo.Hint = "Cantidad a prestar";
            this.txtCantidadPrestamo.LeadingIcon = null;
            this.txtCantidadPrestamo.Location = new System.Drawing.Point(47, 228);
            this.txtCantidadPrestamo.MaxLength = 50;
            this.txtCantidadPrestamo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidadPrestamo.Multiline = false;
            this.txtCantidadPrestamo.Name = "txtCantidadPrestamo";
            this.txtCantidadPrestamo.Size = new System.Drawing.Size(235, 50);
            this.txtCantidadPrestamo.TabIndex = 34;
            this.txtCantidadPrestamo.Text = "";
            this.txtCantidadPrestamo.TrailingIcon = null;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.AnimateReadOnly = false;
            this.txtObservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservaciones.Depth = 0;
            this.txtObservaciones.HideSelection = true;
            this.txtObservaciones.Hint = "Observaciones";
            this.txtObservaciones.Location = new System.Drawing.Point(288, 228);
            this.txtObservaciones.MaxLength = 32767;
            this.txtObservaciones.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.ReadOnly = false;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.SelectionLength = 0;
            this.txtObservaciones.SelectionStart = 0;
            this.txtObservaciones.ShortcutsEnabled = true;
            this.txtObservaciones.Size = new System.Drawing.Size(346, 95);
            this.txtObservaciones.TabIndex = 35;
            this.txtObservaciones.TabStop = false;
            this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservaciones.UseSystemPasswordChar = false;
            // 
            // dtg_prestamo
            // 
            this.dtg_prestamo.AllowUserToAddRows = false;
            this.dtg_prestamo.AllowUserToDeleteRows = false;
            this.dtg_prestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_prestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtg_prestamo.Location = new System.Drawing.Point(47, 332);
            this.dtg_prestamo.Name = "dtg_prestamo";
            this.dtg_prestamo.ReadOnly = true;
            this.dtg_prestamo.Size = new System.Drawing.Size(587, 150);
            this.dtg_prestamo.TabIndex = 36;
            this.dtg_prestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_prestamo_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código del implemento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad prestada";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre persona";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(288, 60);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(346, 50);
            this.txtNombre.TabIndex = 37;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AnimateReadOnly = false;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcion.Hint = "Descripcion";
            this.txtDescripcion.LeadingIcon = null;
            this.txtDescripcion.Location = new System.Drawing.Point(288, 116);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(346, 50);
            this.txtDescripcion.TabIndex = 38;
            this.txtDescripcion.Text = "";
            this.txtDescripcion.TrailingIcon = null;
            // 
            // txtNombreImplemento
            // 
            this.txtNombreImplemento.AnimateReadOnly = false;
            this.txtNombreImplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreImplemento.Depth = 0;
            this.txtNombreImplemento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreImplemento.Hint = "Nombre del implemento";
            this.txtNombreImplemento.LeadingIcon = null;
            this.txtNombreImplemento.Location = new System.Drawing.Point(288, 172);
            this.txtNombreImplemento.MaxLength = 50;
            this.txtNombreImplemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreImplemento.Multiline = false;
            this.txtNombreImplemento.Name = "txtNombreImplemento";
            this.txtNombreImplemento.Size = new System.Drawing.Size(346, 50);
            this.txtNombreImplemento.TabIndex = 39;
            this.txtNombreImplemento.Text = "";
            this.txtNombreImplemento.TrailingIcon = null;
            // 
            // txtExistencias
            // 
            this.txtExistencias.AnimateReadOnly = false;
            this.txtExistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExistencias.Depth = 0;
            this.txtExistencias.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtExistencias.Hint = "Existencias";
            this.txtExistencias.LeadingIcon = null;
            this.txtExistencias.Location = new System.Drawing.Point(47, 172);
            this.txtExistencias.MaxLength = 50;
            this.txtExistencias.MouseState = MaterialSkin.MouseState.OUT;
            this.txtExistencias.Multiline = false;
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(235, 50);
            this.txtExistencias.TabIndex = 40;
            this.txtExistencias.Text = "";
            this.txtExistencias.TrailingIcon = null;
            // 
            // frm_prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 512);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.txtNombreImplemento);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtg_prestamo);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtCantidadPrestamo);
            this.Controls.Add(this.txtCodigoImplemento);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frm_prestamos";
            this.Text = "frm_prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnNuevo;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnPrestamo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtIdentificacion;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoImplemento;
        private MaterialSkin.Controls.MaterialTextBox txtCantidadPrestamo;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservaciones;
        private System.Windows.Forms.DataGridView dtg_prestamo;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtNombreImplemento;
        private MaterialSkin.Controls.MaterialTextBox txtExistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}