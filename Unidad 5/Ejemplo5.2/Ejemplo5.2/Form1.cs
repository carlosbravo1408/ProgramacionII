using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//espacios de nombres usados
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Math.Geometry;
using AForge.Math;


namespace Ejemplo5._2
{
    public partial class Form1 : Form
    {
        //objetos necesarios para la adquisicion de video
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] videoCapabilities;
        bool condr = false;
        bool condg = false;
        bool condb = false;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //llenado de ComboBox con las cámaras disponibles en el sistema
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count != 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    cbx_camaras.Items.Add(device.Name);
                }
            }
            else
            {
                cbx_camaras.Items.Add("No DirectShow devices found");
            }
        }
        //método para llenar ComboBox con las Resoluciones válidas según la cámara seleccionada
        private void EnumeratedSupportedFrameSizes(VideoCaptureDevice videoDevice)
        {
            this.Cursor = Cursors.WaitCursor;

            cbx_resolucion.Items.Clear();

            try
            {
                videoCapabilities = videoDevice.VideoCapabilities;
                foreach (VideoCapabilities capabilty in videoCapabilities)
                {
                    cbx_resolucion.Items.Add(string.Format("{0} x {1}",
                        capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }

                if (videoCapabilities.Length == 0)
                {
                    cbx_resolucion.Items.Add("Not supported");
                }
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void cbx_camaras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                videoDevice = new VideoCaptureDevice(videoDevices[cbx_camaras.SelectedIndex].MonikerString);
                EnumeratedSupportedFrameSizes(videoDevice);
            }
        }
        private void btn_camara_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoDevice.VideoResolution = videoCapabilities[cbx_resolucion.SelectedIndex];
                }
                videoSourceCaptura.VideoSource = videoDevice;
                videoSourceCaptura.Start();

                videoDevice.NewFrame += new NewFrameEventHandler(get_Frame);
                videoDevice.Start();
            }
        }
        private void get_Frame(object sender, NewFrameEventArgs eventArgs)
        {
            //Insertar imagen al Panel, y al VideoSourcePlayer
            Bitmap _BsourceFrame = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imageR = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imageG = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imageB = (Bitmap)eventArgs.Frame.Clone();

            Bitmap imagenR = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imagenG = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imagenB = (Bitmap)eventArgs.Frame.Clone();

            EuclideanColorFiltering filterR = new EuclideanColorFiltering();
            EuclideanColorFiltering filterG = new EuclideanColorFiltering();
            EuclideanColorFiltering filterB = new EuclideanColorFiltering();

            //EuclideanColorFiltering filternR = new EuclideanColorFiltering();
            //EuclideanColorFiltering filternG = new EuclideanColorFiltering();
            //EuclideanColorFiltering filternB = new EuclideanColorFiltering();

            filterR.CenterColor = new RGB(Color.FromArgb((int)nudRr.Value, (int)nudRg.Value, (int)nudRb.Value));
            filterR.Radius = 100;
            filterR.ApplyInPlace(imagenR);
            filterR.ApplyInPlace(imageR);
            videoSourceR.Image = imagenR;

            //filternR.CenterColor = new RGB(Color.FromArgb(215, 0, 0));
            //filternR.Radius = 100;
            //filternR.ApplyInPlace(imageR);

            filterG.CenterColor = new RGB(Color.FromArgb((int)nudGr.Value, (int)nudGg.Value, (int)nudGb.Value));
            filterG.Radius = 100;
            filterG.ApplyInPlace(imagenG);
            filterG.ApplyInPlace(imageG);
            videoSourceG.Image = imagenG;

            //filternG.CenterColor = new RGB(Color.FromArgb(0, 215, 0));
            //filternG.Radius = 100;
            //filternG.ApplyInPlace(imageG);

            filterB.CenterColor = new RGB(Color.FromArgb((int)nudBr.Value, (int)nudBg.Value, (int)nudBb.Value));
            filterB.Radius = 100;
            filterB.ApplyInPlace(imagenB);
            filterB.ApplyInPlace(imageB);
            videoSourceB.Image = imagenB;

            //filternB.CenterColor = new RGB(Color.FromArgb(30, 144, 255));
            //filternB.Radius = 100;
            //filternB.ApplyInPlace(imageB);

            try
            {
                ImageStatistics statR = new ImageStatistics(imageR);
                Histogram red = statR.Red;

                ImageStatistics statG = new ImageStatistics(imageG);
                Histogram green = statG.Green;

                ImageStatistics statB = new ImageStatistics(imageB);
                Histogram blue = statB.Green;

                label4.Text = red.Max.ToString();
                label5.Text = blue.Max.ToString();
                label6.Text = green.Max.ToString();

                if (red.Max > 185)
                    label1.Text = "Red";
                else
                    label1.Text = "black";

                if (green.Max > 170)
                    label2.Text = "Green";
                else
                    label2.Text = "black";

                if (blue.Max > 90)
                    label3.Text = "Blue";
                else
                    label3.Text = "black";
            }
            catch (Exception ex)
            { }
        }
        private void videoSourceR_DoubleClick(object sender, EventArgs e)
        {
            if (condr == false)
            {
                groupBox5.Enabled = true;
                condr = true;
            }
            else
            {
                condr = false;
                groupBox5.Enabled = false;
            }
        }
        private void videoSourceG_DoubleClick(object sender, EventArgs e)
        {
            if (condg == false)
            {
                groupBox6.Enabled = true;
                condg = true;
            }
            else
            {
                condg = false;
                groupBox6.Enabled = false;
            }
        }
        private void videoSourceB_DoubleClick(object sender, EventArgs e)
        {
            if (condb == false)
            {
                groupBox7.Enabled = true;
                condb = true;
            }
            else
            {
                condb = false;
                groupBox7.Enabled = false;
            }
        }
    }
}
