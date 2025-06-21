namespace Ejercicio2
{
    partial class Estadistica
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
            this.gBResultados = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lBoxEstadistica = new System.Windows.Forms.ListBox();
            this.gBResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBResultados
            // 
            this.gBResultados.Controls.Add(this.lBoxEstadistica);
            this.gBResultados.Controls.Add(this.btnCerrar);
            this.gBResultados.Location = new System.Drawing.Point(12, 12);
            this.gBResultados.Name = "gBResultados";
            this.gBResultados.Size = new System.Drawing.Size(444, 229);
            this.gBResultados.TabIndex = 0;
            this.gBResultados.TabStop = false;
            this.gBResultados.Text = "Resultados";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(153, 193);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 30);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lBoxEstadistica
            // 
            this.lBoxEstadistica.FormattingEnabled = true;
            this.lBoxEstadistica.ItemHeight = 16;
            this.lBoxEstadistica.Location = new System.Drawing.Point(6, 21);
            this.lBoxEstadistica.Name = "lBoxEstadistica";
            this.lBoxEstadistica.Size = new System.Drawing.Size(424, 148);
            this.lBoxEstadistica.TabIndex = 2;
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 268);
            this.Controls.Add(this.gBResultados);
            this.Name = "Estadistica";
            this.Text = "Estadistica";
            this.gBResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBResultados;
        public System.Windows.Forms.ListBox lBoxEstadistica;
        public System.Windows.Forms.Button btnCerrar;
    }
}