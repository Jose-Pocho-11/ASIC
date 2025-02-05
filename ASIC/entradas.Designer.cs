namespace ASIC
{
    partial class entradas
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
            this.Codigo_label = new System.Windows.Forms.Label();
            this.codigo_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombre_medicamento_txt = new System.Windows.Forms.TextBox();
            this.numero_lote_txt = new System.Windows.Forms.TextBox();
            this.categorias_combo = new System.Windows.Forms.ComboBox();
            this.presentacion_combo = new System.Windows.Forms.ComboBox();
            this.stock_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.fecha_entrega = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.nombre_generico_combo = new System.Windows.Forms.ComboBox();
            this.cantidad_txt = new System.Windows.Forms.TextBox();
            this.medida_combo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.dataGridView_prueba = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigo_label
            // 
            this.Codigo_label.AutoSize = true;
            this.Codigo_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_label.Location = new System.Drawing.Point(35, 49);
            this.Codigo_label.Name = "Codigo_label";
            this.Codigo_label.Size = new System.Drawing.Size(68, 21);
            this.Codigo_label.TabIndex = 2;
            this.Codigo_label.Text = "Código";
            // 
            // codigo_txt
            // 
            this.codigo_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_txt.Location = new System.Drawing.Point(39, 73);
            this.codigo_txt.Multiline = true;
            this.codigo_txt.Name = "codigo_txt";
            this.codigo_txt.Size = new System.Drawing.Size(229, 25);
            this.codigo_txt.TabIndex = 6;
            this.codigo_txt.TextChanged += new System.EventHandler(this.codigo_txt_TextChanged);
            this.codigo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Composición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre Genérico ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "N° de Lote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Categoría";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Presentación";
            // 
            // nombre_medicamento_txt
            // 
            this.nombre_medicamento_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_medicamento_txt.Location = new System.Drawing.Point(39, 144);
            this.nombre_medicamento_txt.Multiline = true;
            this.nombre_medicamento_txt.Name = "nombre_medicamento_txt";
            this.nombre_medicamento_txt.Size = new System.Drawing.Size(229, 25);
            this.nombre_medicamento_txt.TabIndex = 14;
            this.nombre_medicamento_txt.TextChanged += new System.EventHandler(this.nombre_medicamento_txt_TextChanged);
            this.nombre_medicamento_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_medicamento_txt_KeyPress);
            // 
            // numero_lote_txt
            // 
            this.numero_lote_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_lote_txt.Location = new System.Drawing.Point(695, 73);
            this.numero_lote_txt.Multiline = true;
            this.numero_lote_txt.Name = "numero_lote_txt";
            this.numero_lote_txt.Size = new System.Drawing.Size(229, 25);
            this.numero_lote_txt.TabIndex = 16;
            this.numero_lote_txt.TextChanged += new System.EventHandler(this.numero_lote_txt_TextChanged);
            this.numero_lote_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_lote_txt_KeyPress);
            // 
            // categorias_combo
            // 
            this.categorias_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorias_combo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.categorias_combo.FormattingEnabled = true;
            this.categorias_combo.Location = new System.Drawing.Point(39, 205);
            this.categorias_combo.Name = "categorias_combo";
            this.categorias_combo.Size = new System.Drawing.Size(229, 25);
            this.categorias_combo.TabIndex = 17;
            this.categorias_combo.DropDown += new System.EventHandler(this.categorias_combo_DropDown);
            this.categorias_combo.SelectedIndexChanged += new System.EventHandler(this.categorias_combo_SelectedIndexChanged);
            // 
            // presentacion_combo
            // 
            this.presentacion_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presentacion_combo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.presentacion_combo.FormattingEnabled = true;
            this.presentacion_combo.Location = new System.Drawing.Point(366, 144);
            this.presentacion_combo.Name = "presentacion_combo";
            this.presentacion_combo.Size = new System.Drawing.Size(229, 25);
            this.presentacion_combo.TabIndex = 19;
            // 
            // stock_txt
            // 
            this.stock_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stock_txt.Location = new System.Drawing.Point(366, 205);
            this.stock_txt.Multiline = true;
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.Size = new System.Drawing.Size(229, 25);
            this.stock_txt.TabIndex = 20;
            this.stock_txt.TextChanged += new System.EventHandler(this.stock_txt_TextChanged);
            this.stock_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stock_txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Entradas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(691, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha de vencimiento";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_vencimiento.Location = new System.Drawing.Point(695, 207);
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.Size = new System.Drawing.Size(147, 23);
            this.fecha_vencimiento.TabIndex = 24;
            this.fecha_vencimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // fecha_entrega
            // 
            this.fecha_entrega.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.fecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_entrega.Location = new System.Drawing.Point(695, 146);
            this.fecha_entrega.Name = "fecha_entrega";
            this.fecha_entrega.Size = new System.Drawing.Size(147, 23);
            this.fecha_entrega.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(691, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fecha de Elaboración";
            // 
            // nombre_generico_combo
            // 
            this.nombre_generico_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombre_generico_combo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nombre_generico_combo.FormattingEnabled = true;
            this.nombre_generico_combo.Location = new System.Drawing.Point(366, 73);
            this.nombre_generico_combo.Name = "nombre_generico_combo";
            this.nombre_generico_combo.Size = new System.Drawing.Size(229, 25);
            this.nombre_generico_combo.TabIndex = 27;
            this.nombre_generico_combo.SelectedIndexChanged += new System.EventHandler(this.nombre_generico_combo_SelectedIndexChanged);
            // 
            // cantidad_txt
            // 
            this.cantidad_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_txt.Location = new System.Drawing.Point(39, 268);
            this.cantidad_txt.Multiline = true;
            this.cantidad_txt.Name = "cantidad_txt";
            this.cantidad_txt.Size = new System.Drawing.Size(113, 25);
            this.cantidad_txt.TabIndex = 28;
            this.cantidad_txt.TextChanged += new System.EventHandler(this.cantidad_txt_TextChanged);
            this.cantidad_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_txt_KeyPress);
            // 
            // medida_combo
            // 
            this.medida_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medida_combo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.medida_combo.FormattingEnabled = true;
            this.medida_combo.Items.AddRange(new object[] {
            "Escoge una opción",
            "g",
            "mg",
            "l",
            "ml"});
            this.medida_combo.Location = new System.Drawing.Point(158, 268);
            this.medida_combo.Name = "medida_combo";
            this.medida_combo.Size = new System.Drawing.Size(164, 25);
            this.medida_combo.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(154, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Medida";
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(208)))), ((int)(((byte)(132)))));
            this.bt_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_guardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_guardar.Location = new System.Drawing.Point(561, 268);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(117, 39);
            this.bt_guardar.TabIndex = 31;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            this.bt_guardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_guardar_MouseDown);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Salmon;
            this.bt_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_cancelar.Location = new System.Drawing.Point(807, 268);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(117, 39);
            this.bt_cancelar.TabIndex = 32;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.BackColor = System.Drawing.Color.Gold;
            this.bt_mostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mostrar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_mostrar.Location = new System.Drawing.Point(684, 268);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(117, 39);
            this.bt_mostrar.TabIndex = 34;
            this.bt_mostrar.Text = "mostrar";
            this.bt_mostrar.UseVisualStyleBackColor = false;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_mostrar_Click);
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
            this.dataGridView_prueba.Location = new System.Drawing.Point(39, 318);
            this.dataGridView_prueba.Name = "dataGridView_prueba";
            this.dataGridView_prueba.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_prueba.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_prueba.Size = new System.Drawing.Size(885, 231);
            this.dataGridView_prueba.TabIndex = 65;
            // 
            // entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 570);
            this.Controls.Add(this.dataGridView_prueba);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.medida_combo);
            this.Controls.Add(this.cantidad_txt);
            this.Controls.Add(this.nombre_generico_combo);
            this.Controls.Add(this.fecha_entrega);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fecha_vencimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.presentacion_combo);
            this.Controls.Add(this.categorias_combo);
            this.Controls.Add(this.numero_lote_txt);
            this.Controls.Add(this.nombre_medicamento_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigo_txt);
            this.Controls.Add(this.Codigo_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "entradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "entradas";
            this.Load += new System.EventHandler(this.entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Codigo_label;
        private System.Windows.Forms.TextBox codigo_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombre_medicamento_txt;
        private System.Windows.Forms.TextBox numero_lote_txt;
        private System.Windows.Forms.ComboBox categorias_combo;
        private System.Windows.Forms.ComboBox presentacion_combo;
        private System.Windows.Forms.TextBox stock_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fecha_vencimiento;
        private System.Windows.Forms.DateTimePicker fecha_entrega;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox nombre_generico_combo;
        private System.Windows.Forms.TextBox cantidad_txt;
        private System.Windows.Forms.ComboBox medida_combo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.DataGridView dataGridView_prueba;
    }
}