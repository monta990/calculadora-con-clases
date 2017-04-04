using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraConClases
{
    public partial class Form1 : Form
    {
        Double valor = 0;
        String operacion = "";
        bool elegir_operacion = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPunto_Click(object sender, EventArgs e) //se agrega punto
        {
            txbDis.Text = txbDis.Text + ".";
            txbDis.ForeColor = Color.Black;
        }
        private void btnIgual_Click(object sender, EventArgs e) //despues de seleccionar la operacion de manda a operaciones (mediante switch)
        {
            lbDis.Text = "";
            switch (operacion)
            {
                case "+":
                    //txbDis.Text = (valor + Double.Parse(txbDis.Text)).ToString();
                    txbDis.Text = Operadores.Suma(valor, Double.Parse(txbDis.Text)).ToString();
                    break;
                case "-":
                    //txbDis.Text = (valor - Double.Parse(txbDis.Text)).ToString();
                    txbDis.Text = Operadores.Resta(valor, Double.Parse(txbDis.Text)).ToString();
                    break;
                case "*":
                    //txbDis.Text = (valor * Double.Parse(txbDis.Text)).ToString();
                    txbDis.Text = Operadores.Multi(valor, Double.Parse(txbDis.Text)).ToString();
                    break;
                case "/":
                    //txbDis.Text = (valor / Double.Parse(txbDis.Text)).ToString();
                    txbDis.Text = Operadores.Div(valor, Double.Parse(txbDis.Text)).ToString();
                    break;
                case "Sqrt":
                    //txbDis.Text = (Math.Sqrt(Double.Parse(txbDis.Text)).ToString());
                    txbDis.Text = Operadores.sqrt(Double.Parse(txbDis.Text)).ToString();
                    break;
            }
            
        }

        private void boton_click(object sender, EventArgs e)
        {
            if (txbDis.Text == "0" || elegir_operacion)
            {
                txbDis.Clear();
                elegir_operacion = false;
                Button b = (Button)sender;
                txbDis.Text = txbDis.Text + b.Text;
            }
            else
            {
                elegir_operacion = false;
                Button b = (Button)sender;
                txbDis.Text = txbDis.Text + b.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e) //borrado del label dejando 0 en su lugar
        {
            txbDis.Text = "0";
            valor = 0;
        }

        private void operadores_click(object sender, EventArgs e) //mostrar en label el resultado de Operadores
        {
            Button b = (Button)sender;
            operacion = b.Text;
            valor = double.Parse(txbDis.Text);
            elegir_operacion = true;
            lbDis.Text = valor + " " + operacion;

        }

        private void button2_Click(object sender, EventArgs e) //borrar ultimo caracter ingresado
        {
            txbDis.Text = txbDis.Text.Remove(txbDis.Text.Length - 1, 1); 
        }

        private void btSalir_Click(object sender, EventArgs e) //este boton es tan famoso que no ocupa explicación
        {
            this.Close();
        }
    }
}
