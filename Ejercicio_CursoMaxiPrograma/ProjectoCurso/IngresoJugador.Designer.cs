namespace ProjectoCurso
{
    partial class frmIngresoJugador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboPosicion = new System.Windows.Forms.ComboBox();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.btnAltaImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posicion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Altura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Foto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(79, 58);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(79, 122);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 9;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(79, 154);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 10;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(79, 186);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(166, 20);
            this.txtFoto.TabIndex = 11;
            this.txtFoto.Leave += new System.EventHandler(this.txtFoto_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(75, 224);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(170, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboPosicion
            // 
            this.cboPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicion.FormattingEnabled = true;
            this.cboPosicion.Location = new System.Drawing.Point(79, 90);
            this.cboPosicion.Name = "cboPosicion";
            this.cboPosicion.Size = new System.Drawing.Size(121, 21);
            this.cboPosicion.TabIndex = 14;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(311, 24);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(259, 222);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 15;
            this.pbxFoto.TabStop = false;
            // 
            // btnAltaImg
            // 
            this.btnAltaImg.Location = new System.Drawing.Point(251, 184);
            this.btnAltaImg.Name = "btnAltaImg";
            this.btnAltaImg.Size = new System.Drawing.Size(39, 23);
            this.btnAltaImg.TabIndex = 16;
            this.btnAltaImg.Text = "+";
            this.btnAltaImg.UseVisualStyleBackColor = true;
            this.btnAltaImg.Click += new System.EventHandler(this.btnAltaImg_Click);
            // 
            // frmIngresoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 259);
            this.Controls.Add(this.btnAltaImg);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.cboPosicion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIngresoJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AGREGAR NUEVO JUGADOR";
            this.Load += new System.EventHandler(this.frmIngresoJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboPosicion;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Button btnAltaImg;
    }
}