namespace ASIC
{
    partial class Salidas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cedula = new System.Windows.Forms.TextBox();
            this.Codigo_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombre_apellido_txt = new System.Windows.Forms.TextBox();
            this.num_tlf_txt = new System.Windows.Forms.TextBox();
            this.patologia_txt = new System.Windows.Forms.TextBox();
            this.direccion_txt = new System.Windows.Forms.TextBox();
            this.nombre_medicamento_txt = new System.Windows.Forms.TextBox();
            this.fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.fecha_retiro = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cantidad_txt = new System.Windows.Forms.TextBox();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.dataGridView_prueba = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMedicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGenericoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDeLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaElaboracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.medicamentoCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buscar_bt = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cedula
            // 
            this.cedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.Location = new System.Drawing.Point(43, 80);
            this.cedula.Multiline = true;
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(229, 25);
            this.cedula.TabIndex = 29;
            this.cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedula_KeyPress);
            // 
            // Codigo_label
            // 
            this.Codigo_label.AutoSize = true;
            this.Codigo_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_label.Location = new System.Drawing.Point(39, 56);
            this.Codigo_label.Name = "Codigo_label";
            this.Codigo_label.Size = new System.Drawing.Size(68, 21);
            this.Codigo_label.TabIndex = 28;
            this.Codigo_label.Text = "Cédula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre y Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Número de Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Patología";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(672, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Medicamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Fecha de Retiro";
            // 
            // nombre_apellido_txt
            // 
            this.nombre_apellido_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_apellido_txt.Location = new System.Drawing.Point(43, 147);
            this.nombre_apellido_txt.Multiline = true;
            this.nombre_apellido_txt.Name = "nombre_apellido_txt";
            this.nombre_apellido_txt.Size = new System.Drawing.Size(229, 25);
            this.nombre_apellido_txt.TabIndex = 38;
            this.nombre_apellido_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_apellido_txt_KeyPress);
            // 
            // num_tlf_txt
            // 
            this.num_tlf_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_tlf_txt.Location = new System.Drawing.Point(44, 212);
            this.num_tlf_txt.Multiline = true;
            this.num_tlf_txt.Name = "num_tlf_txt";
            this.num_tlf_txt.Size = new System.Drawing.Size(229, 25);
            this.num_tlf_txt.TabIndex = 39;
            this.num_tlf_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_tlf_txt_KeyPress);
            // 
            // patologia_txt
            // 
            this.patologia_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patologia_txt.Location = new System.Drawing.Point(358, 147);
            this.patologia_txt.Multiline = true;
            this.patologia_txt.Name = "patologia_txt";
            this.patologia_txt.Size = new System.Drawing.Size(229, 25);
            this.patologia_txt.TabIndex = 40;
            this.patologia_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patologia_txt_KeyPress);
            // 
            // direccion_txt
            // 
            this.direccion_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_txt.Location = new System.Drawing.Point(360, 212);
            this.direccion_txt.Multiline = true;
            this.direccion_txt.Name = "direccion_txt";
            this.direccion_txt.Size = new System.Drawing.Size(229, 25);
            this.direccion_txt.TabIndex = 41;
            this.direccion_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.direccion_txt_KeyPress);
            // 
            // nombre_medicamento_txt
            // 
            this.nombre_medicamento_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_medicamento_txt.Location = new System.Drawing.Point(676, 80);
            this.nombre_medicamento_txt.Multiline = true;
            this.nombre_medicamento_txt.Name = "nombre_medicamento_txt";
            this.nombre_medicamento_txt.ReadOnly = true;
            this.nombre_medicamento_txt.Size = new System.Drawing.Size(229, 25);
            this.nombre_medicamento_txt.TabIndex = 42;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_nacimiento.Location = new System.Drawing.Point(358, 82);
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Size = new System.Drawing.Size(230, 23);
            this.fecha_nacimiento.TabIndex = 44;
            // 
            // fecha_retiro
            // 
            this.fecha_retiro.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.fecha_retiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_retiro.Location = new System.Drawing.Point(676, 210);
            this.fecha_retiro.Name = "fecha_retiro";
            this.fecha_retiro.Size = new System.Drawing.Size(229, 23);
            this.fecha_retiro.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(672, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Cantidad";
            // 
            // cantidad_txt
            // 
            this.cantidad_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_txt.Location = new System.Drawing.Point(676, 147);
            this.cantidad_txt.Multiline = true;
            this.cantidad_txt.Name = "cantidad_txt";
            this.cantidad_txt.Size = new System.Drawing.Size(229, 25);
            this.cantidad_txt.TabIndex = 47;
            this.cantidad_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_txt_KeyPress);
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.BackColor = System.Drawing.Color.Gold;
            this.bt_mostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.bt_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mostrar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_mostrar.Location = new System.Drawing.Point(665, 263);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(117, 39);
            this.bt_mostrar.TabIndex = 50;
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
            this.bt_cancelar.Location = new System.Drawing.Point(788, 263);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(117, 39);
            this.bt_cancelar.TabIndex = 49;
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
            this.bt_guardar.Location = new System.Drawing.Point(542, 263);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(117, 39);
            this.bt_guardar.TabIndex = 48;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // dataGridView_prueba
            // 
            this.dataGridView_prueba.AutoGenerateColumns = false;
            this.dataGridView_prueba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_prueba.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_prueba.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_prueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_prueba.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_prueba.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_prueba.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_prueba.ColumnHeadersHeight = 30;
            this.dataGridView_prueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_prueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreMedicamentoDataGridViewTextBoxColumn,
            this.composicionDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn,
            this.nombreGenericoDataGridViewTextBoxColumn,
            this.numeroDeLoteDataGridViewTextBoxColumn,
            this.enStockDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.fechaElaboracionDataGridViewTextBoxColumn,
            this.fechaCaducidadDataGridViewTextBoxColumn,
            this.Seleccionar});
            this.dataGridView_prueba.DataSource = this.medicamentoCompletoBindingSource;
            this.dataGridView_prueba.EnableHeadersVisualStyles = false;
            this.dataGridView_prueba.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView_prueba.Location = new System.Drawing.Point(43, 319);
            this.dataGridView_prueba.Name = "dataGridView_prueba";
            this.dataGridView_prueba.ReadOnly = true;
            this.dataGridView_prueba.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_prueba.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_prueba.Size = new System.Drawing.Size(960, 231);
            this.dataGridView_prueba.TabIndex = 72;
            this.dataGridView_prueba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_prueba_CellContentClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 69;
            // 
            // nombreMedicamentoDataGridViewTextBoxColumn
            // 
            this.nombreMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Medicamento";
            this.nombreMedicamentoDataGridViewTextBoxColumn.HeaderText = "Nombre_Medicamento";
            this.nombreMedicamentoDataGridViewTextBoxColumn.Name = "nombreMedicamentoDataGridViewTextBoxColumn";
            this.nombreMedicamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreMedicamentoDataGridViewTextBoxColumn.Width = 147;
            // 
            // composicionDataGridViewTextBoxColumn
            // 
            this.composicionDataGridViewTextBoxColumn.DataPropertyName = "Composicion";
            this.composicionDataGridViewTextBoxColumn.HeaderText = "Composicion";
            this.composicionDataGridViewTextBoxColumn.Name = "composicionDataGridViewTextBoxColumn";
            this.composicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.composicionDataGridViewTextBoxColumn.Width = 98;
            // 
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "Medida";
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            this.medidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.medidaDataGridViewTextBoxColumn.Width = 70;
            // 
            // nombreGenericoDataGridViewTextBoxColumn
            // 
            this.nombreGenericoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Generico";
            this.nombreGenericoDataGridViewTextBoxColumn.HeaderText = "Nombre_Generico";
            this.nombreGenericoDataGridViewTextBoxColumn.Name = "nombreGenericoDataGridViewTextBoxColumn";
            this.nombreGenericoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreGenericoDataGridViewTextBoxColumn.Width = 123;
            // 
            // numeroDeLoteDataGridViewTextBoxColumn
            // 
            this.numeroDeLoteDataGridViewTextBoxColumn.DataPropertyName = "Numero_De_Lote";
            this.numeroDeLoteDataGridViewTextBoxColumn.HeaderText = "Numero_De_Lote";
            this.numeroDeLoteDataGridViewTextBoxColumn.Name = "numeroDeLoteDataGridViewTextBoxColumn";
            this.numeroDeLoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDeLoteDataGridViewTextBoxColumn.Width = 118;
            // 
            // enStockDataGridViewTextBoxColumn
            // 
            this.enStockDataGridViewTextBoxColumn.DataPropertyName = "En_Stock";
            this.enStockDataGridViewTextBoxColumn.HeaderText = "En_Stock";
            this.enStockDataGridViewTextBoxColumn.Name = "enStockDataGridViewTextBoxColumn";
            this.enStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.enStockDataGridViewTextBoxColumn.Width = 77;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Width = 81;
            // 
            // presentacionDataGridViewTextBoxColumn
            // 
            this.presentacionDataGridViewTextBoxColumn.DataPropertyName = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.HeaderText = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.Name = "presentacionDataGridViewTextBoxColumn";
            this.presentacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.presentacionDataGridViewTextBoxColumn.Width = 97;
            // 
            // fechaElaboracionDataGridViewTextBoxColumn
            // 
            this.fechaElaboracionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Elaboracion";
            this.fechaElaboracionDataGridViewTextBoxColumn.HeaderText = "Fecha_Elaboracion";
            this.fechaElaboracionDataGridViewTextBoxColumn.Name = "fechaElaboracionDataGridViewTextBoxColumn";
            this.fechaElaboracionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaElaboracionDataGridViewTextBoxColumn.Width = 127;
            // 
            // fechaCaducidadDataGridViewTextBoxColumn
            // 
            this.fechaCaducidadDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Caducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.HeaderText = "Fecha_Caducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.Name = "fechaCaducidadDataGridViewTextBoxColumn";
            this.fechaCaducidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCaducidadDataGridViewTextBoxColumn.Width = 121;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Image = global::ASIC.Properties.Resources.icons8_hand_with_a_pill_32;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccionar.Width = 70;
            // 
            // medicamentoCompletoBindingSource
            // 
            this.medicamentoCompletoBindingSource.DataSource = typeof(ASIC.Modelo.MedicamentoCompleto);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::ASIC.Properties.Resources.icons8_hand_with_a_pill_32;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 42;
            // 
            // buscar_bt
            // 
            this.buscar_bt.BackColor = System.Drawing.Color.White;
            this.buscar_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar_bt.Image = global::ASIC.Properties.Resources.icons8_google_web_search_52__2_;
            this.buscar_bt.Location = new System.Drawing.Point(278, 282);
            this.buscar_bt.Name = "buscar_bt";
            this.buscar_bt.Size = new System.Drawing.Size(30, 31);
            this.buscar_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buscar_bt.TabIndex = 74;
            this.buscar_bt.TabStop = false;
            this.buscar_bt.Click += new System.EventHandler(this.buscar_bt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(43, 282);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 31);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "buscar...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 75;
            this.label9.Text = "Salidas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ASIC.Properties.Resources.icons8_google_web_search_52__2_;
            this.pictureBox1.Location = new System.Drawing.Point(278, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Salidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buscar_bt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView_prueba);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.cantidad_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fecha_retiro);
            this.Controls.Add(this.fecha_nacimiento);
            this.Controls.Add(this.nombre_medicamento_txt);
            this.Controls.Add(this.direccion_txt);
            this.Controls.Add(this.patologia_txt);
            this.Controls.Add(this.num_tlf_txt);
            this.Controls.Add(this.nombre_apellido_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.Codigo_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salidas";
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.Salidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.Label Codigo_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombre_apellido_txt;
        private System.Windows.Forms.TextBox num_tlf_txt;
        private System.Windows.Forms.TextBox patologia_txt;
        private System.Windows.Forms.TextBox direccion_txt;
        private System.Windows.Forms.TextBox nombre_medicamento_txt;
        private System.Windows.Forms.DateTimePicker fecha_nacimiento;
        private System.Windows.Forms.DateTimePicker fecha_retiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cantidad_txt;
        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.DataGridView dataGridView_prueba;
        private System.Windows.Forms.BindingSource medicamentoCompletoBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.PictureBox buscar_bt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn composicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGenericoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDeLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaElaboracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Seleccionar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}