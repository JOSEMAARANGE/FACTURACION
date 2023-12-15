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
            this.components = new System.ComponentModel.Container();
            this.motivoajusteLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MotivoAjusteComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FiltradofechasLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.FiltradoMotivoslabel = new System.Windows.Forms.Label();
            this.FiltradoMotivoComboBox = new System.Windows.Forms.ComboBox();
            this.NotaExplicativaLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Emitirbutton = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreditosyDebitosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motivoDelAjusteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaExplicativaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditoDebitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnEdicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosyDebitosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnEdicionBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // motivoajusteLabel
            // 
            this.motivoajusteLabel.AutoSize = true;
            this.motivoajusteLabel.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivoajusteLabel.Location = new System.Drawing.Point(8, 56);
            this.motivoajusteLabel.Name = "motivoajusteLabel";
            this.motivoajusteLabel.Size = new System.Drawing.Size(109, 21);
            this.motivoajusteLabel.TabIndex = 0;
            this.motivoajusteLabel.Text = "Motivo del ajuste:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EnEdicionBindingSource, "NotaExplicativa", true));
            this.richTextBox1.Location = new System.Drawing.Point(12, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(377, 156);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // MotivoAjusteComboBox
            // 
            this.MotivoAjusteComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Errores en categoría",
            "Errores en lecturas ",
            "Error en condición de IVA"});
            this.MotivoAjusteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EnEdicionBindingSource, "MotivoDelAjuste", true));
            this.MotivoAjusteComboBox.FormattingEnabled = true;
            this.MotivoAjusteComboBox.Items.AddRange(new object[] {
            "Errores en categoría",
            "Errores en lecturas",
            "Error en condición de IVA"});
            this.MotivoAjusteComboBox.Location = new System.Drawing.Point(123, 54);
            this.MotivoAjusteComboBox.Name = "MotivoAjusteComboBox";
            this.MotivoAjusteComboBox.Size = new System.Drawing.Size(266, 21);
            this.MotivoAjusteComboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.motivoDelAjusteDataGridViewTextBoxColumn,
            this.notaExplicativaDataGridViewTextBoxColumn,
            this.creditoDebitoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.CreditosyDebitosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(440, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 292);
            this.dataGridView1.TabIndex = 3;
            // 
            // FiltradofechasLabel
            // 
            this.FiltradofechasLabel.AutoSize = true;
            this.FiltradofechasLabel.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltradofechasLabel.Location = new System.Drawing.Point(10, 34);
            this.FiltradofechasLabel.Name = "FiltradofechasLabel";
            this.FiltradofechasLabel.Size = new System.Drawing.Size(95, 21);
            this.FiltradofechasLabel.TabIndex = 5;
            this.FiltradofechasLabel.Text = "Filtrado Fechas:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(135, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // FiltradoMotivoslabel
            // 
            this.FiltradoMotivoslabel.AutoSize = true;
            this.FiltradoMotivoslabel.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltradoMotivoslabel.Location = new System.Drawing.Point(6, 16);
            this.FiltradoMotivoslabel.Name = "FiltradoMotivoslabel";
            this.FiltradoMotivoslabel.Size = new System.Drawing.Size(125, 21);
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
            this.FiltradoMotivoComboBox.Location = new System.Drawing.Point(132, 14);
            this.FiltradoMotivoComboBox.Name = "FiltradoMotivoComboBox";
            this.FiltradoMotivoComboBox.Size = new System.Drawing.Size(199, 21);
            this.FiltradoMotivoComboBox.TabIndex = 9;
            // 
            // NotaExplicativaLabel
            // 
            this.NotaExplicativaLabel.AutoSize = true;
            this.NotaExplicativaLabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaExplicativaLabel.Location = new System.Drawing.Point(15, 86);
            this.NotaExplicativaLabel.Name = "NotaExplicativaLabel";
            this.NotaExplicativaLabel.Size = new System.Drawing.Size(93, 20);
            this.NotaExplicativaLabel.TabIndex = 10;
            this.NotaExplicativaLabel.Text = "Nota Explicativa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generar Informe Detallado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Emitirbutton
            // 
            this.Emitirbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Emitirbutton.Location = new System.Drawing.Point(23, 270);
            this.Emitirbutton.Name = "Emitirbutton";
            this.Emitirbutton.Size = new System.Drawing.Size(75, 23);
            this.Emitirbutton.TabIndex = 12;
            this.Emitirbutton.Text = "EMITIR";
            this.Emitirbutton.UseVisualStyleBackColor = false;
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
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.FiltradofechasLabel);
            this.groupBox1.Location = new System.Drawing.Point(40, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 88);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // CreditosyDebitosBindingSource
            // 
            this.CreditosyDebitosBindingSource.DataSource = typeof(ENTIDADES.CreditosDebitos);
            // 
            // motivoDelAjusteDataGridViewTextBoxColumn
            // 
            this.motivoDelAjusteDataGridViewTextBoxColumn.DataPropertyName = "MotivoDelAjuste";
            this.motivoDelAjusteDataGridViewTextBoxColumn.HeaderText = "MotivoDelAjuste";
            this.motivoDelAjusteDataGridViewTextBoxColumn.Name = "motivoDelAjusteDataGridViewTextBoxColumn";
            // 
            // notaExplicativaDataGridViewTextBoxColumn
            // 
            this.notaExplicativaDataGridViewTextBoxColumn.DataPropertyName = "NotaExplicativa";
            this.notaExplicativaDataGridViewTextBoxColumn.HeaderText = "NotaExplicativa";
            this.notaExplicativaDataGridViewTextBoxColumn.Name = "notaExplicativaDataGridViewTextBoxColumn";
            // 
            // creditoDebitoDataGridViewTextBoxColumn
            // 
            this.creditoDebitoDataGridViewTextBoxColumn.DataPropertyName = "CreditoDebito";
            this.creditoDebitoDataGridViewTextBoxColumn.HeaderText = "CreditoDebito";
            this.creditoDebitoDataGridViewTextBoxColumn.Name = "creditoDebitoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // EnEdicionBindingSource
            // 
            this.EnEdicionBindingSource.DataSource = typeof(ENTIDADES.CreditosDebitos);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.FiltradoMotivoComboBox);
            this.groupBox2.Controls.Add(this.FiltradoMotivoslabel);
            this.groupBox2.Location = new System.Drawing.Point(38, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 51);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.Emitirbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NotaExplicativaLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MotivoAjusteComboBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.motivoajusteLabel);
            this.Name = "Form1";
            this.Text = "Asistente de Créditos y Débitos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosyDebitosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnEdicionBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label NotaExplicativaLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Emitirbutton;
        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource CreditosyDebitosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDelAjusteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaExplicativaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditoDebitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource EnEdicionBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

