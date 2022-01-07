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

namespace Ejemplo1._2
{
    public partial class frm_acceso : Form
    {
        public int r, g, b;
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
            lbl_estado.Text = "Dispositivo: " + cbx_dispositivo.SelectedItem.ToString() + " @ " + lbx_velocidad.SelectedItem.ToString() + " Bauds";
            lbl_sample.Text = "SampleTime = " + nud_delay.Value;
        }

        private void nud_delay_ValueChanged(object sender, EventArgs e)
        {
            lbl_sample.Text = "SampleTime = " + nud_delay.Value;
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
    }
}
