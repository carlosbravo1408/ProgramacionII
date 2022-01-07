using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*foreach(int i in checkedListBox1.CheckedIndices)
            {
                MessageBox.Show("indices: " + i.ToString() + "estan seleccionados  " + checkedListBox1.GetItemCheckState(i).ToString());
            }*/
            checkedListBox1.SetItemChecked(1,true);
            char R = Convert.ToChar(trackBar1.Value);
            char G = Convert.ToChar(trackBar3.Value);
            char B = Convert.ToChar(trackBar4.Value);
            string cadena = "";
            cadena = R.ToString();
            Arduino.Write(cadena);
            rch_datoRecibido.Text = Arduino.ReadLine();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Label lbl_test = new Label();
            lbl_test.Location=new Point(250, 250);
            lbl_test.Text = Convert.ToString(dateTimePicker1.Value);
            label1.Text = Convert.ToString(dateTimePicker1.Value);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Arduino.PortName = "COM" + nud_COM.Value.ToString();
            Arduino.BaudRate = 9600;
            Arduino.Open();
            btnConectar.Text = "Conectado";
            btnConectar.Enabled = false;
            nud_COM.Enabled = false;
            btn_enviar.Enabled = true;
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            byte[] dato = new byte[4];
            dato[0] = (byte)trackBar2.Value;
            dato[1] = (byte)trackBar3.Value;
            dato[2] = (byte)trackBar4.Value;
            dato[3] = (byte)trackBar5.Value;
            //char s = (char)trackBar5.Value;
            //char m = (char)trackBar6.Value;+ s.ToString() + m.ToString()
            //string cadena = "R" + r.ToString() + "G" + g.ToString() + "B" + b.ToString();
            Arduino.Write(dato,0,3);
            //if (Arduino.ReadLine().Length > 0)
            //{
                rch_datoRecibido.Text = rch_datoRecibido.Text + Arduino.ReadLine() + "\n";
            //}
        }

        private void nud_COM_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Arduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //rch_datoRecibido.Text = Arduino.ReadLine();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text = e.KeyChar.ToString() +" "+ (int)e.KeyChar;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(trackBar1.Value) + " " +Convert.ToString((char)trackBar1.Value);
        }
    }
}
