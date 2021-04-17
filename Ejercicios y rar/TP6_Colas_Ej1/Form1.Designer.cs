namespace Colas
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
            this.lstCola = new System.Windows.Forms.ListView();
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstFem = new System.Windows.Forms.ListView();
            this.lstMasc = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCola
            // 
            this.lstCola.HideSelection = false;
            this.lstCola.Location = new System.Drawing.Point(12, 128);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(160, 307);
            this.lstCola.TabIndex = 0;
            this.lstCola.UseCompatibleStateImageBehavior = false;
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(194, 12);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreNodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(329, 12);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(75, 23);
            this.btnEncolar.TabIndex = 3;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(446, 12);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencolar.TabIndex = 4;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 50);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(152, 13);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo (1Femenino 2 Masculino)";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(194, 50);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 6;
            this.txtSexo.TextChanged += new System.EventHandler(this.txtSexo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Listado General de Pacientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Consultorio Femenino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Consultorio Masculino";
            // 
            // lstFem
            // 
            this.lstFem.HideSelection = false;
            this.lstFem.Location = new System.Drawing.Point(194, 128);
            this.lstFem.Name = "lstFem";
            this.lstFem.Size = new System.Drawing.Size(160, 307);
            this.lstFem.TabIndex = 10;
            this.lstFem.UseCompatibleStateImageBehavior = false;
            // 
            // lstMasc
            // 
            this.lstMasc.HideSelection = false;
            this.lstMasc.Location = new System.Drawing.Point(383, 128);
            this.lstMasc.Name = "lstMasc";
            this.lstMasc.Size = new System.Drawing.Size(160, 307);
            this.lstMasc.TabIndex = 11;
            this.lstMasc.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mostrar por Sexo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstMasc);
            this.Controls.Add(this.lstFem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreNodo);
            this.Controls.Add(this.lstCola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCola;
        private System.Windows.Forms.TextBox txtNombreNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstFem;
        private System.Windows.Forms.ListView lstMasc;
        private System.Windows.Forms.Button button1;
    }
}

