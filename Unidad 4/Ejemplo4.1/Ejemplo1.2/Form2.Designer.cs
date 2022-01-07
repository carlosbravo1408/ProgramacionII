﻿namespace Ejemplo1._2
{
    partial class frm_acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_acceso));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_sample = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.tcl_control = new System.Windows.Forms.TabControl();
            this.tbp_AccesoNivel0 = new System.Windows.Forms.TabPage();
            this.clb_control = new System.Windows.Forms.CheckedListBox();
            this.pbx_picture = new System.Windows.Forms.PictureBox();
            this.rch_mensaje = new System.Windows.Forms.RichTextBox();
            this.tbp_AccesoNivel1 = new System.Windows.Forms.TabPage();
            this.gbx_Conexion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_delay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_dispositivo = new System.Windows.Forms.ComboBox();
            this.tbp_AccesoNivel2 = new System.Windows.Forms.TabPage();
            this.gbx_Color = new System.Windows.Forms.GroupBox();
            this.chx_Blue = new System.Windows.Forms.CheckBox();
            this.chx_Green = new System.Windows.Forms.CheckBox();
            this.chx_Red = new System.Windows.Forms.CheckBox();
            this.pnl_clr = new System.Windows.Forms.Panel();
            this.pnl_Color = new System.Windows.Forms.Panel();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_g = new System.Windows.Forms.Label();
            this.tkb_g = new System.Windows.Forms.TrackBar();
            this.lbl_r = new System.Windows.Forms.Label();
            this.tkb_b = new System.Windows.Forms.TrackBar();
            this.tkb_r = new System.Windows.Forms.TrackBar();
            this.tbp_AccesoNivel3 = new System.Windows.Forms.TabPage();
            this.chrt_gráfico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbx_Sensor4 = new System.Windows.Forms.ListBox();
            this.lbx_Sensor3 = new System.Windows.Forms.ListBox();
            this.lbx_Sensor2 = new System.Windows.Forms.ListBox();
            this.lbx_Sensor1 = new System.Windows.Forms.ListBox();
            this.tbp_AccesoNivel4 = new System.Windows.Forms.TabPage();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.lbl_servo = new System.Windows.Forms.Label();
            this.tkb_motor = new System.Windows.Forms.TrackBar();
            this.tkb_servo = new System.Windows.Forms.TrackBar();
            this.tbp_AccesoNivel5 = new System.Windows.Forms.TabPage();
            this.btn_ConsultaHora = new System.Windows.Forms.Button();
            this.cbx_Usuarios = new System.Windows.Forms.ComboBox();
            this.tcl_RegistroHoras = new System.Windows.Forms.TabControl();
            this.tbp_RegistrosUsuarios = new System.Windows.Forms.TabPage();
            this.dgv_Registro_Horas = new System.Windows.Forms.DataGridView();
            this.tbp_RegistroSensores = new System.Windows.Forms.TabPage();
            this.dgv_sensores = new System.Windows.Forms.DataGridView();
            this.tmr_dato = new System.Windows.Forms.Timer(this.components);
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.btn_consultarsensor = new System.Windows.Forms.Button();
            this.cbx_Horas = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.tcl_control.SuspendLayout();
            this.tbp_AccesoNivel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_picture)).BeginInit();
            this.tbp_AccesoNivel1.SuspendLayout();
            this.gbx_Conexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delay)).BeginInit();
            this.tbp_AccesoNivel2.SuspendLayout();
            this.gbx_Color.SuspendLayout();
            this.pnl_clr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_r)).BeginInit();
            this.tbp_AccesoNivel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_gráfico)).BeginInit();
            this.tbp_AccesoNivel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_motor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_servo)).BeginInit();
            this.tbp_AccesoNivel5.SuspendLayout();
            this.tcl_RegistroHoras.SuspendLayout();
            this.tbp_RegistrosUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro_Horas)).BeginInit();
            this.tbp_RegistroSensores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sensores)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_estado,
            this.lbl_sample});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_estado
            // 
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(82, 17);
            this.lbl_estado.Text = "Desconectado";
            // 
            // lbl_sample
            // 
            this.lbl_sample.Name = "lbl_sample";
            this.lbl_sample.Size = new System.Drawing.Size(34, 17);
            this.lbl_sample.Text = "Baud";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(443, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(110, 23);
            this.btn_cerrar.TabIndex = 9;
            this.btn_cerrar.Text = "Cerrar Sesión";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // tcl_control
            // 
            this.tcl_control.Controls.Add(this.tbp_AccesoNivel0);
            this.tcl_control.Controls.Add(this.tbp_AccesoNivel1);
            this.tcl_control.Controls.Add(this.tbp_AccesoNivel2);
            this.tcl_control.Controls.Add(this.tbp_AccesoNivel3);
            this.tcl_control.Controls.Add(this.tbp_AccesoNivel4);
            this.tcl_control.Controls.Add(this.tbp_AccesoNivel5);
            this.tcl_control.Location = new System.Drawing.Point(12, 31);
            this.tcl_control.Name = "tcl_control";
            this.tcl_control.SelectedIndex = 0;
            this.tcl_control.ShowToolTips = true;
            this.tcl_control.Size = new System.Drawing.Size(541, 405);
            this.tcl_control.TabIndex = 8;
            this.tcl_control.SelectedIndexChanged += new System.EventHandler(this.tcl_control_SelectedIndexChanged);
            // 
            // tbp_AccesoNivel0
            // 
            this.tbp_AccesoNivel0.Controls.Add(this.clb_control);
            this.tbp_AccesoNivel0.Controls.Add(this.pbx_picture);
            this.tbp_AccesoNivel0.Controls.Add(this.rch_mensaje);
            this.tbp_AccesoNivel0.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel0.Name = "tbp_AccesoNivel0";
            this.tbp_AccesoNivel0.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_AccesoNivel0.Size = new System.Drawing.Size(533, 379);
            this.tbp_AccesoNivel0.TabIndex = 0;
            this.tbp_AccesoNivel0.Text = "Datos";
            this.tbp_AccesoNivel0.UseVisualStyleBackColor = true;
            // 
            // clb_control
            // 
            this.clb_control.FormattingEnabled = true;
            this.clb_control.Location = new System.Drawing.Point(422, 147);
            this.clb_control.Name = "clb_control";
            this.clb_control.Size = new System.Drawing.Size(100, 199);
            this.clb_control.TabIndex = 6;
            // 
            // pbx_picture
            // 
            this.pbx_picture.Location = new System.Drawing.Point(422, 9);
            this.pbx_picture.Name = "pbx_picture";
            this.pbx_picture.Size = new System.Drawing.Size(100, 132);
            this.pbx_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_picture.TabIndex = 5;
            this.pbx_picture.TabStop = false;
            // 
            // rch_mensaje
            // 
            this.rch_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_mensaje.Location = new System.Drawing.Point(6, 6);
            this.rch_mensaje.Name = "rch_mensaje";
            this.rch_mensaje.Size = new System.Drawing.Size(410, 343);
            this.rch_mensaje.TabIndex = 1;
            this.rch_mensaje.Text = "";
            // 
            // tbp_AccesoNivel1
            // 
            this.tbp_AccesoNivel1.Controls.Add(this.gbx_Conexion);
            this.tbp_AccesoNivel1.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel1.Name = "tbp_AccesoNivel1";
            this.tbp_AccesoNivel1.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_AccesoNivel1.Size = new System.Drawing.Size(533, 379);
            this.tbp_AccesoNivel1.TabIndex = 1;
            this.tbp_AccesoNivel1.Text = "AccesoNivel1";
            this.tbp_AccesoNivel1.UseVisualStyleBackColor = true;
            // 
            // gbx_Conexion
            // 
            this.gbx_Conexion.Controls.Add(this.label3);
            this.gbx_Conexion.Controls.Add(this.nud_delay);
            this.gbx_Conexion.Controls.Add(this.label1);
            this.gbx_Conexion.Controls.Add(this.cbx_dispositivo);
            this.gbx_Conexion.Location = new System.Drawing.Point(7, 7);
            this.gbx_Conexion.Name = "gbx_Conexion";
            this.gbx_Conexion.Size = new System.Drawing.Size(266, 342);
            this.gbx_Conexion.TabIndex = 0;
            this.gbx_Conexion.TabStop = false;
            this.gbx_Conexion.Text = "Conexión Dispositivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiempo  de \r\nMuestreo (ms)";
            // 
            // nud_delay
            // 
            this.nud_delay.Enabled = false;
            this.nud_delay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_delay.Location = new System.Drawing.Point(7, 47);
            this.nud_delay.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_delay.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_delay.Name = "nud_delay";
            this.nud_delay.Size = new System.Drawing.Size(131, 20);
            this.nud_delay.TabIndex = 4;
            this.nud_delay.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_delay.ValueChanged += new System.EventHandler(this.nud_delay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dispositivo";
            // 
            // cbx_dispositivo
            // 
            this.cbx_dispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_dispositivo.FormattingEnabled = true;
            this.cbx_dispositivo.Location = new System.Drawing.Point(7, 20);
            this.cbx_dispositivo.Name = "cbx_dispositivo";
            this.cbx_dispositivo.Size = new System.Drawing.Size(131, 21);
            this.cbx_dispositivo.TabIndex = 0;
            this.cbx_dispositivo.SelectedIndexChanged += new System.EventHandler(this.cbx_dispositivo_SelectedIndexChanged);
            // 
            // tbp_AccesoNivel2
            // 
            this.tbp_AccesoNivel2.Controls.Add(this.gbx_Color);
            this.tbp_AccesoNivel2.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel2.Name = "tbp_AccesoNivel2";
            this.tbp_AccesoNivel2.Size = new System.Drawing.Size(533, 379);
            this.tbp_AccesoNivel2.TabIndex = 2;
            this.tbp_AccesoNivel2.Text = "AccesoNivel2";
            this.tbp_AccesoNivel2.UseVisualStyleBackColor = true;
            // 
            // gbx_Color
            // 
            this.gbx_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_Color.Controls.Add(this.chx_Blue);
            this.gbx_Color.Controls.Add(this.chx_Green);
            this.gbx_Color.Controls.Add(this.chx_Red);
            this.gbx_Color.Controls.Add(this.pnl_clr);
            this.gbx_Color.Controls.Add(this.lbl_b);
            this.gbx_Color.Controls.Add(this.lbl_g);
            this.gbx_Color.Controls.Add(this.tkb_g);
            this.gbx_Color.Controls.Add(this.lbl_r);
            this.gbx_Color.Controls.Add(this.tkb_b);
            this.gbx_Color.Controls.Add(this.tkb_r);
            this.gbx_Color.Location = new System.Drawing.Point(3, 3);
            this.gbx_Color.Name = "gbx_Color";
            this.gbx_Color.Size = new System.Drawing.Size(527, 364);
            this.gbx_Color.TabIndex = 4;
            this.gbx_Color.TabStop = false;
            this.gbx_Color.Text = "Color Sección";
            // 
            // chx_Blue
            // 
            this.chx_Blue.AutoSize = true;
            this.chx_Blue.Checked = true;
            this.chx_Blue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chx_Blue.Location = new System.Drawing.Point(487, 193);
            this.chx_Blue.Name = "chx_Blue";
            this.chx_Blue.Size = new System.Drawing.Size(33, 17);
            this.chx_Blue.TabIndex = 8;
            this.chx_Blue.Text = "B";
            this.chx_Blue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chx_Blue.UseVisualStyleBackColor = true;
            this.chx_Blue.CheckedChanged += new System.EventHandler(this.chx_Blue_CheckedChanged);
            // 
            // chx_Green
            // 
            this.chx_Green.AutoSize = true;
            this.chx_Green.Checked = true;
            this.chx_Green.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chx_Green.Location = new System.Drawing.Point(487, 129);
            this.chx_Green.Name = "chx_Green";
            this.chx_Green.Size = new System.Drawing.Size(34, 17);
            this.chx_Green.TabIndex = 7;
            this.chx_Green.Text = "G";
            this.chx_Green.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chx_Green.UseVisualStyleBackColor = true;
            this.chx_Green.CheckedChanged += new System.EventHandler(this.chx_Green_CheckedChanged);
            // 
            // chx_Red
            // 
            this.chx_Red.AutoSize = true;
            this.chx_Red.Checked = true;
            this.chx_Red.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chx_Red.Location = new System.Drawing.Point(487, 65);
            this.chx_Red.Name = "chx_Red";
            this.chx_Red.Size = new System.Drawing.Size(34, 17);
            this.chx_Red.TabIndex = 6;
            this.chx_Red.Text = "R";
            this.chx_Red.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chx_Red.UseVisualStyleBackColor = true;
            this.chx_Red.CheckedChanged += new System.EventHandler(this.chx_Red_CheckedChanged);
            // 
            // pnl_clr
            // 
            this.pnl_clr.Controls.Add(this.pnl_Color);
            this.pnl_clr.Location = new System.Drawing.Point(7, 211);
            this.pnl_clr.Name = "pnl_clr";
            this.pnl_clr.Size = new System.Drawing.Size(514, 141);
            this.pnl_clr.TabIndex = 5;
            // 
            // pnl_Color
            // 
            this.pnl_Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Color.BackgroundImage")));
            this.pnl_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Color.Location = new System.Drawing.Point(205, 3);
            this.pnl_Color.Name = "pnl_Color";
            this.pnl_Color.Size = new System.Drawing.Size(120, 120);
            this.pnl_Color.TabIndex = 4;
            this.pnl_Color.Click += new System.EventHandler(this.pnl_Color_Click);
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(6, 194);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(29, 13);
            this.lbl_b.TabIndex = 2;
            this.lbl_b.Text = "lbl_b";
            // 
            // lbl_g
            // 
            this.lbl_g.AutoSize = true;
            this.lbl_g.Location = new System.Drawing.Point(3, 130);
            this.lbl_g.Name = "lbl_g";
            this.lbl_g.Size = new System.Drawing.Size(29, 13);
            this.lbl_g.TabIndex = 1;
            this.lbl_g.Text = "lbl_g";
            // 
            // tkb_g
            // 
            this.tkb_g.Enabled = false;
            this.tkb_g.Location = new System.Drawing.Point(6, 82);
            this.tkb_g.Maximum = 255;
            this.tkb_g.Name = "tkb_g";
            this.tkb_g.Size = new System.Drawing.Size(515, 45);
            this.tkb_g.TabIndex = 2;
            this.tkb_g.Scroll += new System.EventHandler(this.tkb_g_Scroll);
            // 
            // lbl_r
            // 
            this.lbl_r.AutoSize = true;
            this.lbl_r.Location = new System.Drawing.Point(3, 66);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(26, 13);
            this.lbl_r.TabIndex = 0;
            this.lbl_r.Text = "lbl_r";
            // 
            // tkb_b
            // 
            this.tkb_b.Enabled = false;
            this.tkb_b.Location = new System.Drawing.Point(6, 146);
            this.tkb_b.Maximum = 255;
            this.tkb_b.Name = "tkb_b";
            this.tkb_b.Size = new System.Drawing.Size(515, 45);
            this.tkb_b.TabIndex = 3;
            this.tkb_b.Scroll += new System.EventHandler(this.tkb_b_Scroll);
            // 
            // tkb_r
            // 
            this.tkb_r.Enabled = false;
            this.tkb_r.Location = new System.Drawing.Point(6, 19);
            this.tkb_r.Maximum = 255;
            this.tkb_r.Name = "tkb_r";
            this.tkb_r.Size = new System.Drawing.Size(515, 45);
            this.tkb_r.TabIndex = 1;
            this.tkb_r.Scroll += new System.EventHandler(this.tkb_r_Scroll);
            // 
            // tbp_AccesoNivel3
            // 
            this.tbp_AccesoNivel3.Controls.Add(this.chrt_gráfico);
            this.tbp_AccesoNivel3.Controls.Add(this.lbx_Sensor4);
            this.tbp_AccesoNivel3.Controls.Add(this.lbx_Sensor3);
            this.tbp_AccesoNivel3.Controls.Add(this.lbx_Sensor2);
            this.tbp_AccesoNivel3.Controls.Add(this.lbx_Sensor1);
            this.tbp_AccesoNivel3.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel3.Name = "tbp_AccesoNivel3";
            this.tbp_AccesoNivel3.Size = new System.Drawing.Size(533, 379);
            this.tbp_AccesoNivel3.TabIndex = 3;
            this.tbp_AccesoNivel3.Text = "AccesoNivel3";
            this.tbp_AccesoNivel3.UseVisualStyleBackColor = true;
            // 
            // chrt_gráfico
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_gráfico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_gráfico.Legends.Add(legend2);
            this.chrt_gráfico.Location = new System.Drawing.Point(261, 4);
            this.chrt_gráfico.Name = "chrt_gráfico";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Sensor1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Sensor2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Sensor3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Sensor4";
            this.chrt_gráfico.Series.Add(series5);
            this.chrt_gráfico.Series.Add(series6);
            this.chrt_gráfico.Series.Add(series7);
            this.chrt_gráfico.Series.Add(series8);
            this.chrt_gráfico.Size = new System.Drawing.Size(269, 368);
            this.chrt_gráfico.TabIndex = 4;
            this.chrt_gráfico.Text = "chart1";
            // 
            // lbx_Sensor4
            // 
            this.lbx_Sensor4.FormattingEnabled = true;
            this.lbx_Sensor4.Location = new System.Drawing.Point(196, 4);
            this.lbx_Sensor4.Name = "lbx_Sensor4";
            this.lbx_Sensor4.Size = new System.Drawing.Size(58, 368);
            this.lbx_Sensor4.TabIndex = 3;
            // 
            // lbx_Sensor3
            // 
            this.lbx_Sensor3.FormattingEnabled = true;
            this.lbx_Sensor3.Location = new System.Drawing.Point(132, 4);
            this.lbx_Sensor3.Name = "lbx_Sensor3";
            this.lbx_Sensor3.Size = new System.Drawing.Size(58, 368);
            this.lbx_Sensor3.TabIndex = 2;
            // 
            // lbx_Sensor2
            // 
            this.lbx_Sensor2.FormattingEnabled = true;
            this.lbx_Sensor2.Location = new System.Drawing.Point(68, 4);
            this.lbx_Sensor2.Name = "lbx_Sensor2";
            this.lbx_Sensor2.Size = new System.Drawing.Size(58, 368);
            this.lbx_Sensor2.TabIndex = 1;
            // 
            // lbx_Sensor1
            // 
            this.lbx_Sensor1.FormattingEnabled = true;
            this.lbx_Sensor1.Location = new System.Drawing.Point(4, 4);
            this.lbx_Sensor1.Name = "lbx_Sensor1";
            this.lbx_Sensor1.Size = new System.Drawing.Size(58, 368);
            this.lbx_Sensor1.TabIndex = 0;
            // 
            // tbp_AccesoNivel4
            // 
            this.tbp_AccesoNivel4.Controls.Add(this.lbl_motor);
            this.tbp_AccesoNivel4.Controls.Add(this.lbl_servo);
            this.tbp_AccesoNivel4.Controls.Add(this.tkb_motor);
            this.tbp_AccesoNivel4.Controls.Add(this.tkb_servo);
            this.tbp_AccesoNivel4.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel4.Name = "tbp_AccesoNivel4";
            this.tbp_AccesoNivel4.Size = new System.Drawing.Size(533, 379);
            this.tbp_AccesoNivel4.TabIndex = 4;
            this.tbp_AccesoNivel4.Text = "AccesoNivel4";
            this.tbp_AccesoNivel4.UseVisualStyleBackColor = true;
            // 
            // lbl_motor
            // 
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.Location = new System.Drawing.Point(3, 175);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(35, 13);
            this.lbl_motor.TabIndex = 3;
            this.lbl_motor.Text = "label4";
            // 
            // lbl_servo
            // 
            this.lbl_servo.AutoSize = true;
            this.lbl_servo.Location = new System.Drawing.Point(3, 51);
            this.lbl_servo.Name = "lbl_servo";
            this.lbl_servo.Size = new System.Drawing.Size(35, 13);
            this.lbl_servo.TabIndex = 2;
            this.lbl_servo.Text = "label2";
            // 
            // tkb_motor
            // 
            this.tkb_motor.Location = new System.Drawing.Point(4, 127);
            this.tkb_motor.Maximum = 255;
            this.tkb_motor.Name = "tkb_motor";
            this.tkb_motor.Size = new System.Drawing.Size(526, 45);
            this.tkb_motor.TabIndex = 1;
            this.tkb_motor.Scroll += new System.EventHandler(this.tkb_motor_Scroll);
            // 
            // tkb_servo
            // 
            this.tkb_servo.Location = new System.Drawing.Point(3, 3);
            this.tkb_servo.Maximum = 180;
            this.tkb_servo.Name = "tkb_servo";
            this.tkb_servo.Size = new System.Drawing.Size(527, 45);
            this.tkb_servo.TabIndex = 0;
            this.tkb_servo.Scroll += new System.EventHandler(this.tkb_servo_Scroll);
            // 
            // tbp_AccesoNivel5
            // 
            this.tbp_AccesoNivel5.Controls.Add(this.btn_ConsultaHora);
            this.tbp_AccesoNivel5.Controls.Add(this.cbx_Usuarios);
            this.tbp_AccesoNivel5.Controls.Add(this.tcl_RegistroHoras);
            this.tbp_AccesoNivel5.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel5.Name = "tbp_AccesoNivel5";
            this.tbp_AccesoNivel5.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_AccesoNivel5.Size = new System.Drawing.Size(533, 379);
            this.tbp_AccesoNivel5.TabIndex = 5;
            this.tbp_AccesoNivel5.Text = "AccesoNivel5";
            this.tbp_AccesoNivel5.UseVisualStyleBackColor = true;
            // 
            // btn_ConsultaHora
            // 
            this.btn_ConsultaHora.Location = new System.Drawing.Point(401, 1);
            this.btn_ConsultaHora.Name = "btn_ConsultaHora";
            this.btn_ConsultaHora.Size = new System.Drawing.Size(122, 23);
            this.btn_ConsultaHora.TabIndex = 12;
            this.btn_ConsultaHora.Text = "Consultar";
            this.btn_ConsultaHora.UseVisualStyleBackColor = true;
            this.btn_ConsultaHora.Click += new System.EventHandler(this.btn_ConsultaHora_Click);
            // 
            // cbx_Usuarios
            // 
            this.cbx_Usuarios.FormattingEnabled = true;
            this.cbx_Usuarios.Location = new System.Drawing.Point(278, 3);
            this.cbx_Usuarios.Name = "cbx_Usuarios";
            this.cbx_Usuarios.Size = new System.Drawing.Size(121, 21);
            this.cbx_Usuarios.TabIndex = 11;
            this.cbx_Usuarios.SelectedIndexChanged += new System.EventHandler(this.cbx_Usuarios_SelectedIndexChanged);
            // 
            // tcl_RegistroHoras
            // 
            this.tcl_RegistroHoras.Controls.Add(this.tbp_RegistrosUsuarios);
            this.tcl_RegistroHoras.Controls.Add(this.tbp_RegistroSensores);
            this.tcl_RegistroHoras.Enabled = false;
            this.tcl_RegistroHoras.Location = new System.Drawing.Point(7, 17);
            this.tcl_RegistroHoras.Name = "tcl_RegistroHoras";
            this.tcl_RegistroHoras.SelectedIndex = 0;
            this.tcl_RegistroHoras.Size = new System.Drawing.Size(520, 359);
            this.tcl_RegistroHoras.TabIndex = 0;
            // 
            // tbp_RegistrosUsuarios
            // 
            this.tbp_RegistrosUsuarios.Controls.Add(this.dgv_Registro_Horas);
            this.tbp_RegistrosUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tbp_RegistrosUsuarios.Name = "tbp_RegistrosUsuarios";
            this.tbp_RegistrosUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_RegistrosUsuarios.Size = new System.Drawing.Size(512, 333);
            this.tbp_RegistrosUsuarios.TabIndex = 0;
            this.tbp_RegistrosUsuarios.Text = "Registros Ingreso a Sistema";
            this.tbp_RegistrosUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgv_Registro_Horas
            // 
            this.dgv_Registro_Horas.AllowUserToAddRows = false;
            this.dgv_Registro_Horas.AllowUserToDeleteRows = false;
            this.dgv_Registro_Horas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Registro_Horas.Location = new System.Drawing.Point(4, 7);
            this.dgv_Registro_Horas.Name = "dgv_Registro_Horas";
            this.dgv_Registro_Horas.ReadOnly = true;
            this.dgv_Registro_Horas.Size = new System.Drawing.Size(502, 320);
            this.dgv_Registro_Horas.TabIndex = 0;
            // 
            // tbp_RegistroSensores
            // 
            this.tbp_RegistroSensores.Controls.Add(this.btn_consultarsensor);
            this.tbp_RegistroSensores.Controls.Add(this.cbx_Horas);
            this.tbp_RegistroSensores.Controls.Add(this.dgv_sensores);
            this.tbp_RegistroSensores.Location = new System.Drawing.Point(4, 22);
            this.tbp_RegistroSensores.Name = "tbp_RegistroSensores";
            this.tbp_RegistroSensores.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_RegistroSensores.Size = new System.Drawing.Size(512, 333);
            this.tbp_RegistroSensores.TabIndex = 1;
            this.tbp_RegistroSensores.Text = "Registros de Sensores";
            this.tbp_RegistroSensores.UseVisualStyleBackColor = true;
            // 
            // dgv_sensores
            // 
            this.dgv_sensores.AllowUserToAddRows = false;
            this.dgv_sensores.AllowUserToDeleteRows = false;
            this.dgv_sensores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sensores.Enabled = false;
            this.dgv_sensores.Location = new System.Drawing.Point(5, 32);
            this.dgv_sensores.Name = "dgv_sensores";
            this.dgv_sensores.ReadOnly = true;
            this.dgv_sensores.Size = new System.Drawing.Size(502, 294);
            this.dgv_sensores.TabIndex = 1;
            // 
            // tmr_dato
            // 
            this.tmr_dato.Tick += new System.EventHandler(this.tmr_dato_Tick);
            // 
            // btn_consultarsensor
            // 
            this.btn_consultarsensor.Location = new System.Drawing.Point(383, 1);
            this.btn_consultarsensor.Name = "btn_consultarsensor";
            this.btn_consultarsensor.Size = new System.Drawing.Size(122, 23);
            this.btn_consultarsensor.TabIndex = 14;
            this.btn_consultarsensor.Text = "Consultar";
            this.btn_consultarsensor.UseVisualStyleBackColor = true;
            this.btn_consultarsensor.Click += new System.EventHandler(this.btn_consultarsensor_Click);
            // 
            // cbx_Horas
            // 
            this.cbx_Horas.FormattingEnabled = true;
            this.cbx_Horas.Location = new System.Drawing.Point(256, 3);
            this.cbx_Horas.Name = "cbx_Horas";
            this.cbx_Horas.Size = new System.Drawing.Size(121, 21);
            this.cbx_Horas.TabIndex = 13;
            // 
            // frm_acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(565, 473);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.tcl_control);
            this.Name = "frm_acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_acceso_FormClosing);
            this.Load += new System.EventHandler(this.frm_acceso_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tcl_control.ResumeLayout(false);
            this.tbp_AccesoNivel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_picture)).EndInit();
            this.tbp_AccesoNivel1.ResumeLayout(false);
            this.gbx_Conexion.ResumeLayout(false);
            this.gbx_Conexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delay)).EndInit();
            this.tbp_AccesoNivel2.ResumeLayout(false);
            this.gbx_Color.ResumeLayout(false);
            this.gbx_Color.PerformLayout();
            this.pnl_clr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tkb_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_r)).EndInit();
            this.tbp_AccesoNivel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_gráfico)).EndInit();
            this.tbp_AccesoNivel4.ResumeLayout(false);
            this.tbp_AccesoNivel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_motor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_servo)).EndInit();
            this.tbp_AccesoNivel5.ResumeLayout(false);
            this.tcl_RegistroHoras.ResumeLayout(false);
            this.tbp_RegistrosUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro_Horas)).EndInit();
            this.tbp_RegistroSensores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sensores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_estado;
        private System.Windows.Forms.ToolStripStatusLabel lbl_sample;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TabControl tcl_control;
        private System.Windows.Forms.TabPage tbp_AccesoNivel0;
        private System.Windows.Forms.CheckedListBox clb_control;
        private System.Windows.Forms.PictureBox pbx_picture;
        private System.Windows.Forms.RichTextBox rch_mensaje;
        private System.Windows.Forms.TabPage tbp_AccesoNivel1;
        private System.Windows.Forms.GroupBox gbx_Conexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_delay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_dispositivo;
        private System.Windows.Forms.TabPage tbp_AccesoNivel2;
        private System.Windows.Forms.GroupBox gbx_Color;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Panel pnl_Color;
        private System.Windows.Forms.Label lbl_g;
        private System.Windows.Forms.TrackBar tkb_g;
        private System.Windows.Forms.Label lbl_r;
        private System.Windows.Forms.TrackBar tkb_b;
        private System.Windows.Forms.TrackBar tkb_r;
        private System.Windows.Forms.TabPage tbp_AccesoNivel4;
        private System.Windows.Forms.Panel pnl_clr;
        private System.Windows.Forms.CheckBox chx_Blue;
        private System.Windows.Forms.CheckBox chx_Green;
        private System.Windows.Forms.CheckBox chx_Red;
        private System.Windows.Forms.Timer tmr_dato;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.TabPage tbp_AccesoNivel3;
        private System.Windows.Forms.ListBox lbx_Sensor4;
        private System.Windows.Forms.ListBox lbx_Sensor3;
        private System.Windows.Forms.ListBox lbx_Sensor2;
        private System.Windows.Forms.ListBox lbx_Sensor1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_gráfico;
        private System.Windows.Forms.TrackBar tkb_motor;
        private System.Windows.Forms.TrackBar tkb_servo;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.Label lbl_servo;
        private System.Windows.Forms.TabPage tbp_AccesoNivel5;
        private System.Windows.Forms.Button btn_ConsultaHora;
        private System.Windows.Forms.ComboBox cbx_Usuarios;
        private System.Windows.Forms.TabControl tcl_RegistroHoras;
        private System.Windows.Forms.TabPage tbp_RegistrosUsuarios;
        private System.Windows.Forms.DataGridView dgv_Registro_Horas;
        private System.Windows.Forms.TabPage tbp_RegistroSensores;
        private System.Windows.Forms.DataGridView dgv_sensores;
        private System.Windows.Forms.Button btn_consultarsensor;
        private System.Windows.Forms.ComboBox cbx_Horas;
    }
}