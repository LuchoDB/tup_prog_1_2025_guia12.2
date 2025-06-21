namespace Ejercicio3
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cBPais = new System.Windows.Forms.ComboBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.btnAgregarContenedor = new System.Windows.Forms.Button();
            this.btnVerListado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cBPais);
            this.groupBox1.Controls.Add(this.lbPais);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver Informacion Contenedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(253, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 74);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cBPais
            // 
            this.cBPais.FormattingEnabled = true;
            this.cBPais.Location = new System.Drawing.Point(54, 70);
            this.cBPais.Name = "cBPais";
            this.cBPais.Size = new System.Drawing.Size(126, 24);
            this.cBPais.Sorted = true;
            this.cBPais.TabIndex = 1;
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbPais.Location = new System.Drawing.Point(51, 49);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(85, 18);
            this.lbPais.TabIndex = 0;
            this.lbPais.Text = "Pais Origen";
            // 
            // btnAgregarContenedor
            // 
            this.btnAgregarContenedor.Location = new System.Drawing.Point(52, 35);
            this.btnAgregarContenedor.Name = "btnAgregarContenedor";
            this.btnAgregarContenedor.Size = new System.Drawing.Size(153, 74);
            this.btnAgregarContenedor.TabIndex = 1;
            this.btnAgregarContenedor.Text = "Agregar Contenedor";
            this.btnAgregarContenedor.UseVisualStyleBackColor = true;
            this.btnAgregarContenedor.Click += new System.EventHandler(this.btnAgregarContenedor_Click);
            // 
            // btnVerListado
            // 
            this.btnVerListado.Location = new System.Drawing.Point(265, 35);
            this.btnVerListado.Name = "btnVerListado";
            this.btnVerListado.Size = new System.Drawing.Size(153, 74);
            this.btnVerListado.TabIndex = 2;
            this.btnVerListado.Text = "Ver Listado";
            this.btnVerListado.UseVisualStyleBackColor = true;
            this.btnVerListado.Click += new System.EventHandler(this.btnVerListado_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 279);
            this.Controls.Add(this.btnVerListado);
            this.Controls.Add(this.btnAgregarContenedor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cBPais;
        private System.Windows.Forms.Button btnAgregarContenedor;
        private System.Windows.Forms.Button btnVerListado;
    }
}

