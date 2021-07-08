using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claculadora
{
    public partial class Form1 : Form
    {
        string numero = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numero = numero + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numero = numero + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numero = numero + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numero = numero + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numero = numero + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numero = numero + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numero = numero + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numero = numero + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numero = numero + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numero = numero + "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            numero = numero + "+";
            string[] num = numero.Split('+');
            int sumador = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (!string.IsNullOrEmpty( num[i]))
                    sumador = sumador + Convert.ToInt32(num[i]);
            }
            blnCabezara1.Text = numero;
            blnCabezara2.Text = sumador.ToString();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string[] num = numero.Split('+');
            int sumador = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sumador = sumador + Convert.ToInt32(num[i]);
            }
            blnCabezara1.Text = numero;
            blnCabezara2.Text = sumador.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numero = string.Empty;
            blnCabezara1.Text = "";
            blnCabezara2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blnCabezara1.Text = "";
            blnCabezara2.Text = "";
        }
    }
}
