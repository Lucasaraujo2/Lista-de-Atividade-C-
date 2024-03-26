using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        private operacao operacaoSelecionada {  get; set; }

        private enum operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
            

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "9";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = operacao.Adicao;
            Valor = Convert.ToDecimal(txbResultado);
            txbResultado.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = operacao.Subtracao;
            Valor = Convert.ToDecimal(txbResultado);
            txbResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txbResultado);
            txbResultado.Text = "";
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = operacao.Divisao;
            Valor = Convert.ToDecimal(txbResultado);
            txbResultado.Text = "";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (operacaoSelecionada)
            {
                case operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txbResultado.Text);
                    break;
                case operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txbResultado.Text);
                    break;
                case operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txbResultado.Text);
                    break;
                case operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txbResultado.Text);
                    break;
            }
            txbResultado.Text = Convert.ToString (Resultado);

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!txbResultado.Text.Contains(","))
            txbResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "";
        }
    }
}
