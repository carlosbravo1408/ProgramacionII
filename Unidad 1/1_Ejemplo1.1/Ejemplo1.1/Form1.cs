using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1._1
{
    public partial class frm_ingreso : Form
    {
        private string User1 = "JuanAvilar123";
        private string Pass1 = "contraseña123";
        private string User2 = "CarlosJavier258";
        private string Pass2 = "asdasd^-^";
        private string User3 = "PepePepito666";
        private string Pass3 = "@nope:p";
        private int i = 0;
        public frm_ingreso()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            {
                string cadena_usuario = txt_usuario.Text;
                string cadena_contraseña = msk_contraseña.Text;
                if ((cadena_usuario == User1 && cadena_contraseña == Pass1) || (cadena_usuario == User2 && cadena_contraseña == Pass2) || (cadena_usuario == User3 && cadena_contraseña == Pass3))
                {
                    i = 0;
                    frm_acceso acceso = new frm_acceso();
                    acceso.Show();
                    this.Hide();
                }
                else
                {
                    i++;
                    if (i == 3)
                        this.Close();
                    MessageBox.Show("Error al ingresar Usuario, o contraseña, por favor ingrese los datos adecuados \nTiene " + Convert.ToString(3 - i) + " intentos.");
                }
            }

        }
    }
}
