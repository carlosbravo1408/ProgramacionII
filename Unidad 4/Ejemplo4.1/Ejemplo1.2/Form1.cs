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
//espacios de nombres usados para la comunicacion de la base de datos
using System.Configuration;
using System.Data.SqlClient;

namespace Ejemplo1._2
{
    public partial class frm_ingreso : Form
    {
        public string cadena_usuario;
        public string cadena_contraseña;
        //variable que almacenará la clave principal del usuario ingresado
        public static int cod_usuario;
        private int i = 0;
        SqlConnection conexion = new SqlConnection();
        public static string con1;
        public frm_ingreso()
        {
            InitializeComponent();
            
        }
        private void conexionBaseD()
        {
            try
            {
                //CADENA DE CONEXIÓN
                //Data Source=Servidor_PC; Initial Catalog = Nombre_Base de datos; Integrated Security=true
                conexion.ConnectionString = @"Data Source=AS-PC\WINCC;Initial Catalog=Base_prueba;Integrated Security=true";
                conexion.Open();
            }
            catch
            {
                MessageBox.Show("No se ha conectado a Base de Datos", "Conexión Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_contraseña_Click(object sender, EventArgs e)
        {

            frm_acceso acceso = new frm_acceso();
            cadena_usuario = txt_usuario.Text;
            cadena_contraseña = msk_contraseña.Text;
            int j = 0;
            bool status = false;
            string consulta1;
            string consulta2;
            try
            {
                //comando.Parameters.AddWithValue("Usiario", j);

                //string que contendrá las instrucciones en SQL para realizar la consulta
                consulta1 = "SELECT count(*) FROM dbo.Usuarios WHERE (Usuario = '" + cadena_usuario + "') AND (Contraseña = '" + cadena_contraseña + "')";
                consulta2 = "Select Cod_Usuario From dbo.Usuarios WHERE (Usuario = '" + cadena_usuario + "') AND (Contraseña = '" + cadena_contraseña + "')";
                //Objeto SqlCommand de nombre comando que tiene de parámetros de constructor la consulta (string) y la conexion (string)
                SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                SqlCommand comando2 = new SqlCommand(consulta2, conexion);
                cod_usuario = Convert.ToInt16(comando2.ExecuteScalar());
                //la consulta lo que hace es verificar si existe en la tabla usuario, un usuario y su contraseña son iguales a lo que estan en los 
                //textbox, y cuenta cuantos hay de ellos, como se ha hecho que sea único el campo usuario, (evita las redundancias) si encuentra bajo esta
                //condicional algun elemento de la columna, contará siempre 1, sino siempre contará 0
                j = Convert.ToInt32(comando1.ExecuteScalar());
                if (j == 0)
                    status = false;
                else
                {
                    status = true;
                    MessageBox.Show(this.AcceptButton + "Acceso Exitoso\nBienvenido ");
                    acceso.Show();
                    this.Hide();
                }
            }
            catch (Exception ex) { }
            /*for (j = 0; j < acceso.Users.GetLength(0); j++)
            {
                if (cadena_usuario == acceso.Users[j, 0] && cadena_contraseña == acceso.Users[j, 1])
                {
                    i = 0;
                    acceso.cadena_usuario = cadena_usuario;
                    acceso.indice = j;
                    status = true;
                    MessageBox.Show(this.AcceptButton + "Acceso Exitoso\nBienvenido ");
                    acceso.Show();
                    this.Hide();
                }
            }*/
            if (status == false)
            {
                i++;
                if (i == 3)
                {
                    this.Close();
                    acceso.Close();
                }
                MessageBox.Show("Error al ingresar Usuario, o contraseña, por favor ingrese los datos adecuados \nTiene " + Convert.ToString(3 - i) + " intentos.");
                msk_contraseña.Text = "";
            }
        }

        private void chx_verPass_CheckedChanged(object sender, EventArgs e)
        {

            if (chx_verPass.Checked == true)
            {
                msk_contraseña.PasswordChar = '\0';
            }
            else
            {
                msk_contraseña.PasswordChar = '*';
            }
        }

        private void msk_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                btn_contraseña_Click(sender, e);
            }
        }

        private void frm_ingreso_Load(object sender, EventArgs e)
        {
            conexionBaseD();
        }

        private void btn_nuevo_usuario_Click(object sender, EventArgs e)
        {
            frm_Usuario_nuevo nuevo = new frm_Usuario_nuevo();
            this.Hide();
            nuevo.Show();
        }
    }
}
