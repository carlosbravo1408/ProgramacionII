using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3._1
{
    public partial class frm_conexion : Form
    {
        int i = 0;
        public frm_conexion()
        {
            InitializeComponent();
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                if (!Arduino.IsOpen)
                {
                    Arduino.PortName = "COM" + nud_COM.Value.ToString();
                    Arduino.BaudRate = 9600;
                    Arduino.Open();
                    btnConectar.Text = "Desconectar";
                    //btnConectar.Enabled = false;
                    nud_COM.Enabled = false;
                    btn_enviar.Enabled = true;
                    grb_metodos_envio.Enabled = true;
                }
                else
                    MessageBox.Show("Ya hay un dispositivo Conectado");
            }
            else 
            {
                if(Arduino.IsOpen)
                {
                    Arduino.Close();
                    nud_COM.Enabled = true;
                    btn_enviar.Enabled = false;
                    grb_metodos_envio.Enabled = false;
                    btnConectar.Text = "Conectar!";
                    txt_dato_a_enviar.Text = "";
                }
            }
            if (i == 2)
                i = 0;
            i++;
        }
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            rch_datoRecibido.Text = "";
            if (rdb_write_byte.Checked == true)
            {
                Arduino.Write(new byte[] { Convert.ToByte(txt_dato_a_enviar.Text) }, 0, 1);
                rch_datoRecibido.Text = Arduino.ReadLine();
            }
            if(rdb_writeString.Checked==true)
            {
                Arduino.Write(txt_dato_a_enviar.Text);
                for (int i = 0; i < txt_dato_a_enviar.TextLength; i++)
                    rch_datoRecibido.Text = rch_datoRecibido.Text + Arduino.ReadLine() + "\n";
            }
            if(rdb_writeline.Checked==true)
            {
                Arduino.WriteLine(txt_dato_a_enviar.Text);
                for (int i = 0; i < txt_dato_a_enviar.TextLength+1; i++)
                    rch_datoRecibido.Text = rch_datoRecibido.Text + Arduino.ReadLine() + "\n";
            }
        }
        private void txt_dato_a_enviar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                btn_enviar_Click(sender, e);
            }
        }
    }
}
