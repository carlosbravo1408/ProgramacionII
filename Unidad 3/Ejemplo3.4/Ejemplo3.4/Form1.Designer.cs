namespace Ejemplo3._4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chrt_grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ayuda
            // 
            this.lbl_ayuda.AutoSize = true;
            this.lbl_ayuda.Location = new System.Drawing.Point(9, 389);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(285, 26);
            this.lbl_ayuda.TabIndex = 45;
            this.lbl_ayuda.Text = "Por favor cargue este código \r\n_08_EnvioMultiplesDatos_ConControlDeEnvioDeDatos.i" +
    "no\r\n";
            // 
            // cbx_3d_gra2
            // 
            this.cbx_3d_gra2.AutoSize = true;
            this.cbx_3d_gra2.Location = new System.Drawing.Point(35, 368);
            this.cbx_3d_gra2.Name = "cbx_3d_gra2";
            this.cbx_3d_gra2.Size = new System.Drawing.Size(66, 17);
            this.cbx_3d_gra2.TabIndex = 44;
            this.cbx_3d_gra2.Text = "Vista 3D";
            this.ttp_ayuda.SetToolTip(this.cbx_3d_gra2, "Vista 3D");
            this.cbx_3d_gra2.UseVisualStyleBackColor = true;
            this.cbx_3d_gra2.CheckedChanged += new System.EventHandler(this.cbx_3d_gra2_CheckedChanged);
            // 
            // cbx_3d_gra1
            // 
            this.cbx_3d_gra1.AutoSize = true;
            this.cbx_3d_gra1.Location = new System.Drawing.Point(35, 202);
            this.cbx_3d_gra1.Name = "cbx_3d_gra1";
            this.cbx_3d_gra1.Size = new System.Drawing.Size(66, 17);
            this.cbx_3d_gra1.TabIndex = 43;
            this.cbx_3d_gra1.Text = "Vista 3D";
            this.ttp_ayuda.SetToolTip(this.cbx_3d_gra1, "Vista 3D");
            this.cbx_3d_gra1.UseVisualStyleBackColor = true;
            this.cbx_3d_gra1.CheckedChanged += new System.EventHandler(this.cbx_3d_gra1_CheckedChanged);
            // 
            // lbx_sensor3
            // 
            this.lbx_sensor3.FormattingEnabled = true;
            this.lbx_sensor3.Location = new System.Drawing.Point(664, 10);
            this.lbx_sensor3.Name = "lbx_sensor3";
            this.lbx_sensor3.Size = new System.Drawing.Size(60, 407);
            this.lbx_sensor3.TabIndex = 42;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor3, "Datos Sensor 3");
            // 
            // lbx_sensor2
            // 
            this.lbx_sensor2.FormattingEnabled = true;
            this.lbx_sensor2.Location = new System.Drawing.Point(601, 10);
            this.lbx_sensor2.Name = "lbx_sensor2";
            this.lbx_sensor2.Size = new System.Drawing.Size(60, 407);
            this.lbx_sensor2.TabIndex = 41;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor2, "Datos Sensor 2");
            // 
            // lbx_sensor1
            // 
            this.lbx_sensor1.FormattingEnabled = true;
            this.lbx_sensor1.Location = new System.Drawing.Point(538, 10);
            this.lbx_sensor1.Name = "lbx_sensor1";
            this.lbx_sensor1.Size = new System.Drawing.Size(60, 407);
            this.lbx_sensor1.TabIndex = 40;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor1, "Datos Sensor 1");
            // 
            // btn_pausar_seguir
            // 
            this.btn_pausar_seguir.Enabled = false;
            this.btn_pausar_seguir.Location = new System.Drawing.Point(219, 10);
            this.btn_pausar_seguir.Name = "btn_pausar_seguir";
            this.btn_pausar_seguir.Size = new System.Drawing.Size(77, 23);
            this.btn_pausar_seguir.TabIndex = 39;
            this.btn_pausar_seguir.Text = "Adquirir Dato";
            this.ttp_ayuda.SetToolTip(this.btn_pausar_seguir, "Por cada click se tomará los datos de los sensores");
            this.btn_pausar_seguir.UseVisualStyleBackColor = true;
            this.btn_pausar_seguir.Click += new System.EventHandler(this.btn_pausar_seguir_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(137, 10);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 38;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // dud_Puertos
            // 
            this.dud_Puertos.Location = new System.Drawing.Point(10, 14);
            this.dud_Puertos.Name = "dud_Puertos";
            this.dud_Puertos.Size = new System.Drawing.Size(120, 20);
            this.dud_Puertos.TabIndex = 37;
            this.ttp_ayuda.SetToolTip(this.dud_Puertos, "Dispositivo");
            // 
            // chrt_grafico
            // 
            chartArea15.Name = "ChartArea1";
            chartArea16.Name = "ChartArea2";
            this.chrt_grafico.ChartAreas.Add(chartArea15);
            this.chrt_grafico.ChartAreas.Add(chartArea16);
            legend8.Name = "Legend1";
            this.chrt_grafico.Legends.Add(legend8);
            this.chrt_grafico.Location = new System.Drawing.Point(12, 41);
            this.chrt_grafico.Name = "chrt_grafico";
            this.chrt_grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series43.Legend = "Legend1";
            series43.Name = "Sensor1";
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series44.Legend = "Legend1";
            series44.Name = "Sensor2";
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series45.Legend = "Legend1";
            series45.Name = "Sensor3";
            series46.ChartArea = "ChartArea2";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series46.IsValueShownAsLabel = true;
            series46.Legend = "Legend1";
            series46.Name = "Sensor 1 Promedio";
            series47.ChartArea = "ChartArea2";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series47.IsValueShownAsLabel = true;
            series47.Legend = "Legend1";
            series47.Name = "Sensor 2 Promedio";
            series48.ChartArea = "ChartArea2";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series48.IsValueShownAsLabel = true;
            series48.Legend = "Legend1";
            series48.Name = "Sensor 3 Promedio";
            this.chrt_grafico.Series.Add(series43);
            this.chrt_grafico.Series.Add(series44);
            this.chrt_grafico.Series.Add(series45);
            this.chrt_grafico.Series.Add(series46);
            this.chrt_grafico.Series.Add(series47);
            this.chrt_grafico.Series.Add(series48);
            this.chrt_grafico.Size = new System.Drawing.Size(523, 346);
            this.chrt_grafico.TabIndex = 36;
            this.chrt_grafico.Text = "chart1";
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_grafico;

    }
}

