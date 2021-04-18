namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Btnejecutar = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Btnejecutar
            // 
            this.Btnejecutar.Location = new System.Drawing.Point(127, 41);
            this.Btnejecutar.Name = "Btnejecutar";
            this.Btnejecutar.Size = new System.Drawing.Size(75, 23);
            this.Btnejecutar.TabIndex = 0;
            this.Btnejecutar.Text = "Cargar";
            this.Btnejecutar.UseVisualStyleBackColor = true;
            this.Btnejecutar.Click += new System.EventHandler(this.Btnejecutar_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(127, 282);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(75, 23);
            this.Btnsalir.TabIndex = 1;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Lst1
            // 
            this.Lst1.FormattingEnabled = true;
            this.Lst1.Location = new System.Drawing.Point(87, 114);
            this.Lst1.Name = "Lst1";
            this.Lst1.Size = new System.Drawing.Size(154, 134);
            this.Lst1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 367);
            this.Controls.Add(this.Lst1);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnejecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnejecutar;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.ListBox Lst1;
    }
}

