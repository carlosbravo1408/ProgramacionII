namespace Ejemplo3._3_Variación_
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrt_grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.ttp_ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_ayuda = new System.Windows.Forms.Label();
            this.cbx_3d_gra2 = new System.Windows.Forms.CheckBox();
            this.cbx_3d_gra1 = new System.Windows.Forms.CheckBox();
            this.lbx_sensor3 = new System.Windows.Forms.ListBox();
            this.lbx_sensor2 = new System.Windows.Forms.ListBox();
            this.lbx_sensor1 = new System.Windows.Forms.ListBox();
            this.btn_pausar_seguir = new System.Windows.Forms.Button();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.dud_Puertos = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // chrt_grafico
            // 
            chartArea3.Name = "ChartArea1";
            chartArea4.Name = "ChartArea2";
            this.chrt_grafico.ChartAreas.Add(chartArea3);
            this.chrt_grafico.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            this.chrt_grafico.Legends.Add(legend2);
            this.chrt_grafico.Location = new System.Drawing.Point(12, 42);
            this.chrt_grafico.Name = "chrt_grafico";
            this.chrt_grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Sensor1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Sensor2";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Sensor3";
            series10.ChartArea = "ChartArea2";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series10.IsValueShownAsLabel = true;
            series10.Legend = "Legend1";
            series10.Name = "Sensor 1 Promedio";
            series11.ChartArea = "ChartArea2";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.IsValueShownAsLabel = true;
            series11.Legend = "Legend1";
            series11.Name = "Sensor 2 Promedio";
            series12.ChartArea = "ChartArea2";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series12.IsValueShownAsLabel = true;
            series12.Legend = "Legend1";
            series12.Name = "Sensor 3 Promedio";
            this.chrt_grafico.Series.Add(series7);
            this.chrt_grafico.Series.Add(series8);
            this.chrt_grafico.Series.Add(series9);
            this.chrt_grafico.Series.Add(series10);
            this.chrt_grafico.Series.Add(series11);
            this.chrt_grafico.Series.Add(series12);
            this.chrt_grafico.Size = new System.Drawing.Size(523, 346);
            this.chrt_grafico.TabIndex = 25;
            this.chrt_grafico.Text = "chart1";
            // 
            // Arduino
            // 
            this.Arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Arduino_DataReceived);
            // 
            // lbl_ayuda
            // 
            this.lbl_ayuda.AutoSize = true;
            this.lbl_ayuda.Location = new System.Drawing.Point(9, 390);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(241, 26);
            this.lbl_ayuda.TabIndex = 35;
            this.lbl_ayuda.Text = "Por favor cargue este código \r\n_07_EnvioMultiplesDatos_ConControlDeInicio.ino\r\n";
            // 
            // cbx_3d_gra2
            // 
            this.cbx_3d_gra2.AutoSize = true;
            this.cbx_3d_gra2.Location = new System.Drawing.Point(35, 369);
            this.cbx_3d_gra2.Name = "cbx_3d_gra2";
            this.cbx_3d_gra2.Size = new System.Drawing.Size(66, 17);
            this.cbx_3d_gra2.TabIndex = 34;
            this.cbx_3d_gra2.Text = "Vista 3D";
            this.ttp_ayuda.SetToolTip(this.cbx_3d_gra2, "Vista 3D");
            this.cbx_3d_gra2.UseVisualStyleBackColor = true;
            this.cbx_3d_gra2.CheckedChanged += new System.EventHandler(this.cbx_3d_gra2_CheckedChanged);
            // 
            // cbx_3d_gra1
            // 
            this.cbx_3d_gra1.AutoSize = true;
            this.cbx_3d_gra1.Location = new System.Drawing.Point(35, 203);
            this.cbx_3d_gra1.Name = "cbx_3d_gra1";
            this.cbx_3d_gra1.Size = new System.Drawing.Size(66, 17);
            this.cbx_3d_gra1.TabIndex = 33;
            this.cbx_3d_gra1.Text = "Vista 3D";
            this.ttp_ayuda.SetToolTip(this.cbx_3d_gra1, "Vista 3D");
            this.cbx_3d_gra1.UseVisualStyleBackColor = true;
            this.cbx_3d_gra1.CheckedChanged += new System.EventHandler(this.cbx_3d_gra1_CheckedChanged);
            // 
            // lbx_sensor3
            // 
            this.lbx_sensor3.FormattingEnabled = true;
            this.lbx_sensor3.Location = new System.Drawing.Point(664, 11);
            this.lbx_sensor3.Name = "lbx_sensor3";
            this.lbx_sensor3.Size = new System.Drawing.Size(60, 407);
            this.lbx_sensor3.TabIndex = 31;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor3, "Datos Sensor 3");
            // 
            // lbx_sensor2
            // 
            this.lbx_sensor2.FormattingEnabled = true;
            this.lbx_sensor2.Location = new System.Drawing.Point(601, 11);
            this.lbx_sensor2.Name = "lbx_sensor2";
            this.lbx_sensor2.Size = new System.Drawing.Size(60, 407);
            this.lbx_sensor2.TabIndex = 30;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor2, "Datos Sensor 2");
            // 
            // lbx_sensor1
            // 
            this.lbx_sensor1.FormattingEnabled = true;
            this.lbx_sensor1.Location = new System.Drawing.Point(538, 11);
            this.lbx_sensor1.Name = "lbx_sensor1";
            this.lbx_sensor1.Size = new System.Drawing.Size(60, 407);
            this.lbx_sensor1.TabIndex = 29;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor1, "Datos Sensor 1");
            // 
            // btn_pausar_seguir
            // 
            this.btn_pausar_seguir.Enabled = false;
            this.btn_pausar_seguir.Location = new System.Drawing.Point(219, 11);
            this.btn_pausar_seguir.Name = "btn_pausar_seguir";
            this.btn_pausar_seguir.Size = new System.Drawing.Size(75, 23);
            this.btn_pausar_seguir.TabIndex = 28;
            this.btn_pausar_seguir.Text = "asd.";
            this.btn_pausar_seguir.UseVisualStyleBackColor = true;
            this.btn_pausar_seguir.Click += new System.EventHandler(this.btn_pausar_seguir_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(137, 11);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 27;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // dud_Puertos
            // 
            this.dud_Puertos.Location = new System.Drawing.Point(10, 15);
            this.dud_Puertos.Name = "dud_Puertos";
            this.dud_Puertos.Size = new System.Drawing.Size(120, 20);
            this.dud_Puertos.TabIndex = 26;
            this.ttp_ayuda.SetToolTip(this.dud_Puertos, "Dispositivo");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 427);
            this.Controls.Add(this.lbl_ayuda);
            this.Controls.Add(this.cbx_3d_gra2);
            this.Controls.Add(this.cbx_3d_gra1);
            this.Controls.Add(this.lbx_sensor3);
            this.Controls.Add(this.lbx_sensor2);
            this.Controls.Add(this.lbx_sensor1);
            this.Controls.Add(this.btn_pausar_seguir);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.dud_Puertos);
            this.Controls.Add(this.chrt_grafico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_grafico;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.ToolTip ttp_ayuda;
        private System.Windows.Forms.Label lbl_ayuda;
        private System.Windows.Forms.CheckBox cbx_3d_gra2;
        private System.Windows.Forms.CheckBox cbx_3d_gra1;
        private System.Windows.Forms.ListBox lbx_sensor3;
        private System.Windows.Forms.ListBox lbx_sensor2;
        private System.Windows.Forms.ListBox lbx_sensor1;
        private System.Windows.Forms.Button btn_pausar_seguir;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.DomainUpDown dud_Puertos;

    }
}

