namespace ProjectoCurso
{
    partial class frmPrincipal
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
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFijo = new System.Windows.Forms.Button();
            this.btnEliminarLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanilla
            // 
            this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlanilla.Location = new System.Drawing.Point(17, 18);
            this.dgvPlanilla.MultiSelect = false;
            this.dgvPlanilla.Name = "dgvPlanilla";
            this.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanilla.Size = new System.Drawing.Size(372, 234);
            this.dgvPlanilla.TabIndex = 0;
            this.dgvPlanilla.SelectionChanged += new System.EventHandler(this.dgvPlanilla_SelectionChanged);
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(398, 18);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(248, 233);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 1;
            this.pbxFoto.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 258);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(112, 258);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFijo
            // 
            this.btnEliminarFijo.Location = new System.Drawing.Point(204, 258);
            this.btnEliminarFijo.Name = "btnEliminarFijo";
            this.btnEliminarFijo.Size = new System.Drawing.Size(91, 23);
            this.btnEliminarFijo.TabIndex = 4;
            this.btnEliminarFijo.Text = "ELIMINAR FIJO";
            this.btnEliminarFijo.UseVisualStyleBackColor = true;
            this.btnEliminarFijo.Click += new System.EventHandler(this.btnEliminarFijo_Click);
            // 
            // btnEliminarLog
            // 
            this.btnEliminarLog.Location = new System.Drawing.Point(312, 258);
            this.btnEliminarLog.Name = "btnEliminarLog";
            this.btnEliminarLog.Size = new System.Drawing.Size(109, 23);
            this.btnEliminarLog.TabIndex = 5;
            this.btnEliminarLog.Text = "ELIMINAR LÓGICO";
            this.btnEliminarLog.UseVisualStyleBackColor = true;
            this.btnEliminarLog.Click += new System.EventHandler(this.btnEliminarLog_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 292);
            this.Controls.Add(this.btnEliminarLog);
            this.Controls.Add(this.btnEliminarFijo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.dgvPlanilla);
            this.Name = "frmPrincipal";
            this.Text = "PLANILLA JUGADORES";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFijo;
        private System.Windows.Forms.Button btnEliminarLog;
    }
}

