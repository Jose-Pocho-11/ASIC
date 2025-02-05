namespace ASIC
{
    partial class Reporte_medicamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_prueba = new System.Windows.Forms.DataGridView();
            this.combo_medicamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check_NG = new System.Windows.Forms.CheckBox();
            this.check_presentacion = new System.Windows.Forms.CheckBox();
            this.check_medicamento = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo_label = new System.Windows.Forms.Label();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.combo_categoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.check_categoria = new System.Windows.Forms.CheckBox();
            this.check_Fvencimineto = new System.Windows.Forms.CheckBox();
            this.combo_NG = new System.Windows.Forms.ComboBox();
            this.combo_presentacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha_vencimineto = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_prueba
            // 
            this.dataGridView_prueba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_prueba.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_prueba.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_prueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_prueba.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_prueba.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_prueba.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_prueba.ColumnHeadersHeight = 30;
            this.dataGridView_prueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_prueba.EnableHeadersVisualStyles = false;
            this.dataGridView_prueba.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView_prueba.Location = new System.Drawing.Point(74, 355);
            this.dataGridView_prueba.Name = "dataGridView_prueba";
            this.dataGridView_prueba.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_prueba.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_prueba.Size = new System.Drawing.Size(916, 172);
            this.dataGridView_prueba.TabIndex = 83;
            // 
            // combo_medicamento
            // 
            this.combo_medicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_medicamento.Enabled = false;
            this.combo_medicamento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.combo_medicamento.FormattingEnabled = true;
            this.combo_medicamento.Location = new System.Drawing.Point(70, 181);
            this.combo_medicamento.Name = "combo_medicamento";
            this.combo_medicamento.Size = new System.Drawing.Size(208, 25);
            this.combo_medicamento.TabIndex = 82;
            this.combo_medicamento.SelectedIndexChanged += new System.EventHandler(this.combo_medicamento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 81;
            this.label3.Text = "Presentación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "Medicamento";
            // 
            // check_NG
            // 
            this.check_NG.AutoSize = true;
            this.check_NG.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.check_NG.Location = new System.Drawing.Point(70, 114);
            this.check_NG.Name = "check_NG";
            this.check_NG.Size = new System.Drawing.Size(168, 25);
            this.check_NG.TabIndex = 79;
            this.check_NG.Text = "Nombre Genérico";
            this.check_NG.UseVisualStyleBackColor = true;
            this.check_NG.CheckedChanged += new System.EventHandler(this.check_NG_CheckedChanged);
            // 
            // check_presentacion
            // 
            this.check_presentacion.AutoSize = true;
            this.check_presentacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.check_presentacion.Location = new System.Drawing.Point(260, 83);
            this.check_presentacion.Name = "check_presentacion";
            this.check_presentacion.Size = new System.Drawing.Size(130, 25);
            this.check_presentacion.TabIndex = 78;
            this.check_presentacion.Text = "Presentación";
            this.check_presentacion.UseVisualStyleBackColor = true;
            this.check_presentacion.CheckedChanged += new System.EventHandler(this.check_presentacion_CheckedChanged);
            // 
            // check_medicamento
            // 
            this.check_medicamento.AutoSize = true;
            this.check_medicamento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.check_medicamento.Location = new System.Drawing.Point(70, 83);
            this.check_medicamento.Name = "check_medicamento";
            this.check_medicamento.Size = new System.Drawing.Size(141, 25);
            this.check_medicamento.TabIndex = 77;
            this.check_medicamento.Text = "Medicamento";
            this.check_medicamento.UseVisualStyleBackColor = true;
            this.check_medicamento.CheckedChanged += new System.EventHandler(this.check_medicamento_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "Nombre generico";
            // 
            // Codigo_label
            // 
            this.Codigo_label.AutoSize = true;
            this.Codigo_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_label.Location = new System.Drawing.Point(66, 59);
            this.Codigo_label.Name = "Codigo_label";
            this.Codigo_label.Size = new System.Drawing.Size(52, 21);
            this.Codigo_label.TabIndex = 75;
            this.Codigo_label.Text = "Filtrar";
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.BackColor = System.Drawing.Color.Gold;
            this.bt_mostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mostrar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_mostrar.Location = new System.Drawing.Point(750, 310);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(117, 39);
            this.bt_mostrar.TabIndex = 74;
            this.bt_mostrar.Text = "mostrar";
            this.bt_mostrar.UseVisualStyleBackColor = false;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_mostrar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Salmon;
            this.bt_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_cancelar.Location = new System.Drawing.Point(873, 310);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(117, 39);
            this.bt_cancelar.TabIndex = 73;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(208)))), ((int)(((byte)(132)))));
            this.bt_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_guardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_guardar.Location = new System.Drawing.Point(627, 310);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(117, 39);
            this.bt_guardar.TabIndex = 72;
            this.bt_guardar.Text = "Generar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // combo_categoria
            // 
            this.combo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_categoria.Enabled = false;
            this.combo_categoria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.combo_categoria.FormattingEnabled = true;
            this.combo_categoria.Location = new System.Drawing.Point(70, 244);
            this.combo_categoria.Name = "combo_categoria";
            this.combo_categoria.Size = new System.Drawing.Size(208, 25);
            this.combo_categoria.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 21);
            this.label8.TabIndex = 70;
            this.label8.Text = "Reporte Medicamentos";
            // 
            // check_categoria
            // 
            this.check_categoria.AutoSize = true;
            this.check_categoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.check_categoria.Location = new System.Drawing.Point(260, 114);
            this.check_categoria.Name = "check_categoria";
            this.check_categoria.Size = new System.Drawing.Size(110, 25);
            this.check_categoria.TabIndex = 86;
            this.check_categoria.Text = "Categoria";
            this.check_categoria.UseVisualStyleBackColor = true;
            this.check_categoria.CheckedChanged += new System.EventHandler(this.check_categoria_CheckedChanged);
            // 
            // check_Fvencimineto
            // 
            this.check_Fvencimineto.AutoSize = true;
            this.check_Fvencimineto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.check_Fvencimineto.Location = new System.Drawing.Point(409, 83);
            this.check_Fvencimineto.Name = "check_Fvencimineto";
            this.check_Fvencimineto.Size = new System.Drawing.Size(205, 25);
            this.check_Fvencimineto.TabIndex = 87;
            this.check_Fvencimineto.Text = "Fecha de vencimineto";
            this.check_Fvencimineto.UseVisualStyleBackColor = true;
            this.check_Fvencimineto.CheckedChanged += new System.EventHandler(this.check_Fvencimineto_CheckedChanged);
            // 
            // combo_NG
            // 
            this.combo_NG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_NG.Enabled = false;
            this.combo_NG.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.combo_NG.FormattingEnabled = true;
            this.combo_NG.Location = new System.Drawing.Point(366, 181);
            this.combo_NG.Name = "combo_NG";
            this.combo_NG.Size = new System.Drawing.Size(208, 25);
            this.combo_NG.TabIndex = 88;
            // 
            // combo_presentacion
            // 
            this.combo_presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_presentacion.Enabled = false;
            this.combo_presentacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.combo_presentacion.FormattingEnabled = true;
            this.combo_presentacion.Location = new System.Drawing.Point(644, 181);
            this.combo_presentacion.Name = "combo_presentacion";
            this.combo_presentacion.Size = new System.Drawing.Size(208, 25);
            this.combo_presentacion.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 89;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 21);
            this.label5.TabIndex = 91;
            this.label5.Text = "Fecha de vencimineto";
            // 
            // fecha_vencimineto
            // 
            this.fecha_vencimineto.Enabled = false;
            this.fecha_vencimineto.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.fecha_vencimineto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_vencimineto.Location = new System.Drawing.Point(366, 246);
            this.fecha_vencimineto.Name = "fecha_vencimineto";
            this.fecha_vencimineto.Size = new System.Drawing.Size(208, 23);
            this.fecha_vencimineto.TabIndex = 92;
            // 
            // Reporte_medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 539);
            this.Controls.Add(this.fecha_vencimineto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_presentacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_NG);
            this.Controls.Add(this.check_Fvencimineto);
            this.Controls.Add(this.check_categoria);
            this.Controls.Add(this.dataGridView_prueba);
            this.Controls.Add(this.combo_medicamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check_NG);
            this.Controls.Add(this.check_presentacion);
            this.Controls.Add(this.check_medicamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Codigo_label);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.combo_categoria);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_medicamento";
            this.Text = "Reporte_medicamento";
            this.Load += new System.EventHandler(this.Reporte_medicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_prueba;
        private System.Windows.Forms.ComboBox combo_medicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_NG;
        private System.Windows.Forms.CheckBox check_presentacion;
        private System.Windows.Forms.CheckBox check_medicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Codigo_label;
        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.ComboBox combo_categoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox check_categoria;
        private System.Windows.Forms.CheckBox check_Fvencimineto;
        private System.Windows.Forms.ComboBox combo_NG;
        private System.Windows.Forms.ComboBox combo_presentacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecha_vencimineto;
    }
}