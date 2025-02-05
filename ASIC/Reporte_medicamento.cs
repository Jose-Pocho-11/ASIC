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
    public partial class Reporte_medicamento : Form
    {
        public Reporte_medicamento()
        {
            InitializeComponent();
            mostrar_medicamentos();
            mostrar_categorias();
            mostrar_presentaciones();
            mostrar_NG();
            mostrarcostas();

        }

        private void check_medicamento_CheckedChanged(object sender, EventArgs e)
        {
            if (check_medicamento.Checked == true)
            {
                
                check_categoria.Checked = false;
                combo_categoria.Enabled = false;
                combo_categoria.SelectedIndex = 0;

                check_NG.Checked = false;
                combo_NG.Enabled = false;
                combo_NG.SelectedIndex = 0;

                check_presentacion.Checked = false;
                combo_presentacion.Enabled = false;
                combo_presentacion.SelectedIndex = 0;

                check_Fvencimineto.Checked = false;
                fecha_vencimineto.Enabled = false;

                combo_medicamento.Enabled = true;

            } else if (check_medicamento.Checked == false)
            {
                combo_medicamento.Enabled = false;
                combo_medicamento.SelectedIndex = 0;
            }
        }

        private void check_categoria_CheckedChanged(object sender, EventArgs e)
        {
            if (check_categoria.Checked)
            {
                combo_categoria.Enabled = true;
                check_medicamento.Checked = false;
                combo_medicamento.Enabled = false;
                combo_medicamento.SelectedIndex = 0;

                check_NG.Checked = false;
                combo_NG.Enabled = false;
                combo_NG.SelectedIndex = 0;

                check_presentacion.Checked = false;
                combo_presentacion.Enabled = false;
                combo_presentacion.SelectedIndex = 0;

                check_Fvencimineto.Checked = false;
                fecha_vencimineto.Enabled = false;
            } else
            {
                combo_categoria.Enabled = false;
                combo_categoria.SelectedIndex = 0;
            }
        }

        private void check_NG_CheckedChanged(object sender, EventArgs e)
        {
            if (check_NG.Checked)
            {
                combo_NG.Enabled = true;
                check_medicamento.Checked = false;
                combo_medicamento.Enabled = false;
                combo_medicamento.SelectedIndex = 0;

                check_categoria.Checked = false;
                combo_categoria.Enabled = false;
                combo_categoria.SelectedIndex = 0;

                check_presentacion.Checked = false;
                combo_presentacion.Enabled = false;
                combo_presentacion.SelectedIndex = 0;

                check_Fvencimineto.Checked = false;
                fecha_vencimineto.Enabled = false;
            } else
            {
                combo_NG.Enabled = false;
                combo_NG.SelectedIndex = 0;
            }
        }

        private void check_presentacion_CheckedChanged(object sender, EventArgs e)
        {
            
                if (check_presentacion.Checked)
                {
                    combo_presentacion.Enabled = true;
                    check_medicamento.Checked = false;
                    combo_medicamento.Enabled = false;
                    combo_medicamento.SelectedIndex = 0;

                    check_categoria.Checked = false;
                    combo_categoria.Enabled = false;
                    combo_categoria.SelectedIndex = 0;

                    check_NG.Checked = false;
                    combo_NG.Enabled = false;
                    combo_NG.SelectedIndex = 0;

                    check_Fvencimineto.Checked = false;
                    fecha_vencimineto.Enabled = false;
                }
                else
                {
                    combo_presentacion.Enabled = false; combo_presentacion.SelectedIndex = 0;
                }

                
            
        }
        private void check_Fvencimineto_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Fvencimineto.Checked)
            {
                fecha_vencimineto.Enabled = true;
                check_medicamento.Checked = false; 
                combo_medicamento.Enabled = false;
                combo_medicamento.SelectedIndex = 0;
                
                check_categoria.Checked = false; 
                combo_categoria.Enabled = false; 
                combo_categoria.SelectedIndex = 0;
                
                check_NG.Checked = false;
                combo_NG.Enabled = false;
                combo_NG.SelectedIndex = 0; 

                check_presentacion.Checked = false; 
                combo_presentacion.Enabled = false;
                combo_presentacion.SelectedIndex = 0;
            } else
            {
                fecha_vencimineto.Enabled = false;
            }
        }
        void mostrar_medicamentos()
        {
            List<MedicamentoCompleto> lista_medicamentos = Logica_reportes.Instancia.medicamentosList2();
            lista_medicamentos.Insert(0, new MedicamentoCompleto { Nombre_Medicamento = "Escoge una opción" });
            combo_medicamento.DataSource = lista_medicamentos;
            combo_medicamento.DisplayMember = "Nombre_Medicamento";
            combo_medicamento.ValueMember = "Nombre_Medicamento";
            combo_medicamento.SelectedIndex = 0;
        }

        void mostrar_NG()
        {
            List<MedicamentoCompleto> lista_ng = Logica_reportes.Instancia.nombres_Genericos();
            lista_ng.Insert(0, new MedicamentoCompleto { Nombre_Generico = "Escoge una opción" });
            combo_NG.DataSource = lista_ng;
            combo_NG.DisplayMember = "Nombre_Generico";
            combo_NG.ValueMember = "Nombre_Generico";
            combo_NG.SelectedIndex = 0;
        }

        void mostrar_categorias()
        {
            List<MedicamentoCompleto> lista_ng = Logica_reportes.Instancia.mostrar_categorias();
            lista_ng.Insert(0, new MedicamentoCompleto { Categoria = "Escoge una opción" });
            combo_categoria.DataSource = lista_ng;
            combo_categoria.DisplayMember = "Categoria";
            combo_categoria.ValueMember = "Categoria";
            combo_categoria.SelectedIndex = 0;
        }

        void mostrar_presentaciones()
        {
            List<MedicamentoCompleto> lista_medicamentos = Logica_reportes.Instancia.mostrar_presentaciones();
            lista_medicamentos.Insert(0, new MedicamentoCompleto { Presentacion = "Escoge una opción" });
            combo_presentacion.DataSource = lista_medicamentos;
            combo_presentacion.DisplayMember = "Presentacion";
            combo_presentacion.ValueMember = "Presentacion";
            combo_presentacion.SelectedIndex = 0;
        }

        private void Reporte_medicamento_Load(object sender, EventArgs e)
        {

        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            mostrarcostas(); 
        }
        void mostrarcostas()
        {
            int opc = 0;


            if (check_medicamento.Checked == true)
            {
                opc = 1;
            }
            else if (check_categoria.Checked == true)
            {
                opc = 2;
            }
            else if (check_NG.Checked == true)
            {
                opc = 3;
            }
            else if (check_presentacion.Checked == true)
            {
                opc = 4;
            }
            else if (check_Fvencimineto.Checked == true)
            {
                opc = 5;
            }

            switch (opc)
            {
                case 1:
                    var selectedMedicamento = (MedicamentoCompleto)combo_medicamento.SelectedItem;
                    mostrar("medicamento", selectedMedicamento.Nombre_Medicamento);
                    break;

                case 2:
                    var selectedCategoria = (MedicamentoCompleto)combo_categoria.SelectedItem;
                    mostrar("categoria", selectedCategoria.Categoria);
                    break;

                case 3:
                    var selectedNG = (MedicamentoCompleto)combo_NG.SelectedItem;
                    mostrar("nombre generico", selectedNG.Nombre_Generico); break;

                case 4:
                    var selectedPresentacion = (MedicamentoCompleto)combo_presentacion.SelectedItem;
                    mostrar("presentacion", selectedPresentacion.Presentacion); break;

                case 5:
                    var fecha_vencimiento = fecha_vencimineto.Value.ToString("dd/MM/yyyy") ; 
                    mostrar("fechaV", fecha_vencimiento); break;

                default: mostrar("", ""); break;
            }

            void mostrar(string tipoFiltro, string valor)
            {
                dataGridView_prueba.DataSource = null;
                dataGridView_prueba.DataSource = Logica_reportes.Instancia.Listar_medicamentos(tipoFiltro, valor);
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            generarReporte(); 

        }
        void generarReporte()
        {
            int opc = 0;

            if (check_medicamento.Checked == true)
            {
                opc = 1;
            }
            else if (check_categoria.Checked == true)
            {
                opc = 2;
            }
            else if (check_NG.Checked == true)
            {
                opc = 3;
            }
            else if (check_presentacion.Checked == true)
            {
                opc = 4;
            }
            else if (check_Fvencimineto.Checked == true)
            {
                opc = 5;
            }

            switch (opc)
            {
                case 1:
                    var selectedMedicamento = (MedicamentoCompleto)combo_medicamento.SelectedItem;
                    Logica_reportes.Instancia.GenerarReporteHTMLM("medicamento", selectedMedicamento.Nombre_Medicamento, "reporte_medicamentos");
                    break;

                case 2:
                    var selectedCategoria = (MedicamentoCompleto)combo_categoria.SelectedItem;
                    Logica_reportes.Instancia.GenerarReporteHTMLM("categoria", selectedCategoria.Categoria, "reporte_medicamentos");
                    break;

                case 3:
                    var selectedNG = (MedicamentoCompleto)combo_NG.SelectedItem;
                    Logica_reportes.Instancia.GenerarReporteHTML("nombre generico", selectedNG.Nombre_Generico, "reporte_medicamentos");
                    break;

                case 4:
                    var selectedPresentacion = (MedicamentoCompleto)combo_presentacion.SelectedItem;
                    Logica_reportes.Instancia.GenerarReporteHTMLM("presentacion", selectedPresentacion.Presentacion, "reporte_medicamentos");
                    break;

                case 5:
                    var fecha_vencimiento = fecha_vencimineto.Value.ToString("dd/MM/yyyy");
                    Logica_reportes.Instancia.GenerarReporteHTMLM("fechaV", fecha_vencimiento, "reporte_medicamentos");
                    break;

                default:
                    Logica_reportes.Instancia.GenerarReporteHTMLM("", "", "reporte_medicamentos");
                    break;
            }
        }

        private void combo_medicamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}