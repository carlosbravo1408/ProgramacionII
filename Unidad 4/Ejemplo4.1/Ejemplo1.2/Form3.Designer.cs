namespace Ejemplo1._2
{
    partial class frm_Usuario_nuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contraseña2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cod_prioridad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcb_usuario = new System.Windows.Forms.PictureBox();
            this.pcb_contraseña1 = new System.Windows.Forms.PictureBox();
            this.pcb_contraseña2 = new System.Windows.Forms.PictureBox();
            this.pcb_codigo = new System.Windows.Forms.PictureBox();
            this.btn_Crear_Usuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_contraseña1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_contraseña2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_codigo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(103, 6);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(169, 20);
            this.txt_usuario.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_usuario, "Ingrese un Usuario Válido");
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // txt_contraseña1
            // 
            this.txt_contraseña1.Enabled = false;
            this.txt_contraseña1.Location = new System.Drawing.Point(103, 32);
            this.txt_contraseña1.Name = "txt_contraseña1";
            this.txt_contraseña1.PasswordChar = '*';
            this.txt_contraseña1.Size = new System.Drawing.Size(169, 20);
            this.txt_contraseña1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_contraseña1, "Ingrese una contraseña");
            this.txt_contraseña1.TextChanged += new System.EventHandler(this.txt_contraseña1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txt_contraseña2
            // 
            this.txt_contraseña2.Enabled = false;
            this.txt_contraseña2.Location = new System.Drawing.Point(103, 58);
            this.txt_contraseña2.Name = "txt_contraseña2";
            this.txt_contraseña2.PasswordChar = '*';
            this.txt_contraseña2.Size = new System.Drawing.Size(169, 20);
            this.txt_contraseña2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txt_contraseña2, "Repita la contraseña");
            this.txt_contraseña2.TextChanged += new System.EventHandler(this.txt_contraseña2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repita Contraseña";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(103, 84);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(169, 20);
            this.txt_nombre.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txt_nombre, "Ingrese un Nombre");
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre(s)";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Location = new System.Drawing.Point(103, 110);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(169, 20);
            this.txt_apellido.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txt_apellido, "Ingrese su(s) apellido(s)");
            this.txt_apellido.TextChanged += new System.EventHandler(this.apellido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido(s)";
            // 
            // txt_cod_prioridad
            // 
            this.txt_cod_prioridad.Enabled = false;
            this.txt_cod_prioridad.Location = new System.Drawing.Point(103, 136);
            this.txt_cod_prioridad.Name = "txt_cod_prioridad";
            this.txt_cod_prioridad.PasswordChar = 'x';
            this.txt_cod_prioridad.Size = new System.Drawing.Size(169, 20);
            this.txt_cod_prioridad.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txt_cod_prioridad, "0875 Prioridad de 1\r\n4567 Prioridad de 2\r\n3451 Prioridad de 3\r\n1789 Prioridad de " +
        "4\r\notros o vacio Prioridad de 0");
            this.txt_cod_prioridad.TextChanged += new System.EventHandler(this.txt_cod_prioridad_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Código Designado";
            // 
            // pcb_usuario
            // 
            this.pcb_usuario.Location = new System.Drawing.Point(273, 6);
            this.pcb_usuario.Name = "pcb_usuario";
            this.pcb_usuario.Size = new System.Drawing.Size(25, 25);
            this.pcb_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_usuario.TabIndex = 14;
            this.pcb_usuario.TabStop = false;
            // 
            // pcb_contraseña1
            // 
            this.pcb_contraseña1.Location = new System.Drawing.Point(273, 32);
            this.pcb_contraseña1.Name = "pcb_contraseña1";
            this.pcb_contraseña1.Size = new System.Drawing.Size(25, 25);
            this.pcb_contraseña1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_contraseña1.TabIndex = 15;
            this.pcb_contraseña1.TabStop = false;
            // 
            // pcb_contraseña2
            // 
            this.pcb_contraseña2.Location = new System.Drawing.Point(273, 58);
            this.pcb_contraseña2.Name = "pcb_contraseña2";
            this.pcb_contraseña2.Size = new System.Drawing.Size(25, 25);
            this.pcb_contraseña2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_contraseña2.TabIndex = 16;
            this.pcb_contraseña2.TabStop = false;
            // 
            // pcb_codigo
            // 
            this.pcb_codigo.Location = new System.Drawing.Point(273, 136);
            this.pcb_codigo.Name = "pcb_codigo";
            this.pcb_codigo.Size = new System.Drawing.Size(25, 25);
            this.pcb_codigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_codigo.TabIndex = 19;
            this.pcb_codigo.TabStop = false;
            // 
            // btn_Crear_Usuario
            // 
            this.btn_Crear_Usuario.Enabled = false;
            this.btn_Crear_Usuario.Location = new System.Drawing.Point(15, 167);
            this.btn_Crear_Usuario.Name = "btn_Crear_Usuario";
            this.btn_Crear_Usuario.Size = new System.Drawing.Size(282, 23);
            this.btn_Crear_Usuario.TabIndex = 22;
            this.btn_Crear_Usuario.Text = "Crear Usuario";
            this.btn_Crear_Usuario.UseVisualStyleBackColor = true;
            this.btn_Crear_Usuario.Click += new System.EventHandler(this.btn_Crear_Usuario_Click);
            // 
            // frm_Usuario_nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(309, 201);
            this.Controls.Add(this.btn_Crear_Usuario);
            this.Controls.Add(this.pcb_codigo);
            this.Controls.Add(this.pcb_contraseña2);
            this.Controls.Add(this.pcb_contraseña1);
            this.Controls.Add(this.pcb_usuario);
            this.Controls.Add(this.txt_cod_prioridad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_contraseña2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_contraseña1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Usuario_nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Usuario_nuevo_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_contraseña1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_contraseña2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_codigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contraseña2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cod_prioridad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pcb_usuario;
        private System.Windows.Forms.PictureBox pcb_contraseña1;
        private System.Windows.Forms.PictureBox pcb_contraseña2;
        private System.Windows.Forms.PictureBox pcb_codigo;
        private System.Windows.Forms.Button btn_Crear_Usuario;
    }
}