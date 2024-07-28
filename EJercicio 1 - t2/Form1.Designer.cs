namespace EJercicio_1___t2
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
            this.Valor = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnfondo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(12, 16);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(31, 13);
            this.Valor.TabIndex = 0;
            this.Valor.Text = "Valor";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(203, 32);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(59, 37);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(12, 58);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(173, 238);
            this.lstDatos.TabIndex = 2;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(12, 32);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(173, 20);
            this.txtDato.TabIndex = 3;
            // 
            // btnfondo
            // 
            this.btnfondo.Location = new System.Drawing.Point(203, 75);
            this.btnfondo.Name = "btnfondo";
            this.btnfondo.Size = new System.Drawing.Size(59, 37);
            this.btnfondo.TabIndex = 4;
            this.btnfondo.Text = "Fondo";
            this.btnfondo.UseVisualStyleBackColor = true;
            this.btnfondo.Click += new System.EventHandler(this.btnfondo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Desapilar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(203, 218);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(106, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 314);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnfondo);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.Valor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnfondo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

