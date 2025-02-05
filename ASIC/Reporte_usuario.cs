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
    public partial class Reporte_usuario : Form
    {
        public Reporte_usuario()
        {
            InitializeComponent();
            mostrar_patologias();
            mostrar_medicamentos();
            mostrar("", "");


        }

        private void check_medicamentos_CheckedChanged(object sender, EventArgs e)
        {
            if (check_medicamentos.Checked == true) 
            {
                check_patologia.Checked= false;
                combo_patologias.Enabled= false;
                combo_patologias.SelectedIndex = 0; 


                comboMedicamentos.Enabled = true;

            }
            else if(check_medicamentos.Checked == false)
            {
                comboMedicamentos.Enabled = false;
                comboMedicamentos.SelectedIndex = 0; 

            }
        }

        private void check_patologia_CheckedChanged(object sender, EventArgs e)
        {

            if (check_patologia.Checked == true)
            {
                check_medicamentos.Checked = false; 
                comboMedicamentos.Enabled = false; 
                comboMedicamentos.SelectedIndex = 0;

               

                combo_patologias.Enabled = true; 
            }
            else if (check_patologia.Checked == false)
            {
                combo_patologias.Enabled = false; combo_patologias.SelectedIndex = 0;
            }



        }

        //private void check_edad_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (check_edad.Checked == true) 
        //    { 
        //        check_medicamentos.Checked = false; 
        //        comboMedicamentos.Enabled = false; 
        //        comboMedicamentos.SelectedIndex = 0; 

        //        check_patologia.Checked = false; 
        //        combo_patologias.Enabled = false; 
        //        combo_patologias.SelectedIndex = 0; 

        //        edad_txt.Enabled = true; 
        //        edad_txt.ReadOnly = false; 
        //    } else if (check_edad.Checked == false) 
        //    { 
        //        edad_txt.Enabled = false;
        //        edad_txt.Text = ""; 
        //    }
        //}

        void mostrar_patologias()
        {
            List<clase_salidas> lista_patologia = Logica_reportes.Instancia.patologiaList();
            lista_patologia.Insert(0, new clase_salidas { patologia = "Escoge una opción" });
            combo_patologias.DataSource = lista_patologia;
            combo_patologias.DisplayMember = "patologia";
            combo_patologias.ValueMember = "patologia";
            combo_patologias.SelectedIndex = 0;
        }

        void mostrar_medicamentos()
        {
            List<clase_salidas> lista_medicamentos = Logica_reportes.Instancia.medicamentosList();
            lista_medicamentos.Insert(0, new clase_salidas { nombre_medicamento = "Escoge una opción" });
            comboMedicamentos.DataSource = lista_medicamentos;
            comboMedicamentos.DisplayMember = "nombre_medicamento";
            comboMedicamentos.ValueMember = "nombre_medicamento";
            comboMedicamentos.SelectedIndex = 0;
        }

        private void Reporte_usuario_Load(object sender, EventArgs e)
        {

        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            mostrarcostas();

        }
        void mostrarcostas()
        {
            int opc = 0;

            
            if (check_patologia.Checked == true)
            {
                opc = 2;
            }
            else if (check_medicamentos.Checked == true)
            {
                opc = 1;
            }

            switch (opc)
            {
                case 1:
                    var selectedMedicamento = (clase_salidas)comboMedicamentos.SelectedItem;
                    mostrar("medicamento", selectedMedicamento.nombre_medicamento);
                    break;

                case 2:
                    var selectedPatologia = (clase_salidas)combo_patologias.SelectedItem;
                    mostrar("patologia", selectedPatologia.patologia);
                    break;

                case 3: break;

                default: mostrar("", ""); break;
            }
        }


        void mostrar(string tipoFiltro, string valor)
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = Logica_reportes.Instancia.Listar_usuarios(tipoFiltro,valor);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            medicamentos_logica.Instancia.LimpiarControles(this);
        }
        public void filtrar(string cedula)
        {
            dataGridView_prueba.DataSource = null;
            dataGridView_prueba.DataSource = Logica_reportes.Instancia.Filtrar(cedula);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cedula = textBox1.Text;
            if (cedula != ""|| cedula == "buscar...")
            {
                filtrar(cedula);
            }
            else
            {
                mostrar("", "");
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            //if (textBox1.Text == "buscar...")
            //{
            //    textBox1.Text = "";
            //    textBox1.ForeColor = Color.Black;
            //}
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

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    textBox1.Text = "buscar...";
            //    textBox1.ForeColor = Color.Gray;

            //}
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "buscar...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            int opc = 0;

           
             if (check_patologia.Checked == true)
            {
                opc = 2;
            }
            else if (check_medicamentos.Checked == true)
            {
                opc = 1;
            }

            switch (opc)
            {
                case 1:
                    var selectedMedicamento = (clase_salidas)comboMedicamentos.SelectedItem;
                    Logica_reportes.Instancia.GenerarReporteHTML("medicamento", selectedMedicamento.nombre_medicamento,"plantilla");
                    break;

                case 2:
                    var selectedPatologia = (clase_salidas)combo_patologias.SelectedItem;
                    Logica_reportes.Instancia.GenerarReporteHTML("patologia", selectedPatologia.patologia, "plantilla");
                    break;

                case 3: break;

                default:  Logica_reportes.Instancia.GenerarReporteHTML("", "", "plantilla"); break;
            }
             
        }
    }
}
