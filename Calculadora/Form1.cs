using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        String operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textresultado.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
                textresultado.Text = "";
                operacao = "DIVIDIR";
                labelOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor!!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textresultado.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textresultado.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                valor2 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    textresultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "MULT")
                {
                    textresultado.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "MENOS")
                {
                    textresultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "DIVIDIR")
                {
                    textresultado.Text = Convert.ToString(valor1 / valor2);
                }
            } 
            else
            {
                MessageBox.Show("Informe um valor!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textresultado.Text  += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textresultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textresultado.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textresultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textresultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textresultado.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textresultado.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textresultado.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textresultado.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textresultado.Clear();
            textresultado.Focus();
            labelOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
                textresultado.Text = "";
                operacao = "SOMA";
                labelOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor!!");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
                textresultado.Text = "";
                operacao = "MULT";
                labelOperacao.Text = "*";
            } 
            else
            {
                MessageBox.Show("Informe um valor!!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                valor1 = decimal.Parse(textresultado.Text, CultureInfo.InvariantCulture);
                textresultado.Text = "";
                operacao = "MENOS";
                labelOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor!!");
            }
        }

        private void textresultado_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
