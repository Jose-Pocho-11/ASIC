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
using ASIC.Logica; 


namespace ASIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (usuario_txt.Text == "ejemplo")
            {
                usuario_txt.Text="";
                usuario_txt.ForeColor = Color.Black;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (contraseña_txt.Text == "ejemplo")
            {
                contraseña_txt.Text = "";
                contraseña_txt.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (usuario_txt.Text == "")
            {
                usuario_txt.Text= "ejemplo";
                usuario_txt.ForeColor= Color.Gray;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (contraseña_txt.Text == "")
            {
                contraseña_txt.Text = "ejemplo";
                contraseña_txt.ForeColor = Color.Gray;

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrar_ventana_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_V_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            minimizar_V.Visible=true;
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
            this.WindowState=FormWindowState.Minimized;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            //linkLabel1.ForeColor = Color.RoyalBlue; 
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.RoyalBlue;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Recuperando_contraseña = new Recuperar_contraseña();
            Recuperando_contraseña.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clase_login obj = new clase_login()
            {
                usuario = usuario_txt.Text,
                contraseña = contraseña_txt.Text
            };
            string cargo; 
            bool esValido = login_logica.Instancia.verificar_usuario(obj, out cargo);

            if (esValido)
            {
                MessageBox.Show("Credenciales válidas. Acceso concedido.", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                obj.cargo = cargo; 
                panelControl formMenu_Inicio = new panelControl();
                this.Hide();
                formMenu_Inicio.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


       

    }
}
