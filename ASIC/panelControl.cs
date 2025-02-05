using ASIC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASIC
{
    public partial class panelControl : Form
    {
        private clase_login usuario; 
        public panelControl()
        {

            InitializeComponent();
            //string usuario = usurio_txt.text; 
            //string contraseña = contraseña_txt.text;
            CargarDatos(usuario);
            abrir_panel(new panel_control());
            
            
        }
        internal panelControl(clase_login usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            CargarDatos(usuario);
        }
        private void CargarDatos(clase_login usuario)
        {
            this.usuario = usuario; 
            // Usar la variable `usuario` para acceder a los datos necesarios
            if (usuario != null)
            {
                labelUsuario.Text = usuario.usuario.ToString();
                labelCargo.Text = usuario.cargo.ToString();
            }
            else
            {

            }
             
        }
         [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        public void abrir_panel(object formpanel)
        {
            if (this.panel_principal.Controls.Count > 0)
            {
                this.panel_principal.Controls.RemoveAt(0);
                Form fh = formpanel as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_principal.Controls.Add(fh);
                this.panel_principal.Tag = fh;
                fh.Show();
            }
        }

        private void panelControl_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrar_V_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_V_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            minimizar_V.Visible = true;
            maximizar_V.Visible = false;
        }

        private void minimizar_V_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            minimizar_V.Visible = false;
            maximizar_V.Visible = true;
        }

        private void esconder_V_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void entradas_bt_MouseHover(object sender, EventArgs e)
        {
            panel34.Visible = true; 
            //entradas_bt.ForeColor = Color.Black; 
        }

        private void entradas_bt_MouseLeave(object sender, EventArgs e)
        {
            panel34.Visible = false;
            entradas_bt.ForeColor = Color.WhiteSmoke;
        }

        private void salidas_bt_MouseHover(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void salidas_bt_MouseLeave(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void reportes_bt_MouseHover(object sender, EventArgs e)
        {
            panel10.Visible = true;
        }

        private void reportes_bt_MouseLeave(object sender, EventArgs e)
        {
            panel10.Visible = false;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            Form1 login= new Form1();
            this.Hide();
            login.Show();
        }

        private void configuracion_bt_MouseHover(object sender, EventArgs e)
        {
            panel12.Visible = true;
        }

        private void configuracion_bt_MouseLeave(object sender, EventArgs e)
        {
            panel12.Visible = false;
        }

        private void panel_principal_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            abrir_panel(new panel_control());
        }

        private void entradas_bt_MouseHover_1(object sender, EventArgs e)
        {
            panel34.Visible = true;
        }

        private void entradas_bt_MouseLeave_1(object sender, EventArgs e)
        {
            panel34.Visible = false; 
        }

        private void salidas_bt_Click(object sender, EventArgs e)
        {
            panel_reportes();
            abrir_panel(new Salidas());
        }

        private void configuracion_bt_Click(object sender, EventArgs e)
        {
            panel_reportes();
            abrir_panel(new Soporte()); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrir_panel(new panel_control());
        }

        private void entradas_bt_Click(object sender, EventArgs e)
        {
            panel_reportes(); 
            abrir_panel(new entradas());
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        void panel_reportes()
        {
            if (panel_de_reportes.Visible == true)
            {
                panel_de_reportes.Visible = false;
            }
           
        }
        private void reportes_bt_Click(object sender, EventArgs e)
        {

            
            if (panel_de_reportes.Visible == true)
            {
                panel_de_reportes.Visible = false;
            }
            else
            {
                panel_de_reportes.Visible = true;
            }

        }

        private void btn_R_usuarios_Click(object sender, EventArgs e)
        {
            panel_reportes();
            abrir_panel(new Reporte_usuario());
        }

        private void btn_R_usuarios_MouseHover(object sender, EventArgs e)
        {
            panel_1.Visible = true;
        }

        private void btn_R_usuarios_MouseLeave(object sender, EventArgs e)
        {
            panel_1.Visible = false;
        }

        private void btn_R_medicamentos_MouseHover(object sender, EventArgs e)
        {
            panel_2.Visible = true;
        }

        private void btn_R_medicamentos_MouseLeave(object sender, EventArgs e)
        {
            panel_2.Visible = false;
        }

        private void btn_R_salidas_MouseHover(object sender, EventArgs e)
        {
            panel_3.Visible = true;
        }
        private void btn_R_salidas_MouseLeave(object sender, EventArgs e)
        {
            panel_3.Visible = false;
        }

        private void btn_R_salidas_Click(object sender, EventArgs e)
        {
            abrir_panel(new reporte_salida());
            panel_reportes();
        }

        private void btn_R_salidas_MouseLeave_1(object sender, EventArgs e)
        {
            panel_3.Visible = false;
        }

        private void btn_R_medicamentos_Click(object sender, EventArgs e)
        {
            abrir_panel(new Reporte_medicamento());
            panel_reportes();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //abrir_panel(new agregar()); 
        //}
    }
}
