using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            string Marca = tbMarca.Text;
            int Modelo = Convert.ToInt32(nupModelo.Value);
            int anioACalcular = Convert.ToInt32(nupAñoACalcular.Value);
            double ValorFabricacion = Convert.ToDouble(tbValorFabricacion.Text);
            double TasaDepreciacion = Convert.ToDouble(tbTasaDepreciacion.Text);
            int VidaUtil = Convert.ToInt32(tbVidaUtil.Text);
            Moto m = new Moto(Marca, Modelo, ValorFabricacion);
            VerResultados verResultados = new VerResultados();
            verResultados.lbxResultados.Items.Clear();
            verResultados.lbxResultados.Items.Add(m.VerDescripcion());
            verResultados.lbxResultados.Items.Add($"Depreciación Lineal: ${m.CalcularDepreciacionLineal(anioACalcular, VidaUtil):F2}");
            verResultados.lbxResultados.Items.Add($"Depreciación Anual: ${m.CalcularDepreciacionAnual(anioACalcular, TasaDepreciacion):F2}");
            verResultados.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
