using ASIC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASIC
{
    public partial class Recuperar_contraseña : Form
    {
        public Recuperar_contraseña()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
            medicamentos_logica.Instancia.LimpiarControles(this);
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            bool respuesta_verificar = medicamentos_logica.Instancia.verificar_Todo_correto(this, 9);
            if (respuesta_verificar)
            {
                string Usuario = usuario.Text;
                string respuesta1 = Respuesta_1.Text;
                string respuesta2 = Respuesta_2.Text;

                string Contraseña = logica_confi.Instancia.RecuperarContraseña(Usuario, respuesta1, respuesta2);
                contraseña.Text = Contraseña;
            }
            else
            {
                MessageBox.Show("Faltan campos sin llenar");
            }
           



        }
        private void buscar_bt_Click(object sender, EventArgs e)
        {
            string Usuario = usuario.Text; // Asegúrate de obtener el nombre de usuario desde el TextBox correspondiente

            // Obtener las preguntas de seguridad
            string pregunta1 = logica_confi.Instancia.ObtenerPreguntaSeguridad1(Usuario);
            string pregunta2 = logica_confi.Instancia.ObtenerPreguntaSeguridad2(Usuario);

            if (!string.IsNullOrEmpty(pregunta1) && !string.IsNullOrEmpty(pregunta2))
            {
                // Mostrar las preguntas en los Labels
                Pregunta_1.Text = pregunta1;
                Pregunta_2.Text = pregunta2;
            }
            else
            {
                MessageBox.Show("El usuario no existe o las preguntas de seguridad no están disponibles.", "Usuario No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}

