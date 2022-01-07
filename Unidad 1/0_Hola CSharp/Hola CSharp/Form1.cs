using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_CSharp
{
    public partial class frm_inicial : Form
    {
        private int i = 0;
        /*Variables globales de la clase*/
        public frm_inicial()
        {
            InitializeComponent();
        }

        private void frm_inicial_Load(object sender, EventArgs e)
        {

        }
        //evento click del boton btn_mensaje
        private void btn_mensaje_Click(object sender, EventArgs e)
        {
            /*Aquí va el código que se ejecutará cada vez que se invoque 
             el método click del boton btn_mensaje*/
            if (i % 2 == 0)
            {
                //cambiamos ciertas propiedades del los controles lbl_mensaje, y btn_mensaje
                lbl_mensaje.Text = "Hola C#";
                btn_mensaje.Text = "^--^";
                // se puede cambiar aspectos físicos de los controles, tipo de fuente, color, etc.
                btn_mensaje.BackColor = Color.Red;
            }
            if (i % 2 == 1)
            {
                lbl_mensaje.Text = "Bienvenido";
                btn_mensaje.Text = "n_n";
                btn_mensaje.BackColor = Color.Blue;
            }
            if (i == 2)
                i = 0;
            i++;
        }
    }
}
