namespace TP3_03
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
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTNcargar = new System.Windows.Forms.Button();
            this.TXTnumero = new System.Windows.Forms.TextBox();
            this.LSTnumeros = new System.Windows.Forms.ListBox();
            this.LBLresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.Location = new System.Drawing.Point(205, 243);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNlimpiar.TabIndex = 0;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = true;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // BTNcargar
            // 
            this.BTNcargar.Location = new System.Drawing.Point(205, 39);
            this.BTNcargar.Name = "BTNcargar";
            this.BTNcargar.Size = new System.Drawing.Size(75, 23);
            this.BTNcargar.TabIndex = 1;
            this.BTNcargar.Text = "Acumular";
            this.BTNcargar.UseVisualStyleBackColor = true;
            this.BTNcargar.Click += new System.EventHandler(this.BTNcargar_Click);
            // 
            // TXTnumero
            // 
            this.TXTnumero.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnumero.Location = new System.Drawing.Point(33, 39);
            this.TXTnumero.Name = "TXTnumero";
            this.TXTnumero.Size = new System.Drawing.Size(100, 28);
            this.TXTnumero.TabIndex = 2;
            this.TXTnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LSTnumeros
            // 
            this.LSTnumeros.FormatString = "N0";
            this.LSTnumeros.FormattingEnabled = true;
            this.LSTnumeros.Location = new System.Drawing.Point(33, 75);
            this.LSTnumeros.Name = "LSTnumeros";
            this.LSTnumeros.Size = new System.Drawing.Size(100, 147);
            this.LSTnumeros.TabIndex = 3;
            // 
            // LBLresultado
            // 
            this.LBLresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LBLresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLresultado.Location = new System.Drawing.Point(33, 243);
            this.LBLresultado.Name = "LBLresultado";
            this.LBLresultado.Size = new System.Drawing.Size(100, 23);
            this.LBLresultado.TabIndex = 4;
            this.LBLresultado.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(297, 324);
            this.Controls.Add(this.LBLresultado);
            this.Controls.Add(this.LSTnumeros);
            this.Controls.Add(this.TXTnumero);
            this.Controls.Add(this.BTNcargar);
            this.Controls.Add(this.BTNlimpiar);
            this.Name = "Form1";
            this.Text = "Sumador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNlimpiar;
        private System.Windows.Forms.Button BTNcargar;
        private System.Windows.Forms.TextBox TXTnumero;
        private System.Windows.Forms.ListBox LSTnumeros;
        private System.Windows.Forms.Label LBLresultado;
    }
}

