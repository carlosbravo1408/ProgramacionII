﻿namespace Ejemplo1._2
{
    partial class frm_ingreso
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
            this.chx_verPass = new System.Windows.Forms.CheckBox();
            this.btn_contraseña = new System.Windows.Forms.Button();
            this.msk_contraseña = new System.Windows.Forms.MaskedTextBox();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chx_verPass
            // 
            this.chx_verPass.AutoSize = true;
            this.chx_verPass.Location = new System.Drawing.Point(12, 63);
            this.chx_verPass.Name = "chx_verPass";
            this.chx_verPass.Size = new System.Drawing.Size(99, 17);
            this.chx_verPass.TabIndex = 11;
            this.chx_verPass.Text = "Ver Contraseña";
            this.chx_verPass.UseVisualStyleBackColor = true;
            this.chx_verPass.CheckedChanged += new System.EventHandler(this.chx_verPass_CheckedChanged);
            // 
            // btn_contraseña
            // 
            this.btn_contraseña.Location = new System.Drawing.Point(12, 79);
            this.btn_contraseña.Name = "btn_contraseña";
            this.btn_contraseña.Size = new System.Drawing.Size(226, 23);
            this.btn_contraseña.TabIndex = 10;
            this.btn_contraseña.Text = "Contraseña";
            this.btn_contraseña.UseVisualStyleBackColor = true;
            this.btn_contraseña.Click += new System.EventHandler(this.btn_contraseña_Click);
            // 
            // msk_contraseña
            // 
            this.msk_contraseña.Location = new System.Drawing.Point(72, 37);
            this.msk_contraseña.Name = "msk_contraseña";
            this.msk_contraseña.PasswordChar = '*';
            this.msk_contraseña.Size = new System.Drawing.Size(166, 20);
            this.msk_contraseña.TabIndex = 9;
            this.msk_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_contraseña_KeyPress);
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(12, 40);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_contraseña.TabIndex = 8;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(72, 10);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(166, 20);
            this.txt_usuario.TabIndex = 7;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(13, 13);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 6;
            this.lbl_usuario.Text = "Usuario";
            // 
            // frm_ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(250, 112);
            this.Controls.Add(this.chx_verPass);
            this.Controls.Add(this.btn_contraseña);
            this.Controls.Add(this.msk_contraseña);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frm_ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.frm_ingreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chx_verPass;
        private System.Windows.Forms.Button btn_contraseña;
        private System.Windows.Forms.MaskedTextBox msk_contraseña;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
    }
}

