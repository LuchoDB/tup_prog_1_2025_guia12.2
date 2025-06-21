namespace Ejercicio3
{
    partial class Datos_del_Contenedor
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
            this.numericID = new System.Windows.Forms.NumericUpDown();
            this.numericPeso = new System.Windows.Forms.NumericUpDown();
            this.tBoxPaisOrigen = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(163, 50);
            this.numericID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(105, 22);
            this.numericID.TabIndex = 0;
            // 
            // numericPeso
            // 
            this.numericPeso.Location = new System.Drawing.Point(163, 106);
            this.numericPeso.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPeso.Name = "numericPeso";
            this.numericPeso.Size = new System.Drawing.Size(105, 22);
            this.numericPeso.TabIndex = 2;
            // 
            // tBoxPaisOrigen
            // 
            this.tBoxPaisOrigen.Location = new System.Drawing.Point(163, 78);
            this.tBoxPaisOrigen.Name = "tBoxPaisOrigen";
            this.tBoxPaisOrigen.Size = new System.Drawing.Size(103, 22);
            this.tBoxPaisOrigen.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbID.Location = new System.Drawing.Point(108, 54);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(22, 18);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbPais.Location = new System.Drawing.Point(45, 82);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(85, 18);
            this.lbPais.TabIndex = 4;
            this.lbPais.Text = "Pais Origen";
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbPeso.Location = new System.Drawing.Point(87, 106);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(43, 18);
            this.lbPeso.TabIndex = 5;
            this.lbPeso.Text = "Peso";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(111, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 60);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Datos_del_Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 263);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tBoxPaisOrigen);
            this.Controls.Add(this.numericPeso);
            this.Controls.Add(this.numericID);
            this.Name = "Datos_del_Contenedor";
            this.Text = "Datos del Contenedor";
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbPeso;
        public System.Windows.Forms.NumericUpDown numericID;
        public System.Windows.Forms.NumericUpDown numericPeso;
        public System.Windows.Forms.TextBox tBoxPaisOrigen;
        public System.Windows.Forms.Button btnAgregar;
    }
}