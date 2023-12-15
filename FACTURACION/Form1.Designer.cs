namespace FACTURACION
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
            this.motivoajusteLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MotivoAjusteComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FiltradofechasLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.FiltradoMotivoslabel = new System.Windows.Forms.Label();
            this.FiltradoMotivoComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // motivoajusteLabel
            // 
            this.motivoajusteLabel.AutoSize = true;
            this.motivoajusteLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivoajusteLabel.Location = new System.Drawing.Point(12, 45);
            this.motivoajusteLabel.Name = "motivoajusteLabel";
            this.motivoajusteLabel.Size = new System.Drawing.Size(122, 24);
            this.motivoajusteLabel.TabIndex = 0;
            this.motivoajusteLabel.Text = "Motivo del ajuste:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(327, 156);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // MotivoAjusteComboBox
            // 
            this.MotivoAjusteComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Errores en categoría",
            "Errores en lecturas ",
            "Error en condición de IVA"});
            this.MotivoAjusteComboBox.FormattingEnabled = true;
            this.MotivoAjusteComboBox.Items.AddRange(new object[] {
            "Errores en categoría",
            "Errores en lecturas",
            "Error en condición de IVA"});
            this.MotivoAjusteComboBox.Location = new System.Drawing.Point(140, 45);
            this.MotivoAjusteComboBox.Name = "MotivoAjusteComboBox";
            this.MotivoAjusteComboBox.Size = new System.Drawing.Size(266, 21);
            this.MotivoAjusteComboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 258);
            this.dataGridView1.TabIndex = 3;
            // 
            // FiltradofechasLabel
            // 
            this.FiltradofechasLabel.AutoSize = true;
            this.FiltradofechasLabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltradofechasLabel.Location = new System.Drawing.Point(3, 347);
            this.FiltradofechasLabel.Name = "FiltradofechasLabel";
            this.FiltradofechasLabel.Size = new System.Drawing.Size(107, 24);
            this.FiltradofechasLabel.TabIndex = 5;
            this.FiltradofechasLabel.Text = "Filtrado Fechas:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 364);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // FiltradoMotivoslabel
            // 
            this.FiltradoMotivoslabel.AutoSize = true;
            this.FiltradoMotivoslabel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltradoMotivoslabel.Location = new System.Drawing.Point(3, 405);
            this.FiltradoMotivoslabel.Name = "FiltradoMotivoslabel";
            this.FiltradoMotivoslabel.Size = new System.Drawing.Size(141, 24);
            this.FiltradoMotivoslabel.TabIndex = 8;
            this.FiltradoMotivoslabel.Text = "Filtrado Por Motivos:";
            // 
            // FiltradoMotivoComboBox
            // 
            this.FiltradoMotivoComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Errores en categoría",
            "Errores en lecturas ",
            "Error en condición de IVA"});
            this.FiltradoMotivoComboBox.FormattingEnabled = true;
            this.FiltradoMotivoComboBox.Items.AddRange(new object[] {
            "Errores en categoría",
            "Errores en lecturas",
            "Error en condición de IVA"});
            this.FiltradoMotivoComboBox.Location = new System.Drawing.Point(140, 405);
            this.FiltradoMotivoComboBox.Name = "FiltradoMotivoComboBox";
            this.FiltradoMotivoComboBox.Size = new System.Drawing.Size(266, 21);
            this.FiltradoMotivoComboBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FiltradoMotivoComboBox);
            this.Controls.Add(this.FiltradoMotivoslabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FiltradofechasLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MotivoAjusteComboBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.motivoajusteLabel);
            this.Name = "Form1";
            this.Text = "Creditos y debitos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label motivoajusteLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox MotivoAjusteComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FiltradofechasLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label FiltradoMotivoslabel;
        private System.Windows.Forms.ComboBox FiltradoMotivoComboBox;
    }
}

