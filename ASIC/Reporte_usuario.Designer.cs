namespace ASIC
{
    partial class Reporte_usuario
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
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.combo_patologias = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Codigo_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.check_medicamentos = new System.Windows.Forms.CheckBox();
            this.check_patologia = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMedicamentos = new System.Windows.Forms.ComboBox();
            this.dataGridView_prueba = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buscar_bt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar_bt)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.BackColor = System.Drawing.Color.Gold;
            this.bt_mostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mostrar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_mostrar.Location = new System.Drawing.Point(755, 221);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(117, 39);
            this.bt_mostrar.TabIndex = 40;
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
            this.bt_cancelar.Location = new System.Drawing.Point(878, 221);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(117, 39);
            this.bt_cancelar.TabIndex = 39;
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
            this.bt_guardar.Location = new System.Drawing.Point(632, 221);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(117, 39);
            this.bt_guardar.TabIndex = 38;
            this.bt_guardar.Text = "Generar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // combo_patologias
            // 
            this.combo_patologias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_patologias.Enabled = false;
            this.combo_patologias.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.combo_patologias.FormattingEnabled = true;
            this.combo_patologias.Location = new System.Drawing.Point(389, 155);
            this.combo_patologias.Name = "combo_patologias";
            this.combo_patologias.Size = new System.Drawing.Size(276, 25);
            this.combo_patologias.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Reporte Pacientes";
            // 
            // Codigo_label
            // 
            this.Codigo_label.AutoSize = true;
            this.Codigo_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_label.Location = new System.Drawing.Point(85, 66);
            this.Codigo_label.Name = "Codigo_label";
            this.Codigo_label.Size = new System.Drawing.Size(52, 21);
            this.Codigo_label.TabIndex = 41;
            this.Codigo_label.Text = "Filtrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Patologías";
            // 
            // check_medicamentos
            // 
            this.check_medicamentos.AutoSize = true;
            this.check_medicamentos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.check_medicamentos.Location = new System.Drawing.Point(88, 90);
            this.check_medicamentos.Name = "check_medicamentos";
            this.check_medicamentos.Size = new System.Drawing.Size(147, 25);
            this.check_medicamentos.TabIndex = 43;
            this.check_medicamentos.Text = "Medicamentos";
            this.check_medicamentos.UseVisualStyleBackColor = true;
            this.check_medicamentos.CheckedChanged += new System.EventHandler(this.check_medicamentos_CheckedChanged);
            // 
            // check_patologia
            // 
            this.check_patologia.AutoSize = true;
            this.check_patologia.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.check_patologia.Location = new System.Drawing.Point(242, 90);
            this.check_patologia.Name = "check_patologia";
            this.check_patologia.Size = new System.Drawing.Size(104, 25);
            this.check_patologia.TabIndex = 45;
            this.check_patologia.Text = "Patología";
            this.check_patologia.UseVisualStyleBackColor = true;
            this.check_patologia.CheckedChanged += new System.EventHandler(this.check_patologia_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Medicamentos";
            // 
            // comboMedicamentos
            // 
            this.comboMedicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMedicamentos.Enabled = false;
            this.comboMedicamentos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboMedicamentos.FormattingEnabled = true;
            this.comboMedicamentos.Location = new System.Drawing.Point(79, 155);
            this.comboMedicamentos.Name = "comboMedicamentos";
            this.comboMedicamentos.Size = new System.Drawing.Size(276, 25);
            this.comboMedicamentos.TabIndex = 48;
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
            this.dataGridView_prueba.Location = new System.Drawing.Point(79, 266);
            this.dataGridView_prueba.Name = "dataGridView_prueba";
            this.dataGridView_prueba.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_prueba.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_prueba.Size = new System.Drawing.Size(916, 172);
            this.dataGridView_prueba.TabIndex = 66;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(79, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 31);
            this.textBox1.TabIndex = 67;
            this.textBox1.Text = "buscar...";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // buscar_bt
            // 
            this.buscar_bt.BackColor = System.Drawing.Color.White;
            this.buscar_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar_bt.Image = global::ASIC.Properties.Resources.icons8_google_web_search_52__2_;
            this.buscar_bt.Location = new System.Drawing.Point(314, 229);
            this.buscar_bt.Name = "buscar_bt";
            this.buscar_bt.Size = new System.Drawing.Size(30, 31);
            this.buscar_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buscar_bt.TabIndex = 68;
            this.buscar_bt.TabStop = false;
            // 
            // Reporte_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.buscar_bt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView_prueba);
            this.Controls.Add(this.comboMedicamentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check_patologia);
            this.Controls.Add(this.check_medicamentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Codigo_label);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.combo_patologias);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_usuario";
            this.Text = "Reporte_usuario";
            this.Load += new System.EventHandler(this.Reporte_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar_bt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.ComboBox combo_patologias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Codigo_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_medicamentos;
        private System.Windows.Forms.CheckBox check_patologia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMedicamentos;
        private System.Windows.Forms.DataGridView dataGridView_prueba;
        private System.Windows.Forms.PictureBox buscar_bt;
        private System.Windows.Forms.TextBox textBox1;
    }
}