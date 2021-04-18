namespace Tp1Programación
{
    partial class frmPrincipal
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
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.bttnCargar = new System.Windows.Forms.Button();
            this.bttnBorrar = new System.Windows.Forms.Button();
            this.BttnTope = new System.Windows.Forms.Button();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.bttnOtro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(85, 112);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(313, 121);
            this.lstNombres.TabIndex = 0;
            // 
            // bttnCargar
            // 
            this.bttnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnCargar.Location = new System.Drawing.Point(40, 249);
            this.bttnCargar.Name = "bttnCargar";
            this.bttnCargar.Size = new System.Drawing.Size(116, 23);
            this.bttnCargar.TabIndex = 3;
            this.bttnCargar.Text = "Cargar";
            this.bttnCargar.UseVisualStyleBackColor = false;
            this.bttnCargar.Click += new System.EventHandler(this.bttnCargar_Click);
            // 
            // bttnBorrar
            // 
            this.bttnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnBorrar.Location = new System.Drawing.Point(330, 249);
            this.bttnBorrar.Name = "bttnBorrar";
            this.bttnBorrar.Size = new System.Drawing.Size(116, 23);
            this.bttnBorrar.TabIndex = 4;
            this.bttnBorrar.Text = "Borrar";
            this.bttnBorrar.UseVisualStyleBackColor = false;
            // 
            // BttnTope
            // 
            this.BttnTope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BttnTope.Location = new System.Drawing.Point(40, 288);
            this.BttnTope.Name = "BttnTope";
            this.BttnTope.Size = new System.Drawing.Size(116, 23);
            this.BttnTope.TabIndex = 5;
            this.BttnTope.Text = "Tope";
            this.BttnTope.UseVisualStyleBackColor = false;
            this.BttnTope.Click += new System.EventHandler(this.BttnTope_Click);
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnSalir.Location = new System.Drawing.Point(330, 288);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(116, 23);
            this.bttnSalir.TabIndex = 6;
            this.bttnSalir.Text = "Salir";
            this.bttnSalir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nue Gothic Round", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISTADO DE ALUMNOS";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(254, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(177, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // bttnOtro
            // 
            this.bttnOtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnOtro.Location = new System.Drawing.Point(170, 319);
            this.bttnOtro.Name = "bttnOtro";
            this.bttnOtro.Size = new System.Drawing.Size(143, 23);
            this.bttnOtro.TabIndex = 12;
            this.bttnOtro.Text = "Cargar Otro Formulario";
            this.bttnOtro.UseVisualStyleBackColor = false;
            this.bttnOtro.Click += new System.EventHandler(this.bttnOtro_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(498, 369);
            this.Controls.Add(this.bttnOtro);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.BttnTope);
            this.Controls.Add(this.bttnBorrar);
            this.Controls.Add(this.bttnCargar);
            this.Controls.Add(this.lstNombres);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Button bttnCargar;
        private System.Windows.Forms.Button bttnBorrar;
        private System.Windows.Forms.Button BttnTope;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button bttnOtro;
    }
}

