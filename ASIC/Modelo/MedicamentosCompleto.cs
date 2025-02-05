using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASIC.Modelo
{
   

        public class MedicamentoCompleto
        {
            public int Codigo { get; set; } //esto
            public string Nombre_Medicamento { get; set; } //esto
            public int Composicion { get; set; } //esto
            public string Medida { get; set; }
            public string Nombre_Generico { get; set; } //esto
            
            public string Numero_De_Lote { get; set; } //esto
            public int En_Stock { get; set; } //esto 
            public string Categoria { get; set; } //esto (agg mas cosas)
     
        


            public string Presentacion { get; set; } //esto (agg mas cosas)
            public string Fecha_Elaboracion { get; set; }
            public string Fecha_Caducidad { get; set; }
            
            
            
        }
    
}
