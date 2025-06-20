using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        public string[] nombres = new string[100];
        public int[] tiempos = new int[100];
        int contador = 0;
        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            Inscripcion ventanaInscripcion = new Inscripcion();

            if (contador == 100)
            {
                btnAgregarCompetidor.Enabled = false;
            }

            if (ventanaInscripcion.ShowDialog() == DialogResult.OK)
            {
                nombres[contador] = ventanaInscripcion.tBNombre.Text;
                contador++;
            }
            ventanaInscripcion.Dispose();
        }

        private void btnCargarTiempos_Click(object sender, EventArgs e)
        {
            CargaDeTiempos ventanaCarga = new CargaDeTiempos();
            ventanaCarga.lbNumero.Text = (contador - 1).ToString("D3");
            if (ventanaCarga.ShowDialog() == DialogResult.OK)
            {
                int horas = Convert.ToInt32(ventanaCarga.tBHoras.Text);
                int minutos = Convert.ToInt32(ventanaCarga.tBMinutos.Text);

                
                tiempos[contador-1] = (horas * 60) + minutos;
            }
            ventanaCarga.Dispose();

        }
         public void Ordenar()
         {
            int i, j, auxTiempo;
            string auxNombre;
            for (i = 0; i < contador - 1; i++)
            {
                for(j = i+1; j < contador; j++)
                {
                    if (tiempos[i] > tiempos[j])
                    {
                        auxTiempo = tiempos[i];
                        tiempos[i] = tiempos[j];
                        tiempos[j] = auxTiempo;

                        auxNombre = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxNombre;

                    }
                }
            }
         }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            Resultados ventanaResultados = new Resultados();
            Ordenar();
            ventanaResultados.lBoxResultados.Items.Clear();

            for (int i = 0; i < contador; i++)
            {
                int hh = tiempos[i] / 60;
                int mm = tiempos[i] % 60;
                ventanaResultados.lBoxResultados.Items.Add($"{i:D3} - {nombres[i]} - {hh:D2} : {mm:D2}");
            }
            ventanaResultados.ShowDialog();
        }
    }
}
