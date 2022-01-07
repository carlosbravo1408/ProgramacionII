using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1._5
{
    public partial class Form1 : Form
    {
        Random numero = new Random();
        int t = 0,i=0;
        bool st;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tss_lbl_Velocidad.ForeColor = Color.Red;
            tss_lbl_Velocidad.Text = "Desconectado";
            tmr_intervalo.Enabled = false;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            nud_intervalo_ValueChanged(sender, e);
            if (i % 2 == 0)
            {
                tmr_intervalo.Enabled = true;
                btn_generar.Text = "Pausar";
                tss_lbl_Velocidad.ForeColor = Color.Blue;
                tss_lbl_Velocidad.Text = "Conectado";
            }
            else 
            {
                tmr_intervalo.Enabled = false;
                btn_generar.Text = "Iniciar";
                tss_lbl_Velocidad.ForeColor = Color.Red;
                tss_lbl_Velocidad.Text = "Desconectado";
            }
            i++;
            if(i==2)
                i=0;
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            i = 1;
            t = 0;
            st = false;
            btn_generar_Click(sender, e);
            chrt_grafico_circular.Series[0].Points.Clear();
            chrt_grafica_barra.Series[0].Points.Clear();
            chrt_grafica_barra.Series[1].Points.Clear();
            chrt_grafica_barra.Series[2].Points.Clear();
        }

        private void nud_intervalo_ValueChanged(object sender, EventArgs e)
        {
            tmr_intervalo.Interval = Convert.ToInt16(nud_intervalo.Value); 
        }

        private void nud_maximo_ValueChanged(object sender, EventArgs e)
        {
        }

        private void tmr_intervalo_Tick(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1=numero.Next(0, Convert.ToInt16(nud_maximo.Value));
            num2=numero.Next(0, Convert.ToInt16(nud_maximo.Value));
            num3=numero.Next(0, Convert.ToInt16(nud_maximo.Value));
            chrt_grafica_barra.Series[0].Points.Add(num1);
            chrt_grafica_barra.Series[1].Points.Add(num2);
            chrt_grafica_barra.Series[2].Points.Add(num3);
            chrt_grafica_barra.Update();
            if(chrt_grafico_circular.Series[0].Points.Count()>=3)
            {
                chrt_grafico_circular.Series[0].Points.Clear();
            }
            chrt_grafico_circular.Series[0].Points.Add(num1);
            chrt_grafico_circular.Series[0].Points.Add(num2);
            chrt_grafico_circular.Series[0].Points.Add(num3);
            chrt_grafico_circular.Update();
            tss_prb_intermitencia.Value = t;
            if (st == false)
            {
                t++;
                if (t >= 100)
                {
                    t = 100;
                    st = true;
                }
            }
            if (st == true)
            {
                t--;
                if (t <= 0)
                {
                    t = 10;
                    st = false;
                }
            }
        }
    }
}
