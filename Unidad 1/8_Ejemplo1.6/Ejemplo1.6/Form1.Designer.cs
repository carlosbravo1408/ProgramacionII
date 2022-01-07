namespace Ejemplo1._6
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
            this.pnl_area_dibujo = new System.Windows.Forms.Panel();
            this.pbx_area_dibujo = new System.Windows.Forms.PictureBox();
            this.grb_area_dibujo = new System.Windows.Forms.GroupBox();
            this.txt_magnitud = new System.Windows.Forms.TextBox();
            this.lbl_Magnitud = new System.Windows.Forms.Label();
            this.lbl_angulo = new System.Windows.Forms.Label();
            this.txt_angulo = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lbl_c = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.btn_graficar = new System.Windows.Forms.Button();
            this.tlt_areas_graficas = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_posicion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_area_dibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_area_dibujo
            // 
            this.pnl_area_dibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_area_dibujo.Location = new System.Drawing.Point(10, 10);
            this.pnl_area_dibujo.Name = "pnl_area_dibujo";
            this.pnl_area_dibujo.Size = new System.Drawing.Size(350, 350);
            this.pnl_area_dibujo.TabIndex = 0;
            this.tlt_areas_graficas.SetToolTip(this.pnl_area_dibujo, "Grafico en panel");
            this.pnl_area_dibujo.Click += new System.EventHandler(this.pnl_area_dibujo_Click);
            this.pnl_area_dibujo.DoubleClick += new System.EventHandler(this.pnl_area_dibujo_DoubleClick);
            this.pnl_area_dibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_area_dibujo_MouseMove);
            // 
            // pbx_area_dibujo
            // 
            this.pbx_area_dibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_area_dibujo.Location = new System.Drawing.Point(370, 10);
            this.pbx_area_dibujo.Name = "pbx_area_dibujo";
            this.pbx_area_dibujo.Size = new System.Drawing.Size(350, 350);
            this.pbx_area_dibujo.TabIndex = 1;
            this.pbx_area_dibujo.TabStop = false;
            this.tlt_areas_graficas.SetToolTip(this.pbx_area_dibujo, "Grafico en PictureBox");
            this.pbx_area_dibujo.Click += new System.EventHandler(this.pbx_area_dibujo_Click);
            this.pbx_area_dibujo.DoubleClick += new System.EventHandler(this.pbx_area_dibujo_DoubleClick);
            this.pbx_area_dibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbx_area_dibujo_MouseMove);
            // 
            // grb_area_dibujo
            // 
            this.grb_area_dibujo.Location = new System.Drawing.Point(730, 10);
            this.grb_area_dibujo.Name = "grb_area_dibujo";
            this.grb_area_dibujo.Size = new System.Drawing.Size(350, 350);
            this.grb_area_dibujo.TabIndex = 2;
            this.grb_area_dibujo.TabStop = false;
            this.grb_area_dibujo.Text = "GroupBox";
            this.tlt_areas_graficas.SetToolTip(this.grb_area_dibujo, "Grafico en GroupBox");
            // 
            // txt_magnitud
            // 
            this.txt_magnitud.Location = new System.Drawing.Point(1139, 12);
            this.txt_magnitud.Name = "txt_magnitud";
            this.txt_magnitud.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_magnitud.Size = new System.Drawing.Size(41, 20);
            this.txt_magnitud.TabIndex = 3;
            this.txt_magnitud.Text = "1";
            // 
            // lbl_Magnitud
            // 
            this.lbl_Magnitud.AutoSize = true;
            this.lbl_Magnitud.Location = new System.Drawing.Point(1082, 15);
            this.lbl_Magnitud.Name = "lbl_Magnitud";
            this.lbl_Magnitud.Size = new System.Drawing.Size(51, 13);
            this.lbl_Magnitud.TabIndex = 4;
            this.lbl_Magnitud.Text = "Magnitud";
            this.lbl_Magnitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_angulo
            // 
            this.lbl_angulo.AutoSize = true;
            this.lbl_angulo.Location = new System.Drawing.Point(1093, 38);
            this.lbl_angulo.Name = "lbl_angulo";
            this.lbl_angulo.Size = new System.Drawing.Size(40, 13);
            this.lbl_angulo.TabIndex = 6;
            this.lbl_angulo.Text = "Ángulo";
            this.lbl_angulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_angulo
            // 
            this.txt_angulo.Location = new System.Drawing.Point(1139, 35);
            this.txt_angulo.Name = "txt_angulo";
            this.txt_angulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_angulo.Size = new System.Drawing.Size(41, 20);
            this.txt_angulo.TabIndex = 5;
            this.txt_angulo.Text = "45";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(1097, 75);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(36, 13);
            this.lbl_a.TabIndex = 8;
            this.lbl_a.Text = "a(x^2)";
            this.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(1139, 72);
            this.txt_a.Name = "txt_a";
            this.txt_a.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_a.Size = new System.Drawing.Size(41, 20);
            this.txt_a.TabIndex = 7;
            this.txt_a.Text = "1";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(1109, 97);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(24, 13);
            this.lbl_b.TabIndex = 10;
            this.lbl_b.Text = "b(x)";
            this.lbl_b.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(1139, 94);
            this.txt_b.Name = "txt_b";
            this.txt_b.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_b.Size = new System.Drawing.Size(41, 20);
            this.txt_b.TabIndex = 9;
            this.txt_b.Text = "0";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(1120, 120);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(13, 13);
            this.lbl_c.TabIndex = 12;
            this.lbl_c.Text = "c";
            this.lbl_c.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(1139, 117);
            this.txt_c.Name = "txt_c";
            this.txt_c.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_c.Size = new System.Drawing.Size(41, 20);
            this.txt_c.TabIndex = 11;
            this.txt_c.Text = "0";
            // 
            // btn_graficar
            // 
            this.btn_graficar.Location = new System.Drawing.Point(1085, 143);
            this.btn_graficar.Name = "btn_graficar";
            this.btn_graficar.Size = new System.Drawing.Size(95, 23);
            this.btn_graficar.TabIndex = 13;
            this.btn_graficar.Text = "Graficar";
            this.btn_graficar.UseVisualStyleBackColor = true;
            this.btn_graficar.Click += new System.EventHandler(this.btn_graficar_Click);
            // 
            // tlt_areas_graficas
            // 
            this.tlt_areas_graficas.IsBalloon = true;
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.AutoSize = true;
            this.lbl_posicion.Location = new System.Drawing.Point(1096, 173);
            this.lbl_posicion.Name = "lbl_posicion";
            this.lbl_posicion.Size = new System.Drawing.Size(48, 13);
            this.lbl_posicion.TabIndex = 14;
            this.lbl_posicion.Text = "X: 0 Y: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1188, 372);
            this.Controls.Add(this.lbl_posicion);
            this.Controls.Add(this.btn_graficar);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.lbl_angulo);
            this.Controls.Add(this.txt_angulo);
            this.Controls.Add(this.lbl_Magnitud);
            this.Controls.Add(this.txt_magnitud);
            this.Controls.Add(this.grb_area_dibujo);
            this.Controls.Add(this.pbx_area_dibujo);
            this.Controls.Add(this.pnl_area_dibujo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_area_dibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_area_dibujo;
        private System.Windows.Forms.PictureBox pbx_area_dibujo;
        private System.Windows.Forms.GroupBox grb_area_dibujo;
        private System.Windows.Forms.ToolTip tlt_areas_graficas;
        private System.Windows.Forms.TextBox txt_magnitud;
        private System.Windows.Forms.Label lbl_Magnitud;
        private System.Windows.Forms.Label lbl_angulo;
        private System.Windows.Forms.TextBox txt_angulo;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Button btn_graficar;
        private System.Windows.Forms.Label lbl_posicion;
    }
}

