using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btncalcular.Enabled = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double.TryParse(txbAltura.Text, out double Altura);
            if (Altura == null) return;

            //executar os cáuculos

            double peso_ideal = 0;

            //condiçâo Homem ou Mulher
            if (radio_Homem.Checked)
            {
                //Homem
                peso_ideal = (72.7 * Altura) - 58;
            }
            else
            {
                //Mulher
                peso_ideal = (62.7 * Altura) - 44.7;

            }

            StringBuilder str = new StringBuilder("Peso ideal: " + peso_ideal.ToString("0.00")+ "Kg.");

            //Comparação com o peso atual
            if(txbPeso_atual.Text != "")
            {
                double.TryParse(txbPeso_atual.Text, out double peso_atual);
                if (txbPeso_atual != null)
                {
                    if (peso_ideal < peso_atual)
                    {
                        str.Append(Environment.NewLine + "Deve emagrecer " + (peso_atual - peso_ideal).ToString("0.00"));

                    }
                    else if (peso_ideal > peso_atual)
                    {
                        str.Append(Environment.NewLine + "Esta" + (peso_ideal - peso_atual).ToString("0.00") + "Kg. abaixo do seu peso ideal");

                    }
                    else
                    {
                        // tem o peso ideal 
                        str.Append(Environment.NewLine + "Parabens, esta com o seu peso ideal");
                    }

                }
            }



            MessageBox.Show(str.ToString());
            

        }

        private void txbAltura_TextChanged(object sender, EventArgs e)
        {
            btncalcular.Enabled = txbAltura.Text != "" ? true : false;
        }
    }
}
