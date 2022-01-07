namespace Ejemplo1._5
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_generar = new System.Windows.Forms.Button();
            this.nud_intervalo = new System.Windows.Forms.NumericUpDown();
            this.chrt_grafica_barra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nud_maximo = new System.Windows.Forms.NumericUpDown();
            this.tmr_intervalo = new System.Windows.Forms.Timer(this.components);
            this.tlt_objetos = new System.Windows.Forms.ToolTip(this.components);
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.sst_barra_estado = new System.Windows.Forms.StatusStrip();
            this.tss_lbl_Velocidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_prb_intermitencia = new System.Windows.Forms.ToolStripProgressBar();
            this.chrt_grafico_circular = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.nud_intervalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafica_barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maximo)).BeginInit();
            this.sst_barra_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafico_circular)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(445, 83);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.Text = "Generar";
            this.tlt_objetos.SetToolTip(this.btn_generar, "Iniciar Secuencia, o pausarla");
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // nud_intervalo
            // 
            this.nud_intervalo.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_intervalo.Location = new System.Drawing.Point(445, 31);
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
            this.nud_intervalo.TabIndex = 1;
            this.tlt_objetos.SetToolTip(this.nud_intervalo, "Intervalo de tiempo de muestreo");
            this.nud_intervalo.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_intervalo.ValueChanged += new System.EventHandler(this.nud_intervalo_ValueChanged);
            // 
            // chrt_grafica_barra
            // 
            chartArea1.Name = "chrt_area_lineas";
            this.chrt_grafica_barra.ChartAreas.Add(chartArea1);
            legend1.Name = "leyenda_lineas";
            this.chrt_grafica_barra.Legends.Add(legend1);
            this.chrt_grafica_barra.Location = new System.Drawing.Point(12, 165);
            this.chrt_grafica_barra.Name = "chrt_grafica_barra";
            series1.ChartArea = "chrt_area_lineas";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "leyenda_lineas";
            series1.Name = "lineas1";
            series1.ToolTip = "Valor1";
            series2.ChartArea = "chrt_area_lineas";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "leyenda_lineas";
            series2.Name = "lineas2";
            series2.ToolTip = "Valor2";
            series3.ChartArea = "chrt_area_lineas";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "leyenda_lineas";
            series3.Name = "lineas3";
            series3.ToolTip = "Valor3";
            this.chrt_grafica_barra.Series.Add(series1);
            this.chrt_grafica_barra.Series.Add(series2);
            this.chrt_grafica_barra.Series.Add(series3);
            this.chrt_grafica_barra.Size = new System.Drawing.Size(508, 217);
            this.chrt_grafica_barra.TabIndex = 2;
            this.chrt_grafica_barra.Text = "Gráficas";
            // 
            // nud_maximo
            // 
            this.nud_maximo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_maximo.Location = new System.Drawing.Point(445, 57);
            this.nud_maximo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_maximo.Name = "nud_maximo";
            this.nud_maximo.Size = new System.Drawing.Size(75, 20);
            this.nud_maximo.TabIndex = 3;
            this.tlt_objetos.SetToolTip(this.nud_maximo, "Valor máximo de la generación randómica\r\nRecuerde: \r\nQue los valores aleatorios s" +
        "e generan desde 0 hasta el máximo que se establezca en este control");
            this.nud_maximo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_maximo.ValueChanged += new System.EventHandler(this.nud_maximo_ValueChanged);
            // 
            // tmr_intervalo
            // 
            this.tmr_intervalo.Tick += new System.EventHandler(this.tmr_intervalo_Tick);
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(445, 112);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_reiniciar.TabIndex = 6;
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
            this.sst_barra_estado.TabIndex = 5;
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
            // chrt_grafico_circular
            // 
            chartArea2.Name = "chrt_area_circular";
            this.chrt_grafico_circular.ChartAreas.Add(chartArea2);
            legend2.Name = "leyenda_circular";
            this.chrt_grafico_circular.Legends.Add(legend2);
            this.chrt_grafico_circular.Location = new System.Drawing.Point(12, 12);
            this.chrt_grafico_circular.Name = "chrt_grafico_circular";
            series4.ChartArea = "chrt_area_circular";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "leyenda_circular";
            series4.Name = "circular1";
            this.chrt_grafico_circular.Series.Add(series4);
            this.chrt_grafico_circular.Size = new System.Drawing.Size(427, 147);
            this.chrt_grafico_circular.TabIndex = 7;
            this.chrt_grafico_circular.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 407);
            this.Controls.Add(this.chrt_grafico_circular);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.sst_barra_estado);
            this.Controls.Add(this.nud_maximo);
            this.Controls.Add(this.chrt_grafica_barra);
            this.Controls.Add(this.nud_intervalo);
            this.Controls.Add(this.btn_generar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_intervalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafica_barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maximo)).EndInit();
            this.sst_barra_estado.ResumeLayout(false);
            this.sst_barra_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_grafico_circular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.NumericUpDown nud_intervalo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_grafica_barra;
        private System.Windows.Forms.NumericUpDown nud_maximo;
        private System.Windows.Forms.Timer tmr_intervalo;
        private System.Windows.Forms.ToolTip tlt_objetos;
        private System.Windows.Forms.StatusStrip sst_barra_estado;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_Velocidad;
        private System.Windows.Forms.ToolStripProgressBar tss_prb_intermitencia;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_grafico_circular;
    }
}

