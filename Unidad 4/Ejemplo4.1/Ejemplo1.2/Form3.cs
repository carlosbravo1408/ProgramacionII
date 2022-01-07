using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//
using System.Data.SqlClient;

namespace Ejemplo1._2
{
    public partial class frm_Usuario_nuevo : Form
    {
        SqlConnection conexion = new SqlConnection();
        frm_ingreso ingreso = new frm_ingreso();
        List<string> Usuario = new List<string>();
        string usuario;
        string contraseña;
        string nombre;
        string apellido;
        int prioridad = 0;
        string ub_imagen = "\\Image\\new_user.jpg";
        
        public frm_Usuario_nuevo()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conexionBaseD();
            string im = Directory.GetCurrentDirectory() + "\\Image\\1.png";
            pcb_usuario.Image = Image.FromFile(im);
            pcb_contraseña1.Image = Image.FromFile(im);
            pcb_contraseña2.Image = Image.FromFile(im);
            pcb_codigo.Image = Image.FromFile(im);
        }
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
        //consulta para ver si existe usuario
        private bool cond(string usuario)
        {
            string consulta1;
            //string que contendrá las instrucciones en SQL para realizar la consulta
            consulta1 = "SELECT count(*) FROM dbo.Usuarios WHERE (Usuario = '" + usuario + "')";
            //Objeto SqlCommand de nombre comando que tiene de parámetros de constructor la consulta (string) y la conexion (string)
            SqlCommand comando = new SqlCommand(consulta1, conexion);
            //la consulta lo que hace es verificar si existe en la tabla usuario, un usuario y su contraseña son iguales a lo que estan en los 
            //textbox, y cuenta cuantos hay de ellos, como se ha hecho que sea único el campo usuario, (evita las redundancias) si encuentra bajo esta
            //condicional algun elemento de la columna, contará siempre 1, sino siempre contará 0
            int j = Convert.ToInt32(comando.ExecuteScalar());
            if (j == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            string cadena_usuario = txt_usuario.Text;
            if(cond(cadena_usuario)==true && cadena_usuario.Length>=5)
            {
                pcb_usuario.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\2.png");
                txt_contraseña1.Enabled = true;
            }
            else if (cadena_usuario.Length==0)
            {
                pcb_usuario.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\1.png");
                txt_contraseña1.Enabled = false;
            }
            else
            {
                pcb_usuario.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\3.png");
                txt_contraseña1.Enabled = false;
            }
        }

        private void txt_contraseña1_TextChanged(object sender, EventArgs e)
        {
            string aux = txt_contraseña1.Text;
            if (aux.Length >= 3)
            {
                txt_contraseña2.Enabled = true;
                pcb_contraseña1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\2.png");
            }
            else
            { 
                txt_contraseña2.Enabled = false;
                pcb_contraseña1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\3.png");
            }
        }

        private void txt_contraseña2_TextChanged(object sender, EventArgs e)
        {
            if(txt_contraseña1.Text == txt_contraseña2.Text)
            {
                pcb_contraseña2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\2.png");
                txt_nombre.Enabled = true;
            }
            else
            {
                pcb_contraseña2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\3.png");
                txt_nombre.Enabled = false;
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Length > 0)
            {
                txt_apellido.Enabled = true;
            }
            else
            {
                txt_apellido.Enabled = false;
            }
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {
            if (txt_apellido.Text.Length > 0)
            {
                txt_cod_prioridad.Enabled = true;
                btn_Crear_Usuario.Enabled = true;
            }
            else
            {
                txt_cod_prioridad.Enabled = false;
                btn_Crear_Usuario.Enabled = false;
            }
        }

        private void txt_cod_prioridad_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_cod_prioridad.Text == "0875")
            {
                prioridad = 1;
                pcb_codigo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\2.png");
            }
            else if (txt_cod_prioridad.Text == "4567")
            {
                prioridad = 2;
                pcb_codigo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\2.png");
            }
            else if (txt_cod_prioridad.Text == "3451")
            {
                prioridad = 3;
                pcb_codigo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\2.png");
            }
            else if (txt_cod_prioridad.Text == "1789")
            {
                prioridad = 4;
                pcb_codigo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\2.png");
            }
            else
            {
                prioridad = 0;
                pcb_codigo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\1.png");
            }
        }

        private void btn_Crear_Usuario_Click(object sender, EventArgs e)
        {
            usuario = txt_usuario.Text;
            contraseña = txt_contraseña2.Text;
            nombre = txt_nombre.Text;
            apellido = txt_apellido.Text;
            string comandoSQL = "INSERT INTO dbo.Usuarios(Usuario, Contraseña, Nombres, Apellidos, Ubic_Imagen, Prioridad) VALUES(@Usuario, @Contraseña, @Nombres, @Apellidos, @Ubic_Imagen, @Prioridad)";
            SqlCommand cmd = new SqlCommand(comandoSQL, conexion);
            cmd.Parameters.AddWithValue("Usuario", usuario);
            cmd.Parameters.AddWithValue("Contraseña", contraseña);
            cmd.Parameters.AddWithValue("Nombres", nombre);
            cmd.Parameters.AddWithValue("Apellidos", apellido);
            cmd.Parameters.AddWithValue("Ubic_Imagen", ub_imagen);
            cmd.Parameters.AddWithValue("Prioridad", prioridad);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Ingresado con Exito...");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se Pudo Ingresar el Registro...");
            }

        }

        private void frm_Usuario_nuevo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ingreso.Show();
        }
    }
}
