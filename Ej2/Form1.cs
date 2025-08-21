using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        Viaje viaje;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViaje_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            if (f4.DialogResult == DialogResult.OK)
            {
                int hInicio = Convert.ToInt32(f4.tbHViaje.Text);
                int mInicio = Convert.ToInt32(f4.tbMViaje.Text);
                int Asientos = Convert.ToInt32(f4.tbAsientos.Text);
                bool correctoh = hInicio >= 0 && hInicio < 24;
                bool correctom = mInicio >= 0 && mInicio < 60;
                if (!correctoh)
                {
                    MessageBox.Show("Hora incorrecta");
                    return;
                }
                if (!correctom)
                {
                    MessageBox.Show("Minutos incorrectos");
                    return;
                }
                if (correctoh && correctom)
                {
                   viaje = new Viaje(hInicio, mInicio, Asientos);
                }
                

            }

        }

        private void btnParada_Click(object sender, EventArgs e)
        {
            Form2 parada = new Form2();
            parada.ShowDialog();
            if (parada.DialogResult == DialogResult.OK)
            {
                int hLlegada = Convert.ToInt32(parada.tbHLlegada.Text);
                int mLlegada = Convert.ToInt32(parada.tbMLlegada.Text);
                int ascienden = Convert.ToInt32(parada.tbAscienden.Text);
                int descienden = Convert.ToInt32(parada.tbDescienden.Text);
                int HSalida = Convert.ToInt32(parada.tbHSalida.Text);
                int MSalida = Convert.ToInt32(parada.tbMSalida.Text);
                bool correctohl = hLlegada >= 0 && hLlegada < 24;
                bool correctoml = mLlegada >= 0 && mLlegada < 60;
                bool correctohs = HSalida >= 0 && HSalida < 24;
                bool correctoms = MSalida >= 0 && MSalida < 60;
                if (!correctohl)
                {
                    MessageBox.Show("Hora de llegada incorrecta");
                    return;
                }
                if (!correctoml)
                {
                    MessageBox.Show("Minutos de llegada incorrecta");
                    return;
                }
                if (!correctohs)
                {
                    MessageBox.Show("Hora de salida incorrecta");
                    return;
                }
                if (!correctoms)
                {
                    MessageBox.Show("Minutos de salida incorrecta");
                    return;
                }
                if (correctohl && correctoml && correctohs && correctoms)
                {
                    viaje.RealizarParada(hLlegada,mLlegada,HSalida,MSalida,ascienden,descienden);
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
        }

        private void btnFinalizarViaje_Click(object sender, EventArgs e)
        {
          int HFinal = Convert.ToInt32(tbH.Text);
          int MFinal = Convert.ToInt32(tbM.Text);
            bool correctohf = HFinal >= 0 && HFinal < 24;
            bool correctomf = MFinal >= 0 && MFinal < 60;
            if (!correctohf)
            {
                MessageBox.Show("Hora final incorrecta");
                return;
            }
            if (!correctomf)
            {
                MessageBox.Show("Minutos final incorrectos");
                return;
            }
            if (correctohf && correctomf)
            {
                viaje.FinalizarViaje(HFinal, MFinal);
                Form3 f3 = new Form3();
                f3.lbxViaje.Items.Clear();
                f3.lbxViaje.Items.Add($"Cantidad de pasajeros: {viaje.Pasajeros}");
                f3.lbxViaje.Items.Add($"Tiempo total de recorrido en [HH:MM]: {viaje.HDuracionViaje}:{viaje.MinDuracionViaje}");
                f3.lbxViaje.Items.Add($"Cantidad de paradas: {viaje.CantParadas}");
                f3.lbxViaje.Items.Add($"Tiempo total de demora por paradas en [HH:MM]: {viaje.DemoraTotalenH}:{viaje.DemoraTotalenM}");
                f3.ShowDialog();
            }
            
        }
    }
}
