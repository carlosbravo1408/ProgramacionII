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

namespace Ejemplo1._8
{
    public partial class frm_acceso : Form
    {
        public int r, g, b, i,j=0;
        Random numero = new Random();
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
        public frm_acceso()
        {
            InitializeComponent();
        }
        private void frm_acceso_Load(object sender, EventArgs e)
        {
            #region pantalla
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.ControlBox = false;
            #endregion
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
            clb_control.SetItemChecked(0, true);
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
            cbx_dispositivo.Items.Add("Dispositivo 1");
            cbx_dispositivo.Items.Add("Dispositivo 2");
            cbx_dispositivo.Items.Add("Dispositivo 3");
            #region velocidad conexión
            int velocidad = 1200;
            do
            {
                lbx_velocidad.Items.Add(Convert.ToString(velocidad));
                velocidad *= 2;
            } while (velocidad <= 115200 * 2);
            #endregion
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
            #region encabezado datagridview
            dgv_datos.ColumnCount = 4;
            dgv_datos.Columns[0].HeaderText = "Sensor1";
            dgv_datos.Columns[1].HeaderText = "Sensor2";
            dgv_datos.Columns[2].HeaderText = "Sensor3";
            dgv_datos.Columns[3].HeaderText = "Hora Adquisicion";
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
            tmr_muestreo.Enabled = false;
            
        }
        private void tcl_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcl_control.SelectedIndex > Convert.ToInt16(Users[indice, 5]))
            {
                MessageBox.Show("No tiene acceso a estas pestañas");
            }
            try
            {
                clb_control.SetItemChecked(tcl_control.SelectedIndex, true);
            }
            catch (Exception)
            { }
        }
        private void cbx_dispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbx_velocidad.Enabled = true;
            cbx_dispositivo.Enabled = false;
        }
        private void lbx_velocidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            nud_delay.Enabled = true;
            lbx_velocidad.Enabled = false;
            tkb_r.Enabled = true;
            tkb_g.Enabled = true;
            tkb_b.Enabled = true;
            tmr_muestreo.Interval = Convert.ToInt16(nud_delay.Value);
            tmr_muestreo.Enabled = true;
            lbl_estado.Text = "Dispositivo: " + cbx_dispositivo.SelectedItem.ToString() + " @ " + lbx_velocidad.SelectedItem.ToString() + " Bauds";
            lbl_sample.Text = "SampleTime = " + nud_delay.Value;
        }
        private void nud_delay_ValueChanged(object sender, EventArgs e)
        {
            lbl_sample.Text = "SampleTime = " + nud_delay.Value;
            tmr_muestreo.Interval = Convert.ToInt16(nud_delay.Value);
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

            pnl_Color.BackColor = Color.FromArgb(r, g, b);
            pnl_clr.BackColor = Color.FromArgb(r, g, b);
            lbl_r.ForeColor = Color.FromArgb(r, 0, 0);
            lbl_g.ForeColor = Color.FromArgb(0, g, 0);
            lbl_b.ForeColor = Color.FromArgb(0, 0, b);
            lbl_r.Text = "Red " + Convert.ToString(r);
            lbl_g.Text = "Green " + Convert.ToString(g);
            lbl_b.Text = "Blue " + Convert.ToString(b);
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
        private void tmr_muestreo_Tick(object sender, EventArgs e)
        {
            double num1, num2, num3;
            double sum1, pro1, sum2, pro2, sum3, pro3;
            if (i % 2 == 0)
            {
                lbl_indicador.ForeColor = Color.Red;
            }
            else
            {
                lbl_indicador.ForeColor = Color.Blue;
            }
            if (i == 2)
                i = 0;
            i++;
            if (Convert.ToInt16(Users[indice, 5]) >3)
            {
                num1 = numero.Next(1, 50);
                num2 = numero.Next(1, 60);
                num3 = numero.Next(10, 50);
                dgv_datos.RowCount = j + 1;
                dgv_datos[0, j].Value = num1;
                dgv_datos[1, j].Value = num2;
                dgv_datos[2, j].Value = num3;
                dgv_datos[3, j].Value = System.DateTime.Now.ToShortTimeString();
                dgv_datos.FirstDisplayedScrollingRowIndex = j;
                if (j > 0)
                {
                    sum1 = Convert.ToDouble(dgv_datos[0, j].Value) + Convert.ToDouble(dgv_datos[0, j - 1].Value);
                    sum2 = Convert.ToDouble(dgv_datos[1, j].Value) + Convert.ToDouble(dgv_datos[1, j - 1].Value);
                    sum3 = Convert.ToDouble(dgv_datos[2, j].Value) + Convert.ToDouble(dgv_datos[2, j - 1].Value);
                    pro1 = sum1 / dgv_datos.RowCount;
                    pro2 = sum2 / dgv_datos.RowCount;
                    pro3 = sum3 / dgv_datos.RowCount;
                }
                else
                { 
                    pro1 = 0;
                    pro2 = 0;
                    pro3 = 0;
                }
                if(chrt_grafico.Series[5].Points.Count>=1)
                {
                    chrt_grafico.Series[3].Points.Clear();
                    chrt_grafico.Series[4].Points.Clear();
                    chrt_grafico.Series[5].Points.Clear();
                }
                if (chrt_grafico.Series[0].Points.Count >= 10)
                {
                    chrt_grafico.Series[0].Points.RemoveAt(0);
                    chrt_grafico.Series[1].Points.RemoveAt(0);
                    chrt_grafico.Series[2].Points.RemoveAt(0);
                }
                chrt_grafico.Series[0].Points.AddXY(j,num1);
                chrt_grafico.Series[1].Points.AddXY(j, num2);
                chrt_grafico.Series[2].Points.AddXY(j, num3);
                chrt_grafico.Series[3].Points.Add(pro1);
                chrt_grafico.Series[4].Points.Add(pro2);
                chrt_grafico.Series[5].Points.Add(pro3);
                chrt_grafico.Update();
                j++;
            }
        }
        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            tmr_muestreo.Enabled = false;
            lbx_velocidad.Enabled = false;
            cbx_dispositivo.Enabled = true;
        }

        private void cbx_3d_gra1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_3d_gra1.Checked==true)
            {
                chrt_grafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                chrt_grafico.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }

        private void cbx_3d_gra2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_3d_gra2.Checked == true)
            {
                chrt_grafico.ChartAreas[1].Area3DStyle.Enable3D = true;
            }
            else
            {
                chrt_grafico.ChartAreas[1].Area3DStyle.Enable3D = false;
            }
        }
    }
}

