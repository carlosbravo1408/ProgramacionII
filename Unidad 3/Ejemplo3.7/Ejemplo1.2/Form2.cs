using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Ejemplo1._2
{
    public partial class frm_acceso : Form
    {
        public int r=0, g=0, b=0, servo=0, motor=0;
        public string[,] Users = new string[,]
            {{"Root","1234","Asd","Asd",Directory.GetCurrentDirectory()+"\\Image\\Root.png","4"},
            {"RosaAvilar123","contraseña123","Rosa","Avilar",Directory.GetCurrentDirectory()+"\\Image\\User0.png","3"},
            {"CarlosJavier258","asdasd","Carlos","Bravo",Directory.GetCurrentDirectory()+"\\Image\\User1.png","2"},
            {"PepePepito666","@nope:p","José","Andrea",Directory.GetCurrentDirectory()+"\\Image\\User2.jpg","1"},
            {"asd","asd","Asd","Asd",Directory.GetCurrentDirectory()+"\\Image\\User3.jpg","0"}};
        frm_ingreso ingreso = new frm_ingreso();
        public string cadena_usuario;
        public string cadena_contraseña;
        public int indice;
        string[] puertos;
        public frm_acceso()
        {
            InitializeComponent();
            puertos_disponibles();
        }
        void puertos_disponibles()
        {
            puertos = SerialPort.GetPortNames();
            if (puertos.Length > 0)
            {
                cbx_dispositivo.Items.Clear();
                cbx_dispositivo.SelectedIndex = -1;
                cbx_dispositivo.Items.AddRange(puertos);
            }
            else
                MessageBox.Show(this, "No existen puertos disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frm_acceso_Load(object sender, EventArgs e)
        {
            rch_mensaje.Text = "Acceso Exitoso\nBienvenido:" + Users[indice, 0] + "\nFecha y Hora de acceso:\n";
            rch_mensaje.Text = rch_mensaje.Text + DateTime.Now.ToShortDateString() + "\t" + DateTime.Now.ToShortTimeString() + "\n" + "\n";
            rch_mensaje.Text = rch_mensaje.Text + "Nombre(s): " + Users[indice, 2] + "\n";
            rch_mensaje.Text = rch_mensaje.Text + "Apellidos(s): " + Users[indice, 3] + "\n";
            string p = Users[indice, 4];
            imagen(p);
            #region Nivel de acceso
            string[] acceso = new string[5] { "Datos Personales", "Conexion Dispositivo", "RGB", "Adquisicion Datos", "Motor" };
            for (int i = 0; i <= Convert.ToInt16(Users[indice, 5]); i++)
            {
                clb_control.Items.Add(acceso[i]);
            }
            clb_control.SetItemChecked(0,true);
            clb_control.Enabled = false;
            if (Convert.ToInt16(Users[indice, 5]) == 0)
            {
                tbp_AccesoNivel0.Enabled = true;
                tbp_AccesoNivel1.Enabled = false;
                tbp_AccesoNivel2.Enabled = false;
                tbp_AccesoNivel3.Enabled = false;
                tbp_AccesoNivel4.Enabled = false;
            }
            else if (Convert.ToInt16(Users[indice, 5]) == 1)
            {
                tbp_AccesoNivel0.Enabled = true;
                tbp_AccesoNivel1.Enabled = true;
                tbp_AccesoNivel2.Enabled = false;
                tbp_AccesoNivel3.Enabled = false;
                tbp_AccesoNivel4.Enabled = false;
            }
            else if (Convert.ToInt16(Users[indice, 5]) == 2)
            {
                tbp_AccesoNivel0.Enabled = true;
                tbp_AccesoNivel1.Enabled = true;
                tbp_AccesoNivel2.Enabled = true;
                tbp_AccesoNivel3.Enabled = false;
                tbp_AccesoNivel4.Enabled = false;
            }
            else if (Convert.ToInt16(Users[indice, 5]) == 3)
            {
                tbp_AccesoNivel0.Enabled = true;
                tbp_AccesoNivel1.Enabled = true;
                tbp_AccesoNivel2.Enabled = true;
                tbp_AccesoNivel3.Enabled = true;
                tbp_AccesoNivel4.Enabled = false;
            }
            else if (Convert.ToInt16(Users[indice, 5]) == 4)
            {
                tbp_AccesoNivel0.Enabled = true;
                tbp_AccesoNivel1.Enabled = true;
                tbp_AccesoNivel2.Enabled = true;
                tbp_AccesoNivel3.Enabled = true;
                tbp_AccesoNivel4.Enabled = true;
            }
            else
            {
                tbp_AccesoNivel0.Enabled = false;
                tbp_AccesoNivel1.Enabled = false;
                tbp_AccesoNivel2.Enabled = false;
                tbp_AccesoNivel3.Enabled = false;
                tbp_AccesoNivel4.Enabled = false;
            }
            #endregion
            /*cbx_dispositivo.Items.Add("Dispositivo 1");
            cbx_dispositivo.Items.Add("Dispositivo 2");
            cbx_dispositivo.Items.Add("Dispositivo 3");*/
            color_panel();
            #region lista imagenes iconos pestañas
            ImageList iconsList = new ImageList();
            iconsList.ImageSize = new Size(25, 25);
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\datos_personales.png"));
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\usb2.png"));
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\RGB.png"));
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\graficas.png"));
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\Servo.png"));
            tcl_control.ImageList = iconsList;
            tbp_AccesoNivel0.ImageIndex = 0;
            tbp_AccesoNivel1.ImageIndex = 1;
            tbp_AccesoNivel2.ImageIndex = 2;
            tbp_AccesoNivel3.ImageIndex = 3;
            tbp_AccesoNivel4.ImageIndex = 4;
            #endregion
        }
        private void imagen(string dir)
        {
            pbx_picture.Image = Image.FromFile(dir);
        }

        private void frm_acceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            ingreso.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ingreso.Show();
        }

        private void tcl_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcl_control.SelectedIndex > Convert.ToInt16(Users[indice, 5]))
            {
                MessageBox.Show("No tiene acceso a estas pestañas");
            }
            clb_control.SetItemChecked(tcl_control.SelectedIndex, true);
        }

        private void cbx_dispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (cbx_dispositivo.SelectedIndex != -1)
                {
                    Arduino.PortName = cbx_dispositivo.SelectedItem.ToString();
                    Arduino.BaudRate = 9600;
                }
                else
                    throw new Exception("Seleccione un puerto adecuado");
                if (!Arduino.IsOpen)
                {
                    Arduino.Open();
                    cbx_dispositivo.Enabled = false;
                    nud_delay.Enabled = true;
                    tkb_r.Enabled = true;
                    tkb_g.Enabled = true;
                    tkb_b.Enabled = true;
                    lbl_estado.Text = "Dispositivo: " + cbx_dispositivo.SelectedItem.ToString() + " @ " + "9600 Bauds";
                    lbl_sample.Text = "SampleTime = " + nud_delay.Value;
                    tmr_dato.Interval = (int)(nud_delay.Value);
                    tmr_dato.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible conectar con Arduino");
            }
            Cursor.Current = Cursors.Default;
        }
        private void nud_delay_ValueChanged(object sender, EventArgs e)
        {
            lbl_sample.Text = "SampleTime = " + nud_delay.Value;
            tmr_dato.Interval = (int)(nud_delay.Value);
            //tmr_dato.Start();
        }

        private void tkb_r_Scroll(object sender, EventArgs e)
        {
            color_panel();
        }

        private void tkb_g_Scroll(object sender, EventArgs e)
        {
            color_panel();
        }

        private void tkb_b_Scroll(object sender, EventArgs e)
        {
            color_panel();
        }
        void color_panel()
        {
            if (chx_Red.Checked == true)
                r = tkb_r.Value;
            else
                r = 0;

            if (chx_Green.Checked == true)
                g = tkb_g.Value;
            else
                g = 0;

            if (chx_Blue.Checked == true)
                b = tkb_b.Value;
            else
                b = 0;
            servo = tkb_servo.Value;
            motor = tkb_motor.Value;
            pnl_Color.BackColor = Color.FromArgb(r, g, b);
            pnl_clr.BackColor = Color.FromArgb(r, g, b);
            lbl_r.ForeColor = Color.FromArgb(r, 0, 0);
            lbl_g.ForeColor = Color.FromArgb(0, g, 0);
            lbl_b.ForeColor = Color.FromArgb(0, 0, b);
            lbl_r.Text = "Red " + Convert.ToString(r);
            lbl_g.Text = "Green " + Convert.ToString(g);
            lbl_b.Text = "Blue " + Convert.ToString(b);
            lbl_motor.Text = "Motor a " + Convert.ToString(motor) + " de ciclo útil (PWM)";
            lbl_servo.Text = "Servomotor en " + Convert.ToString(servo) + " grados";
        }

        private void chx_Red_CheckedChanged(object sender, EventArgs e)
        {
            color_panel();
        }

        private void chx_Green_CheckedChanged(object sender, EventArgs e)
        {
            color_panel();
        }

        private void chx_Blue_CheckedChanged(object sender, EventArgs e)
        {
            color_panel();
        }

        private void tmr_dato_Tick(object sender, EventArgs e)
        {
            Arduino.Write(new byte[] { Convert.ToByte(r) }, 0, 1);
            Arduino.Write(new byte[] { Convert.ToByte(g) }, 0, 1);
            Arduino.Write(new byte[] { Convert.ToByte(b) }, 0, 1);
            Arduino.Write(new byte[] { Convert.ToByte(motor) }, 0, 1);
            Arduino.Write(new byte[] { Convert.ToByte(servo) }, 0, 1);
            string[] cadena = Arduino.ReadLine().Split(',');
            lbx_Sensor1.Items.Add(cadena[0]);
            lbx_Sensor2.Items.Add(cadena[1]);
            lbx_Sensor3.Items.Add(cadena[2]);
            lbx_Sensor4.Items.Add(cadena[3]);
            lbx_Sensor1.SelectedIndex = lbx_Sensor1.Items.Count - 1;
            lbx_Sensor2.SelectedIndex = lbx_Sensor1.Items.Count - 1;
            lbx_Sensor3.SelectedIndex = lbx_Sensor1.Items.Count - 1;
            lbx_Sensor4.SelectedIndex = lbx_Sensor1.Items.Count - 1;
            if (chrt_gráfico.Series[0].Points.Count >= 10)
            {
                chrt_gráfico.Series[0].Points.RemoveAt(0);
                chrt_gráfico.Series[1].Points.RemoveAt(0);
                chrt_gráfico.Series[2].Points.RemoveAt(0);
                chrt_gráfico.Series[3].Points.RemoveAt(0);

            }
            chrt_gráfico.Series[0].Points.AddY(Convert.ToInt32(cadena[0]));
            chrt_gráfico.Series[1].Points.AddY(Convert.ToInt32(cadena[1]));
            chrt_gráfico.Series[2].Points.AddY(Convert.ToInt32(cadena[2]));
            chrt_gráfico.Series[3].Points.AddY(Convert.ToInt32(cadena[3]));
        }

        private void tkb_servo_Scroll(object sender, EventArgs e)
        {
            color_panel();
        }

        private void tkb_motor_Scroll(object sender, EventArgs e)
        {
            color_panel();
        }

        private void pnl_Color_Click(object sender, EventArgs e)
        {
            //tmr_dato_Tick(sender, e);
        }
    }
}
