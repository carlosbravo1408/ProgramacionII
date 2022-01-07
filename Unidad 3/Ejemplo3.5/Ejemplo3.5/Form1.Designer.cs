namespace Ejemplo3._5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tst_menu_conexion = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_Puerto = new System.Windows.Forms.ToolStripComboBox();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.ttp_ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tkb_b = new System.Windows.Forms.TrackBar();
            this.tkb_g = new System.Windows.Forms.TrackBar();
            this.tkb_r = new System.Windows.Forms.TrackBar();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_g = new System.Windows.Forms.Label();
            this.lbl_r = new System.Windows.Forms.Label();
            this.pnl_Color = new System.Windows.Forms.Panel();
            this.btn_enviar_dato = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rch_cadena = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_r)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_menu_conexion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(316, 24);
            this.menuStrip1.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rch_cadena);
            this.groupBox1.Controls.Add(this.tkb_b);
            this.groupBox1.Controls.Add(this.tkb_g);
            this.groupBox1.Controls.Add(this.tkb_r);
            this.groupBox1.Controls.Add(this.lbl_b);
            this.groupBox1.Controls.Add(this.lbl_g);
            this.groupBox1.Controls.Add(this.lbl_r);
            this.groupBox1.Controls.Add(this.pnl_Color);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 326);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COLOR";
            // 
            // tkb_b
            // 
            this.tkb_b.Location = new System.Drawing.Point(108, 19);
            this.tkb_b.Maximum = 255;
            this.tkb_b.Name = "tkb_b";
            this.tkb_b.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_b.Size = new System.Drawing.Size(45, 284);
            this.tkb_b.TabIndex = 21;
            this.tkb_b.Scroll += new System.EventHandler(this.tkb_b_Scroll);
            // 
            // tkb_g
            // 
            this.tkb_g.Location = new System.Drawing.Point(57, 19);
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
            this.lbl_b.Location = new System.Drawing.Point(105, 306);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(29, 13);
            this.lbl_b.TabIndex = 7;
            this.lbl_b.Text = "lbl_b";
            // 
            // lbl_g
            // 
            this.lbl_g.AutoSize = true;
            this.lbl_g.Location = new System.Drawing.Point(54, 306);
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
            this.pnl_Color.Location = new System.Drawing.Point(159, 19);
            this.pnl_Color.Name = "pnl_Color";
            this.pnl_Color.Size = new System.Drawing.Size(120, 120);
            this.pnl_Color.TabIndex = 8;
            // 
            // btn_enviar_dato
            // 
            this.btn_enviar_dato.Enabled = false;
            this.btn_enviar_dato.Location = new System.Drawing.Point(230, 359);
            this.btn_enviar_dato.Name = "btn_enviar_dato";
            this.btn_enviar_dato.Size = new System.Drawing.Size(75, 35);
            this.btn_enviar_dato.TabIndex = 24;
            this.btn_enviar_dato.Text = "Enviar Dato";
            this.btn_enviar_dato.UseVisualStyleBackColor = true;
            this.btn_enviar_dato.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 359);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(215, 35);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Por favor cargue este código:\r\n_09_RecepcionMultiplesDatosByte.ino\r\n";
            // 
            // rch_cadena
            // 
            this.rch_cadena.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rch_cadena.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_cadena.ForeColor = System.Drawing.SystemColors.Info;
            this.rch_cadena.Location = new System.Drawing.Point(159, 146);
            this.rch_cadena.Name = "rch_cadena";
            this.rch_cadena.ReadOnly = true;
            this.rch_cadena.Size = new System.Drawing.Size(120, 174);
            this.rch_cadena.TabIndex = 22;
            this.rch_cadena.Text = "";
            this.ttp_ayuda.SetToolTip(this.rch_cadena, "Dato(s) enviados.");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 401);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_enviar_dato);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_r)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tst_menu_conexion;
        private System.Windows.Forms.ToolStripComboBox cbx_Puerto;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.ToolTip ttp_ayuda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tkb_b;
        private System.Windows.Forms.TrackBar tkb_g;
        private System.Windows.Forms.TrackBar tkb_r;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_g;
        private System.Windows.Forms.Label lbl_r;
        private System.Windows.Forms.Panel pnl_Color;
        private System.Windows.Forms.Button btn_enviar_dato;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rch_cadena;

    }
}

