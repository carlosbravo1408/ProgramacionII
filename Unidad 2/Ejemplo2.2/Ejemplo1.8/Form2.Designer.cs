namespace Ejemplo1._8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_sample = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_indicador = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.tcl_control = new System.Windows.Forms.TabControl();
            this.tbp_AccesoNivel0 = new System.Windows.Forms.TabPage();
            this.clb_control = new System.Windows.Forms.CheckedListBox();
            this.pbx_picture = new System.Windows.Forms.PictureBox();
            this.rch_mensaje = new System.Windows.Forms.RichTextBox();
            this.tbp_AccesoNivel1 = new System.Windows.Forms.TabPage();
            this.txt_secuencia = new System.Windows.Forms.RichTextBox();
            this.gbx_Conexion = new System.Windows.Forms.GroupBox();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_delay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx_velocidad = new System.Windows.Forms.ListBox();
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
            this.tcl_datos_graficas = new System.Windows.Forms.TabControl();
            this.tab_adquisicion = new System.Windows.Forms.TabPage();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.tab_graficas = new System.Windows.Forms.TabPage();
            this.cbx_3d_gra2 = new System.Windows.Forms.CheckBox();
            this.cbx_3d_gra1 = new System.Windows.Forms.CheckBox();
            this.chrt_grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbp_AccesoNivel4 = new System.Windows.Forms.TabPage();
            this.ttp_info = new System.Windows.Forms.ToolTip(this.components);
            this.tmr_muestreo = new System.Windows.Forms.Timer(this.components);
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
            this.tcl_datos_graficas.SuspendLayout();
            this.tab_adquisicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.tab_graficas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_estado,
            this.lbl_sample,
            this.lbl_indicador});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
            this.statusStrip1.TabIndex = 13;
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
            // lbl_indicador
            // 
            this.lbl_indicador.Name = "lbl_indicador";
            this.lbl_indicador.Size = new System.Drawing.Size(18, 17);
            this.lbl_indicador.Text = "@";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(443, 1);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(110, 23);
            this.btn_cerrar.TabIndex = 12;
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
            this.tcl_control.Location = new System.Drawing.Point(12, 30);
            this.tcl_control.Name = "tcl_control";
            this.tcl_control.SelectedIndex = 0;
            this.tcl_control.ShowToolTips = true;
            this.tcl_control.Size = new System.Drawing.Size(541, 384);
            this.tcl_control.TabIndex = 11;
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
            this.tbp_AccesoNivel0.Size = new System.Drawing.Size(533, 358);
            this.tbp_AccesoNivel0.TabIndex = 0;
            this.tbp_AccesoNivel0.Text = "Datos";
            this.ttp_info.SetToolTip(this.tbp_AccesoNivel0, "Datos Personales");
            this.tbp_AccesoNivel0.UseVisualStyleBackColor = true;
            // 
            // clb_control
            // 
            this.clb_control.FormattingEnabled = true;
            this.clb_control.Location = new System.Drawing.Point(422, 147);
            this.clb_control.Name = "clb_control";
            this.clb_control.Size = new System.Drawing.Size(100, 199);
            this.clb_control.TabIndex = 6;
            this.ttp_info.SetToolTip(this.clb_control, "Pestañas accesibles (Selección)\r\nPestañas ingresadas (Checked)");
            // 
            // pbx_picture
            // 
            this.pbx_picture.Location = new System.Drawing.Point(422, 9);
            this.pbx_picture.Name = "pbx_picture";
            this.pbx_picture.Size = new System.Drawing.Size(100, 132);
            this.pbx_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_picture.TabIndex = 5;
            this.pbx_picture.TabStop = false;
            this.ttp_info.SetToolTip(this.pbx_picture, "Imagen del Usuario");
            // 
            // rch_mensaje
            // 
            this.rch_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_mensaje.Location = new System.Drawing.Point(6, 6);
            this.rch_mensaje.Name = "rch_mensaje";
            this.rch_mensaje.Size = new System.Drawing.Size(410, 343);
            this.rch_mensaje.TabIndex = 1;
            this.rch_mensaje.Text = "";
            this.ttp_info.SetToolTip(this.rch_mensaje, "Informacion Personal");
            // 
            // tbp_AccesoNivel1
            // 
            this.tbp_AccesoNivel1.Controls.Add(this.txt_secuencia);
            this.tbp_AccesoNivel1.Controls.Add(this.gbx_Conexion);
            this.tbp_AccesoNivel1.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel1.Name = "tbp_AccesoNivel1";
            this.tbp_AccesoNivel1.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_AccesoNivel1.Size = new System.Drawing.Size(533, 358);
            this.tbp_AccesoNivel1.TabIndex = 1;
            this.tbp_AccesoNivel1.Text = "AccesoNivel1";
            this.ttp_info.SetToolTip(this.tbp_AccesoNivel1, "Dispositivo a conectar");
            this.tbp_AccesoNivel1.UseVisualStyleBackColor = true;
            // 
            // txt_secuencia
            // 
            this.txt_secuencia.Location = new System.Drawing.Point(237, 7);
            this.txt_secuencia.Name = "txt_secuencia";
            this.txt_secuencia.Size = new System.Drawing.Size(290, 345);
            this.txt_secuencia.TabIndex = 1;
            this.txt_secuencia.Text = "";
            // 
            // gbx_Conexion
            // 
            this.gbx_Conexion.Controls.Add(this.btn_desconectar);
            this.gbx_Conexion.Controls.Add(this.label3);
            this.gbx_Conexion.Controls.Add(this.nud_delay);
            this.gbx_Conexion.Controls.Add(this.label2);
            this.gbx_Conexion.Controls.Add(this.lbx_velocidad);
            this.gbx_Conexion.Controls.Add(this.label1);
            this.gbx_Conexion.Controls.Add(this.cbx_dispositivo);
            this.gbx_Conexion.Location = new System.Drawing.Point(7, 7);
            this.gbx_Conexion.Name = "gbx_Conexion";
            this.gbx_Conexion.Size = new System.Drawing.Size(223, 345);
            this.gbx_Conexion.TabIndex = 0;
            this.gbx_Conexion.TabStop = false;
            this.gbx_Conexion.Text = "Conexión Dispositivo";
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(7, 179);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(209, 23);
            this.btn_desconectar.TabIndex = 6;
            this.btn_desconectar.Text = "Desconectar Dispositivo";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 150);
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
            this.nud_delay.Location = new System.Drawing.Point(7, 150);
            this.nud_delay.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_delay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_delay.Name = "nud_delay";
            this.nud_delay.Size = new System.Drawing.Size(131, 20);
            this.nud_delay.TabIndex = 4;
            this.ttp_info.SetToolTip(this.nud_delay, "Tiempo de muestreo (ms)");
            this.nud_delay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_delay.ValueChanged += new System.EventHandler(this.nud_delay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocidad de \r\nconexión";
            // 
            // lbx_velocidad
            // 
            this.lbx_velocidad.Enabled = false;
            this.lbx_velocidad.FormattingEnabled = true;
            this.lbx_velocidad.Location = new System.Drawing.Point(7, 48);
            this.lbx_velocidad.Name = "lbx_velocidad";
            this.lbx_velocidad.Size = new System.Drawing.Size(131, 95);
            this.lbx_velocidad.TabIndex = 2;
            this.ttp_info.SetToolTip(this.lbx_velocidad, "Velocidad de transmision de datos\r\nBaudios por segundo");
            this.lbx_velocidad.SelectedIndexChanged += new System.EventHandler(this.lbx_velocidad_SelectedIndexChanged);
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
            this.ttp_info.SetToolTip(this.cbx_dispositivo, "Dispositivos encontrados");
            this.cbx_dispositivo.SelectedIndexChanged += new System.EventHandler(this.cbx_dispositivo_SelectedIndexChanged);
            // 
            // tbp_AccesoNivel2
            // 
            this.tbp_AccesoNivel2.Controls.Add(this.gbx_Color);
            this.tbp_AccesoNivel2.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel2.Name = "tbp_AccesoNivel2";
            this.tbp_AccesoNivel2.Size = new System.Drawing.Size(533, 358);
            this.tbp_AccesoNivel2.TabIndex = 2;
            this.tbp_AccesoNivel2.Text = "AccesoNivel2";
            this.ttp_info.SetToolTip(this.tbp_AccesoNivel2, "Color de habitacion (RGB)");
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
            this.gbx_Color.Size = new System.Drawing.Size(527, 340);
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
            this.ttp_info.SetToolTip(this.tkb_g, "Color Verde");
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
            this.ttp_info.SetToolTip(this.tkb_b, "Color Azul");
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
            this.ttp_info.SetToolTip(this.tkb_r, "Color Rojo");
            this.tkb_r.Scroll += new System.EventHandler(this.tkb_r_Scroll);
            // 
            // tbp_AccesoNivel3
            // 
            this.tbp_AccesoNivel3.Controls.Add(this.tcl_datos_graficas);
            this.tbp_AccesoNivel3.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel3.Name = "tbp_AccesoNivel3";
            this.tbp_AccesoNivel3.Size = new System.Drawing.Size(533, 358);
            this.tbp_AccesoNivel3.TabIndex = 3;
            this.tbp_AccesoNivel3.Text = "AccesoNivel3";
            this.ttp_info.SetToolTip(this.tbp_AccesoNivel3, "Toma de datos y Gráficas Sensor");
            this.tbp_AccesoNivel3.UseVisualStyleBackColor = true;
            // 
            // tcl_datos_graficas
            // 
            this.tcl_datos_graficas.Controls.Add(this.tab_adquisicion);
            this.tcl_datos_graficas.Controls.Add(this.tab_graficas);
            this.tcl_datos_graficas.Location = new System.Drawing.Point(3, 3);
            this.tcl_datos_graficas.Name = "tcl_datos_graficas";
            this.tcl_datos_graficas.SelectedIndex = 0;
            this.tcl_datos_graficas.Size = new System.Drawing.Size(527, 352);
            this.tcl_datos_graficas.TabIndex = 0;
            // 
            // tab_adquisicion
            // 
            this.tab_adquisicion.Controls.Add(this.dgv_datos);
            this.tab_adquisicion.Location = new System.Drawing.Point(4, 22);
            this.tab_adquisicion.Name = "tab_adquisicion";
            this.tab_adquisicion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_adquisicion.Size = new System.Drawing.Size(519, 326);
            this.tab_adquisicion.TabIndex = 0;
            this.tab_adquisicion.Text = "Adquisición Datos";
            this.ttp_info.SetToolTip(this.tab_adquisicion, "tabla de adquisició de datos");
            this.tab_adquisicion.UseVisualStyleBackColor = true;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(7, 7);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(506, 313);
            this.dgv_datos.TabIndex = 0;
            // 
            // tab_graficas
            // 
            this.tab_graficas.Controls.Add(this.cbx_3d_gra2);
            this.tab_graficas.Controls.Add(this.cbx_3d_gra1);
            this.tab_graficas.Controls.Add(this.chrt_grafico);
            this.tab_graficas.Location = new System.Drawing.Point(4, 22);
            this.tab_graficas.Name = "tab_graficas";
            this.tab_graficas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_graficas.Size = new System.Drawing.Size(519, 326);
            this.tab_graficas.TabIndex = 1;
            this.tab_graficas.Text = "Gráficas";
            this.tab_graficas.UseVisualStyleBackColor = true;
            // 
            // cbx_3d_gra2
            // 
            this.cbx_3d_gra2.AutoSize = true;
            this.cbx_3d_gra2.Location = new System.Drawing.Point(33, 290);
            this.cbx_3d_gra2.Name = "cbx_3d_gra2";
            this.cbx_3d_gra2.Size = new System.Drawing.Size(66, 17);
            this.cbx_3d_gra2.TabIndex = 2;
            this.cbx_3d_gra2.Text = "Vista 3D";
            this.cbx_3d_gra2.UseVisualStyleBackColor = true;
            this.cbx_3d_gra2.CheckedChanged += new System.EventHandler(this.cbx_3d_gra2_CheckedChanged);
            // 
            // cbx_3d_gra1
            // 
            this.cbx_3d_gra1.AutoSize = true;
            this.cbx_3d_gra1.Location = new System.Drawing.Point(33, 147);
            this.cbx_3d_gra1.Name = "cbx_3d_gra1";
            this.cbx_3d_gra1.Size = new System.Drawing.Size(66, 17);
            this.cbx_3d_gra1.TabIndex = 1;
            this.cbx_3d_gra1.Text = "Vista 3D";
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
            this.chrt_grafico.Location = new System.Drawing.Point(7, 7);
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
            this.chrt_grafico.Size = new System.Drawing.Size(506, 300);
            this.chrt_grafico.TabIndex = 0;
            this.chrt_grafico.Text = "chart1";
            // 
            // tbp_AccesoNivel4
            // 
            this.tbp_AccesoNivel4.Location = new System.Drawing.Point(4, 22);
            this.tbp_AccesoNivel4.Name = "tbp_AccesoNivel4";
            this.tbp_AccesoNivel4.Size = new System.Drawing.Size(533, 358);
            this.tbp_AccesoNivel4.TabIndex = 4;
            this.tbp_AccesoNivel4.Text = "AccesoNivel4";
            this.ttp_info.SetToolTip(this.tbp_AccesoNivel4, "Giro controlado Motor");
            this.tbp_AccesoNivel4.UseVisualStyleBackColor = true;
            // 
            // tmr_muestreo
            // 
            this.tmr_muestreo.Tick += new System.EventHandler(this.tmr_muestreo_Tick);
            // 
            // frm_acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.tcl_control);
            this.Name = "frm_acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.tcl_datos_graficas.ResumeLayout(false);
            this.tab_adquisicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.tab_graficas.ResumeLayout(false);
            this.tab_graficas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafico)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbx_velocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_dispositivo;
        private System.Windows.Forms.TabPage tbp_AccesoNivel2;
        private System.Windows.Forms.GroupBox gbx_Color;
        private System.Windows.Forms.CheckBox chx_Blue;
        private System.Windows.Forms.CheckBox chx_Green;
        private System.Windows.Forms.CheckBox chx_Red;
        private System.Windows.Forms.Panel pnl_clr;
        private System.Windows.Forms.Panel pnl_Color;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_g;
        private System.Windows.Forms.TrackBar tkb_g;
        private System.Windows.Forms.Label lbl_r;
        private System.Windows.Forms.TrackBar tkb_b;
        private System.Windows.Forms.TrackBar tkb_r;
        private System.Windows.Forms.TabPage tbp_AccesoNivel3;
        private System.Windows.Forms.TabPage tbp_AccesoNivel4;
        private System.Windows.Forms.ToolTip ttp_info;
        private System.Windows.Forms.TabControl tcl_datos_graficas;
        private System.Windows.Forms.TabPage tab_adquisicion;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.TabPage tab_graficas;
        private System.Windows.Forms.RichTextBox txt_secuencia;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Timer tmr_muestreo;
        private System.Windows.Forms.ToolStripStatusLabel lbl_indicador;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_grafico;
        private System.Windows.Forms.CheckBox cbx_3d_gra2;
        private System.Windows.Forms.CheckBox cbx_3d_gra1;
    }
}