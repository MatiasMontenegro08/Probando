namespace EjerciciosBasicos_08
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
            this.txtPU = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubT = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRECIO UNITARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CANTIDAD:";
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(165, 31);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(100, 20);
            this.txtPU.TabIndex = 2;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(165, 64);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(24, 112);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(240, 37);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SUBTOTAL:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(21, 213);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(91, 13);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "DESCUENTO  %:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TOTAL:";
            // 
            // txtSubT
            // 
            this.txtSubT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSubT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubT.Enabled = false;
            this.txtSubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubT.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSubT.Location = new System.Drawing.Point(165, 185);
            this.txtSubT.Name = "txtSubT";
            this.txtSubT.Size = new System.Drawing.Size(100, 15);
            this.txtSubT.TabIndex = 8;
            this.txtSubT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDesc.Location = new System.Drawing.Point(165, 211);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 15);
            this.txtDesc.TabIndex = 9;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Location = new System.Drawing.Point(165, 237);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 15);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 269);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtSubT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcular Precio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubT;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

