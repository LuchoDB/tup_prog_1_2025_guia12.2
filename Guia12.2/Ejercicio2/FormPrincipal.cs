using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public string[] patentes = new string[1000];
        public int[] tipoVehiculos = new int[1000];
        public bool[] sonElectricos = new bool[1000];
        public int[] modelos = new int[1000];
        public int contador = 0;

        public string[] patentesElectricos = new string[1000];
        public int[] modelosElectricos = new int[1000];
        public int[] tiposVehiculosElectricos = new int[1000];
        public int contadorElectricos = 0;

        /*public void RegistrarVehiculo(string Patente,int tipo, bool esElectrico)
        {
            Patente = tBPatente.Text;
            patentes[contador] = Patente;
            tipo = Convert.ToInt32(cBTipoVehiculo.SelectedItem);
            tipoVehiculos[contador] = tipo;
            esElectrico = checkBElectrico.Checked;
            sonElectricos[contador] = esElectrico;
        }*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Patente = tBPatente.Text;
            patentes[contador] = Patente;
            
            int tipo = Convert.ToInt32(cBTipoVehiculo.SelectedIndex);
            tipoVehiculos[contador] = tipo;

            int modelo = Convert.ToInt32(tBModelo.Text);
            modelos[contador] = modelo;

            bool esElectrico = checkBElectrico.Checked;
            sonElectricos[contador] = esElectrico;

            if (esElectrico)
            {
                patentesElectricos[contadorElectricos] = Patente;
                modelosElectricos[contadorElectricos] = modelo;
                tiposVehiculosElectricos[contadorElectricos] = tipo;
                contadorElectricos++;
            }
            contador++;
            tBPatente.Clear();
            tBModelo.Clear();
            cBTipoVehiculo.SelectedIndex = -1;
        }

        public void OrdenarElectricos()
        {
            for (int i = 0; i < contadorElectricos - 1; i++)
            {
                for (int j = i +1; j < contadorElectricos; j++)
                {
                    if (modelosElectricos[i] > modelosElectricos[j])
                    {
                        #region Intercambio de Patentes
                        string auxPatente = patentesElectricos[i];
                        patentesElectricos[i] = patentesElectricos[j];
                        patentesElectricos[j] = auxPatente;
                        #endregion
                        #region Intercambio de Modelos
                        int auxModelo = modelosElectricos[i];
                        modelosElectricos[i] = modelosElectricos[j];
                        modelosElectricos[j] = auxModelo;
                        #endregion
                        #region Intercambio de Tipos
                        int auxTipo = tiposVehiculosElectricos[i];
                        tiposVehiculosElectricos[i] = tiposVehiculosElectricos[j];
                        tiposVehiculosElectricos[j] = auxTipo;
                        #endregion
                    }
                }
            }
        }

        public void OrdenarNoElectricos()
        {
            for (int i = 0; i < contador - 1; i++)
            { for(int j = i + 1; j<contador; j++)
                {
                    if (modelos[i] > modelos[j])
                    {
                        string auxPatente = patentes[i];
                        patentes[i] = patentes[j];
                        patentes[j] = auxPatente;

                        int auxModelo = modelos[i];
                        modelos[i] = modelos[j];
                        modelos[j] = auxModelo;

                        int auxTipo= tipoVehiculos[i];
                        tipoVehiculos[i] = tipoVehiculos[j];
                        tipoVehiculos[j] = auxTipo;

                    }
                }

            }
        }

        private void btnVerEstadistica_Click(object sender, EventArgs e)
        {
            Estadistica ventanaEstadistica = new Estadistica();
            ventanaEstadistica.lBoxEstadistica.Items.Clear();
            OrdenarElectricos();
            OrdenarNoElectricos();

            ventanaEstadistica.lBoxEstadistica.Items.Add("Vehiculos no Electricos:");
            for (int i = 0; i < contador; i++)
            {
                if (!sonElectricos[i])
                {
                    ventanaEstadistica.lBoxEstadistica.Items.Add($"\t\t{patentes[i]} - {modelos[i]} - {tipoVehiculos[i]}");
                }
            }

            ventanaEstadistica.lBoxEstadistica.Items.Add("Vehiculos electricos");
            for (int i = 0; i<contadorElectricos;i++)
            {
                ventanaEstadistica.lBoxEstadistica.Items.Add($"\t\t{patentesElectricos[i]} - {modelosElectricos[i]} - {tiposVehiculosElectricos[i]}");
            }
            ventanaEstadistica.ShowDialog();
        }
    }
}
