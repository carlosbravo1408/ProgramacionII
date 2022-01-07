namespace Ejemplo3._2
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
            this.btn_led1 = new System.Windows.Forms.Button();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.cbx_Puerto = new System.Windows.Forms.ComboBox();
            this.btn_led2 = new System.Windows.Forms.Button();
            this.btn_encendido_apagado = new System.Windows.Forms.Button();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.lbl_ayuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_led1
            // 
            this.btn_led1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_led1.Location = new System.Drawing.Point(13, 41);
            this.btn_led1.Name = "btn_led1";
            this.btn_led1.Size = new System.Drawing.Size(161, 77);
            this.btn_led1.TabIndex = 6;
            this.btn_led1.Text = "Led 1";
            this.btn_led1.UseVisualStyleBackColor = true;
            this.btn_led1.Click += new System.EventHandler(this.btn_led1_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(200, 11);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 5;
            this.btn_conectar.Text = "conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // cbx_Puerto
            // 
            this.cbx_Puerto.FormattingEnabled = true;
            this.cbx_Puerto.Location = new System.Drawing.Point(13, 14);
            this.cbx_Puerto.Name = "cbx_Puerto";
            this.cbx_Puerto.Size = new System.Drawing.Size(181, 21);
            this.cbx_Puerto.TabIndex = 4;
            // 
            // btn_led2
            // 
            this.btn_led2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_led2.Location = new System.Drawing.Point(12, 124);
            this.btn_led2.Name = "btn_led2";
            this.btn_led2.Size = new System.Drawing.Size(162, 77);
            this.btn_led2.TabIndex = 7;
            this.btn_led2.Text = "Led 2 ";
            this.btn_led2.UseVisualStyleBackColor = true;
            this.btn_led2.Click += new System.EventHandler(this.btn_led2_Click);
            // 
            // btn_encendido_apagado
            // 
            this.btn_encendido_apagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encendido_apagado.Location = new System.Drawing.Point(180, 40);
            this.btn_encendido_apagado.Name = "btn_encendido_apagado";
            this.btn_encendido_apagado.Size = new System.Drawing.Size(95, 161);
            this.btn_encendido_apagado.TabIndex = 8;
            this.btn_encendido_apagado.Text = "ON";
            this.btn_encendido_apagado.UseVisualStyleBackColor = true;
            this.btn_encendido_apagado.Click += new System.EventHandler(this.btn_encendido_apagado_Click);
            // 
            // lbl_ayuda
            // 
            this.lbl_ayuda.AutoSize = true;
            this.lbl_ayuda.Location = new System.Drawing.Point(12, 204);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(219, 26);
            this.lbl_ayuda.TabIndex = 14;
            this.lbl_ayuda.Text = "Por favor cargue este código \r\n_03_RecepcionUnicoDatoUnicoCaracter.ino\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 233);
            this.Controls.Add(this.lbl_ayuda);
            this.Controls.Add(this.btn_encendido_apagado);
            this.Controls.Add(this.btn_led2);
            this.Controls.Add(this.btn_led1);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.cbx_Puerto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_led1;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.ComboBox cbx_Puerto;
        private System.Windows.Forms.Button btn_led2;
        private System.Windows.Forms.Button btn_encendido_apagado;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.Label lbl_ayuda;
    }
}

