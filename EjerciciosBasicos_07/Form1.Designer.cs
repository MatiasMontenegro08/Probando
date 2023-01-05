namespace EjerciciosBasicos_07
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodAlu = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 3";
            // 
            // cbxMateria
            // 
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(88, 94);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(164, 21);
            this.cbxMateria.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCodAlu
            // 
            this.txtCodAlu.Location = new System.Drawing.Point(88, 52);
            this.txtCodAlu.Name = "txtCodAlu";
            this.txtCodAlu.Size = new System.Drawing.Size(164, 20);
            this.txtCodAlu.TabIndex = 1;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(35, 162);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(52, 20);
            this.txtNota1.TabIndex = 3;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(121, 162);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(52, 20);
            this.txtNota2.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(31, 193);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(226, 36);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(205, 162);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(52, 20);
            this.txtNota3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Código:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 242);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtCodAlu);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Promedio Alumno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodAlu;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label6;
    }
}

