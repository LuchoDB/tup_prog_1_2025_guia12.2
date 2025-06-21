using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        public int[] identificador = new int[1000];
        public string[] pais = new string[1000];
        public double[] peso = new double[1000];
        public int contador = 0;

        private void btnAgregarContenedor_Click(object sender, EventArgs e)
        {
            Datos_del_Contenedor ventanaDatos = new Datos_del_Contenedor();

            if (ventanaDatos.ShowDialog() == DialogResult.OK)
            {
                identificador[contador] = Convert.ToInt32(ventanaDatos.numericID.Value);
                pais[contador] = ventanaDatos.tBoxPaisOrigen.Text;
                peso[contador] = Convert.ToDouble(ventanaDatos.numericPeso.Value);

                if (!cBPais.Items.Contains(ventanaDatos.tBoxPaisOrigen.Text))
                {
                    cBPais.Items.Add(ventanaDatos.tBoxPaisOrigen.Text);
                }
                contador++;
            }
            ventanaDatos.Dispose();
            
        }

        public void OrdenarID()
        {
            for (int i = 0; i < contador -1; i++)
            {
                for(int j = i +1; j < contador; j++)
                {
                    if (identificador[i] < identificador[j])
                    {
                        int auxId = identificador[i];
                        identificador[i] = identificador[j];
                        identificador[j] = auxId;

                        string auxPais = pais[i];
                        pais[i] = pais[j];
                        pais[j] = auxPais;

                        double auxPeso = peso[i];
                        peso[i] = peso[j];
                        peso[j] = auxPeso;
                    }
                }
            }
        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            Resultados ventanaListado = new Resultados();
            OrdenarID();
            ventanaListado.lBoxResultados.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                ventanaListado.lBoxResultados.Items.Add($"{identificador[i]} - {pais[i]} - {peso[i]:F2}");
            }
            ventanaListado.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Resultados ventanaBusqueda = new Resultados();
            OrdenarID();
            ventanaBusqueda.lBoxResultados.Items.Clear();
            for (int i = 0; i< contador; i++)
            {
                if (cBPais.SelectedItem != null && pais[i] == cBPais.SelectedItem.ToString())
                {
                    ventanaBusqueda.lBoxResultados.Items.Add($"{identificador[i]} - {pais[i]} - {peso[i]:F2}");
                }
            }
            ventanaBusqueda.ShowDialog();
        }
    }
}
