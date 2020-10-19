using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraC
{
    public partial class Form1 : Form
    {
        String nro1;
        String sig;
        String nro2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Equals(""))
            {
                nro1 = pantalla.Text;
                sig = "*";
                pantalla.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String cadena;
            cadena = pantalla.Text;
            if (cadena.Length <= 0)
            {
                pantalla.Text = "0.";
            }
            else {
                if (!punto(pantalla.Text)) {
                    pantalla.Text = pantalla.Text + ".";
                }
            }

        }

        private bool punto(string cadena)
        {
            Boolean resul;
            resul = false;
            for (int i = 0; i < cadena.Length; i++) {
                if (cadena.Substring(i, i + 1).Equals(".")) {
                    resul = true;
                    break;
                }
            }
            return resul;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            String cadena;
            cadena = pantalla.Text;
            if (cadena.Length > 0) {
                cadena = cadena.Substring(0, cadena.Length - 1);
                pantalla.Text = cadena;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pantalla.Text="";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Equals("")) {
                nro1 = pantalla.Text;
                sig = "-";
                pantalla.Text = "";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Equals(""))
            {
                nro1 = pantalla.Text;
                sig = "+";
                pantalla.Text = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Equals(""))
            {
                nro1 = pantalla.Text;
                sig = "/";
                pantalla.Text = "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Double num;
            String cadena;
            cadena = pantalla.Text;
            if (cadena.Length > 0) {
                num = (-1) * Double.Parse(cadena);
                pantalla.Text = num+"";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            String resul;
            nro2 = pantalla.Text;
            if (!nro2.Equals(""))
            {
                resul = calcular(nro1, nro2, sig);
                pantalla.Text = resul;
            }

            
        }

        private string calcular(string nro1, string nro2, string sig)
        {
            Double resultado = 0.0;
            String respuesta;
            if (sig.Equals("-")) { 
                resultado = Double.Parse(nro1) - Double.Parse(nro2);
            }
            if (sig.Equals("+"))
            {
                resultado = Double.Parse(nro1) + Double.Parse(nro2);
            }
            if (sig.Equals("*"))
            {
                resultado = Double.Parse(nro1) * Double.Parse(nro2);
            }
            if (sig.Equals("/"))
            {
                if (!nro2.Equals("0"))
                {
                    resultado = Double.Parse(nro1) / Double.Parse(nro2);
                }
                else {
                    return "";
                }
            }
            respuesta = resultado+"";
            return respuesta;
        }
    }
}
