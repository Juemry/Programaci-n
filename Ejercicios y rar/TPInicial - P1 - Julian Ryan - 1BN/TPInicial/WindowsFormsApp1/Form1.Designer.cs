﻿namespace WindowsFormsApp1
{
    partial class frmcalculadora
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
            this.Txtrta = new System.Windows.Forms.TextBox();
            this.Txtop2 = new System.Windows.Forms.TextBox();
            this.Txtop1 = new System.Windows.Forms.TextBox();
            this.Lblop1 = new System.Windows.Forms.Label();
            this.Lblop2 = new System.Windows.Forms.Label();
            this.Lblrta = new System.Windows.Forms.Label();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Btnprod = new System.Windows.Forms.Button();
            this.Btncoc = new System.Windows.Forms.Button();
            this.Btnresta = new System.Windows.Forms.Button();
            this.Btnsuma = new System.Windows.Forms.Button();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtrta
            // 
            this.Txtrta.Location = new System.Drawing.Point(94, 102);
            this.Txtrta.Name = "Txtrta";
            this.Txtrta.Size = new System.Drawing.Size(100, 20);
            this.Txtrta.TabIndex = 0;
            // 
            // Txtop2
            // 
            this.Txtop2.Location = new System.Drawing.Point(94, 73);
            this.Txtop2.Name = "Txtop2";
            this.Txtop2.Size = new System.Drawing.Size(100, 20);
            this.Txtop2.TabIndex = 1;
            // 
            // Txtop1
            // 
            this.Txtop1.Location = new System.Drawing.Point(94, 43);
            this.Txtop1.Name = "Txtop1";
            this.Txtop1.Size = new System.Drawing.Size(100, 20);
            this.Txtop1.TabIndex = 2;
            this.Txtop1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Lblop1
            // 
            this.Lblop1.AutoSize = true;
            this.Lblop1.Location = new System.Drawing.Point(23, 45);
            this.Lblop1.Name = "Lblop1";
            this.Lblop1.Size = new System.Drawing.Size(67, 13);
            this.Lblop1.TabIndex = 3;
            this.Lblop1.Text = "1er operador";
            this.Lblop1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lblop2
            // 
            this.Lblop2.AutoSize = true;
            this.Lblop2.Location = new System.Drawing.Point(23, 79);
            this.Lblop2.Name = "Lblop2";
            this.Lblop2.Size = new System.Drawing.Size(70, 13);
            this.Lblop2.TabIndex = 4;
            this.Lblop2.Text = "2do operador";
            this.Lblop2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lblrta
            // 
            this.Lblrta.AutoSize = true;
            this.Lblrta.Location = new System.Drawing.Point(23, 108);
            this.Lblrta.Name = "Lblrta";
            this.Lblrta.Size = new System.Drawing.Size(55, 13);
            this.Lblrta.TabIndex = 5;
            this.Lblrta.Text = "Resultado";
            this.Lblrta.Click += new System.EventHandler(this.label3_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(26, 161);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(75, 23);
            this.Btnsalir.TabIndex = 6;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Btnprod
            // 
            this.Btnprod.Location = new System.Drawing.Point(220, 127);
            this.Btnprod.Name = "Btnprod";
            this.Btnprod.Size = new System.Drawing.Size(75, 23);
            this.Btnprod.TabIndex = 7;
            this.Btnprod.Text = "Producto";
            this.Btnprod.UseVisualStyleBackColor = true;
            this.Btnprod.Click += new System.EventHandler(this.Btnprod_Click);
            // 
            // Btncoc
            // 
            this.Btncoc.Location = new System.Drawing.Point(220, 98);
            this.Btncoc.Name = "Btncoc";
            this.Btncoc.Size = new System.Drawing.Size(75, 23);
            this.Btncoc.TabIndex = 8;
            this.Btncoc.Text = "Cociente";
            this.Btncoc.UseVisualStyleBackColor = true;
            this.Btncoc.Click += new System.EventHandler(this.Btncoc_Click);
            // 
            // Btnresta
            // 
            this.Btnresta.Location = new System.Drawing.Point(220, 69);
            this.Btnresta.Name = "Btnresta";
            this.Btnresta.Size = new System.Drawing.Size(75, 23);
            this.Btnresta.TabIndex = 9;
            this.Btnresta.Text = "Resta";
            this.Btnresta.UseVisualStyleBackColor = true;
            this.Btnresta.Click += new System.EventHandler(this.Btnresta_Click);
            // 
            // Btnsuma
            // 
            this.Btnsuma.Location = new System.Drawing.Point(220, 40);
            this.Btnsuma.Name = "Btnsuma";
            this.Btnsuma.Size = new System.Drawing.Size(75, 23);
            this.Btnsuma.TabIndex = 10;
            this.Btnsuma.Text = "Suma";
            this.Btnsuma.UseVisualStyleBackColor = true;
            this.Btnsuma.Click += new System.EventHandler(this.Btnsuma_Click);
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Location = new System.Drawing.Point(220, 156);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.Btnlimpiar.TabIndex = 11;
            this.Btnlimpiar.Text = "Limpiar";
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // frmcalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 196);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.Btnsuma);
            this.Controls.Add(this.Btnresta);
            this.Controls.Add(this.Btncoc);
            this.Controls.Add(this.Btnprod);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Lblrta);
            this.Controls.Add(this.Lblop2);
            this.Controls.Add(this.Lblop1);
            this.Controls.Add(this.Txtop1);
            this.Controls.Add(this.Txtop2);
            this.Controls.Add(this.Txtrta);
            this.Name = "frmcalculadora";
            this.Text = "CalculadoraSimple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtrta;
        private System.Windows.Forms.TextBox Txtop2;
        private System.Windows.Forms.TextBox Txtop1;
        private System.Windows.Forms.Label Lblop1;
        private System.Windows.Forms.Label Lblop2;
        private System.Windows.Forms.Label Lblrta;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button Btnprod;
        private System.Windows.Forms.Button Btncoc;
        private System.Windows.Forms.Button Btnresta;
        private System.Windows.Forms.Button Btnsuma;
        private System.Windows.Forms.Button Btnlimpiar;
    }
}

