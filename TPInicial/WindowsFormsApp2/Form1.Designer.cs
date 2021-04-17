namespace WindowsFormsApp2
{
    partial class frmradiobutton
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
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txtrta = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Optsuma = new System.Windows.Forms.RadioButton();
            this.Optprod = new System.Windows.Forms.RadioButton();
            this.Optresta = new System.Windows.Forms.RadioButton();
            this.Optcoc = new System.Windows.Forms.RadioButton();
            this.Btnswitch = new System.Windows.Forms.Button();
            this.Btnif = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Location = new System.Drawing.Point(169, 127);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.Btnlimpiar.TabIndex = 23;
            this.Btnlimpiar.Text = "Limpiar";
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(148, 324);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(75, 23);
            this.Btnsalir.TabIndex = 18;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(89, 107);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(55, 13);
            this.Lbl3.TabIndex = 17;
            this.Lbl3.Text = "Resultado";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(84, 78);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(70, 13);
            this.Lbl2.TabIndex = 16;
            this.Lbl2.Text = "2do operador";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(84, 44);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(67, 13);
            this.Lbl1.TabIndex = 15;
            this.Lbl1.Text = "1er operador";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(155, 42);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 14;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(155, 72);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 13;
            // 
            // Txtrta
            // 
            this.Txtrta.Location = new System.Drawing.Point(155, 101);
            this.Txtrta.Name = "Txtrta";
            this.Txtrta.Size = new System.Drawing.Size(100, 20);
            this.Txtrta.TabIndex = 12;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Optcoc);
            this.GroupBox1.Controls.Add(this.Optresta);
            this.GroupBox1.Controls.Add(this.Optprod);
            this.GroupBox1.Controls.Add(this.Optsuma);
            this.GroupBox1.Location = new System.Drawing.Point(73, 177);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(200, 72);
            this.GroupBox1.TabIndex = 24;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Operaciones";
            // 
            // Optsuma
            // 
            this.Optsuma.AutoSize = true;
            this.Optsuma.Location = new System.Drawing.Point(16, 19);
            this.Optsuma.Name = "Optsuma";
            this.Optsuma.Size = new System.Drawing.Size(52, 17);
            this.Optsuma.TabIndex = 0;
            this.Optsuma.TabStop = true;
            this.Optsuma.Text = "Suma";
            this.Optsuma.UseVisualStyleBackColor = true;
            this.Optsuma.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Optprod
            // 
            this.Optprod.AutoSize = true;
            this.Optprod.Location = new System.Drawing.Point(16, 42);
            this.Optprod.Name = "Optprod";
            this.Optprod.Size = new System.Drawing.Size(68, 17);
            this.Optprod.TabIndex = 1;
            this.Optprod.TabStop = true;
            this.Optprod.Text = "Producto";
            this.Optprod.UseVisualStyleBackColor = true;
            // 
            // Optresta
            // 
            this.Optresta.AutoSize = true;
            this.Optresta.Location = new System.Drawing.Point(97, 19);
            this.Optresta.Name = "Optresta";
            this.Optresta.Size = new System.Drawing.Size(53, 17);
            this.Optresta.TabIndex = 2;
            this.Optresta.TabStop = true;
            this.Optresta.Text = "Resta";
            this.Optresta.UseVisualStyleBackColor = true;
            // 
            // Optcoc
            // 
            this.Optcoc.AutoSize = true;
            this.Optcoc.Location = new System.Drawing.Point(97, 42);
            this.Optcoc.Name = "Optcoc";
            this.Optcoc.Size = new System.Drawing.Size(67, 17);
            this.Optcoc.TabIndex = 3;
            this.Optcoc.TabStop = true;
            this.Optcoc.Text = "Cociente";
            this.Optcoc.UseVisualStyleBackColor = true;
            // 
            // Btnswitch
            // 
            this.Btnswitch.Location = new System.Drawing.Point(180, 283);
            this.Btnswitch.Name = "Btnswitch";
            this.Btnswitch.Size = new System.Drawing.Size(83, 23);
            this.Btnswitch.TabIndex = 21;
            this.Btnswitch.Text = "Con SWITCH";
            this.Btnswitch.UseVisualStyleBackColor = true;
            this.Btnswitch.Click += new System.EventHandler(this.Btnswitch_Click);
            // 
            // Btnif
            // 
            this.Btnif.Location = new System.Drawing.Point(89, 283);
            this.Btnif.Name = "Btnif";
            this.Btnif.Size = new System.Drawing.Size(75, 23);
            this.Btnif.TabIndex = 22;
            this.Btnif.Text = "Con IF";
            this.Btnif.UseVisualStyleBackColor = true;
            this.Btnif.Click += new System.EventHandler(this.Btnif_Click);
            // 
            // frmradiobutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 359);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.Btnif);
            this.Controls.Add(this.Btnswitch);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txtrta);
            this.Name = "frmradiobutton";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txtrta;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton Optcoc;
        private System.Windows.Forms.RadioButton Optresta;
        private System.Windows.Forms.RadioButton Optprod;
        private System.Windows.Forms.RadioButton Optsuma;
        private System.Windows.Forms.Button Btnswitch;
        private System.Windows.Forms.Button Btnif;
    }
}

