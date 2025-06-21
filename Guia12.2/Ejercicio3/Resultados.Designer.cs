namespace Ejercicio3
{
    partial class Resultados
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
            this.lBoxResultados = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxResultados
            // 
            this.lBoxResultados.FormattingEnabled = true;
            this.lBoxResultados.ItemHeight = 16;
            this.lBoxResultados.Location = new System.Drawing.Point(29, 29);
            this.lBoxResultados.Name = "lBoxResultados";
            this.lBoxResultados.Size = new System.Drawing.Size(401, 260);
            this.lBoxResultados.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(147, 307);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(139, 41);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 360);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lBoxResultados);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lBoxResultados;
        private System.Windows.Forms.Button btnCerrar;
    }
}