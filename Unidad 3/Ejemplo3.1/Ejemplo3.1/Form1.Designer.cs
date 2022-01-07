namespace Ejemplo3._1
{
    partial class frm_conexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_conexion));
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.txt_dato_a_enviar = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.grb_gestorConexion = new System.Windows.Forms.GroupBox();
            this.nud_COM = new System.Windows.Forms.NumericUpDown();
            this.lbl_COM = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.grb_metodos_envio = new System.Windows.Forms.GroupBox();
            this.rdb_writeline = new System.Windows.Forms.RadioButton();
            this.rdb_writeString = new System.Windows.Forms.RadioButton();
            this.rdb_write_byte = new System.Windows.Forms.RadioButton();
            this.ttp_ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.rch_datoRecibido = new System.Windows.Forms.RichTextBox();
            this.lbl_ayuda = new System.Windows.Forms.Label();
            this.grb_gestorConexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COM)).BeginInit();
            this.grb_metodos_envio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_dato_a_enviar
            // 
            this.txt_dato_a_enviar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dato_a_enviar.Location = new System.Drawing.Point(12, 88);
            this.txt_dato_a_enviar.Name = "txt_dato_a_enviar";
            this.txt_dato_a_enviar.Size = new System.Drawing.Size(128, 20);
            this.txt_dato_a_enviar.TabIndex = 10;
            this.ttp_ayuda.SetToolTip(this.txt_dato_a_enviar, "Aquí ingrese lo que desea enviar");
            this.txt_dato_a_enviar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dato_a_enviar_KeyPress);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Enabled = false;
            this.btn_enviar.Location = new System.Drawing.Point(11, 114);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(129, 27);
            this.btn_enviar.TabIndex = 9;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // grb_gestorConexion
            // 
            this.grb_gestorConexion.Controls.Add(this.nud_COM);
            this.grb_gestorConexion.Controls.Add(this.lbl_COM);
            this.grb_gestorConexion.Controls.Add(this.btnConectar);
            this.grb_gestorConexion.Location = new System.Drawing.Point(12, 12);
            this.grb_gestorConexion.Name = "grb_gestorConexion";
            this.grb_gestorConexion.Size = new System.Drawing.Size(129, 71);
            this.grb_gestorConexion.TabIndex = 8;
            this.grb_gestorConexion.TabStop = false;
            this.grb_gestorConexion.Text = "Gestor de Conexión";
            this.ttp_ayuda.SetToolTip(this.grb_gestorConexion, "Velocidad de conexion predefinida 9600");
            // 
            // nud_COM
            // 
            this.nud_COM.Location = new System.Drawing.Point(62, 19);
            this.nud_COM.Name = "nud_COM";
            this.nud_COM.Size = new System.Drawing.Size(39, 20);
            this.nud_COM.TabIndex = 3;
            this.nud_COM.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_COM
            // 
            this.lbl_COM.AutoSize = true;
            this.lbl_COM.Location = new System.Drawing.Point(22, 21);
            this.lbl_COM.Name = "lbl_COM";
            this.lbl_COM.Size = new System.Drawing.Size(34, 13);
            this.lbl_COM.TabIndex = 2;
            this.lbl_COM.Text = "COM:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(6, 45);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(117, 21);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar!";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // grb_metodos_envio
            // 
            this.grb_metodos_envio.Controls.Add(this.rdb_writeline);
            this.grb_metodos_envio.Controls.Add(this.rdb_writeString);
            this.grb_metodos_envio.Controls.Add(this.rdb_write_byte);
            this.grb_metodos_envio.Enabled = false;
            this.grb_metodos_envio.Location = new System.Drawing.Point(12, 147);
            this.grb_metodos_envio.Name = "grb_metodos_envio";
            this.grb_metodos_envio.Size = new System.Drawing.Size(128, 84);
            this.grb_metodos_envio.TabIndex = 11;
            this.grb_metodos_envio.TabStop = false;
            this.grb_metodos_envio.Text = "Métodos de Envío";
            // 
            // rdb_writeline
            // 
            this.rdb_writeline.AutoSize = true;
            this.rdb_writeline.Location = new System.Drawing.Point(7, 63);
            this.rdb_writeline.Name = "rdb_writeline";
            this.rdb_writeline.Size = new System.Drawing.Size(109, 17);
            this.rdb_writeline.TabIndex = 2;
            this.rdb_writeline.Text = "Método WriteLine";
            this.ttp_ayuda.SetToolTip(this.rdb_writeline, "Envio de la cadena ingresada con un bit de salto de línea al final");
            this.rdb_writeline.UseVisualStyleBackColor = true;
            // 
            // rdb_writeString
            // 
            this.rdb_writeString.AutoSize = true;
            this.rdb_writeString.Location = new System.Drawing.Point(7, 39);
            this.rdb_writeString.Name = "rdb_writeString";
            this.rdb_writeString.Size = new System.Drawing.Size(119, 17);
            this.rdb_writeString.TabIndex = 1;
            this.rdb_writeString.Text = "Método Write String";
            this.ttp_ayuda.SetToolTip(this.rdb_writeString, "Envio de la cadena ingresada");
            this.rdb_writeString.UseVisualStyleBackColor = true;
            // 
            // rdb_write_byte
            // 
            this.rdb_write_byte.AutoSize = true;
            this.rdb_write_byte.Checked = true;
            this.rdb_write_byte.Location = new System.Drawing.Point(7, 15);
            this.rdb_write_byte.Name = "rdb_write_byte";
            this.rdb_write_byte.Size = new System.Drawing.Size(113, 17);
            this.rdb_write_byte.TabIndex = 0;
            this.rdb_write_byte.TabStop = true;
            this.rdb_write_byte.Text = "Método Write Byte";
            this.ttp_ayuda.SetToolTip(this.rdb_write_byte, "Valores a enviar 0-255 en valores enteros");
            this.rdb_write_byte.UseVisualStyleBackColor = true;
            // 
            // rch_datoRecibido
            // 
            this.rch_datoRecibido.Location = new System.Drawing.Point(146, 12);
            this.rch_datoRecibido.Name = "rch_datoRecibido";
            this.rch_datoRecibido.ReadOnly = true;
            this.rch_datoRecibido.Size = new System.Drawing.Size(130, 219);
            this.rch_datoRecibido.TabIndex = 12;
            this.rch_datoRecibido.Text = "";
            this.ttp_ayuda.SetToolTip(this.rch_datoRecibido, "Aquí verá lo que envia Arduino solo para el Método Write enviando un Byte");
            // 
            // lbl_ayuda
            // 
            this.lbl_ayuda.AutoSize = true;
            this.lbl_ayuda.Location = new System.Drawing.Point(8, 234);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(249, 78);
            this.lbl_ayuda.TabIndex = 13;
            this.lbl_ayuda.Text = resources.GetString("lbl_ayuda.Text");
            // 
            // frm_conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 314);
            this.Controls.Add(this.lbl_ayuda);
            this.Controls.Add(this.rch_datoRecibido);
            this.Controls.Add(this.grb_metodos_envio);
            this.Controls.Add(this.txt_dato_a_enviar);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.grb_gestorConexion);
            this.Name = "frm_conexion";
            this.Text = "Form1";
            this.ttp_ayuda.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.grb_gestorConexion.ResumeLayout(false);
            this.grb_gestorConexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COM)).EndInit();
            this.grb_metodos_envio.ResumeLayout(false);
            this.grb_metodos_envio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.TextBox txt_dato_a_enviar;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.GroupBox grb_gestorConexion;
        private System.Windows.Forms.NumericUpDown nud_COM;
        private System.Windows.Forms.Label lbl_COM;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.GroupBox grb_metodos_envio;
        private System.Windows.Forms.RadioButton rdb_writeline;
        private System.Windows.Forms.RadioButton rdb_writeString;
        private System.Windows.Forms.RadioButton rdb_write_byte;
        private System.Windows.Forms.ToolTip ttp_ayuda;
        private System.Windows.Forms.RichTextBox rch_datoRecibido;
        private System.Windows.Forms.Label lbl_ayuda;
    }
}

