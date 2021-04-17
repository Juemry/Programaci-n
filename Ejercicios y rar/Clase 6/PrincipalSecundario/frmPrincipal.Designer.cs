namespace PrincipalSecundario
{
    partial class frmPrincipal
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnMostrarHolaMundo = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(147, 91);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(156, 35);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Abrir Secundario Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnMostrarHolaMundo
            // 
            this.btnMostrarHolaMundo.Location = new System.Drawing.Point(147, 50);
            this.btnMostrarHolaMundo.Name = "btnMostrarHolaMundo";
            this.btnMostrarHolaMundo.Size = new System.Drawing.Size(156, 35);
            this.btnMostrarHolaMundo.TabIndex = 1;
            this.btnMostrarHolaMundo.Text = "Hola Mundo";
            this.btnMostrarHolaMundo.UseVisualStyleBackColor = true;
            this.btnMostrarHolaMundo.Click += new System.EventHandler(this.btnMostrarHolaMundo_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(147, 132);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(156, 35);
            this.btnShowDialog.TabIndex = 2;
            this.btnShowDialog.Text = "Abrir Secundario Show Dialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(147, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "TEXTO PRUEBA";
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.Location = new System.Drawing.Point(147, 199);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(156, 121);
            this.lstPacientes.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 338);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnMostrarHolaMundo);
            this.Controls.Add(this.btnShow);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnMostrarHolaMundo;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstPacientes;
    }
}

