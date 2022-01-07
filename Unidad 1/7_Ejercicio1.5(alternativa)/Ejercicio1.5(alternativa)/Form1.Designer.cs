namespace Ejercicio1._5_alternativa_
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.sst_barra_estado = new System.Windows.Forms.StatusStrip();
            this.tss_lbl_Velocidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_prb_intermitencia = new System.Windows.Forms.ToolStripProgressBar();
            this.nud_maximo = new System.Windows.Forms.NumericUpDown();
            this.nud_intervalo = new System.Windows.Forms.NumericUpDown();
            this.btn_generar = new System.Windows.Forms.Button();
            this.tlt_objetos = new System.Windows.Forms.ToolTip(this.components);
            this.tmr_intervalo = new System.Windows.Forms.Timer(this.components);
            this.chrt_Graficos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sst_barra_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_intervalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Graficos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(445, 199);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_reiniciar.TabIndex = 11;
            this.btn_reiniciar.Text = "Reiniciar";
            this.tlt_objetos.SetToolTip(this.btn_reiniciar, "Reiniciar la tabla");
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // sst_barra_estado
            // 
            this.sst_barra_estado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_lbl_Velocidad,
            this.tss_prb_intermitencia});
            this.sst_barra_estado.Location = new System.Drawing.Point(0, 385);
            this.sst_barra_estado.Name = "sst_barra_estado";
            this.sst_barra_estado.Size = new System.Drawing.Size(532, 22);
            this.sst_barra_estado.TabIndex = 10;
            this.sst_barra_estado.Text = "statusStrip1";
            // 
            // tss_lbl_Velocidad
            // 
            this.tss_lbl_Velocidad.Name = "tss_lbl_Velocidad";
            this.tss_lbl_Velocidad.Size = new System.Drawing.Size(118, 17);
            this.tss_lbl_Velocidad.Text = "toolStripStatusLabel1";
            // 
            // tss_prb_intermitencia
            // 
            this.tss_prb_intermitencia.Name = "tss_prb_intermitencia";
            this.tss_prb_intermitencia.Size = new System.Drawing.Size(100, 16);
            // 
            // nud_maximo
            // 
            this.nud_maximo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_maximo.Location = new System.Drawing.Point(445, 144);
            this.nud_maximo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_maximo.Name = "nud_maximo";
            this.nud_maximo.Size = new System.Drawing.Size(75, 20);
            this.nud_maximo.TabIndex = 9;
            this.tlt_objetos.SetToolTip(this.nud_maximo, "Valor máximo de la generación randómica\r\nRecuerde: \r\nQue los valores aleatorios s" +
        "e generan desde 0 hasta el máximo que se establezca en este control");
            this.nud_maximo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_maximo.ValueChanged += new System.EventHandler(this.nud_maximo_ValueChanged);
            // 
            // nud_intervalo
            // 
            this.nud_intervalo.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_intervalo.Location = new System.Drawing.Point(445, 118);
            this.nud_intervalo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_intervalo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_intervalo.Name = "nud_intervalo";
            this.nud_intervalo.Size = new System.Drawing.Size(75, 20);
            this.nud_intervalo.TabIndex = 8;
            this.tlt_objetos.SetToolTip(this.nud_intervalo, "Intervalo de tiempo de muestreo");
            this.nud_intervalo.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_intervalo.ValueChanged += new System.EventHandler(this.nud_intervalo_ValueChanged);
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(445, 170);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 7;
            this.btn_generar.Text = "Generar";
            this.tlt_objetos.SetToolTip(this.btn_generar, "Iniciar Secuencia, o pausarla");
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // tmr_intervalo
            // 
            this.tmr_intervalo.Tick += new System.EventHandler(this.tmr_intervalo_Tick);
            // 
            // chrt_Graficos
            // 
            chartArea1.Name = "Líneas";
            chartArea2.Name = "Barras";
            this.chrt_Graficos.ChartAreas.Add(chartArea1);
            this.chrt_Graficos.ChartAreas.Add(chartArea2);
            legend1.Name = "LeyendaLineas";
            legend1.Title = "Líneas";
            legend2.Name = "LeyendaCircular";
            legend2.Title = "Circular";
            this.chrt_Graficos.Legends.Add(legend1);
            this.chrt_Graficos.Legends.Add(legend2);
            this.chrt_Graficos.Location = new System.Drawing.Point(13, 13);
            this.chrt_Graficos.Name = "chrt_Graficos";
            series1.ChartArea = "Líneas";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "LeyendaLineas";
            series1.Name = "Linea1";
            series2.ChartArea = "Líneas";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "LeyendaLineas";
            series2.Name = "Linea2";
            series3.ChartArea = "Líneas";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "LeyendaLineas";
            series3.Name = "Linea3";
            series4.ChartArea = "Barras";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "LeyendaCircular";
            series4.Name = "Circulo1";
            this.chrt_Graficos.Series.Add(series1);
            this.chrt_Graficos.Series.Add(series2);
            this.chrt_Graficos.Series.Add(series3);
            this.chrt_Graficos.Series.Add(series4);
            this.chrt_Graficos.Size = new System.Drawing.Size(426, 369);
            this.chrt_Graficos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 407);
            this.Controls.Add(this.chrt_Graficos);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.sst_barra_estado);
            this.Controls.Add(this.nud_maximo);
            this.Controls.Add(this.nud_intervalo);
            this.Controls.Add(this.btn_generar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sst_barra_estado.ResumeLayout(false);
            this.sst_barra_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_intervalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Graficos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.ToolTip tlt_objetos;
        private System.Windows.Forms.StatusStrip sst_barra_estado;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_Velocidad;
        private System.Windows.Forms.ToolStripProgressBar tss_prb_intermitencia;
        private System.Windows.Forms.NumericUpDown nud_maximo;
        private System.Windows.Forms.NumericUpDown nud_intervalo;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Timer tmr_intervalo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_Graficos;

    }
}

