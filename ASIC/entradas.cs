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
    public partial class entradas : Form
    {

        public entradas()
        {
            InitializeComponent();
            mostrar_medicamnetos();
            mostrar_presentacion();
            mostrar_categorias();
            mostrar_nombres_genericos();
            medida_combo.SelectedIndex = 0;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            string numeroDeLote; 
            int codigo, composicion, enStock;
            if (!int.TryParse(codigo_txt.Text, out codigo) ||
                !int.TryParse(cantidad_txt.Text, out composicion) ||
                
                !int.TryParse(stock_txt.Text, out enStock))
            {
                MessageBox.Show("Error: La cadena de entrada no tiene el formato correcto.");
                return;
            }



            MedicamentoCompleto objeto = new MedicamentoCompleto()
            {
                Codigo = int.Parse(codigo_txt.Text),
                Nombre_Medicamento = nombre_medicamento_txt.Text.ToLower(),
                Composicion = int.Parse(cantidad_txt.Text),
                Medida = medida_combo.SelectedItem.ToString().ToLower(),
                Nombre_Generico = nombre_generico_combo.SelectedIndex.ToString(),
                Numero_De_Lote = numero_lote_txt.Text,
                En_Stock = int.Parse(stock_txt.Text),
                Categoria = categorias_combo.SelectedIndex.ToString().ToLower(),
                Presentacion = presentacion_combo.SelectedIndex.ToString().ToLower(),
                Fecha_Caducidad = fecha_vencimiento.Value.ToString("dd/MM/yyyy"),
                Fecha_Elaboracion = fecha_entrega.Value.ToString("dd/MM/yyyy"),

            };
            Clase_lotes objeto2 = new Clase_lotes()
            {
                id_L = numero_lote_txt.Text,
                fecha_elaboracion = fecha_entrega.Text,
                fecha_caducidad = fecha_vencimiento.Text,
            };

            bool respuesta_verificar = medicamentos_logica.Instancia.verificar_Todo_correto(this, 9);
            if (respuesta_verificar)
            {
                bool respuesta2 = medicamentos_logica.Instancia.guardarL(objeto2);
                if (respuesta2 == true)
                {
                    bool respuesta = medicamentos_logica.Instancia.guardar(objeto);
                    if (respuesta && respuesta2)
                    {
                        mostrar_medicamnetos();
                    }
                }
            }
            else
            {
                MessageBox.Show("faltan campos sin llenar");
            }
        }



        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            mostrar_medicamnetos();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            medicamentos_logica.Instancia.LimpiarControles(this);
            //string nombre_categoria = categorias_combo.Text.ToString(); 
            //MessageBox.Show(nombre_categoria); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void mostrar_medicamnetos()
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = medicamentos_logica.Instancia.Listar();
        }

        public void mostrar_presentacion()
        {
            //usar el SelectedIndex
            List<clase_presentaciones> listaPresentaciones = medicamentos_logica.Instancia.ComboList_Presentacion();
            listaPresentaciones.Insert(0, new clase_presentaciones { nombre_presentacion = "Escoge una opción" });
            presentacion_combo.DataSource = listaPresentaciones;
            presentacion_combo.DisplayMember = "nombre_presentacion";
            presentacion_combo.ValueMember = "nombre_presentacion";
            presentacion_combo.SelectedIndex = 0;

        }

        public void mostrar_nombres_genericos()
        {
            //usar el SelectedIndex
            List<clase_nombres_genericos> listaNombres_Genericos = medicamentos_logica.Instancia.ComboList_Nombres_Genericos();
            listaNombres_Genericos.Insert(0, new clase_nombres_genericos { nombre_principio_activo = "Escoge una opción" });
            nombre_generico_combo.DataSource = listaNombres_Genericos;
            nombre_generico_combo.DisplayMember = "nombre_principio_activo";
            nombre_generico_combo.ValueMember = "nombre_principio_activo";
            nombre_generico_combo.SelectedIndex = 0;

        }

        public void mostrar_categorias()
        {
            //usar el SelectedIndex
            List<clase_categorias> listaCategorias = medicamentos_logica.Instancia.ComboList();
            listaCategorias.Insert(0, new clase_categorias { nombre_categoria = "Escoge una opción" });
            categorias_combo.DataSource = listaCategorias;
            categorias_combo.DisplayMember = "nombre_categoria";
            categorias_combo.ValueMember = "nombre_categoria";
            categorias_combo.SelectedIndex = 0;

        }
        private void categorias_combo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void categorias_combo_DropDown(object sender, EventArgs e)
        {
            //clase_categorias objeto3 = new clase_categorias()
            //{
            //    nombre_categoria = categorias_combo.Text.ToLower()
            //};
            //if (categorias_combo.SelectedIndex == 0)
            //{
            //    MessageBox.Show(categorias_combo.SelectedIndex.ToString() + "\nno se agg noda");
            //}
            //else
            //{
            //    bool respuesta3 = medicamentos_logica.Instancia.verificar_combo_Categoria(objeto3);
            //    if (respuesta3)
            //    {
            //        mostrar_medicamnetos();
            //    }
            //}

        }

        private void entradas_Load(object sender, EventArgs e)
        {

            //mostrar_categorias();
            //mostrar_presentacion(); 
        }

        private void bt_guardar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void nombre_generico_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void codigo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter 
            }
        }

        private void codigo_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_medicamento_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_medicamento_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter }
            }
        }

        private void cantidad_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter
            }

        }

        private void stock_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter }
            }
        }

        private void numero_lote_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true; // Ignorar el carácter
            //}
        }

        private void stock_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidad_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero_lote_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
