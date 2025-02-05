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
    public partial class Form_vista_pacientes : Form
    {
        public Form_vista_pacientes()
        {
            InitializeComponent();
            mostrar_pacientes(); 
        }
        void mostrar_pacientes()
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = salidas_logica.Instancia.Listar_salidas_unicas();
        }

        private void dataGridView_prueba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
