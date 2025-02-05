namespace ASIC
{
    partial class Recuperar_contraseña
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
            this.label8 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pregunta_2 = new System.Windows.Forms.Label();
            this.Pregunta_1 = new System.Windows.Forms.Label();
            this.Respuesta_1 = new System.Windows.Forms.TextBox();
            this.Respuesta_2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.buscar_bt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buscar_bt)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Recuperando contraseña";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Salmon;
            this.bt_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bt_cancelar.Location = new System.Drawing.Point(655, 381);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(117, 39);
            this.bt_cancelar.TabIndex = 36;
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
            this.bt_guardar.Location = new System.Drawing.Point(522, 381);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(117, 39);
            this.bt_guardar.TabIndex = 35;
            this.bt_guardar.Text = "Recuperar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(284, 104);
            this.usuario.Multiline = true;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(229, 25);
            this.usuario.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre de Usuario";
            // 
            // Pregunta_2
            // 
            this.Pregunta_2.AutoSize = true;
            this.Pregunta_2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregunta_2.Location = new System.Drawing.Point(280, 230);
            this.Pregunta_2.Name = "Pregunta_2";
            this.Pregunta_2.Size = new System.Drawing.Size(98, 21);
            this.Pregunta_2.TabIndex = 37;
            this.Pregunta_2.Text = "pregunta 2";
            // 
            // Pregunta_1
            // 
            this.Pregunta_1.AutoSize = true;
            this.Pregunta_1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregunta_1.Location = new System.Drawing.Point(280, 156);
            this.Pregunta_1.Name = "Pregunta_1";
            this.Pregunta_1.Size = new System.Drawing.Size(96, 21);
            this.Pregunta_1.TabIndex = 38;
            this.Pregunta_1.Text = "Pregunta 1";
            // 
            // Respuesta_1
            // 
            this.Respuesta_1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta_1.Location = new System.Drawing.Point(284, 180);
            this.Respuesta_1.Multiline = true;
            this.Respuesta_1.Name = "Respuesta_1";
            this.Respuesta_1.Size = new System.Drawing.Size(229, 25);
            this.Respuesta_1.TabIndex = 39;
            // 
            // Respuesta_2
            // 
            this.Respuesta_2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta_2.Location = new System.Drawing.Point(284, 254);
            this.Respuesta_2.Multiline = true;
            this.Respuesta_2.Name = "Respuesta_2";
            this.Respuesta_2.Size = new System.Drawing.Size(229, 25);
            this.Respuesta_2.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "La Contraseña es: ";
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(416, 344);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(103, 21);
            this.contraseña.TabIndex = 42;
            this.contraseña.Text = "Contraseña";
            // 
            // buscar_bt
            // 
            this.buscar_bt.BackColor = System.Drawing.Color.White;
            this.buscar_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar_bt.Image = global::ASIC.Properties.Resources.icons8_google_web_search_52__2_;
            this.buscar_bt.Location = new System.Drawing.Point(519, 104);
            this.buscar_bt.Name = "buscar_bt";
            this.buscar_bt.Size = new System.Drawing.Size(26, 25);
            this.buscar_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buscar_bt.TabIndex = 43;
            this.buscar_bt.TabStop = false;
            this.buscar_bt.Click += new System.EventHandler(this.buscar_bt_Click);
            // 
            // Recuperar_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscar_bt);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Respuesta_2);
            this.Controls.Add(this.Respuesta_1);
            this.Controls.Add(this.Pregunta_1);
            this.Controls.Add(this.Pregunta_2);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.MaximizeBox = false;
            this.Name = "Recuperar_contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar_contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.buscar_bt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pregunta_2;
        private System.Windows.Forms.Label Pregunta_1;
        private System.Windows.Forms.TextBox Respuesta_1;
        private System.Windows.Forms.TextBox Respuesta_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.PictureBox buscar_bt;
    }
}