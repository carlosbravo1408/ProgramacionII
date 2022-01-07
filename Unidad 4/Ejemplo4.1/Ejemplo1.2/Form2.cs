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
using System.Data.SqlClient;

namespace Ejemplo1._2
{
    public partial class frm_acceso : Form
    {
        public int r=0, g=0, b=0, servo=0, motor=0;
        int cod_reg = 0;
        SqlConnection conexion = new SqlConnection();
        //SqlConnection conexion2 = new SqlConnection();
        frm_ingreso ingreso = new frm_ingreso();
        /*public string[,] Users = new string[,]
            {{"Root","1234","Asd","Asd",Directory.GetCurrentDirectory()+"\\Image\\Root.png","4"},
            {"RosaAvilar123","contraseña123","Rosa","Avilar",Directory.GetCurrentDirectory()+"\\Image\\User0.png","3"},
            {"CarlosJavier258","asdasd","Carlos","Bravo",Directory.GetCurrentDirectory()+"\\Image\\User1.png","2"},
            {"PepePepito666","@nope:p","José","Andrea",Directory.GetCurrentDirectory()+"\\Image\\User2.jpg","1"},
            {"asd","asd","Asd","Asd",Directory.GetCurrentDirectory()+"\\Image\\User3.jpg","0"}};*/
        public string cadena_usuario;
        public string cadena_contraseña;
        public string Usuario, contraseña, nombre, apellido, ubi_imagen;
        public int prioridad;
        public int indice;
        string[] puertos;
        public frm_acceso()
        {
            InitializeComponent();
            puertos_disponibles();
        }
        //método para conexion de la base de datos
        private void conexionBaseD()
        {
            try
            {
                //CADENA DE CONEXIÓN
                //Data Source=(Servidor PC); Initial Catalog = (Base de datos); Integrated Security=true
                conexion.ConnectionString = @"Data Source=AS-PC\WINCC;Initial Catalog=Base_prueba;Integrated Security=true";
                conexion.Open();
            }
            catch
            {
                MessageBox.Show("No se ha conectado a Base de Datos", "Conexión Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            conexionBaseD();
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();
            indice = frm_ingreso.cod_usuario;
            //insersion de la fecha y hora de registro
            string comando_insertar = "INSERT INTO dbo.Registro_Hora(Cod_Usuario, Fecha, Hora) VALUES(@Cod_Usuario, @Fecha, @Hora)";
            SqlCommand com = new SqlCommand(comando_insertar, conexion);
            com.Parameters.AddWithValue("Cod_Usuario", indice);
            com.Parameters.AddWithValue("Fecha", fecha);
            com.Parameters.AddWithValue("Hora", hora);
            try
            {
                com.ExecuteNonQuery();
                //consulta para identificar el ultimo registro de la tabal Registro_Hora
                string consulta = "Select MAX(Cod_Registro) From dbo.Registro_Hora";
                SqlCommand consultaID = new SqlCommand(consulta, conexion);
                cod_reg = Convert.ToInt32(consultaID.ExecuteScalar());
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("Select Cod_Usuario,Usuario from dbo.Usuarios",conexion);
                da.Fill(ds, "Usuarios");
                cbx_Usuarios.DataSource = ds.Tables[0].DefaultView;
                cbx_Usuarios.ValueMember = "Cod_Usuario";
                cbx_Usuarios.DisplayMember = "Usuario";
                //da.
                //string reg_usuarios = "Select Cod_Usuario,Usuario from dbo.Usuarios";
            }
            catch (Exception) { }
            string consulta1 = "SELECT * FROM dbo.Usuarios WHERE (Cod_Usuario = " + indice + ")";
            //string consulta
            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
            SqlDataReader leer = comando1.ExecuteReader();
            if (leer.Read() == true)
            {
                prioridad = Convert.ToInt16(leer["Prioridad"]);
                rch_mensaje.Text = "Acceso Exitoso\nBienvenido:" + leer["Usuario"].ToString() + "\nFecha y Hora de acceso:\n";
                rch_mensaje.Text = rch_mensaje.Text + fecha + "\t" + hora + "\n" + "\n";
                rch_mensaje.Text = rch_mensaje.Text + "Nombre(s): " + leer["Nombres"].ToString() + "\n";
                rch_mensaje.Text = rch_mensaje.Text + "Apellidos(s): " + leer["Apellidos"].ToString() + "\n";
                
                    //string p = Users[indice, 4];
                    //imagen(p);
                    imagen(Directory.GetCurrentDirectory() + leer["Ubic_Imagen"].ToString());
                    #region Nivel de acceso
                    string[] acceso = new string[6] { "Datos Personales", "Conexion Dispositivo", "RGB", "Adquisicion Datos", "Motor","Consultas" };
                    for (int i = 0; i <= prioridad; i++)
                    {
                        clb_control.Items.Add(acceso[i]);
                    }
                    clb_control.SetItemChecked(0, true);
                    clb_control.Enabled = false;
                    if (prioridad == 0)
                    {
                        tbp_AccesoNivel0.Enabled = true;
                        tbp_AccesoNivel1.Enabled = false;
                        tbp_AccesoNivel2.Enabled = false;
                        tbp_AccesoNivel3.Enabled = false;
                        tbp_AccesoNivel4.Enabled = false;
                        tbp_AccesoNivel5.Enabled = false;
                    }
                    else if (prioridad == 1)
                    {
                        tbp_AccesoNivel0.Enabled = true;
                        tbp_AccesoNivel1.Enabled = true;
                        tbp_AccesoNivel2.Enabled = false;
                        tbp_AccesoNivel3.Enabled = false;
                        tbp_AccesoNivel4.Enabled = false;
                        tbp_AccesoNivel5.Enabled = false;
                    }
                    else if (prioridad == 2)
                    {
                        tbp_AccesoNivel0.Enabled = true;
                        tbp_AccesoNivel1.Enabled = true;
                        tbp_AccesoNivel2.Enabled = true;
                        tbp_AccesoNivel3.Enabled = false;
                        tbp_AccesoNivel4.Enabled = false;
                        tbp_AccesoNivel5.Enabled = false;
                    }
                    else if (prioridad == 3)
                    {
                        tbp_AccesoNivel0.Enabled = true;
                        tbp_AccesoNivel1.Enabled = true;
                        tbp_AccesoNivel2.Enabled = true;
                        tbp_AccesoNivel3.Enabled = true;
                        tbp_AccesoNivel4.Enabled = false;
                        tbp_AccesoNivel5.Enabled = false;
                    }
                    else if (prioridad == 4)
                    {
                        tbp_AccesoNivel0.Enabled = true;
                        tbp_AccesoNivel1.Enabled = true;
                        tbp_AccesoNivel2.Enabled = true;
                        tbp_AccesoNivel3.Enabled = true;
                        tbp_AccesoNivel4.Enabled = true;
                        tbp_AccesoNivel5.Enabled = true;
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
                    iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\graficas.png"));
                    tcl_control.ImageList = iconsList;
                    tbp_AccesoNivel0.ImageIndex = 0;
                    tbp_AccesoNivel1.ImageIndex = 1;
                    tbp_AccesoNivel2.ImageIndex = 2;
                    tbp_AccesoNivel3.ImageIndex = 3;
                    tbp_AccesoNivel4.ImageIndex = 4;
                    tbp_AccesoNivel5.ImageIndex = 5;
                    #endregion   
            }
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
            ingreso.Show();
            this.Close();
        }

        private void tcl_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcl_control.SelectedIndex > prioridad && tcl_control.SelectedIndex!=5)
            {
                MessageBox.Show("No tiene acceso a estas pestañas");
            }
            if(tcl_control.SelectedIndex<=prioridad)
            {
                clb_control.SetItemChecked(tcl_control.SelectedIndex, true);
            }
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
            string registro_sensores = "Insert Into dbo.Registro_Sensor(Cod_Registro,Sensor1,Sensor2,Sensor3,Sensor4,Sensor5,R,G,B,Motor,Servo) Values(@Cod_Registro,@Sensor1,@Sensor2,@Sensor3,@Sensor4,@Sensor5,@R,@G,@B,@Motor,@Servo)";
            SqlCommand reg_Sensores = new SqlCommand(registro_sensores, conexion);
            reg_Sensores.Parameters.AddWithValue("Cod_Registro", cod_reg);
            reg_Sensores.Parameters.AddWithValue("Sensor1", Convert.ToInt32(cadena[0]));
            reg_Sensores.Parameters.AddWithValue("Sensor2", Convert.ToInt32(cadena[1]));
            reg_Sensores.Parameters.AddWithValue("Sensor3", Convert.ToInt32(cadena[2]));
            reg_Sensores.Parameters.AddWithValue("Sensor4", Convert.ToInt32(cadena[3]));
            reg_Sensores.Parameters.AddWithValue("Sensor5", 0);
            reg_Sensores.Parameters.AddWithValue("R", r);
            reg_Sensores.Parameters.AddWithValue("G", g);
            reg_Sensores.Parameters.AddWithValue("B", b);
            reg_Sensores.Parameters.AddWithValue("Motor", motor);
            reg_Sensores.Parameters.AddWithValue("Servo", servo);
            try 
            {
                reg_Sensores.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
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

        private void btn_ConsultaHora_Click(object sender, EventArgs e)
        {
            if (Arduino.IsOpen)
            {
                Arduino.Close();
                cbx_dispositivo.Enabled = true;
                tmr_dato.Enabled = false;
            }

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select Cod_Registro,Fecha, Hora from dbo.Registro_Hora Where (Cod_Usuario="+ Convert.ToInt32(cbx_Usuarios.SelectedValue)+")", conexion);
            da.Fill(ds, "dbo.Registro_Hora");
            cbx_Horas.DataSource = ds.Tables[0].DefaultView;
            cbx_Horas.ValueMember = "Cod_Registro";
            cbx_Horas.DisplayMember = "Cod_Registro";
            dgv_sensores.Enabled = true;
            tcl_RegistroHoras.Enabled = true;
            DataTable dt = new DataTable();
            string consulta = "Select Cod_Registro,Fecha, Hora From dbo.Registro_Hora where (Cod_Usuario=" + Convert.ToInt32(cbx_Usuarios.SelectedValue) + ")";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            try
            {
                adap.Fill(dt);
                dgv_Registro_Horas.DataSource = dt.DefaultView;
                //dgv_Registro_Horas.dis
            }
            catch (Exception) { }
        }

        private void btn_consultarsensor_Click(object sender, EventArgs e)
        {
            dgv_sensores.Enabled = true;
            DataTable dt = new DataTable();
            string consulta = "Select Sensor1, Sensor2, Sensor3, Sensor4, Sensor5, R, G, B, Motor, Servo From dbo.Registro_Sensor where (Cod_Registro=" + Convert.ToInt32(cbx_Horas.SelectedValue) + ")";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            try
            {
                adap.Fill(dt);
                dgv_sensores.DataSource = dt.DefaultView;
                //dgv_Registro_Horas.dis
            }
            catch (Exception) { }
        }

        private void cbx_Usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string asd = Convert.ToInt32(cbx_Usuarios.SelectedValue);
        }
    }
}
