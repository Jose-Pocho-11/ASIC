using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASIC.Logica;
using ASIC.Modelo;

namespace ASIC
{
    public partial class panel_control : Form
    {
        
        public panel_control()
        {
            InitializeComponent();
            mostrar_medicamnetos();
            //string nombreMedicamento = textBox1.Text;
            //if ( nombreMedicamento !="")
            //{
            //    filtrar(nombreMedicamento);
            //}
            
            

        }
        public void mostrar_medicamnetos()
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = medicamentos_logica.Instancia.Listar();
        }
        public void filtrar(string nombreMedicamento)
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = medicamentos_logica.Instancia.Filtrar(nombreMedicamento);
        }
        public void Mostrar_Medicamentos_alerta()
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = medicamentos_logica.Instancia.mostrar_medicamentos_alerta();
        }


        private void buscar_bt_Click(object sender, EventArgs e)
        {
            mostrar_medicamnetos(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombreMedicamento = textBox1.Text;
            if (nombreMedicamento != "")
            {
                filtrar(nombreMedicamento);
            }
            else
            {
                mostrar_medicamnetos(); 
            }
        }



        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "buscar...";
                textBox1.ForeColor = Color.Gray;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "buscar...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void panel_control_Load(object sender, EventArgs e)
        {
            int medicamentosEnAlerta = medicamentos_logica.Instancia.Alerta_stock();
            label5.Text =  medicamentosEnAlerta.ToString();

        }

        private void atributosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



        private void dataGridView_prueba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que el índice de la fila sea válido
            {
                int indice = e.RowIndex;
                var Codigo_medicamneto = dataGridView_prueba.Rows[indice].Cells[0].Value.ToString();
                var Numero_lote = dataGridView_prueba.Rows[indice].Cells[5].Value.ToString();
                int codigoMedicamnetoInt = int.Parse(Codigo_medicamneto);
                string numeroLoteInt = Numero_lote;
                    
                MedicamentoCompleto objeto = new MedicamentoCompleto()
                {
                    Codigo = codigoMedicamnetoInt,
                    Numero_De_Lote = numeroLoteInt,
                };

                if (dataGridView_prueba.Columns[e.ColumnIndex].Name == "Editar")
                {
                    if (MessageBox.Show("¿Seguro que quieres editar este lote?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool datosCargados = medicamentos_logica.Instancia.CargarDatos(objeto);
                        if (datosCargados)
                        {

                            Form editar = new editar(objeto);
                            editar.ShowDialog();
                            mostrar_medicamnetos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para el medicamento seleccionado.");
                        }
                    }
                }

                if (dataGridView_prueba.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    if (MessageBox.Show("¿Seguro que quieres eliminar este lote?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool respuesta = medicamentos_logica.Instancia.eliminar_registro(objeto, codigoMedicamnetoInt, numeroLoteInt);
                        mostrar_medicamnetos();
                    }
                }
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Mostrar_Medicamentos_alerta();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form Form_vista_pacientes = new Form_vista_pacientes();
            Form_vista_pacientes.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form Form_vista_pacientes = new Form_vista_pacientes();
            Form_vista_pacientes.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form Form_vista_proximosVc = new configuracion();
            Form_vista_proximosVc.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form Form_vista_proximosVc = new configuracion();
            Form_vista_proximosVc.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
