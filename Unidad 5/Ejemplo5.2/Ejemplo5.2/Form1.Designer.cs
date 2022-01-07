namespace Ejemplo5._2
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nudBb = new System.Windows.Forms.NumericUpDown();
            this.nudBg = new System.Windows.Forms.NumericUpDown();
            this.nudBr = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nudGb = new System.Windows.Forms.NumericUpDown();
            this.nudGg = new System.Windows.Forms.NumericUpDown();
            this.nudGr = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudRb = new System.Windows.Forms.NumericUpDown();
            this.nudRg = new System.Windows.Forms.NumericUpDown();
            this.nudRr = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_resolucion = new System.Windows.Forms.ComboBox();
            this.btn_camara = new System.Windows.Forms.Button();
            this.cbx_camaras = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.videoSourceCaptura = new AForge.Controls.VideoSourcePlayer();
            this.videoSourceR = new System.Windows.Forms.PictureBox();
            this.videoSourceG = new System.Windows.Forms.PictureBox();
            this.videoSourceB = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBr)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGr)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(456, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 110);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calibración";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.nudBb);
            this.groupBox7.Controls.Add(this.nudBg);
            this.groupBox7.Controls.Add(this.nudBr);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(224, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(91, 92);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Blue";
            // 
            // nudBb
            // 
            this.nudBb.Location = new System.Drawing.Point(6, 66);
            this.nudBb.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBb.Name = "nudBb";
            this.nudBb.Size = new System.Drawing.Size(78, 20);
            this.nudBb.TabIndex = 5;
            this.nudBb.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nudBg
            // 
            this.nudBg.Location = new System.Drawing.Point(6, 41);
            this.nudBg.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBg.Name = "nudBg";
            this.nudBg.Size = new System.Drawing.Size(78, 20);
            this.nudBg.TabIndex = 4;
            this.nudBg.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nudBr
            // 
            this.nudBr.Location = new System.Drawing.Point(6, 17);
            this.nudBr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBr.Name = "nudBr";
            this.nudBr.Size = new System.Drawing.Size(78, 20);
            this.nudBr.TabIndex = 3;
            this.nudBr.Value = new decimal(new int[] {
            27,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nudGb);
            this.groupBox6.Controls.Add(this.nudGg);
            this.groupBox6.Controls.Add(this.nudGr);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(118, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(91, 92);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Green";
            // 
            // nudGb
            // 
            this.nudGb.Location = new System.Drawing.Point(6, 66);
            this.nudGb.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGb.Name = "nudGb";
            this.nudGb.Size = new System.Drawing.Size(78, 20);
            this.nudGb.TabIndex = 5;
            this.nudGb.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nudGg
            // 
            this.nudGg.Location = new System.Drawing.Point(6, 41);
            this.nudGg.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGg.Name = "nudGg";
            this.nudGg.Size = new System.Drawing.Size(78, 20);
            this.nudGg.TabIndex = 4;
            this.nudGg.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nudGr
            // 
            this.nudGr.Location = new System.Drawing.Point(6, 17);
            this.nudGr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGr.Name = "nudGr";
            this.nudGr.Size = new System.Drawing.Size(78, 20);
            this.nudGr.TabIndex = 3;
            this.nudGr.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudRb);
            this.groupBox5.Controls.Add(this.nudRg);
            this.groupBox5.Controls.Add(this.nudRr);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(6, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(91, 92);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Red";
            // 
            // nudRb
            // 
            this.nudRb.Location = new System.Drawing.Point(6, 66);
            this.nudRb.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRb.Name = "nudRb";
            this.nudRb.Size = new System.Drawing.Size(78, 20);
            this.nudRb.TabIndex = 5;
            this.nudRb.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudRg
            // 
            this.nudRg.Location = new System.Drawing.Point(6, 41);
            this.nudRg.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRg.Name = "nudRg";
            this.nudRg.Size = new System.Drawing.Size(78, 20);
            this.nudRg.TabIndex = 4;
            this.nudRg.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudRr
            // 
            this.nudRr.Location = new System.Drawing.Point(6, 17);
            this.nudRr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRr.Name = "nudRr";
            this.nudRr.Size = new System.Drawing.Size(78, 20);
            this.nudRr.TabIndex = 3;
            this.nudRr.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbx_resolucion);
            this.groupBox1.Controls.Add(this.btn_camara);
            this.groupBox1.Controls.Add(this.cbx_camaras);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 110);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión Cámara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(333, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 62);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // cbx_resolucion
            // 
            this.cbx_resolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_resolucion.FormattingEnabled = true;
            this.cbx_resolucion.Location = new System.Drawing.Point(201, 18);
            this.cbx_resolucion.Name = "cbx_resolucion";
            this.cbx_resolucion.Size = new System.Drawing.Size(127, 21);
            this.cbx_resolucion.TabIndex = 4;
            // 
            // btn_camara
            // 
            this.btn_camara.Location = new System.Drawing.Point(7, 44);
            this.btn_camara.Name = "btn_camara";
            this.btn_camara.Size = new System.Drawing.Size(321, 23);
            this.btn_camara.TabIndex = 2;
            this.btn_camara.Text = "Conectar Cámara";
            this.btn_camara.UseVisualStyleBackColor = true;
            this.btn_camara.Click += new System.EventHandler(this.btn_camara_Click);
            // 
            // cbx_camaras
            // 
            this.cbx_camaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_camaras.FormattingEnabled = true;
            this.cbx_camaras.Location = new System.Drawing.Point(7, 19);
            this.cbx_camaras.Name = "cbx_camaras";
            this.cbx_camaras.Size = new System.Drawing.Size(188, 21);
            this.cbx_camaras.TabIndex = 0;
            this.cbx_camaras.SelectedIndexChanged += new System.EventHandler(this.cbx_camaras_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.videoSourceB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoSourceG, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoSourceR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoSourceCaptura, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 129);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 497);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // videoSourceCaptura
            // 
            this.videoSourceCaptura.Location = new System.Drawing.Point(3, 3);
            this.videoSourceCaptura.Name = "videoSourceCaptura";
            this.videoSourceCaptura.Size = new System.Drawing.Size(376, 242);
            this.videoSourceCaptura.TabIndex = 0;
            this.videoSourceCaptura.Text = "videoSourcePlayer1";
            this.videoSourceCaptura.VideoSource = null;
            // 
            // videoSourceR
            // 
            this.videoSourceR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourceR.Location = new System.Drawing.Point(385, 3);
            this.videoSourceR.Name = "videoSourceR";
            this.videoSourceR.Size = new System.Drawing.Size(377, 242);
            this.videoSourceR.TabIndex = 3;
            this.videoSourceR.TabStop = false;
            this.videoSourceR.DoubleClick += new System.EventHandler(this.videoSourceR_DoubleClick);
            // 
            // videoSourceG
            // 
            this.videoSourceG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourceG.Location = new System.Drawing.Point(3, 251);
            this.videoSourceG.Name = "videoSourceG";
            this.videoSourceG.Size = new System.Drawing.Size(376, 243);
            this.videoSourceG.TabIndex = 14;
            this.videoSourceG.TabStop = false;
            this.videoSourceG.DoubleClick += new System.EventHandler(this.videoSourceG_DoubleClick);
            // 
            // videoSourceB
            // 
            this.videoSourceB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourceB.Location = new System.Drawing.Point(385, 251);
            this.videoSourceB.Name = "videoSourceB";
            this.videoSourceB.Size = new System.Drawing.Size(377, 243);
            this.videoSourceB.TabIndex = 15;
            this.videoSourceB.TabStop = false;
            this.videoSourceB.DoubleClick += new System.EventHandler(this.videoSourceB_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBr)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGr)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown nudBb;
        private System.Windows.Forms.NumericUpDown nudBg;
        private System.Windows.Forms.NumericUpDown nudBr;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nudGb;
        private System.Windows.Forms.NumericUpDown nudGg;
        private System.Windows.Forms.NumericUpDown nudGr;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nudRb;
        private System.Windows.Forms.NumericUpDown nudRg;
        private System.Windows.Forms.NumericUpDown nudRr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_resolucion;
        private System.Windows.Forms.Button btn_camara;
        private System.Windows.Forms.ComboBox cbx_camaras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox videoSourceB;
        private System.Windows.Forms.PictureBox videoSourceG;
        private System.Windows.Forms.PictureBox videoSourceR;
        private AForge.Controls.VideoSourcePlayer videoSourceCaptura;
    }
}

