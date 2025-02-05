namespace ASIC
{
    partial class reporte_salida
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
            this.comboMedicamentos = new System.Windows.Forms.ComboBox();
            this.check_medicamentos = new System.Windows.Forms.CheckBox();
            this.Codigo_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_prueba = new System.Windows.Forms.DataGridView();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.check_fechas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMedicamentos
            // 
            this.comboMedicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMedicamentos.Enabled = false;
            this.comboMedicamentos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboMedicamentos.FormattingEnabled = true;
            this.comboMedicamentos.Location = new System.Drawing.Point(88, 155);
            this.comboMedicamentos.Name = "comboMedicamentos";
            this.comboMedicamentos.Size = new System.Drawing.Size(276, 25);
            this.comboMedicamentos.TabIndex = 52;
            this.comboMedicamentos.SelectedIndexChanged += new System.EventHandler(this.comboMedicamentos_SelectedIndexChanged);
            // 
            // check_medicamentos
            // 
            this.check_medicamentos.AutoSize = true;
            this.check_medicamentos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.check_medicamentos.Location = new System.Drawing.Point(97, 90);
            this.check_medicamentos.Name = "check_medicamentos";
            this.check_medicamentos.Size = new System.Drawing.Size(147, 25);
            this.check_medicamentos.TabIndex = 51;
            this.check_medicamentos.Text = "Medicamentos";
            this.check_medicamentos.UseVisualStyleBackColor = true;
            this.check_medicamentos.CheckedChanged += new System.EventHandler(this.check_medicamentos_CheckedChanged);
            // 
            // Codigo_label
            // 
            this.Codigo_label.AutoSize = true;
            this.Codigo_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_label.Location = new System.Drawing.Point(94, 66);
            this.Codigo_label.Name = "Codigo_label";
            this.Codigo_label.Size = new System.Drawing.Size(52, 21);
            this.Codigo_label.TabIndex = 50;
            this.Codigo_label.Text = "Filtrar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(456, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Reporte Salidas";
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
            this.dataGridView_prueba.Location = new System.Drawing.Point(88, 306);
            this.dataGridView_prueba.Name = "dataGridView_prueba";
            this.dataGridView_prueba.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_prueba.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_prueba.Size = new System.Drawing.Size(916, 172);
            this.dataGridView_prueba.TabIndex = 70;
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.BackColor = System.Drawing.Color.Gold;
            this.bt_mostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mostrar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_mostrar.Location = new System.Drawing.Point(764, 261);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(117, 39);
            this.bt_mostrar.TabIndex = 69;
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
            this.bt_cancelar.Location = new System.Drawing.Point(887, 261);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(117, 39);
            this.bt_cancelar.TabIndex = 68;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(208)))), ((int)(((byte)(132)))));
            this.bt_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_guardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_guardar.Location = new System.Drawing.Point(641, 261);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(117, 39);
            this.bt_guardar.TabIndex = 67;
            this.bt_guardar.Text = "Generar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // fecha_desde
            // 
            this.fecha_desde.Enabled = false;
            this.fecha_desde.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_desde.Location = new System.Drawing.Point(553, 154);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(156, 23);
            this.fecha_desde.TabIndex = 93;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.Enabled = false;
            this.fecha_hasta.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_hasta.Location = new System.Drawing.Point(776, 154);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(157, 23);
            this.fecha_hasta.TabIndex = 94;
            // 
            // check_fechas
            // 
            this.check_fechas.AutoSize = true;
            this.check_fechas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.check_fechas.Location = new System.Drawing.Point(493, 90);
            this.check_fechas.Name = "check_fechas";
            this.check_fechas.Size = new System.Drawing.Size(162, 25);
            this.check_fechas.TabIndex = 95;
            this.check_fechas.Text = "Rango de fechas";
            this.check_fechas.UseVisualStyleBackColor = true;
            this.check_fechas.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 96;
            this.label1.Text = "desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(715, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "hasta";
            // 
            // reporte_salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_fechas);
            this.Controls.Add(this.fecha_hasta);
            this.Controls.Add(this.fecha_desde);
            this.Controls.Add(this.dataGridView_prueba);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.comboMedicamentos);
            this.Controls.Add(this.check_medicamentos);
            this.Controls.Add(this.Codigo_label);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reporte_salida";
            this.Text = "reporte_salida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMedicamentos;
        private System.Windows.Forms.CheckBox check_medicamentos;
        private System.Windows.Forms.Label Codigo_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_prueba;
        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.DateTimePicker fecha_desde;
        private System.Windows.Forms.DateTimePicker fecha_hasta;
        private System.Windows.Forms.CheckBox check_fechas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}