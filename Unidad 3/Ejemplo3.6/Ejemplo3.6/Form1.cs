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

namespace Ejemplo3._6
{
    public partial class Form1 : Form
    {
        string[] puertos;
        int i = 0, r, g, b, j = 0, k = 0;
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
        private void cbx_Puerto_SelectedIndexChanged(object sender, EventArgs e)
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
                if (!Arduino.IsOpen)
                {
                    Arduino.Open();
                    cbx_Puerto.Enabled = false;
                    btn_enviar_dato.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible conectar con Arduino");
            }
        }

        private void tkb_r_Scroll(object sender, EventArgs e)
        {
            //color_panel();
            r = tkb_r.Value;
            lbl_r.ForeColor = Color.FromArgb(r, 0, 0);
            lbl_r.Text = "Red " + Convert.ToString(r);
        }

        private void tkb_g_Scroll(object sender, EventArgs e)
        {
            //color_panel();
            g = tkb_g.Value;
            lbl_g.ForeColor = Color.FromArgb(0, g, 0);
            lbl_g.Text = "Green " + Convert.ToString(g);
        }

        private void tkb_b_Scroll(object sender, EventArgs e)
        {
            //color_panel();
            b = tkb_b.Value;
            lbl_b.ForeColor = Color.FromArgb(0, 0, b);
            lbl_b.Text = "Blue " + Convert.ToString(b);
        }

        private void tkb_servo_Scroll(object sender, EventArgs e)
        {
            //color_panel();
            lb_servo.Text = Convert.ToString(tkb_servo.Value);
        }
        void color_panel()
        {
            r = tkb_r.Value;
            g = tkb_g.Value;
            b = tkb_b.Value;
            pnl_Color.BackColor = Color.FromArgb(r, g, b);
            byte[] dato = new byte[4];
            dato[0] = (byte)tkb_r.Value;
            dato[1] = (byte)tkb_g.Value;
            dato[2] = (byte)tkb_b.Value;
            dato[3] = (byte)tkb_servo.Value;
            if (Arduino.IsOpen)
            {
                Arduino.Write(new byte[] { dato[0] }, 0, 1);
                Arduino.Write(new byte[] { dato[1] }, 0, 1);
                Arduino.Write(new byte[] { dato[2] }, 0, 1);
                Arduino.Write(new byte[] { dato[3] }, 0, 1);
                Arduino.Write(new byte[] { dato[0] }, 0, 1);
            }
        }

        private void btn_enviar_dato_Click(object sender, EventArgs e)
        {
            color_panel();
            string[] cadena = Arduino.ReadLine().Split(',');
            //lbx_sensor1.Items.Add(Arduino.ReadLine());
            lbx_sensor1.Items.Add(cadena[0]);
            lbx_sensor2.Items.Add(cadena[1]);
            lbx_sensor3.Items.Add(cadena[2]);
            lbx_sensor4.Items.Add(cadena[3]);
            lbx_sensor1.SelectedIndex = i;
            lbx_sensor2.SelectedIndex = i;
            lbx_sensor3.SelectedIndex = i;
            lbx_sensor4.SelectedIndex = i;
            i++;
        }

        private void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
        }
    }
}
