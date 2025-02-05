using ASIC.Logica;
using ASIC.Modelo;
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
    public partial class Salidas : Form
    {
        private MedicamentoCompleto medicamento;
        private int enStockActual;
        public Salidas()
        {
            InitializeComponent();
            mostrar_medicamnetos();
        }

        private void CargarDatos(MedicamentoCompleto obj)

        {
            medicamento = obj;
            enStockActual = medicamento.En_Stock;
            nombre_medicamento_txt.Text = medicamento.Nombre_Medicamento;
        }
        int calcular_edad(DateTime fecha)
        {
            int edad_calculada;
            // Obtener la fecha seleccionada en el DateTimePicker
            DateTime fechaNacimiento = fecha;

            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcular la edad
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar si la fecha de nacimiento aún no ha ocurrido este año
            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            // Mostrar la edad en el Label
            return edad_calculada = edad;

        }


        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cedula.Text) || string.IsNullOrWhiteSpace(nombre_apellido_txt.Text)
                || string.IsNullOrWhiteSpace(num_tlf_txt.Text) || string.IsNullOrWhiteSpace(direccion_txt.Text)
                || string.IsNullOrWhiteSpace(patologia_txt.Text) || string.IsNullOrWhiteSpace(fecha_nacimiento.Text)
                || string.IsNullOrWhiteSpace(nombre_medicamento_txt.Text) || string.IsNullOrWhiteSpace(cantidad_txt.Text)
                || string.IsNullOrWhiteSpace(fecha_retiro.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return; // Detener el proceso si algún campo está vacío 
            }
            int edad_calculada = calcular_edad(fecha_nacimiento.Value);

            // Crear el objeto de salida
            clase_salidas objeto = new clase_salidas()
            {
                cedula = cedula.Text, // Tratar cedula como texto
                nombre = nombre_apellido_txt.Text,
                telefono = num_tlf_txt.Text, // Tratar telefono como texto
                direccion = direccion_txt.Text,
                patologia = patologia_txt.Text,
                fecha_nacimiento = fecha_nacimiento.Value.ToString("dd/MM/yyyy"),
                edad = edad_calculada,
                nombre_medicamento = nombre_medicamento_txt.Text,
                cantidad = int.Parse(cantidad_txt.Text), // Convertir cantidad a entero
                fecha_retiro = fecha_retiro.Value.ToString("dd/MM/yyyy"),
            };




            int cantidad_restar = int.Parse(cantidad_txt.Text);

            // Guardar el objeto
            bool respuesta_verificar = medicamentos_logica.Instancia.verificar_Todo_correto(this, 9);
            if (respuesta_verificar)
            {
                bool respuesta0 = salidas_logica.Instancia.verificar_stock(medicamento, cantidad_restar);
                if (respuesta0)
                {
                    bool respuesta1 = salidas_logica.Instancia.guardar_salidas(objeto);
                    if (respuesta1)
                    {
                        bool respuesta = salidas_logica.Instancia.actualizar_cantidad_del_medicamento(medicamento, cantidad_restar);
                        if (respuesta)
                        {
                            MessageBox.Show("Se ha guardado y actualizado en stock con éxito");
                            mostrar_medicamnetos();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("faltan campos sin llenar");
            }

        }

        public void mostrar_medicamnetos()
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = medicamentos_logica.Instancia.Listar();
        }


        private void Salidas_Load(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            medicamentos_logica.Instancia.LimpiarControles(this);
        }
        public void filtrar(string nombreMedicamento)
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = medicamentos_logica.Instancia.Filtrar(nombreMedicamento);
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

        private void buscar_bt_Click(object sender, EventArgs e)
        {
            mostrar_medicamnetos();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "buscar...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "buscar...";
                textBox1.ForeColor = Color.Gray;

            }
        }

        private void dataGridView_prueba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que el índice de la fila sea válido
            {
                int indice = e.RowIndex;
                var Codigo_medicamneto = dataGridView_prueba.Rows[indice].Cells[0].Value.ToString();
                var en_stock = dataGridView_prueba.Rows[indice].Cells[6].Value.ToString();
                string nombre_medicamento = dataGridView_prueba.Rows[indice].Cells[1].Value.ToString();
                int codigoMedicamnetoInt = int.Parse(Codigo_medicamneto);
                int en_stock_int = int.Parse(en_stock);

                MedicamentoCompleto objeto = new MedicamentoCompleto()
                {
                    Codigo = codigoMedicamnetoInt,
                    Nombre_Medicamento = nombre_medicamento,
                    En_Stock = en_stock_int
                };

                if (dataGridView_prueba.Columns[e.ColumnIndex].Name == "Seleccionar")
                {

                    CargarDatos(objeto);
                    nombre_medicamento_txt.Text = nombre_medicamento.ToString();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clase_salidas persona = new clase_salidas()
            {
                cedula = cedula.Text
            };

            bool datosCargados = salidas_logica.Instancia.CargarDatos_de_Personas(persona);
            if (datosCargados)
            { // Mostrar los datos en los controles de texto
                nombre_apellido_txt.Text = persona.nombre;
                num_tlf_txt.Text = persona.telefono;
                direccion_txt.Text = persona.direccion;
                patologia_txt.Text = persona.patologia;
                fecha_nacimiento.Text = persona.fecha_nacimiento;
            }
            else
            {
                MessageBox.Show("No se encontraron datos para la cédula proporcionada.");
            }
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            mostrar_medicamnetos();
        }

        private void cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter
            }
        }

        private void num_tlf_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter }
            }
        }

        private void cantidad_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter }
            }
        }

        private void nombre_apellido_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter }
            }
        }

        private void patologia_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter }
            }
        }

        private void direccion_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter }
            }
        }
    }
}
