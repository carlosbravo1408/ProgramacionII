namespace Ejemplo1._1
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
            this.lbl_texto = new System.Windows.Forms.Label();
            this.txt_ingreso = new System.Windows.Forms.TextBox();
            this.rch_mensaje = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Location = new System.Drawing.Point(12, 9);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(72, 13);
            this.lbl_texto.TabIndex = 4;
            this.lbl_texto.Text = "Texto Ingreso";
            // 
            // txt_ingreso
            // 
            this.txt_ingreso.Location = new System.Drawing.Point(89, 6);
            this.txt_ingreso.Name = "txt_ingreso";
            this.txt_ingreso.Size = new System.Drawing.Size(185, 20);
            this.txt_ingreso.TabIndex = 3;
            this.txt_ingreso.TextChanged += new System.EventHandler(this.txt_ingreso_TextChanged);
            // 
            // rch_mensaje
            // 
            this.rch_mensaje.Location = new System.Drawing.Point(13, 32);
            this.rch_mensaje.Name = "rch_mensaje";
            this.rch_mensaje.Size = new System.Drawing.Size(259, 218);
            this.rch_mensaje.TabIndex = 5;
            this.rch_mensaje.Text = "";
            // 
            // frm_acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rch_mensaje);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.txt_ingreso);
            this.Name = "frm_acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_acceso_FormClosing);
            this.Load += new System.EventHandler(this.frm_acceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.TextBox txt_ingreso;
        private System.Windows.Forms.RichTextBox rch_mensaje;
    }
}