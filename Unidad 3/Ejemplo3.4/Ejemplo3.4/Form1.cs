using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Ejemplo3._4
{
    public partial class Form1 : Form
    {
        string[] puertos;
        int i = 0, j = 0;
        double sum1 = 0, pro1 = 0, sum2 = 0, pro2 = 0, sum3 = 0, pro3 = 0;
        //coleccion de arreglos de datos.
        List<int[]> sensores = new List<int[]>();
        public Form1()
        {
            InitializeComponent();
            lista_puertos();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lista_puertos();
        }
        void lista_puertos()
        {
            puertos = SerialPort.GetPortNames();
            if (puertos.Length > 0)
            {
                dud_Puertos.Items.Clear();
                dud_Puertos.SelectedIndex = -1;
                dud_Puertos.Items.AddRange(puertos);
            }
            else
                MessageBox.Show(this, "No existen puertos disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dud_Puertos.SelectedIndex != -1)
                {
                    Arduino.PortName = dud_Puertos.SelectedItem.ToString();
                    Arduino.BaudRate = 9600;
                }
                else
                    throw new Exception("Seleccione un puerto adecuado");
                if (!Arduino.IsOpen)
                {
                    Arduino.Open();
                    btn_conectar.Enabled = false;
                    dud_Puertos.Enabled = false;
                    btn_pausar_seguir.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible conectar con Arduino");
            }
        }

        private void btn_pausar_seguir_Click(object sender, EventArgs e)
        {
            Arduino.Write("a");
            int num1, num2, num3;
            string[] data = Arduino.ReadLine().Split(',');
            num1 = Convert.ToInt16(data[0]);
            num2 = Convert.ToInt16(data[1]);
            num3 = Convert.ToInt16(data[2]);
            //almacenamos en un arreglo todos los valores obtenidos de la lectura Serial
            int[] aux = {num1,num2,num3};
            //ingresa a la coleccion el objeto de tipo int[3]
            sensores.Add(aux);
            /*
             * note aquí que el primer valor entre corchetes [] es para localizar el objeto en el 
             * indice establecido, y el segundo valor entre corchetes [] es para localizar el valor
             * entero dentro del objeto.
             */
            lbx_sensor1.Items.Add(sensores[i][0]);
            lbx_sensor2.Items.Add(sensores[i][1]);
            lbx_sensor3.Items.Add(sensores[i][2]);
            lbx_sensor1.SelectedIndex = i;
            lbx_sensor2.SelectedIndex = i;
            lbx_sensor3.SelectedIndex = i;
            sum1 = Convert.ToDouble(sensores[i][0]) + sum1;
            sum2 = Convert.ToDouble(sensores[i][1]) + sum2;
            sum3 = Convert.ToDouble(sensores[i][2]) + sum3;
            if (i > 0)
            {
                pro1 = sum1 / sensores.Count;
                pro2 = sum2 / sensores.Count;
                pro3 = sum3 / sensores.Count;
            }
            else
            {
                pro1 = 0;
                pro2 = 0;
                pro3 = 0;
            }
            if (chrt_grafico.Series[5].Points.Count >= 1)
            {
                chrt_grafico.Series[3].Points.Clear();
                chrt_grafico.Series[4].Points.Clear();
                chrt_grafico.Series[5].Points.Clear();
            }
            if (chrt_grafico.Series[0].Points.Count >= 10)
            {
                chrt_grafico.Series[0].Points.RemoveAt(0);
                chrt_grafico.Series[1].Points.RemoveAt(0);
                chrt_grafico.Series[2].Points.RemoveAt(0);
            }
            chrt_grafico.Series[0].Points.AddXY(i, num1);
            chrt_grafico.Series[1].Points.AddXY(i, num2);
            chrt_grafico.Series[2].Points.AddXY(i, num3);
            chrt_grafico.Series[3].Points.Add(pro1);
            chrt_grafico.Series[4].Points.Add(pro2);
            chrt_grafico.Series[5].Points.Add(pro3);
            chrt_grafico.Update();
            i++;
        }

        private void cbx_3d_gra1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_3d_gra1.Checked == true)
                chrt_grafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            else
                chrt_grafico.ChartAreas[0].Area3DStyle.Enable3D = false;
        }

        private void cbx_3d_gra2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_3d_gra2.Checked == true)
                chrt_grafico.ChartAreas[1].Area3DStyle.Enable3D = true;
            else
                chrt_grafico.ChartAreas[1].Area3DStyle.Enable3D = false;
        }
    }
}
