using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1._6
{
    public partial class Form1 : Form
    {
        bool sta = false;
        int j = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_area_dibujo.Enabled = false;
            pbx_area_dibujo.Enabled = false;
            grb_area_dibujo.Enabled = false;
        }
        private void btn_graficar_Click(object sender, EventArgs e)
        {
            pnl_area_dibujo.Enabled = true;
            pbx_area_dibujo.Enabled = true;
            grb_area_dibujo.Enabled = true;
            graficas(sta);
        }
        void graficas(bool indi)
        {
            try
            {
                double angulo, modulo, a, b, c;
                angulo = Convert.ToDouble(txt_angulo.Text) * Math.PI / 180;
                modulo = Convert.ToDouble(txt_magnitud.Text);
                a = Convert.ToDouble(txt_a.Text);
                b = Convert.ToDouble(txt_b.Text);
                c = Convert.ToDouble(txt_c.Text);
                //1. creamos el objeto area1 de la clase Graphics
                Graphics area1;
                //2. establecemos nuestra area de trabajo dentro de un control a usar.
                area1 = pnl_area_dibujo.CreateGraphics();
                //hacemos el paso 1 y 2 para las otras 2 areas restantes.
                Graphics area2;
                area2 = pbx_area_dibujo.CreateGraphics();
                Graphics area3;
                area3 = grb_area_dibujo.CreateGraphics();
                //3. Se crea los objetos tipo Pen para la graficacion:
                Pen ejes = new Pen(Color.Red, 1);
                Pen vector = new Pen(Color.Blue, 2);
                Pen curva = new Pen(Color.Green, 2);
                Pen varios = new Pen(Color.Black,4);
                //4. creamos los objetos puntos en un arreglo
                Point origen = new Point(pnl_area_dibujo.Width / 2, pnl_area_dibujo.Height / 2);
                Point punto_vector = new Point(Convert.ToInt32(origen.X + modulo * Math.Cos(angulo) * 25), Convert.ToInt32(pnl_area_dibujo.Height - origen.Y - modulo * Math.Sin(angulo) * 25));
                Point[] funcion = new Point[400];
                for (int i = 0; i < 15; i++)
                {
                    funcion[i] = new Point(origen.X + (i - 7)*25, Convert.ToInt32(origen.Y - (a * Math.Pow((i - 7), 2) + b * ((i - 7)) + c)*25));
                }
                //5. graficamos
                //limpiamos las areas de graficos con color blanco
                area1.Clear(Color.White);
                area2.Clear(Color.White);
                area3.Clear(Color.White);
                //condicional para visualizar subdivicion de los ejes
                if (indi == true)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        area1.DrawLine(ejes,i * 25, 175 - 5, i * 25, 175 + 5);
                        area2.DrawLine(ejes, i * 25, 175 - 5, i * 25, 175 + 5);
                        area1.DrawLine(ejes, 175 - 5, i * 25, 175 + 5, i * 25);
                        area2.DrawLine(ejes, 175 - 5, i * 25, 175 + 5, i * 25);
                    }
                }
                //graficas de los ejes para los 2 areas de gráficas
                area1.DrawLine(ejes, 0, pnl_area_dibujo.Height / 2, pnl_area_dibujo.Height, pnl_area_dibujo.Height / 2);
                area1.DrawLine(ejes, pnl_area_dibujo.Height / 2, 0, pnl_area_dibujo.Height / 2, pnl_area_dibujo.Height);
                area2.DrawLine(ejes, 0, pnl_area_dibujo.Height / 2, pnl_area_dibujo.Height, pnl_area_dibujo.Height / 2);
                area2.DrawLine(ejes, pnl_area_dibujo.Height / 2, 0, pnl_area_dibujo.Height / 2, pnl_area_dibujo.Height);
                //grafica de la recta
                area1.DrawLine(vector, origen, punto_vector);
                //grafica de funcion
                area2.DrawCurve(curva, funcion);
                //graficas varias
                //graficas de poligono
                Point[] poligono = {new Point(10,10),new Point(20,50),new Point(60,100),new Point(100,50),new Point(30,15)};
                area3.DrawPolygon(varios, poligono);
                area3.DrawEllipse(varios, 50, 50, 50, 100);
                area3.DrawRectangle(varios, 10, 100, 300, 200);
            }
            catch (Exception)
            {
                MessageBox.Show("Valor incorrecto, por favor ingrese uno válido");
            }
        }
        private void pnl_area_dibujo_Click(object sender, EventArgs e)
        {
            if (j % 2 == 0)
            {
                sta = true;
            }
            else
                sta = false;
            if (j == 2)
                j = 0;
            j++;
            graficas(sta);
        }
        private void pbx_area_dibujo_Click(object sender, EventArgs e)
        {
            pnl_area_dibujo_Click(sender, e);
        }
        private void pnl_area_dibujo_DoubleClick(object sender, EventArgs e)
        {
            pnl_area_dibujo_Click(sender, e);
        }
        private void pbx_area_dibujo_DoubleClick(object sender, EventArgs e)
        {
            pnl_area_dibujo_Click(sender, e);
        }
        private void pnl_area_dibujo_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto = pnl_area_dibujo.PointToClient(Cursor.Position);
            lbl_posicion.Text = "X: " + Convert.ToString((punto.X-175.0)/25) + " Y: " + Convert.ToString((175.0 - punto.Y)/25);
        }
        private void pbx_area_dibujo_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto = pbx_area_dibujo.PointToClient(Cursor.Position);
            lbl_posicion.Text = "X: " + Convert.ToString((punto.X - 175.0) / 25) + " Y: " + Convert.ToString((175.0 - punto.Y) / 25);
        }
    }
}
