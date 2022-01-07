namespace Hola_CSharp
{
    partial class frm_inicial
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
            this.btn_mensaje = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mensaje
            // 
            this.btn_mensaje.Location = new System.Drawing.Point(64, 12);
            this.btn_mensaje.Name = "btn_mensaje";
            this.btn_mensaje.Size = new System.Drawing.Size(75, 23);
            this.btn_mensaje.TabIndex = 0;
            this.btn_mensaje.Text = ":|";
            this.btn_mensaje.UseVisualStyleBackColor = true;
            this.btn_mensaje.Click += new System.EventHandler(this.btn_mensaje_Click);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(78, 73);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(19, 13);
            this.lbl_mensaje.TabIndex = 1;
            this.lbl_mensaje.Text = "._.";
            // 
            // frm_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 110);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.btn_mensaje);
            this.Name = "frm_inicial";
            this.Text = "Hola C#";
            this.Load += new System.EventHandler(this.frm_inicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mensaje;
        private System.Windows.Forms.Label lbl_mensaje;
    }
}

