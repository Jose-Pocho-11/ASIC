namespace ASIC
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
            this.label3 = new System.Windows.Forms.Label();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.contraseña_txt = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.esconder_V = new System.Windows.Forms.PictureBox();
            this.minimizar_V = new System.Windows.Forms.PictureBox();
            this.maximizar_V = new System.Windows.Forms.PictureBox();
            this.cerrar_V = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.esconder_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // usuario_txt
            // 
            this.usuario_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario_txt.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.usuario_txt.ForeColor = System.Drawing.Color.Gray;
            this.usuario_txt.Location = new System.Drawing.Point(82, 167);
            this.usuario_txt.Multiline = true;
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(302, 38);
            this.usuario_txt.TabIndex = 4;
            this.usuario_txt.Text = "ejemplo";
            this.usuario_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.usuario_txt.Enter += new System.EventHandler(this.textBox1_Enter);
            this.usuario_txt.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(72, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(152, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar Sesión";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(82, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.contraseña_txt);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.usuario_txt);
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 451);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Location = new System.Drawing.Point(80, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 11;
            // 
            // contraseña_txt
            // 
            this.contraseña_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña_txt.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.contraseña_txt.ForeColor = System.Drawing.Color.Gray;
            this.contraseña_txt.Location = new System.Drawing.Point(81, 264);
            this.contraseña_txt.Multiline = true;
            this.contraseña_txt.Name = "contraseña_txt";
            this.contraseña_txt.PasswordChar = '*';
            this.contraseña_txt.Size = new System.Drawing.Size(302, 38);
            this.contraseña_txt.TabIndex = 14;
            this.contraseña_txt.Text = "ejemplo";
            this.contraseña_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.contraseña_txt.Enter += new System.EventHandler(this.textBox3_Enter);
            this.contraseña_txt.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(104, 372);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(238, 19);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseDown);
            this.linkLabel1.MouseHover += new System.EventHandler(this.linkLabel1_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ASIC.Properties.Resources.icons8_contraseña_50;
            this.pictureBox3.Location = new System.Drawing.Point(34, 255);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ASIC.Properties.Resources.img_usuario1;
            this.pictureBox2.Location = new System.Drawing.Point(34, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.esconder_V);
            this.panel4.Controls.Add(this.minimizar_V);
            this.panel4.Controls.Add(this.maximizar_V);
            this.panel4.Controls.Add(this.cerrar_V);
            this.panel4.Location = new System.Drawing.Point(248, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(467, 35);
            this.panel4.TabIndex = 10;
            this.panel4.Visible = false;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // esconder_V
            // 
            this.esconder_V.Cursor = System.Windows.Forms.Cursors.Hand;
            this.esconder_V.Image = global::ASIC.Properties.Resources.icons8_minimizar_la_ventana_32;
            this.esconder_V.Location = new System.Drawing.Point(395, 3);
            this.esconder_V.Name = "esconder_V";
            this.esconder_V.Size = new System.Drawing.Size(31, 32);
            this.esconder_V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.esconder_V.TabIndex = 18;
            this.esconder_V.TabStop = false;
            this.esconder_V.Click += new System.EventHandler(this.esconder_V_Click);
            // 
            // minimizar_V
            // 
            this.minimizar_V.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar_V.Image = global::ASIC.Properties.Resources.icons8_restore_down_32;
            this.minimizar_V.Location = new System.Drawing.Point(295, 0);
            this.minimizar_V.Name = "minimizar_V";
            this.minimizar_V.Size = new System.Drawing.Size(44, 35);
            this.minimizar_V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar_V.TabIndex = 17;
            this.minimizar_V.TabStop = false;
            this.minimizar_V.Visible = false;
            this.minimizar_V.Click += new System.EventHandler(this.minimizar_V_Click);
            // 
            // maximizar_V
            // 
            this.maximizar_V.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar_V.Image = global::ASIC.Properties.Resources.icons8_botón_maximizar_32;
            this.maximizar_V.Location = new System.Drawing.Point(245, 0);
            this.maximizar_V.Name = "maximizar_V";
            this.maximizar_V.Size = new System.Drawing.Size(44, 35);
            this.maximizar_V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar_V.TabIndex = 16;
            this.maximizar_V.TabStop = false;
            this.maximizar_V.Visible = false;
            this.maximizar_V.Click += new System.EventHandler(this.maximizar_V_Click);
            // 
            // cerrar_V
            // 
            this.cerrar_V.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar_V.Image = global::ASIC.Properties.Resources.icons8_cerrar_ventana_32;
            this.cerrar_V.Location = new System.Drawing.Point(432, 3);
            this.cerrar_V.Name = "cerrar_V";
            this.cerrar_V.Size = new System.Drawing.Size(31, 32);
            this.cerrar_V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar_V.TabIndex = 15;
            this.cerrar_V.TabStop = false;
            this.cerrar_V.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ASIC.Properties.Resources.Imagen_de_WhatsApp_2024_11_03_a_las_00_58_43_3208a3dd;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.esconder_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox contraseña_txt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox cerrar_V;
        private System.Windows.Forms.PictureBox esconder_V;
        private System.Windows.Forms.PictureBox minimizar_V;
        private System.Windows.Forms.PictureBox maximizar_V;
    }
}

