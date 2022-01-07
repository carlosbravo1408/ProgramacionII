using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1._2
{
    public partial class frm_ingreso : Form
    {
        public string cadena_usuario;
        public string cadena_contraseña;
        private int i = 0;
        public frm_ingreso()
        {
            InitializeComponent();
        }

        private void btn_contraseña_Click(object sender, EventArgs e)
        {

            frm_acceso acceso = new frm_acceso();
            cadena_usuario = txt_usuario.Text;
            cadena_contraseña = msk_contraseña.Text;
            int j = 0;
            bool status = false;
            for (j = 0; j < acceso.Users.GetLength(0); j++)
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
            }
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

        }
    }
}
