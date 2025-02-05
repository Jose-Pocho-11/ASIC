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
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
            
        }
        public void mostrar_Presentaciones()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = medicamentos_logica.Instancia.ComboList_Presentacion();
        }
        public void mostrar_nombres_genericos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = medicamentos_logica.Instancia.ComboList_Nombres_Genericos();
        }
        public void mostrar_categorias()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = medicamentos_logica.Instancia.ComboList();
        }
        private void bt_agg_Click(object sender, EventArgs e)
        {
            string nombre_elemento = txt_nuevo_elemento.Text;
            int opcion = combo_opciones.SelectedIndex;
            bool respuesta;


            switch (opcion)
            {
                case 1: respuesta = medicamentos_logica.Instancia.verificar_combo_Categoria("categorias", "nombre_categoria", nombre_elemento);
                    mostrar_categorias();
                    
                    break;
                case 2: respuesta = medicamentos_logica.Instancia.verificar_combo_Categoria("nombre_genericos", "nombre_principio_activo", nombre_elemento); mostrar_nombres_genericos();   break;
                case 3: respuesta = medicamentos_logica.Instancia.verificar_combo_Categoria("presentaciones", "nombre_presentacion", nombre_elemento); mostrar_Presentaciones(); break;
                default: MessageBox.Show("Por favor Ingrese una opción"); break;
            }
        }

        private void combo_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_opciones.SelectedIndex = 0; 
        }
    }
}
