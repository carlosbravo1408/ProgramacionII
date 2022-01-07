namespace Ejemplo1._4
{
    partial class frm_timer
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
            this.tmr_contador = new System.Windows.Forms.Timer(this.components);
            this.lbl_tiempo = new System.Windows.Forms.Label();
            this.lbl_dec_seg = new System.Windows.Forms.Label();
            this.grb_opciones = new System.Windows.Forms.GroupBox();
            this.grb_Temporizador = new System.Windows.Forms.GroupBox();
            this.lbl_segundos = new System.Windows.Forms.Label();
            this.lbl_minutos = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.nud_hora = new System.Windows.Forms.NumericUpDown();
            this.nud_minuto = new System.Windows.Forms.NumericUpDown();
            this.nud_segundo = new System.Windows.Forms.NumericUpDown();
            this.rdb_temporizador = new System.Windows.Forms.RadioButton();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.rdb_cronometro = new System.Windows.Forms.RadioButton();
            this.btn_inicio_pausa = new System.Windows.Forms.Button();
            this.grb_vueltas = new System.Windows.Forms.GroupBox();
            this.lbx_vueltas = new System.Windows.Forms.ListBox();
            this.pnl_indicador = new System.Windows.Forms.Panel();
            this.grb_opciones.SuspendLayout();
            this.grb_Temporizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_segundo)).BeginInit();
            this.grb_vueltas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_contador
            // 
            this.tmr_contador.Interval = 10;
            this.tmr_contador.Tick += new System.EventHandler(this.tmr_contador_Tick);
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo.Location = new System.Drawing.Point(16, 7);
            this.lbl_tiempo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(193, 37);
            this.lbl_tiempo.TabIndex = 0;
            this.lbl_tiempo.Text = "00:00:00";
            // 
            // lbl_dec_seg
            // 
            this.lbl_dec_seg.AutoSize = true;
            this.lbl_dec_seg.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dec_seg.Location = new System.Drawing.Point(200, 21);
            this.lbl_dec_seg.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_dec_seg.Name = "lbl_dec_seg";
            this.lbl_dec_seg.Size = new System.Drawing.Size(52, 23);
            this.lbl_dec_seg.TabIndex = 1;
            this.lbl_dec_seg.Text = ":00";
            // 
            // grb_opciones
            // 
            this.grb_opciones.Controls.Add(this.grb_vueltas);
            this.grb_opciones.Controls.Add(this.grb_Temporizador);
            this.grb_opciones.Controls.Add(this.rdb_temporizador);
            this.grb_opciones.Controls.Add(this.btn_reiniciar);
            this.grb_opciones.Controls.Add(this.rdb_cronometro);
            this.grb_opciones.Controls.Add(this.btn_inicio_pausa);
            this.grb_opciones.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_opciones.Location = new System.Drawing.Point(13, 50);
            this.grb_opciones.Name = "grb_opciones";
            this.grb_opciones.Size = new System.Drawing.Size(274, 127);
            this.grb_opciones.TabIndex = 2;
            this.grb_opciones.TabStop = false;
            this.grb_opciones.Text = "Tiempo";
            // 
            // grb_Temporizador
            // 
            this.grb_Temporizador.Controls.Add(this.lbl_segundos);
            this.grb_Temporizador.Controls.Add(this.lbl_minutos);
            this.grb_Temporizador.Controls.Add(this.lbl_hora);
            this.grb_Temporizador.Controls.Add(this.nud_hora);
            this.grb_Temporizador.Controls.Add(this.nud_minuto);
            this.grb_Temporizador.Controls.Add(this.nud_segundo);
            this.grb_Temporizador.Location = new System.Drawing.Point(137, 11);
            this.grb_Temporizador.Name = "grb_Temporizador";
            this.grb_Temporizador.Size = new System.Drawing.Size(129, 80);
            this.grb_Temporizador.TabIndex = 3;
            this.grb_Temporizador.TabStop = false;
            // 
            // lbl_segundos
            // 
            this.lbl_segundos.AutoSize = true;
            this.lbl_segundos.Location = new System.Drawing.Point(92, 35);
            this.lbl_segundos.Name = "lbl_segundos";
            this.lbl_segundos.Size = new System.Drawing.Size(31, 13);
            this.lbl_segundos.TabIndex = 5;
            this.lbl_segundos.Text = "Seg";
            // 
            // lbl_minutos
            // 
            this.lbl_minutos.AutoSize = true;
            this.lbl_minutos.Location = new System.Drawing.Point(51, 35);
            this.lbl_minutos.Name = "lbl_minutos";
            this.lbl_minutos.Size = new System.Drawing.Size(31, 13);
            this.lbl_minutos.TabIndex = 4;
            this.lbl_minutos.Text = "Min";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(10, 33);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(31, 13);
            this.lbl_hora.TabIndex = 3;
            this.lbl_hora.Text = "Hor";
            // 
            // nud_hora
            // 
            this.nud_hora.Location = new System.Drawing.Point(6, 10);
            this.nud_hora.Name = "nud_hora";
            this.nud_hora.Size = new System.Drawing.Size(35, 21);
            this.nud_hora.TabIndex = 2;
            this.nud_hora.ValueChanged += new System.EventHandler(this.nud_hora_ValueChanged);
            // 
            // nud_minuto
            // 
            this.nud_minuto.Location = new System.Drawing.Point(47, 10);
            this.nud_minuto.Name = "nud_minuto";
            this.nud_minuto.Size = new System.Drawing.Size(35, 21);
            this.nud_minuto.TabIndex = 1;
            this.nud_minuto.ValueChanged += new System.EventHandler(this.nud_minuto_ValueChanged);
            // 
            // nud_segundo
            // 
            this.nud_segundo.Location = new System.Drawing.Point(88, 10);
            this.nud_segundo.Name = "nud_segundo";
            this.nud_segundo.Size = new System.Drawing.Size(35, 21);
            this.nud_segundo.TabIndex = 0;
            this.nud_segundo.ValueChanged += new System.EventHandler(this.nud_segundo_ValueChanged);
            // 
            // rdb_temporizador
            // 
            this.rdb_temporizador.AutoSize = true;
            this.rdb_temporizador.Location = new System.Drawing.Point(10, 44);
            this.rdb_temporizador.Name = "rdb_temporizador";
            this.rdb_temporizador.Size = new System.Drawing.Size(121, 17);
            this.rdb_temporizador.TabIndex = 1;
            this.rdb_temporizador.TabStop = true;
            this.rdb_temporizador.Text = "Temporizador";
            this.rdb_temporizador.UseVisualStyleBackColor = true;
            this.rdb_temporizador.CheckedChanged += new System.EventHandler(this.rdb_temporizador_CheckedChanged);
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(137, 97);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(127, 23);
            this.btn_reiniciar.TabIndex = 2;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // rdb_cronometro
            // 
            this.rdb_cronometro.AutoSize = true;
            this.rdb_cronometro.Location = new System.Drawing.Point(10, 20);
            this.rdb_cronometro.Name = "rdb_cronometro";
            this.rdb_cronometro.Size = new System.Drawing.Size(105, 17);
            this.rdb_cronometro.TabIndex = 0;
            this.rdb_cronometro.TabStop = true;
            this.rdb_cronometro.Text = "Cronómetro";
            this.rdb_cronometro.UseVisualStyleBackColor = true;
            this.rdb_cronometro.CheckedChanged += new System.EventHandler(this.rdb_cronometro_CheckedChanged);
            // 
            // btn_inicio_pausa
            // 
            this.btn_inicio_pausa.Location = new System.Drawing.Point(6, 97);
            this.btn_inicio_pausa.Name = "btn_inicio_pausa";
            this.btn_inicio_pausa.Size = new System.Drawing.Size(125, 23);
            this.btn_inicio_pausa.TabIndex = 1;
            this.btn_inicio_pausa.Text = "Inicio";
            this.btn_inicio_pausa.UseVisualStyleBackColor = true;
            this.btn_inicio_pausa.Click += new System.EventHandler(this.btn_inicio_pausa_Click);
            // 
            // grb_vueltas
            // 
            this.grb_vueltas.Controls.Add(this.lbx_vueltas);
            this.grb_vueltas.Location = new System.Drawing.Point(137, 11);
            this.grb_vueltas.Name = "grb_vueltas";
            this.grb_vueltas.Size = new System.Drawing.Size(127, 80);
            this.grb_vueltas.TabIndex = 6;
            this.grb_vueltas.TabStop = false;
            this.grb_vueltas.Text = "Vueltas";
            // 
            // lbx_vueltas
            // 
            this.lbx_vueltas.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_vueltas.FormattingEnabled = true;
            this.lbx_vueltas.ItemHeight = 12;
            this.lbx_vueltas.Location = new System.Drawing.Point(6, 14);
            this.lbx_vueltas.Name = "lbx_vueltas";
            this.lbx_vueltas.Size = new System.Drawing.Size(115, 52);
            this.lbx_vueltas.TabIndex = 0;
            // 
            // pnl_indicador
            // 
            this.pnl_indicador.Location = new System.Drawing.Point(253, 18);
            this.pnl_indicador.Name = "pnl_indicador";
            this.pnl_indicador.Size = new System.Drawing.Size(25, 26);
            this.pnl_indicador.TabIndex = 3;
            // 
            // frm_timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 189);
            this.Controls.Add(this.pnl_indicador);
            this.Controls.Add(this.grb_opciones);
            this.Controls.Add(this.lbl_dec_seg);
            this.Controls.Add(this.lbl_tiempo);
            this.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frm_timer";
            this.Text = "EjemploTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb_opciones.ResumeLayout(false);
            this.grb_opciones.PerformLayout();
            this.grb_Temporizador.ResumeLayout(false);
            this.grb_Temporizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_segundo)).EndInit();
            this.grb_vueltas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_contador;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.Label lbl_dec_seg;
        private System.Windows.Forms.GroupBox grb_opciones;
        private System.Windows.Forms.RadioButton rdb_temporizador;
        private System.Windows.Forms.RadioButton rdb_cronometro;
        private System.Windows.Forms.GroupBox grb_Temporizador;
        private System.Windows.Forms.Label lbl_segundos;
        private System.Windows.Forms.Label lbl_minutos;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.NumericUpDown nud_hora;
        private System.Windows.Forms.NumericUpDown nud_minuto;
        private System.Windows.Forms.NumericUpDown nud_segundo;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.Button btn_inicio_pausa;
        private System.Windows.Forms.GroupBox grb_vueltas;
        private System.Windows.Forms.ListBox lbx_vueltas;
        private System.Windows.Forms.Panel pnl_indicador;
    }
}

