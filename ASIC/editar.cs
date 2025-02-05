using ASIC.Logica;
using ASIC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ASIC
{
    public partial class editar : Form
    {
        private MedicamentoCompleto medicamento; 
        public editar()
        {
            InitializeComponent();

            mostrar_medicamnetos();
            mostrar_presentacion();
            mostrar_categorias();
            mostrar_nombres_genericos();
        }
        public editar(MedicamentoCompleto medicamento) 
        {
            InitializeComponent(); 
            this.medicamento = medicamento;
            CargarDatos(); 
        }



        private void CargarDatos()
        {
            // Asignar valores a los controles de texto
            codigo_txt.Text = medicamento.Codigo.ToString();
            numero_lote_txt.Text = medicamento.Numero_De_Lote.ToString();
            nombre_medicamento_txt.Text = medicamento.Nombre_Medicamento;
            cantidad_txt.Text = medicamento.Composicion.ToString();
            stock_txt.Text = medicamento.En_Stock.ToString();
            fecha_entrega.Text = medicamento.Fecha_Elaboracion;
            fecha_vencimiento.Text = medicamento.Fecha_Caducidad;

            // Asignar valores a los ComboBox por ID
            medida_combo.SelectedIndex = medida_combo.FindStringExact(medicamento.Medida);
            nombre_generico_combo.SelectedIndex = nombre_generico_combo.FindStringExact(medicamento.Nombre_Generico); 
            categorias_combo.SelectedIndex = categorias_combo.FindStringExact(medicamento.Categoria); 
            presentacion_combo.SelectedIndex = presentacion_combo.FindStringExact(medicamento.Presentacion);

            
        }




        private void editar_Load(object sender, EventArgs e)
        {
            mostrar_medicamnetos();
            mostrar_presentacion();
            mostrar_categorias();
            mostrar_nombres_genericos();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            
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
                    Fecha_Caducidad = fecha_vencimiento.Text,
                    Fecha_Elaboracion = fecha_entrega.Text,

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
                    bool respuesta2 = medicamentos_logica.Instancia.guardarOActualizarLote(objeto2);
                    if (respuesta2 == true)
                    {
                        bool respuesta = medicamentos_logica.Instancia.actualizar(objeto);
                        if (respuesta && respuesta2)
                        {
                            MessageBox.Show("Se ha actualizado con exito el medicamento");
                            mostrar_medicamnetos();
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

        public void mostrar_presentacion()
        {
            //usar el SelectedIndex
            List<clase_presentaciones> listaPresentaciones = medicamentos_logica.Instancia.ComboList_Presentacion();
            listaPresentaciones.Insert(0, new clase_presentaciones { nombre_presentacion = "Escoge una opción" });
            presentacion_combo.DataSource = listaPresentaciones;
            presentacion_combo.DisplayMember = "nombre_presentacion";
            presentacion_combo.ValueMember = "nombre_presentacion";
            //presentacion_combo.SelectedIndex = 0;
            CargarDatos(); 

        }

        public void mostrar_nombres_genericos()
        {
            //usar el SelectedIndex
            List<clase_nombres_genericos> listaNombres_Genericos = medicamentos_logica.Instancia.ComboList_Nombres_Genericos();
            listaNombres_Genericos.Insert(0, new clase_nombres_genericos { nombre_principio_activo = "Escoge una opción" });
            nombre_generico_combo.DataSource = listaNombres_Genericos;
            nombre_generico_combo.DisplayMember = "nombre_principio_activo";
            nombre_generico_combo.ValueMember = "nombre_principio_activo";
            //nombre_generico_combo.SelectedIndex = 0;
            CargarDatos();

        }

        public void mostrar_categorias()
        {
            //usar el SelectedIndex
            List<clase_categorias> listaCategorias = medicamentos_logica.Instancia.ComboList();
            listaCategorias.Insert(0, new clase_categorias { nombre_categoria = "Escoge una opción" });
            categorias_combo.DataSource = listaCategorias;
            categorias_combo.DisplayMember = "nombre_categoria";
            categorias_combo.ValueMember = "nombre_categoria";
            //categorias_combo.SelectedIndex = 0;
            CargarDatos();

        }
        

        private void bt_cancelar_Click(object sender, EventArgs e)
            
        {
           
            this.Close();
            //medicamentos_logica.Instancia.LimpiarControles(this);
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            mostrar_medicamnetos(); 
        }

        private void nombre_medicamento_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void stock_txt_TextChanged(object sender, EventArgs e)
        {

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
                e.Handled = true; // Ignorar el carácter
            }
        }

        private void nombre_medicamento_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
