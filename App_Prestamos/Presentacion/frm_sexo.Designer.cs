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
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNomenclatura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(152, 182);
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
            this.btnIngresar.Location = new System.Drawing.Point(53, 182);
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
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(206, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 42;
            this.materialLabel1.Text = "Ingresar sexo";
            // 
            // txtNomenclatura
            // 
            this.txtNomenclatura.AnimateReadOnly = false;
            this.txtNomenclatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomenclatura.Depth = 0;
            this.txtNomenclatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomenclatura.Hint = "Nomenclatura";
            this.txtNomenclatura.LeadingIcon = null;
            this.txtNomenclatura.Location = new System.Drawing.Point(53, 123);
            this.txtNomenclatura.MaxLength = 50;
            this.txtNomenclatura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomenclatura.Multiline = false;
            this.txtNomenclatura.Name = "txtNomenclatura";
            this.txtNomenclatura.ReadOnly = true;
            this.txtNomenclatura.Size = new System.Drawing.Size(419, 50);
            this.txtNomenclatura.TabIndex = 41;
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
            this.txtNombre.Location = new System.Drawing.Point(53, 67);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(419, 50);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // frm_sexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 254);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtNomenclatura);
            this.Controls.Add(this.txtNombre);
            this.Name = "frm_sexo";
            this.Text = "frm_sexo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNomenclatura;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
    }
}