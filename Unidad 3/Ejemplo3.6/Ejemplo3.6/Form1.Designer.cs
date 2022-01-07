namespace Ejemplo3._6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ttp_ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbx_sensor3 = new System.Windows.Forms.ListBox();
            this.lbx_sensor2 = new System.Windows.Forms.ListBox();
            this.lbx_sensor1 = new System.Windows.Forms.ListBox();
            this.lbx_sensor4 = new System.Windows.Forms.ListBox();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_enviar_dato = new System.Windows.Forms.Button();
            this.lb_servo = new System.Windows.Forms.Label();
            this.tkb_servo = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tkb_b = new System.Windows.Forms.TrackBar();
            this.tkb_g = new System.Windows.Forms.TrackBar();
            this.tkb_r = new System.Windows.Forms.TrackBar();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_g = new System.Windows.Forms.Label();
            this.lbl_r = new System.Windows.Forms.Label();
            this.pnl_Color = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tst_menu_conexion = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_Puerto = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_servo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_r)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_sensor3
            // 
            this.lbx_sensor3.FormattingEnabled = true;
            this.lbx_sensor3.Location = new System.Drawing.Point(243, 172);
            this.lbx_sensor3.Name = "lbx_sensor3";
            this.lbx_sensor3.Size = new System.Drawing.Size(42, 147);
            this.lbx_sensor3.TabIndex = 34;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor3, "Datos Sensor 3");
            // 
            // lbx_sensor2
            // 
            this.lbx_sensor2.FormattingEnabled = true;
            this.lbx_sensor2.Location = new System.Drawing.Point(195, 172);
            this.lbx_sensor2.Name = "lbx_sensor2";
            this.lbx_sensor2.Size = new System.Drawing.Size(42, 147);
            this.lbx_sensor2.TabIndex = 33;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor2, "Datos Sensor 2");
            // 
            // lbx_sensor1
            // 
            this.lbx_sensor1.FormattingEnabled = true;
            this.lbx_sensor1.Location = new System.Drawing.Point(147, 172);
            this.lbx_sensor1.Name = "lbx_sensor1";
            this.lbx_sensor1.Size = new System.Drawing.Size(42, 147);
            this.lbx_sensor1.TabIndex = 32;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor1, "Datos Sensor 1");
            // 
            // lbx_sensor4
            // 
            this.lbx_sensor4.FormattingEnabled = true;
            this.lbx_sensor4.Location = new System.Drawing.Point(291, 172);
            this.lbx_sensor4.Name = "lbx_sensor4";
            this.lbx_sensor4.Size = new System.Drawing.Size(42, 147);
            this.lbx_sensor4.TabIndex = 35;
            this.ttp_ayuda.SetToolTip(this.lbx_sensor4, "Datos Sensor 3");
            // 
            // Arduino
            // 
            this.Arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Arduino_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 362);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(302, 35);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Por favor cargue este código:\r\n_10_EnvioRecepcionMultiplesDatosByte.ino\r\n";
            // 
            // btn_enviar_dato
            // 
            this.btn_enviar_dato.Enabled = false;
            this.btn_enviar_dato.Location = new System.Drawing.Point(320, 362);
            this.btn_enviar_dato.Name = "btn_enviar_dato";
            this.btn_enviar_dato.Size = new System.Drawing.Size(85, 35);
            this.btn_enviar_dato.TabIndex = 30;
            this.btn_enviar_dato.Text = "Enviar Dato";
            this.btn_enviar_dato.UseVisualStyleBackColor = true;
            this.btn_enviar_dato.Click += new System.EventHandler(this.btn_enviar_dato_Click);
            // 
            // lb_servo
            // 
            this.lb_servo.AutoSize = true;
            this.lb_servo.Location = new System.Drawing.Point(358, 336);
            this.lb_servo.Name = "lb_servo";
            this.lb_servo.Size = new System.Drawing.Size(47, 13);
            this.lb_servo.TabIndex = 29;
            this.lb_servo.Text = "lb_servo";
            // 
            // tkb_servo
            // 
            this.tkb_servo.Location = new System.Drawing.Point(361, 49);
            this.tkb_servo.Maximum = 180;
            this.tkb_servo.Name = "tkb_servo";
            this.tkb_servo.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_servo.Size = new System.Drawing.Size(45, 284);
            this.tkb_servo.TabIndex = 28;
            this.tkb_servo.Scroll += new System.EventHandler(this.tkb_servo_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbx_sensor4);
            this.groupBox1.Controls.Add(this.lbx_sensor3);
            this.groupBox1.Controls.Add(this.lbx_sensor2);
            this.groupBox1.Controls.Add(this.lbx_sensor1);
            this.groupBox1.Controls.Add(this.tkb_b);
            this.groupBox1.Controls.Add(this.tkb_g);
            this.groupBox1.Controls.Add(this.tkb_r);
            this.groupBox1.Controls.Add(this.lbl_b);
            this.groupBox1.Controls.Add(this.lbl_g);
            this.groupBox1.Controls.Add(this.lbl_r);
            this.groupBox1.Controls.Add(this.pnl_Color);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 326);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COLOR";
            // 
            // tkb_b
            // 
            this.tkb_b.Location = new System.Drawing.Point(112, 19);
            this.tkb_b.Maximum = 255;
            this.tkb_b.Name = "tkb_b";
            this.tkb_b.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_b.Size = new System.Drawing.Size(45, 284);
            this.tkb_b.TabIndex = 21;
            this.tkb_b.Scroll += new System.EventHandler(this.tkb_b_Scroll);
            // 
            // tkb_g
            // 
            this.tkb_g.Location = new System.Drawing.Point(59, 19);
            this.tkb_g.Maximum = 255;
            this.tkb_g.Name = "tkb_g";
            this.tkb_g.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_g.Size = new System.Drawing.Size(45, 284);
            this.tkb_g.TabIndex = 20;
            this.tkb_g.Scroll += new System.EventHandler(this.tkb_g_Scroll);
            // 
            // tkb_r
            // 
            this.tkb_r.Location = new System.Drawing.Point(6, 19);
            this.tkb_r.Maximum = 255;
            this.tkb_r.Name = "tkb_r";
            this.tkb_r.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_r.Size = new System.Drawing.Size(45, 284);
            this.tkb_r.TabIndex = 19;
            this.tkb_r.Scroll += new System.EventHandler(this.tkb_r_Scroll);
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(109, 306);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(29, 13);
            this.lbl_b.TabIndex = 7;
            this.lbl_b.Text = "lbl_b";
            // 
            // lbl_g
            // 
            this.lbl_g.AutoSize = true;
            this.lbl_g.Location = new System.Drawing.Point(56, 306);
            this.lbl_g.Name = "lbl_g";
            this.lbl_g.Size = new System.Drawing.Size(29, 13);
            this.lbl_g.TabIndex = 6;
            this.lbl_g.Text = "lbl_g";
            // 
            // lbl_r
            // 
            this.lbl_r.AutoSize = true;
            this.lbl_r.Location = new System.Drawing.Point(3, 306);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(26, 13);
            this.lbl_r.TabIndex = 5;
            this.lbl_r.Text = "lbl_r";
            // 
            // pnl_Color
            // 
            this.pnl_Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Color.BackgroundImage")));
            this.pnl_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Color.Location = new System.Drawing.Point(162, 19);
            this.pnl_Color.Name = "pnl_Color";
            this.pnl_Color.Size = new System.Drawing.Size(150, 150);
            this.pnl_Color.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_menu_conexion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tst_menu_conexion
            // 
            this.tst_menu_conexion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbx_Puerto});
            this.tst_menu_conexion.Name = "tst_menu_conexion";
            this.tst_menu_conexion.Size = new System.Drawing.Size(77, 20);
            this.tst_menu_conexion.Text = "Dispositivo";
            // 
            // cbx_Puerto
            // 
            this.cbx_Puerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Puerto.Name = "cbx_Puerto";
            this.cbx_Puerto.Size = new System.Drawing.Size(121, 23);
            this.cbx_Puerto.SelectedIndexChanged += new System.EventHandler(this.cbx_Puerto_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 401);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_enviar_dato);
            this.Controls.Add(this.lb_servo);
            this.Controls.Add(this.tkb_servo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Ejemplo3.6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkb_servo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_r)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttp_ayuda;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_enviar_dato;
        private System.Windows.Forms.Label lb_servo;
        private System.Windows.Forms.TrackBar tkb_servo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbx_sensor4;
        private System.Windows.Forms.ListBox lbx_sensor3;
        private System.Windows.Forms.ListBox lbx_sensor2;
        private System.Windows.Forms.ListBox lbx_sensor1;
        private System.Windows.Forms.TrackBar tkb_b;
        private System.Windows.Forms.TrackBar tkb_g;
        private System.Windows.Forms.TrackBar tkb_r;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_g;
        private System.Windows.Forms.Label lbl_r;
        private System.Windows.Forms.Panel pnl_Color;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tst_menu_conexion;
        private System.Windows.Forms.ToolStripComboBox cbx_Puerto;
    }
}

