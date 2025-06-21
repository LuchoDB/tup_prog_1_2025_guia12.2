namespace Ejercicio2
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
            this.gBoxDatos = new System.Windows.Forms.GroupBox();
            this.checkBElectrico = new System.Windows.Forms.CheckBox();
            this.cBTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.tBModelo = new System.Windows.Forms.TextBox();
            this.tBPatente = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbTipoVehiculo = new System.Windows.Forms.Label();
            this.lbPatente = new System.Windows.Forms.Label();
            this.btnVerEstadistica = new System.Windows.Forms.Button();
            this.gBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxDatos
            // 
            this.gBoxDatos.Controls.Add(this.checkBElectrico);
            this.gBoxDatos.Controls.Add(this.cBTipoVehiculo);
            this.gBoxDatos.Controls.Add(this.tBModelo);
            this.gBoxDatos.Controls.Add(this.tBPatente);
            this.gBoxDatos.Controls.Add(this.btnRegistrar);
            this.gBoxDatos.Controls.Add(this.lbModelo);
            this.gBoxDatos.Controls.Add(this.lbTipoVehiculo);
            this.gBoxDatos.Controls.Add(this.lbPatente);
            this.gBoxDatos.Location = new System.Drawing.Point(23, 12);
            this.gBoxDatos.Name = "gBoxDatos";
            this.gBoxDatos.Size = new System.Drawing.Size(471, 334);
            this.gBoxDatos.TabIndex = 0;
            this.gBoxDatos.TabStop = false;
            this.gBoxDatos.Text = "Datos de Ingreso";
            // 
            // checkBElectrico
            // 
            this.checkBElectrico.AutoSize = true;
            this.checkBElectrico.Location = new System.Drawing.Point(210, 203);
            this.checkBElectrico.Name = "checkBElectrico";
            this.checkBElectrico.Size = new System.Drawing.Size(113, 20);
            this.checkBElectrico.TabIndex = 8;
            this.checkBElectrico.Text = "¿Es eléctrico?";
            this.checkBElectrico.UseVisualStyleBackColor = true;
            // 
            // cBTipoVehiculo
            // 
            this.cBTipoVehiculo.FormattingEnabled = true;
            this.cBTipoVehiculo.Items.AddRange(new object[] {
            "Automóvil",
            "Motocicleta",
            "Camioneta",
            "Camion"});
            this.cBTipoVehiculo.Location = new System.Drawing.Point(234, 100);
            this.cBTipoVehiculo.Name = "cBTipoVehiculo";
            this.cBTipoVehiculo.Size = new System.Drawing.Size(109, 24);
            this.cBTipoVehiculo.TabIndex = 7;
            // 
            // tBModelo
            // 
            this.tBModelo.Location = new System.Drawing.Point(234, 137);
            this.tBModelo.Name = "tBModelo";
            this.tBModelo.Size = new System.Drawing.Size(100, 22);
            this.tBModelo.TabIndex = 6;
            // 
            // tBPatente
            // 
            this.tBPatente.Location = new System.Drawing.Point(234, 66);
            this.tBPatente.Name = "tBPatente";
            this.tBPatente.Size = new System.Drawing.Size(100, 22);
            this.tBPatente.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(172, 252);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 68);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbModelo.Location = new System.Drawing.Point(23, 137);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(193, 18);
            this.lbModelo.TabIndex = 2;
            this.lbModelo.Text = "Modelo (año de fabricación)";
            // 
            // lbTipoVehiculo
            // 
            this.lbTipoVehiculo.AutoSize = true;
            this.lbTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbTipoVehiculo.Location = new System.Drawing.Point(99, 101);
            this.lbTipoVehiculo.Name = "lbTipoVehiculo";
            this.lbTipoVehiculo.Size = new System.Drawing.Size(117, 18);
            this.lbTipoVehiculo.TabIndex = 1;
            this.lbTipoVehiculo.Text = "Tipo de Vehiculo";
            // 
            // lbPatente
            // 
            this.lbPatente.AutoSize = true;
            this.lbPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbPatente.Location = new System.Drawing.Point(158, 66);
            this.lbPatente.Name = "lbPatente";
            this.lbPatente.Size = new System.Drawing.Size(58, 18);
            this.lbPatente.TabIndex = 0;
            this.lbPatente.Text = "Patente";
            // 
            // btnVerEstadistica
            // 
            this.btnVerEstadistica.Location = new System.Drawing.Point(516, 12);
            this.btnVerEstadistica.Name = "btnVerEstadistica";
            this.btnVerEstadistica.Size = new System.Drawing.Size(147, 56);
            this.btnVerEstadistica.TabIndex = 1;
            this.btnVerEstadistica.Text = "Ver Estadistica";
            this.btnVerEstadistica.UseVisualStyleBackColor = true;
            this.btnVerEstadistica.Click += new System.EventHandler(this.btnVerEstadistica_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 375);
            this.Controls.Add(this.btnVerEstadistica);
            this.Controls.Add(this.gBoxDatos);
            this.Name = "FormPrincipal";
            this.Text = "Control de Paso";
            this.gBoxDatos.ResumeLayout(false);
            this.gBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxDatos;
        private System.Windows.Forms.ComboBox cBTipoVehiculo;
        private System.Windows.Forms.TextBox tBModelo;
        private System.Windows.Forms.TextBox tBPatente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbTipoVehiculo;
        private System.Windows.Forms.Label lbPatente;
        private System.Windows.Forms.CheckBox checkBElectrico;
        private System.Windows.Forms.Button btnVerEstadistica;
    }
}

