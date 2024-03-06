using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Adivinhação
{
    public partial class Form1 : Form
    {
        int minimo = 0;
        int maximo = 1000;
        int numero = 0;
        int tentativas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbNumero.Enabled = false;
            lbInformacao.Text = "Adivinhe o numero";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tentativas = 0;
            minimo = 0;
            maximo = 1000;

            Random rnd = new Random();
            numero = rnd.Next(minimo, maximo);
            lbInformacao.Text = "Jogo iniciado" + Environment.NewLine + "Adivinhe o numero entre" + 
            Environment.NewLine + string.Format("{0} e {1}", minimo, maximo);


            txbNumero.Enabled = true;
            txbNumero.Text = "";
            txbNumero.Focus();
            btnIniciar.Enabled = false;


                
        }

        private void txbNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txbNumero.Text != "") 
            {
                e.SuppressKeyPress = true;
                int.TryParse(txbNumero.Text, out int valor);

                if (valor < numero)
                {
                    lbInformacao.Text = "O numero é mais alto";
                    tentativas++;
                }
                else if (valor > numero)
                {
                    lbInformacao.Text = "O numero é mais baixo";
                    tentativas++;
                }
                else
                {
                    //Venceu
                    lbInformacao.Text = "Acertou!!! " + "Tentativas: " + tentativas;
                    txbNumero.Enabled = false;
                    btnIniciar.Enabled = true;


                }
            }
        }
    }
}
