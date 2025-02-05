using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASIC; 

namespace ASIC
{
    public partial class panel_control_principal : Form
    {
        public panel_control_principal()
        {
            InitializeComponent();
        }

        


            private void panel_control_principal_Load(object sender, EventArgs e)
        {

        }

        private void buscar_bt_Click(object sender, EventArgs e)
        {
            List<atributos> productos = new List<atributos> 
            { 
                new atributos { Id = 1, Nombre = "atributos 1", Precio = 10.0m, Cantidad = 100, Categoria = "Categoría A", FechaIngreso = new DateTime(2023, 1, 15), Descripcion = "Descripcion 1", Proveedor = "Proveedor 1", Descuento = 0.1m, Ubicacion = "A1" }, 
                new atributos { Id = 2, Nombre = "atributos 2", Precio = 15.5m, Cantidad = 50, Categoria = "Categoría B", FechaIngreso = new DateTime(2023, 2, 10), Descripcion = "Descripcion 2", Proveedor = "Proveedor 2", Descuento = 0.2m, Ubicacion = "B2" },
                new atributos { Id = 3, Nombre = "atributos 3", Precio = 7.3m, Cantidad = 75, Categoria = "Categoría A", FechaIngreso = new DateTime(2023, 3, 5), Descripcion = "Descripcion 3", Proveedor = "Proveedor 3", Descuento = 0.15m, Ubicacion = "C3" }, 
                new atributos { Id = 4, Nombre = "atributos 4", Precio = 20.0m, Cantidad = 30, Categoria = "Categoría C", FechaIngreso = new DateTime(2023, 4, 20), Descripcion = "Descripcion 4", Proveedor = "Proveedor 4", Descuento = 0.25m, Ubicacion = "D4" }, 
                new atributos { Id = 5, Nombre = "atributos 5", Precio = 5.0m, Cantidad = 200, Categoria = "Categoría B", FechaIngreso = new DateTime(2023, 5, 25), Descripcion = "Descripcion 5", Proveedor = "Proveedor 5", Descuento = 0.05m, Ubicacion = "E5" }, 
                new atributos { Id = 6, Nombre = "atributos 6", Precio = 12.0m, Cantidad = 60, Categoria = "Categoría A", FechaIngreso = new DateTime(2023, 6, 10), Descripcion = "Descripcion 6", Proveedor = "Proveedor 6", Descuento = 0.1m, Ubicacion = "F6" }, 
                new atributos { Id = 7, Nombre = "atributos 7", Precio = 8.0m, Cantidad = 120, Categoria = "Categoría B", FechaIngreso = new DateTime(2023, 7, 15), Descripcion = "Descripcion 7", Proveedor = "Proveedor 7", Descuento = 0.2m, Ubicacion = "G7" },
                new atributos { Id = 8, Nombre = "atributos 8", Precio = 17.5m, Cantidad = 45, Categoria = "Categoría C", FechaIngreso = new DateTime(2023, 8, 20), Descripcion = "Descripcion 8", Proveedor = "Proveedor 8", Descuento = 0.15m, Ubicacion = "H8" },
                new atributos { Id = 9, Nombre = "atributos 9", Precio = 9.0m, Cantidad = 85, Categoria = "Categoría A", FechaIngreso = new DateTime(2023, 9, 25), Descripcion = "Descripcion 9", Proveedor = "Proveedor 9", Descuento = 0.1m, Ubicacion = "I9" }, 
                new atributos { Id = 10, Nombre = "Producto 10", Precio = 6.5m, Cantidad = 150, Categoria = "Categoría B", FechaIngreso = new DateTime(2023, 10, 30), Descripcion = "Descripcion 10", Proveedor = "Proveedor 10", Descuento = 0.05m, Ubicacion = "J10" } };

            dataGridView_principal.DataSource = productos;  
        }
    }
}
