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
    public partial class reporte_salida : Form
    {
        public reporte_salida()
        {
            InitializeComponent();
            mostrar_medicamentos();
            mostrarcostas();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(check_fechas.Checked == true)
            {
                fecha_hasta.Enabled = true;
                fecha_desde.Enabled = true;

                check_medicamentos.Checked = false;
                comboMedicamentos.Enabled = false;
            }else if (check_fechas.Checked==false) 
            {
                fecha_hasta.Enabled = false;
                fecha_desde.Enabled = false;
            }
        }

        private void check_medicamentos_CheckedChanged(object sender, EventArgs e)
        {
            if (check_medicamentos.Checked == true)
            {
                comboMedicamentos.Enabled = true;
                check_fechas.Checked = false;

                fecha_hasta.Enabled = false; 
                fecha_desde.Enabled = false;

            }
            else if (check_medicamentos.Checked == false)
            {
                comboMedicamentos.Enabled = false;
                //comboMedicamentos.SelectedIndex = 0;
            }

        }

        void mostrar_medicamentos()
        {
            List<clase_salidas> lista_medicamentos = Logica_reportes.Instancia.medicamentosList3();
            lista_medicamentos.Insert(0, new clase_salidas { nombre_medicamento = "Escoge una opción" });
            comboMedicamentos.DataSource = lista_medicamentos;
            comboMedicamentos.DisplayMember = "nombre_medicamento";
            comboMedicamentos.ValueMember = "nombre_medicamento";
            comboMedicamentos.SelectedIndex = 0;
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            mostrarcostas(); 
        }
        void mostrarcostas()
        {
            int opc = 0;


            if (check_medicamentos.Checked == true)
            {
                opc = 1;
            }
            else if (check_fechas.Checked == true)
            {
                opc = 2;
            }

            switch (opc)
            {
                case 1:
                    var selectedMedicamento = (clase_salidas)comboMedicamentos.SelectedItem;
                    mostrar("medicamento", selectedMedicamento.nombre_medicamento);
                    break;

                case 2:
                    string fechaInicio = fecha_desde.Value.ToString("dd-MM-yyyy"); 
                    string fechaFin = fecha_hasta.Value.ToString("dd-MM-yyyy");
                    mostrar("fechas", fechaInicio, fechaFin);
                    break;

                case 3: break;

                default: mostrar("", ""); break;
            }
        }
        void mostrar(string tipoFiltro, string valor)
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = Logica_reportes.Instancia.Listar_salidas(tipoFiltro, valor);
        }
        void mostrar(string tipoFiltro, string fechaInicio, string fechaFin) 
        {
            dataGridView_prueba.DataSource = null; 
            dataGridView_prueba.DataSource = Logica_reportes.Instancia.Listar_salidas(tipoFiltro, null, fechaInicio, fechaFin);
        }


        private void comboMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            medicamentos_logica.Instancia.LimpiarControles(this);

        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            int opc = 0;


            if (check_medicamentos.Checked == true)
            {
                opc = 1;
            }
            else if (check_fechas.Checked == true)
            {
                opc = 2;
            }

            switch (opc)
            {
                case 1:
                    var selectedMedicamento = (clase_salidas)comboMedicamentos.SelectedItem;
                    Logica_reportes.Instancia.GenerarReporteHTMLSalidas("medicamento", selectedMedicamento.nombre_medicamento, "plantilla_salidas");
                    break;

                case 2:
                    string fechaInicio = fecha_desde.Value.ToString("dd-MM-yyyy");
                    string fechaFin = fecha_hasta.Value.ToString("dd-MM-yyyy");

                    Logica_reportes.Instancia.GenerarReporteHTMLSalidas("fecha",null,"plantilla_salidas",fechaInicio, fechaFin);
                    break;

                case 3: break;

                default: Logica_reportes.Instancia.GenerarReporteHTMLSalidas("", "", "plantilla_salidas"); break;
            }

        }
    }

}

