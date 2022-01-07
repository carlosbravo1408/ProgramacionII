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
    public partial class frm_acceso : Form
    {
        private string mensaje;
        public frm_acceso()
        {
            InitializeComponent();
        }

        private void frm_acceso_Load(object sender, EventArgs e)
        {
            rch_mensaje.Text = "Acceso Exitoso\nFecha y Hora de acceso:\t";
            rch_mensaje.Text = rch_mensaje.Text + Convert.ToString(DateTime.Now.ToShortDateString()) + "\t" + Convert.ToString(DateTime.Now.ToShortTimeString() + "\n");
            mensaje = rch_mensaje.Text;
        }

        private void frm_acceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_ingreso ingreso = new frm_ingreso();
            ingreso.Show();

        }

        private void txt_ingreso_TextChanged(object sender, EventArgs e)
        {
            rch_mensaje.Text = mensaje + txt_ingreso.Text;
        }
    }
}
