namespace Ejemplo3._3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dud_Puertos = new System.Windows.Forms.DomainUpDown();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.btn_pausar_seguir = new System.Windows.Forms.Button();
            this.lbx_sensor1 = new System.Windows.Forms.ListBox();
            this.lbx_sensor2 = new System.Windows.Forms.ListBox();
            this.lbx_sensor3 = new System.Windows.Forms.ListBox();
            this.cbx_3d_gra2 = new System.Windows.Forms.CheckBox();
            this.cbx_3d_gra1 = new System.Windows.Forms.CheckBox();
            this.chrt_grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ttp_ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_ayuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // dud_Puertos
            // 
            this.dud_Puertos.Location = new System.Drawing.Point(13, 13);
            this.dud_Puertos.Name = "dud_Puertos";
            this.dud_Puertos.Size = new System.Drawing.Size(120, 20);
            this.dud_Puertos.TabIndex = 0;
            this.ttp_ayuda.SetToolTip(this.dud_Puertos, "Dispositivo");
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(140, 9);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 1;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // Arduino
            // 
            this.Arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Arduino_DataReceived);
            // 
            // btn_pausar_seguir
            // 
            this.btn_pausar_seguir.Enabled = false;
            this.btn_pausar_seguir.Location = new System.Drawing.Point(222, 9);
            this.btn_pausar_seguir.Name = "btn_pausar_seguir";
            this.btn_pausar_seguir.Size = new System.Drawing.Size(75, 23);
            this.btn_pausar_seguir.TabIndex = 3;
            this.btn_pausar_seguir.Text = "asd.";
            this.btn_pausar_seguir.UseVisualStyleBackColor = true;
            this.btn_pausar_seguir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbx_sensor1
            // 
            this.lbx_sensor1.FormattingEnabled = true;
            this.lbx_sensor1.Location = new System.Drawing.Point(541, 9);
            this.lbx_sensor1.Name = "lbx_sensor1";
            this.lbx_sensor1.Size = new System.Drawing.Size(60, 407);
            this.lbx_sensor1.TabIndex = 4;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor1, "Datos Sensor 1");
            this.lbx_sensor1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbx_sensor2
            // 
            this.lbx_sensor2.FormattingEnabled = true;
            this.lbx_sensor2.Location = new System.Drawing.Point(604, 9);
            this.lbx_sensor2.Name = "lbx_sensor2";
            this.lbx_sensor2.Size = new System.Drawing.Size(60, 407);
            this.lbx_sensor2.TabIndex = 5;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor2, "Datos Sensor 2");
            // 
            // lbx_sensor3
            // 
            this.lbx_sensor3.FormattingEnabled = true;
            this.lbx_sensor3.Location = new System.Drawing.Point(667, 9);
            this.lbx_sensor3.Name = "lbx_sensor3";
            this.lbx_sensor3.Size = new System.Drawing.Size(60, 407);
            this.lbx_sensor3.TabIndex = 6;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor3, "Datos Sensor 3");
            // 
            // cbx_3d_gra2
            // 
            this.cbx_3d_gra2.AutoSize = true;
            this.cbx_3d_gra2.Location = new System.Drawing.Point(38, 367);
            this.cbx_3d_gra2.Name = "cbx_3d_gra2";
            this.cbx_3d_gra2.Size = new System.Drawing.Size(66, 17);
            this.cbx_3d_gra2.TabIndex = 9;
            this.cbx_3d_gra2.Text = "Vista 3D";
            this.ttp_ayuda.SetToolTip(this.cbx_3d_gra2, "Vista 3D");
            this.cbx_3d_gra2.UseVisualStyleBackColor = true;
            this.cbx_3d_gra2.CheckedChanged += new System.EventHandler(this.cbx_3d_gra2_CheckedChanged);
            // 
            // cbx_3d_gra1
            // 
            this.cbx_3d_gra1.AutoSize = true;
            this.cbx_3d_gra1.Location = new System.Drawing.Point(38, 201);
            this.cbx_3d_gra1.Name = "cbx_3d_gra1";
            this.cbx_3d_gra1.Size = new System.Drawing.Size(66, 17);
            this.cbx_3d_gra1.TabIndex = 8;
            this.cbx_3d_gra1.Text = "Vista 3D";
            this.ttp_ayuda.SetToolTip(this.cbx_3d_gra1, "Vista 3D");
            this.cbx_3d_gra1.UseVisualStyleBackColor = true;
            this.cbx_3d_gra1.CheckedChanged += new System.EventHandler(this.cbx_3d_gra1_CheckedChanged);
            // 
            // chrt_grafico
            // 
            chartArea1.Name = "Variacion";
            chartArea2.Name = "Promedio";
            this.chrt_grafico.ChartAreas.Add(chartArea1);
            this.chrt_grafico.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend3";
            this.chrt_grafico.Legends.Add(legend1);
            this.chrt_grafico.Location = new System.Drawing.Point(12, 42);
            this.chrt_grafico.Name = "chrt_grafico";
            this.chrt_grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "Variacion";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend3";
            series1.Name = "Sensor1";
            series2.ChartArea = "Variacion";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend3";
            series2.Name = "Sensor2";
            series3.ChartArea = "Variacion";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend3";
            series3.Name = "Sensor3";
            series4.ChartArea = "Promedio";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend3";
            series4.Name = "Sensor1media";
            series4.YValuesPerPoint = 6;
            series5.ChartArea = "Promedio";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend3";
            series5.Name = "Sensor2media";
            series6.ChartArea = "Promedio";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend3";
            series6.Name = "Sensor3media";
            this.chrt_grafico.Series.Add(series1);
            this.chrt_grafico.Series.Add(series2);
            this.chrt_grafico.Series.Add(series3);
            this.chrt_grafico.Series.Add(series4);
            this.chrt_grafico.Series.Add(series5);
            this.chrt_grafico.Series.Add(series6);
            this.chrt_grafico.Size = new System.Drawing.Size(523, 346);
            this.chrt_grafico.SuppressExceptions = true;
            this.chrt_grafico.TabIndex = 7;
            this.chrt_grafico.Text = "chart1";
            // 
            // lbl_ayuda
            // 
            this.lbl_ayuda.AutoSize = true;
            this.lbl_ayuda.Location = new System.Drawing.Point(12, 388);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(147, 26);
            this.lbl_ayuda.TabIndex = 15;
            this.lbl_ayuda.Text = "Por favor cargue este código \r\n_02_EnvioMultiplesDatos.ino\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 427);
            this.Controls.Add(this.lbl_ayuda);
            this.Controls.Add(this.cbx_3d_gra2);
            this.Controls.Add(this.cbx_3d_gra1);
            this.Controls.Add(this.chrt_grafico);
            this.Controls.Add(this.lbx_sensor3);
            this.Controls.Add(this.lbx_sensor2);
            this.Controls.Add(this.lbx_sensor1);
            this.Controls.Add(this.btn_pausar_seguir);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.dud_Puertos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ttp_ayuda.SetToolTip(this, "Cargar al Arduino el programa \r\n_02_EnvioMultiplesDatos.ino");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dud_Puertos;
        private System.Windows.Forms.Button btn_conectar;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.Button btn_pausar_seguir;
        private System.Windows.Forms.ListBox lbx_sensor1;
        private System.Windows.Forms.ListBox lbx_sensor2;
        private System.Windows.Forms.ListBox lbx_sensor3;
        private System.Windows.Forms.CheckBox cbx_3d_gra2;
        private System.Windows.Forms.CheckBox cbx_3d_gra1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_grafico;
        private System.Windows.Forms.ToolTip ttp_ayuda;
        private System.Windows.Forms.Label lbl_ayuda;
    }
}

