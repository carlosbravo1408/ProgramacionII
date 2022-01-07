using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1._4
{
    public partial class frm_timer : Form
    {
        public frm_timer()
        {
            InitializeComponent();
        }

        int auxiliar = 0, vuelta=0, hora=0, minuto=0, segundo=0, decimas=0;
        string hor, min, seg, dec;
        bool indicador1 = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            grb_vueltas.Visible = true;
            grb_Temporizador.Visible = false;
            lbl_dec_seg.Text = "00";
            lbl_tiempo.Text = "00:00:00";
            lbx_vueltas.Items.Clear();
        }

        private void rdb_cronometro_CheckedChanged(object sender, EventArgs e)
        {
            grb_vueltas.Visible = true;
            grb_Temporizador.Visible = false;
            btn_reiniciar_Click(sender, e);
        }

       private void rdb_temporizador_CheckedChanged(object sender, EventArgs e)
        {
            grb_vueltas.Visible = false;
            grb_Temporizador.Visible = true;
            btn_reiniciar_Click(sender, e);
        }

        private void btn_inicio_pausa_Click(object sender, EventArgs e)
        {
            if (indicador1 == true && rdb_cronometro.Checked == true)
            {
                vuelta++;
                string a = Convert.ToString(vuelta) + "  " + hor + ":" + min + ":" + seg + ":" + dec;
                lbx_vueltas.Items.Add(a);
                lbx_vueltas.SelectedIndex = lbx_vueltas.Items.Count - 1;
            }
            if (indicador1 == false)
            {
                tmr_contador.Enabled = true;
                if (rdb_cronometro.Checked == true)
                {
                    indicador1 = true;
                    btn_inicio_pausa.Text = "Vuelta";
                }
            }
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            btn_inicio_pausa.Text = "Iniciar";
            indicador1 = false;
            vuelta = 0;
            auxiliar = 0;
            tmr_contador.Enabled = false;
            lbx_vueltas.Items.Clear();
            lbl_dec_seg.Text = "00";
            lbl_tiempo.Text = "00:00:00";
            if (rdb_cronometro.Checked==true)
            {
                hora = 0;
                minuto = 0;
                segundo = 0;
                decimas = 0;
            }
            if(rdb_temporizador.Checked==true)
            {
                nud_hora_ValueChanged(sender, e);
                nud_minuto_ValueChanged(sender, e);
                nud_segundo_ValueChanged(sender, e);
                decimas = 0;
            }
        }

        private void nud_hora_ValueChanged(object sender, EventArgs e)
        {
            hora = Convert.ToInt16(nud_hora.Value);
        }

        private void nud_minuto_ValueChanged(object sender, EventArgs e)
        {
            minuto = Convert.ToInt16(nud_minuto.Value);
        }

        private void nud_segundo_ValueChanged(object sender, EventArgs e)
        {
            segundo = Convert.ToInt16(nud_segundo.Value);
        }

        private void tmr_contador_Tick(object sender, EventArgs e)
        {
            #region visualizacion label
            if (hora < 10)
                hor = "0" + Convert.ToString(hora);
            else
                hor = Convert.ToString(hora);
            if (minuto < 10)
                min = "0" + Convert.ToString(minuto);
            else
                min = Convert.ToString(minuto);
            if (segundo < 10)
                seg = "0" + Convert.ToString(segundo);
            else
                seg = Convert.ToString(segundo);
            if (decimas < 10)
                dec = "0" + Convert.ToString(decimas);
            else
                dec = Convert.ToString(decimas);
            lbl_tiempo.Text = hor + ":" + min + ":" + seg;
            lbl_dec_seg.Text = decimas.ToString();
            if (auxiliar % 5 == 0)
            {
                pnl_indicador.BackColor = Color.Blue;
            }
            else
            {
                pnl_indicador.BackColor = Color.Red;
            }
            if (auxiliar == 5)
                auxiliar = 0;
            auxiliar++;
            #endregion
            #region cronómetro
            if (rdb_cronometro.Checked == true)
            {
                decimas++;
                if (decimas >= 10)
                {
                    decimas = 0;
                    segundo++;
                    if(segundo>=60)
                    {
                        segundo = 0;
                        minuto++;
                        if(minuto>=60)
                        {
                            minuto = 0;
                            hora++;
                        }
                    }
                }
            }
            #endregion
            #region temporizador
            if (rdb_temporizador.Checked == true)
            {
                if (decimas <= 0 && segundo <= 0 && minuto <= 0 && hora <= 0)
                {
                    hora = 0; minuto = 0; segundo = 0; decimas = 0;
                    tmr_contador.Enabled = false;
                    MessageBox.Show("Listo");
                }
                decimas--;
                if (decimas <= 0 && (segundo > 0 || minuto > 0 || hora > 0))
                {
                    decimas = 9;
                    segundo--;
                    if (segundo <= 0 && (minuto > 0 || hora > 0))
                    {
                        segundo = 59;
                        minuto--;
                        if (minuto <= 0 && hora > 0)
                        {
                            minuto = 059;
                            hora--;
                            if (hora <= 0)
                                hora = 0;
                        }
                    }
                }
            }
            #endregion
        } 
    }
}
