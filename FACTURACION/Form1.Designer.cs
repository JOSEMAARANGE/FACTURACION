namespace FACTURACION
{
    partial class AsientoContable
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
            this.components = new System.ComponentModel.Container();
            this.AsientoEnEdicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AsientoContableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGenerarInformeDetallado = new System.Windows.Forms.Button();
            this.Emitirbutton = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AsientoEnEdicionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsientoContableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AsientoEnEdicionBindingSource
            // 
            this.AsientoEnEdicionBindingSource.DataSource = typeof(ENTIDADES.CreditosDebitos);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(440, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(585, 292);
            this.dataGridView1.TabIndex = 3;
            // 
            // AsientoContableBindingSource
            // 
            this.AsientoContableBindingSource.DataSource = typeof(ENTIDADES.CreditosDebitos);
            // 
            // btnGenerarInformeDetallado
            // 
            this.btnGenerarInformeDetallado.Location = new System.Drawing.Point(461, 402);
            this.btnGenerarInformeDetallado.Name = "btnGenerarInformeDetallado";
            this.btnGenerarInformeDetallado.Size = new System.Drawing.Size(167, 23);
            this.btnGenerarInformeDetallado.TabIndex = 11;
            this.btnGenerarInformeDetallado.Text = "Generar Informe Detallado";
            this.btnGenerarInformeDetallado.UseVisualStyleBackColor = true;
            // 
            // Emitirbutton
            // 
            this.Emitirbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Emitirbutton.Location = new System.Drawing.Point(34, 402);
            this.Emitirbutton.Name = "Emitirbutton";
            this.Emitirbutton.Size = new System.Drawing.Size(75, 23);
            this.Emitirbutton.TabIndex = 12;
            this.Emitirbutton.Text = "EMITIR";
            this.Emitirbutton.UseVisualStyleBackColor = false;
            this.Emitirbutton.Click += new System.EventHandler(this.Emitirbutton_Click);
            // 
            // Salirbutton
            // 
            this.Salirbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Salirbutton.Location = new System.Drawing.Point(950, 415);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(75, 23);
            this.Salirbutton.TabIndex = 13;
            this.Salirbutton.Text = "SALIR";
            this.Salirbutton.UseVisualStyleBackColor = false;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // AsientoContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.Emitirbutton);
            this.Controls.Add(this.btnGenerarInformeDetallado);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AsientoContable";
            this.Text = "Asiento contable";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AsientoEnEdicionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsientoContableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerarInformeDetallado;
        private System.Windows.Forms.Button Emitirbutton;
        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.BindingSource AsientoContableBindingSource;
        private System.Windows.Forms.BindingSource AsientoEnEdicionBindingSource;
    }
}

