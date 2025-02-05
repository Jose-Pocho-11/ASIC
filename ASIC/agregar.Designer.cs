namespace ASIC
{
    partial class agregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nuevo_elemento = new System.Windows.Forms.TextBox();
            this.bt_agg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combo_opciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label1.Location = new System.Drawing.Point(104, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la nueva opción";
            // 
            // txt_nuevo_elemento
            // 
            this.txt_nuevo_elemento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_nuevo_elemento.Location = new System.Drawing.Point(108, 206);
            this.txt_nuevo_elemento.Multiline = true;
            this.txt_nuevo_elemento.Name = "txt_nuevo_elemento";
            this.txt_nuevo_elemento.Size = new System.Drawing.Size(237, 23);
            this.txt_nuevo_elemento.TabIndex = 1;
            // 
            // bt_agg
            // 
            this.bt_agg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bt_agg.Location = new System.Drawing.Point(369, 198);
            this.bt_agg.Name = "bt_agg";
            this.bt_agg.Size = new System.Drawing.Size(89, 39);
            this.bt_agg.TabIndex = 2;
            this.bt_agg.Text = "Agregar";
            this.bt_agg.UseVisualStyleBackColor = true;
            this.bt_agg.Click += new System.EventHandler(this.bt_agg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 149);
            this.dataGridView1.TabIndex = 3;
            // 
            // combo_opciones
            // 
            this.combo_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_opciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.combo_opciones.FormattingEnabled = true;
            this.combo_opciones.Items.AddRange(new object[] {
            "Escoge una Opción",
            "Categoria",
            "Nombre Genérico ",
            "Presentación"});
            this.combo_opciones.Location = new System.Drawing.Point(108, 125);
            this.combo_opciones.Name = "combo_opciones";
            this.combo_opciones.Size = new System.Drawing.Size(237, 25);
            this.combo_opciones.TabIndex = 4;
            this.combo_opciones.SelectedIndexChanged += new System.EventHandler(this.combo_opciones_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label2.Location = new System.Drawing.Point(295, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregando Nuevos Elementos";
            // 
            // agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_opciones);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_agg);
            this.Controls.Add(this.txt_nuevo_elemento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregar";
            this.Text = "agregar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nuevo_elemento;
        private System.Windows.Forms.Button bt_agg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_opciones;
        private System.Windows.Forms.Label label2;
    }
}