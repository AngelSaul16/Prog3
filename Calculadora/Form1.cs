using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        Clases.suma objS = new Clases.suma();
        Clases.resta objR = new Clases.resta();
        Clases.mult objM = new Clases.mult();
        Clases.div objD = new Clases.div();
        Clases.potencia objP = new Clases.potencia();

        private void button4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void bntN9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            operador = "^";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);
            double suma;
            double resta;
            double multiplicacion;
            double division;
            double potencia;

            switch (operador) {
                case "+":
                    suma = objS.Sumar((primero), (segundo));
                    tbxScreen.Text = suma.ToString();
                    break;
                case "-":
                    resta = objR.Restar((primero), (segundo));
                    tbxScreen.Text = resta.ToString();
                    break;
                case "*":
                    multiplicacion = objM.Multiplicar((primero), (segundo));
                    tbxScreen.Text = multiplicacion.ToString();
                    break;
                case "/":
                    division = objD.Dividir((primero), (segundo));
                    tbxScreen.Text = division.ToString();
                    break;
                case "^":
                    potencia = objP.Potencia((primero), (segundo));
                    tbxScreen.Text = potencia.ToString();
                    break;
            }   
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }
    }
}
