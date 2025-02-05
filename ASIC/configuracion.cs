using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASIC.Modelo;
using ASIC.Logica; 

namespace ASIC
{
    public partial class configuracion : Form
    {
        public configuracion()
        {
            InitializeComponent();
            MostrarAlertaStock(); 
        }

       

        private void codigo_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter }
            }
        }
        private void MostrarAlertaStock()
        {
            int alertaStock = logica_confi.Instancia.ObtenerAlertaStock();
            stock.Text = alertaStock.ToString();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            string nueva_alerta = stock.Text; 
            logica_confi.Instancia.ActualizarAlertaStock(int.Parse(nueva_alerta));
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            medicamentos_logica.Instancia.LimpiarControles(this);
        }
    }
}
