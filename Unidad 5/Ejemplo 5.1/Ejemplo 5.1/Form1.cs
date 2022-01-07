using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//espacios de nombres usados 
using AForge.Controls;

namespace Ejemplo_5._1
{
    public partial class Form1 : Form
    {
        List<Joystick.DeviceInfo> devices = Joystick.GetAvailableDevices();
        Joystick joystick;

        public Form1()
        {
            InitializeComponent();
        }
        private void joystick_disponible()
        {
            if (devices.Count > 0)
            {
                foreach (Joystick.DeviceInfo di in devices)
                {
                    cbx_Joystick.Items.Clear();
                    cbx_Joystick.Items.Add(string.Format("{0} : {1} ({2} axes, {3} buttons)",di.ID, di.Name, di.Axes, di.Buttons));
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1} ({2} axes, {3} buttons)",di.ID, di.Name, di.Axes, di.Buttons));
                }
            }
            else
            {
                MessageBox.Show(this, "Lo sentimos, no hubo Joysticks disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_Joystick_SelectedIndexChanged(object sender, EventArgs e)
        {
            joystick = new Joystick(cbx_Joystick.SelectedIndex);
            cbx_Joystick.Enabled = false;
            tmr_joy.Enabled = true;
        }

        private void tmr_joy_Tick(object sender, EventArgs e)
        {
            Joystick.Status status = joystick.GetCurrentStatus();
            if (status.IsButtonPressed(Joystick.Buttons.Button1))
                lblBoton1.ForeColor = Color.Blue;
            else
                lblBoton1.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button2))
                lblBoton2.ForeColor = Color.Blue;
            else
                lblBoton2.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button3))
                lblBoton3.ForeColor = Color.Blue;
            else
                lblBoton3.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button4))
                lblBoton4.ForeColor = Color.Blue;
            else
                lblBoton4.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button5))
                lblBoton5.ForeColor = Color.Blue;
            else
                lblBoton5.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button6))
                lblBoton6.ForeColor = Color.Blue;
            else
                lblBoton6.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button7))
                lblBoton7.ForeColor = Color.Blue;
            else
                lblBoton7.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button8))
                lblBoton8.ForeColor = Color.Blue;
            else
                lblBoton8.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button9))
                lblBoton9.ForeColor = Color.Blue;
            else
                lblBoton9.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button10))
                lblBoton10.ForeColor = Color.Blue;
            else
                lblBoton10.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button11))
                lblBoton11.ForeColor = Color.Blue;
            else
                lblBoton11.ForeColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button12))
                lblBoton12.ForeColor = Color.Blue;
            else
                lblBoton12.ForeColor = Color.Red;
            
            if (status.XAxis > 0)
                lbl_x.ForeColor = Color.Blue;
            else
                lbl_x.ForeColor = Color.Red;
            if (status.YAxis > 0)
                lbl_y.ForeColor = Color.Blue;
            else
                lbl_y.ForeColor = Color.Red;
            if (status.ZAxis > 0)
                lbl_z.ForeColor = Color.Blue;
            else
                lbl_z.ForeColor = Color.Red;
            if (status.RAxis > 0)
                lbl_r.ForeColor = Color.Blue;
            else
                lbl_r.ForeColor = Color.Red;

            if (status.PointOfView >= 0)
                lbl_point_view.ForeColor = Color.Blue;
            else
                lbl_point_view.ForeColor = Color.Red;

            lbl_x.Text = "x: "+status.XAxis.ToString();
            lbl_y.Text = "y: "+status.YAxis.ToString();
            lbl_z.Text = "z: "+status.ZAxis.ToString();
            lbl_r.Text = "r: "+status.RAxis.ToString();

            lbl_point_view.Text = "PointOfView: " + status.PointOfView.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            joystick_disponible();
        }

        private void cbx_Joystick_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbx_Joystick_SelectedIndexChanged(sender, e);
        }
    }
}
