namespace Ejercicio1
{
    partial class CargaDeTiempos
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
            this.lbCompetidor = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBHoras = new System.Windows.Forms.TextBox();
            this.tBMinutos = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCompetidor
            // 
            this.lbCompetidor.AutoSize = true;
            this.lbCompetidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompetidor.Location = new System.Drawing.Point(51, 30);
            this.lbCompetidor.Name = "lbCompetidor";
            this.lbCompetidor.Size = new System.Drawing.Size(171, 18);
            this.lbCompetidor.TabIndex = 0;
            this.lbCompetidor.Text = "Numero del Competidor:";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(243, 30);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(73, 18);
            this.lbNumero.TabIndex = 1;
            this.lbNumero.Text = "lbNumero";
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempo.Location = new System.Drawing.Point(164, 71);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(58, 18);
            this.lbTiempo.TabIndex = 2;
            this.lbTiempo.Text = "Tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // tBHoras
            // 
            this.tBHoras.Location = new System.Drawing.Point(235, 74);
            this.tBHoras.Name = "tBHoras";
            this.tBHoras.Size = new System.Drawing.Size(51, 22);
            this.tBHoras.TabIndex = 4;
            // 
            // tBMinutos
            // 
            this.tBMinutos.Location = new System.Drawing.Point(311, 75);
            this.tBMinutos.Name = "tBMinutos";
            this.tBMinutos.Size = new System.Drawing.Size(51, 22);
            this.tBMinutos.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(183, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // CargaDeTiempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 200);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tBMinutos);
            this.Controls.Add(this.tBHoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbCompetidor);
            this.Name = "CargaDeTiempos";
            this.Text = "CargaDeTiempos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCompetidor;
        public System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tBHoras;
        public System.Windows.Forms.TextBox tBMinutos;
        public System.Windows.Forms.Button btnAgregar;
    }
}