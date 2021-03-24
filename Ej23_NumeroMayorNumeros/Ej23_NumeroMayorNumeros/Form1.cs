using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej23_NumeroMayorNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double m = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() != "") 
                {
                    listBox1.Items.Add(float.Parse(textBox1.Text));
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Campo de numero vacio, favor de ingresar numero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Digito ingresado no es un numero, favor de ingresar un numero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
        }
        private double Maximo()
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (m < Convert.ToDouble(listBox1.Items[i])) 
                {
                    m = Convert.ToDouble(listBox1.Items[i]);
                }
            }
            return m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Maximo();
            textBox2.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox2.Clear();
            textBox1.Focus();
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult salir;
            salir = MessageBox.Show("Deseas salir de la aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
