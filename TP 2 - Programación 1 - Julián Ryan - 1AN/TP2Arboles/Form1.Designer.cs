namespace TP2Arboles
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreNodo = new System.Windows.Forms.Label();
            this.btnAgregarDer = new System.Windows.Forms.Button();
            this.btnAgregarIzq = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(461, 37);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(209, 209);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Aqua;
            this.btnAgregar.Location = new System.Drawing.Point(159, 37);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Familiar y Edad";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreNodo);
            this.groupBox1.Location = new System.Drawing.Point(461, 248);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(208, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nodo seleccionado";
            // 
            // lblNombreNodo
            // 
            this.lblNombreNodo.AutoSize = true;
            this.lblNombreNodo.Location = new System.Drawing.Point(10, 24);
            this.lblNombreNodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreNodo.Name = "lblNombreNodo";
            this.lblNombreNodo.Size = new System.Drawing.Size(0, 13);
            this.lblNombreNodo.TabIndex = 3;
            // 
            // btnAgregarDer
            // 
            this.btnAgregarDer.BackColor = System.Drawing.Color.Aqua;
            this.btnAgregarDer.Location = new System.Drawing.Point(240, 90);
            this.btnAgregarDer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDer.Name = "btnAgregarDer";
            this.btnAgregarDer.Size = new System.Drawing.Size(191, 32);
            this.btnAgregarDer.TabIndex = 3;
            this.btnAgregarDer.Text = "Agregar Familiar y Edad a la Derecha";
            this.btnAgregarDer.UseVisualStyleBackColor = false;
            this.btnAgregarDer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregarIzq
            // 
            this.btnAgregarIzq.BackColor = System.Drawing.Color.Aqua;
            this.btnAgregarIzq.Location = new System.Drawing.Point(8, 91);
            this.btnAgregarIzq.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarIzq.Name = "btnAgregarIzq";
            this.btnAgregarIzq.Size = new System.Drawing.Size(201, 31);
            this.btnAgregarIzq.TabIndex = 4;
            this.btnAgregarIzq.Text = "Agregar Familiar y Edad a la Izquierda";
            this.btnAgregarIzq.UseVisualStyleBackColor = false;
            this.btnAgregarIzq.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAncho);
            this.groupBox2.Controls.Add(this.lblAltura);
            this.groupBox2.Location = new System.Drawing.Point(461, 303);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(208, 62);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arbol";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(14, 36);
            this.lblAncho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(0, 13);
            this.lblAncho.TabIndex = 6;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(4, 19);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(0, 13);
            this.lblAltura.TabIndex = 5;
            // 
            // btnInOrden
            // 
            this.btnInOrden.BackColor = System.Drawing.Color.Aqua;
            this.btnInOrden.Location = new System.Drawing.Point(73, 200);
            this.btnInOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(122, 31);
            this.btnInOrden.TabIndex = 5;
            this.btnInOrden.Text = "Recorrer InOrden";
            this.btnInOrden.UseVisualStyleBackColor = false;
            this.btnInOrden.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.BackColor = System.Drawing.Color.Aqua;
            this.btnPreOrden.Location = new System.Drawing.Point(73, 235);
            this.btnPreOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(122, 31);
            this.btnPreOrden.TabIndex = 6;
            this.btnPreOrden.Text = "Recorrer PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = false;
            this.btnPreOrden.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.BackColor = System.Drawing.Color.Aqua;
            this.btnPostOrden.Location = new System.Drawing.Point(73, 270);
            this.btnPostOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(122, 31);
            this.btnPostOrden.TabIndex = 7;
            this.btnPostOrden.Text = "RecorrerPostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = false;
            this.btnPostOrden.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(73, 330);
            this.txtRecorrido.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(317, 20);
            this.txtRecorrido.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "---Crear Árbol---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "---Recorrido del Árbol---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "---Recorridos en Profundidad---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "---Recorrido en Amplitud---";
            // 
            // btnAmplitud
            // 
            this.btnAmplitud.BackColor = System.Drawing.Color.Aqua;
            this.btnAmplitud.Location = new System.Drawing.Point(268, 200);
            this.btnAmplitud.Margin = new System.Windows.Forms.Padding(2);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(122, 101);
            this.btnAmplitud.TabIndex = 13;
            this.btnAmplitud.Text = "Recorrer en Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = false;
            this.btnAmplitud.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "---Busqueda en Árbol por Nombre---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "---TreeView---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "---Agregar Familiares (seleccionar en TreeView)---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "---Muestra del Recorrido---";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(73, 389);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(317, 20);
            this.txtBusqueda.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Aqua;
            this.btnBuscar.Location = new System.Drawing.Point(173, 425);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 31);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar Nombre";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            //this.BackgroundImage = global::TP2Arboles.Properties.Resources.arboles_21;
            this.ClientSize = new System.Drawing.Size(709, 467);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAmplitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.btnPostOrden);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.btnInOrden);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgregarIzq);
            this.Controls.Add(this.btnAgregarDer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Arboles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombreNodo;
        private System.Windows.Forms.Button btnAgregarDer;
        private System.Windows.Forms.Button btnAgregarIzq;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
    }
}

