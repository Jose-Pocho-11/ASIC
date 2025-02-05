using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASIC.Modelo
{
    public  class medicamentos
    {
        public int codigo { get; set; }
        public string nombre_medicamento { get; set; }
        public int cantidad { get; set; }
        public string nombre_generico { get; set; }
        public string numero_de_lote { get; set; }
        public int en_stock { get; set; }
        public string categoria { get; set; }
        public string presentacion { get; set;} 

    }

    public class clase_categorias
    {
        public int id_categorias { get; set; }
        public string nombre_categoria { get; set; }

    }

    public class Clase_lotes
    {
        public string id_L { get; set; }
        public string fecha_elaboracion { get; set; }
        public string fecha_caducidad { get; set; }
    }

    public class clase_nombres_genericos
    {
        public int id_nombre_generico { get; set; }
        public string nombre_principio_activo { get; set; }
    }

    public class clase_presentaciones
    {
        public int id_presentacion { get; set; }
        public string nombre_presentacion { get; set; }

    }

    public class clase_medicamento
    {
        public string nombre_medicamento { get; set; }
    }

    public class pacinetes
    {
        public string cedula { get; set; }
        public string nombre { get; set; }

        public string telefono { get; set; }
        public string direccion { get; set; }
        public string patologia { get; set; }
        public string fecha_nacimiento { get; set; }
        public int edad { get; set; }
    }
    public class confi
    {
        public int alerta_stock { get; set; }
    }

}
