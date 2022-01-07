using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Ejemplo3._2
{
    public partial class Form1 : Form
    {
        //arreglo de cadena de caracteres con todos los puertos disponibles en el sistema
        string[] puertos;
        int i = 0, j=0, k=0;
        public Form1()
        {
            InitializeComponent();
            lista_puertos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lista_puertos();
        }
        void lista_puertos()
        {
            puertos = SerialPort.GetPortNames();
            if (puertos.Length > 0)
            {
                cbx_Puerto.Items.Clear();
                cbx_Puerto.SelectedIndex = -1;
                cbx_Puerto.Items.AddRange(puertos);
            }
            else
                MessageBox.Show(this, "No existen puertos disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (cbx_Puerto.SelectedIndex != -1)
                {
                    Arduino.PortName = cbx_Puerto.SelectedItem.ToString();
                    Arduino.BaudRate = 9600;
                }
                else
                    throw new Exception("Seleccione un puerto adecuado");
                if(!Arduino.IsOpen)
                {
                    Arduino.Open();
                    btn_conectar.Enabled = false;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No fue posible conectar con Arduino");
            }
        }
        private void btn_led1_Click(object sender, EventArgs e)
        {
            if (Arduino.IsOpen)
            {
                if (i % 2 == 0)
                {
                    btn_led1.Text = "Led1 On";
                    Arduino.Write("a");
                }
                if (i % 2 == 1)
                {
                    btn_led1.Text = "Led1 Off";
                    Arduino.Write("b");
                }
                if (i == 2)
                    i = 0;
                i++;
            }

        }
        private void btn_led2_Click(object sender, EventArgs e)
        {
            if (Arduino.IsOpen)
            {
                if (j % 2 == 0)
                {
                    btn_led2.Text = "Led2 On";
                    Arduino.Write("1");
                }
                if (j % 2 == 1)
                {
                    btn_led2.Text = "Led2 Off";
                    Arduino.Write("2");
                }
                if (j == 2)
                    j = 0;
                j++;
            }
        }
        private void btn_encendido_apagado_Click(object sender, EventArgs e)
        {
            if (Arduino.IsOpen)
            {
                if (k % 2 == 0)
                {
                    btn_led1.Text = "Led1 On";
                    btn_led2.Text = "Led2 On";
                    btn_encendido_apagado.Text = "Leds On";
                    Arduino.Write("t");
                }
                if (k % 2 == 1)
                {
                    btn_led1.Text = "Led1 Off";
                    btn_led2.Text = "Led2 Off";
                    btn_encendido_apagado.Text = "Leds Off";
                    Arduino.Write("n");
                }
                if (k == 2)
                    k = 0;
                k++;
            }
        }
    }
}
