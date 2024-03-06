using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            //convertendo de Celsius para fahrenheit
            if(rbCelsius.Checked)
            {
                float celsius, fahrenheit;
                celsius = float.Parse(txbTemperatura.Text);

                fahrenheit = ((celsius * 9 / 5) + 32);
                lbResultado.Text = fahrenheit.ToString() + " °F";
            } 
            
            if(rbFahrenheit.Checked)
            {
                float fahrenheit;
                float celsius;

                fahrenheit = float.Parse(txbTemperatura.Text);

                celsius = ((fahrenheit - 32) * 5 / 9);

                lbResultado.Text = celsius.ToString() + "°C";
            }

        }

        
        //convertendo de fahrenheit para celsius
            
        
             
    }
}
