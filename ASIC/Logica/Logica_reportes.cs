using ASIC.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASIC.Logica
{
    internal class Logica_reportes
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static Logica_reportes _intancia = null;

        public Logica_reportes()
        {

        }
        public static Logica_reportes Instancia
        {
            get
            {
                if (_intancia == null)
                {
                    _intancia = new Logica_reportes();
                }
                return _intancia;
            }

        }





        public List<clase_salidas> patologiaList()
        {
            List<clase_salidas> ocombo = new List<clase_salidas>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT DISTINCT patologia FROM salidas";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new clase_salidas()
                        {
                            patologia = dr["patologia"].ToString(),

                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_categoria); }
            return ocombo;
        }

        public List<clase_salidas> medicamentosList()
        {
            List<clase_salidas> ocombo = new List<clase_salidas>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT DISTINCT nombre_medicamento FROM salidas";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new clase_salidas()
                        {
                            nombre_medicamento = dr["nombre_medicamento"].ToString(),

                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_categoria); }
            return ocombo;
        }

        public List<MedicamentoCompleto> medicamentosList2()
        {
            List<MedicamentoCompleto> ocombo = new List<MedicamentoCompleto>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT DISTINCT nombre_medicamento FROM medicamentos";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new MedicamentoCompleto()
                        {
                            Nombre_Medicamento = dr["Nombre_Medicamento"].ToString(),

                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_categoria); }
            return ocombo;
        }

        public List<MedicamentoCompleto> medicamentosList4()
        {
            List<MedicamentoCompleto> ocombo = new List<MedicamentoCompleto>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT DISTINCT nombre_medicamento FROM medicamentos";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new MedicamentoCompleto()
                        {
                            Nombre_Medicamento = dr["Nombre_Medicamento"].ToString(),

                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_categoria); }
            return ocombo;
        }

        public List<MedicamentoCompleto> nombres_Genericos()
        {
            List<MedicamentoCompleto> ocombo = new List<MedicamentoCompleto>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
               // string query = "SELECT DISTINCT NG.nombre_principio_activo FROM medicamentos M INNER JOIN nombre_genericos NG ON M.nombre_generico = NG.id_nombre_generico;";
                string query = "SELECT nombre_principio_activo FROM nombre_genericos";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new MedicamentoCompleto()
                        {
                            Nombre_Generico = dr["nombre_principio_activo"].ToString(),

                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_categoria); }
            return ocombo;
        }

        public List<MedicamentoCompleto> mostrar_categorias()
        {
            List<MedicamentoCompleto> ocombo = new List<MedicamentoCompleto>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT nombre_categoria FROM categorias";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new MedicamentoCompleto()
                        {
                            Categoria = dr["nombre_categoria"].ToString(),

                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_categoria); }
            return ocombo;
        }
        public List<MedicamentoCompleto> mostrar_presentaciones()
        {
            List<MedicamentoCompleto> ocombo = new List<MedicamentoCompleto>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT nombre_presentacion FROM presentaciones";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    
                    while (dr.Read())
                    {
                        ocombo.Add(new MedicamentoCompleto()
                        {
                            Presentacion = dr["nombre_presentacion"].ToString(),

                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_categoria); }
            return ocombo;
        }

        public List<clase_reporte_usuario> Listar_usuarios(string filtroTipo, string filtroValor)
        {
            List<clase_reporte_usuario> olista = new List<clase_reporte_usuario>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT cedula, nombre, telefono, direccion, patologia, fecha_nacimiento, edad,nombre_medicamento FROM salidas";

                switch (filtroTipo)
                {
                    case "patologia":
                        query += " WHERE patologia = @filtroValor";
                        break;
                    case "medicamento":
                        query += " WHERE nombre_medicamento = @filtroValor";
                        break;
                    default:
                        // No se agrega ninguna condición
                        break;
                }

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                // Añadir el parámetro si es necesario
                if (!string.IsNullOrEmpty(filtroTipo))
                {
                    cmd.Parameters.AddWithValue("@filtroValor", filtroValor);
                }

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new clase_reporte_usuario()
                        {
                            cedula = dr["cedula"].ToString(),
                            nombre = dr["nombre"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            patologia = dr["patologia"].ToString(),
                            fecha_nacimiento = dr["fecha_nacimiento"].ToString(),
                            edad = int.Parse(dr["edad"].ToString()),
                            nombre_medicamento = dr["nombre_medicamento"].ToString(),
                        }); 
                    }
                }
            }
            return olista;
        }

        public List<MedicamentoCompleto> Listar_medicamentos(string filtroTipo, string filtroValor)
        {
            List<MedicamentoCompleto> olista = new List<MedicamentoCompleto>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"SELECT codigo, nombre_medicamento, cantidad, medida, nombre_principio_activo, 
                            en_stock, nombre_categoria, nombre_presentacion, numero_de_lote, 
                            fecha_adquisicion, fecha_caducidad
                        FROM medicamentos M
                        INNER JOIN lote L ON M.numero_de_lote = L.id_lote
                        INNER JOIN nombre_genericos NG ON M.nombre_generico = NG.id_nombre_generico
                        INNER JOIN categorias C ON M.categoria = C.id_categoria
                        INNER JOIN presentaciones P ON M.presentacion = P.id_presentacion";

                switch (filtroTipo)
                {
                    case "medicamento":
                        query += " WHERE nombre_medicamento = @filtroValor";
                        break;
                    case "categoria":
                        query += " WHERE nombre_categoria = @filtroValor"; // Reemplaza por la columna correcta
                        break;
                    case "nombre generico":
                        query += " WHERE nombre_principio_activo = @filtroValor"; // Reemplaza por la columna correcta
                        break;
                    case "presentacion":
                        query += " WHERE nombre_presentacion = @filtroValor"; // Reemplaza por la columna correcta
                        break;
                    case "fechaV":
                        query += " WHERE fecha_caducidad = @filtroValor";
                        break;
                    default:
                        // No se agrega ninguna condición
                        break;
                }

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                // Añadir el parámetro si es necesario
                if (!string.IsNullOrEmpty(filtroTipo))
                {
                    cmd.Parameters.AddWithValue("@filtroValor", filtroValor);
                }

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (!dr.HasRows)
                    {
                        MessageBox.Show("No se encontraron medicamentos.");
                    }
                    else
                    {
                        while (dr.Read())
                        {
                            olista.Add(new MedicamentoCompleto()
                            {
                                Codigo = int.Parse(dr["codigo"].ToString()),
                                Nombre_Medicamento = dr["nombre_medicamento"].ToString(),
                                Composicion = int.Parse(dr["cantidad"].ToString()), 
                                Medida = dr["medida"].ToString(),
                                Nombre_Generico = dr["nombre_principio_activo"].ToString(),
                                Numero_De_Lote = dr["numero_de_lote"].ToString(),
                                En_Stock = int.Parse(dr["en_stock"].ToString()),
                                Categoria = dr["nombre_categoria"].ToString(),
                                Presentacion = dr["nombre_presentacion"].ToString(),
                                Fecha_Elaboracion = dr["fecha_adquisicion"].ToString(),
                                Fecha_Caducidad = dr["fecha_caducidad"].ToString(),
                            });
                        }
                    }
                }

            }
            return olista;
        }








        public List<clase_reporte_usuario> Filtrar(string cedula)
        {
            List<clase_reporte_usuario> olista = new List<clase_reporte_usuario>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"SELECT cedula, nombre, telefono, direccion, patologia, fecha_nacimiento, edad, nombre_medicamento
                         FROM salidas 
                         WHERE cedula LIKE @cedula";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@cedula", "%" + cedula + "%"));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new clase_reporte_usuario()
                        {
                            cedula = dr["cedula"].ToString(),
                            nombre = dr["nombre"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            patologia = dr["patologia"].ToString(),
                            fecha_nacimiento = dr["fecha_nacimiento"].ToString(),
                            edad = int.Parse(dr["edad"].ToString()),
                            nombre_medicamento = dr["nombre_medicamento"].ToString(),
                        });
                    }
                }
            }
            return olista;
        }
        private string ObtenerRecursoHTML(string nombreRecurso)
        {
            switch (nombreRecurso)
            {
                case "plantilla":
                    return Properties.Resources.plantilla; // Cambia "plantilla" según el nombre del recurso
                case "reporte_medicamentos": 
                    return Properties.Resources.reportes_medicamentos;
                case "plantilla_salidas": 
                    return Properties.Resources.plantilla_salidas;
                default:
                    throw new ArgumentException("Recurso no encontrado");
            }
        }



        public void GenerarReporteHTML(string filtroTipo, string filtroValor,string recurso )
        {
            // Obtener los datos de los usuarios
            List<clase_reporte_usuario> usuarios = Listar_usuarios(filtroTipo, filtroValor);

            if (usuarios != null && usuarios.Count > 0)
            {
                // Leer el archivo HTML de la plantilla desde los recursos
                string htmlTemplate = ObtenerRecursoHTML(recurso); 

                // Formatear los datos de los usuarios en filas de la tabla
                string usuarioRows = "";
                foreach (var usuario in usuarios)
                {
                    usuarioRows += $"<tr>" +
                        $"<td>{usuario.cedula}</td>" +
                        $"<td>{usuario.nombre}</td>" +
                        $"<td>{usuario.telefono}</td>" +
                        $"<td>{usuario.direccion}</td>" +
                        $"<td>{usuario.patologia}</td>" +
                        $"<td>{usuario.fecha_nacimiento}</td>" +
                        $"<td>{usuario.edad}</td>" +
                        $"<td>{usuario.nombre_medicamento}</td>" +
                        $"</tr>";
                }

                // Reemplazar los marcadores de posición con los datos de los usuarios
                string htmlContent = htmlTemplate
                    .Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"))
                    .Replace("@Categoria", filtroTipo)
                    .Replace("@html", usuarioRows);

                // Guardar el archivo HTML actualizado
                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reporte.html");
                File.WriteAllText(htmlPath, htmlContent);

                // Abrir el archivo HTML en el navegador predeterminado
                Process.Start(new ProcessStartInfo(htmlPath) { UseShellExecute = true });
            }
        }

        public void GenerarReporteHTMLM(string filtroTipo, string filtroValor, string recurso)
        {
            // Obtener los datos de los usuarios
            List<MedicamentoCompleto> usuarios = Listar_medicamentos(filtroTipo, filtroValor);

            if (usuarios != null && usuarios.Count > 0)
            {
                // Leer el archivo HTML de la plantilla desde los recursos
                string htmlTemplate = ObtenerRecursoHTML(recurso);

                // Formatear los datos de los usuarios en filas de la tabla
                string usuarioRows = "";
                foreach (var usuario in usuarios)
                {
                    usuarioRows += $"<tr>" +
                        $"<td>{usuario.Codigo}</td>" +
                        $"<td>{usuario.Nombre_Medicamento}</td>" +
                        $"<td>{usuario.Composicion}</td>" +
                        $"<td>{usuario.Medida}</td>" +
                        $"<td>{usuario.Nombre_Generico}</td>" +
                        $"<td>{usuario.Numero_De_Lote}</td>" +
                        $"<td>{usuario.En_Stock}</td>" +
                        $"<td>{usuario.Categoria}</td>" +
                        $"<td>{usuario.Presentacion}</td>" +
                        $"<td>{usuario.Fecha_Elaboracion}</td>" +
                        $"<td>{usuario.Fecha_Caducidad}</td>" +
                        $"</tr>";
                }

                // Reemplazar los marcadores de posición con los datos de los usuarios
                string htmlContent = htmlTemplate
                    .Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"))
                    .Replace("@Categoria", filtroTipo)
                    .Replace("@html", usuarioRows);

                // Guardar el archivo HTML actualizado
                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reporte.html");
                File.WriteAllText(htmlPath, htmlContent);

                // Abrir el archivo HTML en el navegador predeterminado
                Process.Start(new ProcessStartInfo(htmlPath) { UseShellExecute = true });
            }
        }

        public List<clase_salidas> Listar_salidas(string filtroTipo, string filtroValor, string fechaInicio = null, string fechaFin = null)
        {
            List<clase_salidas> olista = new List<clase_salidas>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM salidas";
                List<SQLiteParameter> parameters = new List<SQLiteParameter>();

                switch (filtroTipo)
                {
                    case "fecha":
                        query += @" WHERE strftime('%Y-%m-%d', substr(fecha_retiro, 7, 4) || '-' || printf('%02d', 
                            cast(substr(fecha_retiro, instr(fecha_retiro, '/') + 1, instr(substr(fecha_retiro, instr(fecha_retiro, '/') + 1), '/') - 1) as integer)) 
                            || '-' || printf('%02d', cast(substr(fecha_retiro, 1, instr(fecha_retiro, '/') - 1) as integer))) 
                            BETWEEN @fechaInicio AND @fechaFin";
                        parameters.Add(new SQLiteParameter("@fechaInicio", DateTime.ParseExact(fechaInicio, "dd-MM-yyyy", null).ToString("yyyy-MM-dd")));
                        parameters.Add(new SQLiteParameter("@fechaFin", DateTime.ParseExact(fechaFin, "dd-MM-yyyy", null).ToString("yyyy-MM-dd")));
                        break;
                    case "medicamento":
                        query += " WHERE nombre_medicamento = @filtroValor";
                        parameters.Add(new SQLiteParameter("@filtroValor", filtroValor));
                        break;
                    default:
                        // No se agrega ninguna condición
                        break;
                }

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                // Añadir los parámetros a la consulta
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new clase_salidas()
                        {
                            cedula = dr["cedula"].ToString(),
                            nombre = dr["nombre"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            patologia = dr["patologia"].ToString(),
                            fecha_nacimiento = dr["fecha_nacimiento"].ToString(),
                            edad = int.Parse(dr["edad"].ToString()),
                            nombre_medicamento = dr["nombre_medicamento"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                            fecha_retiro = dr["fecha_retiro"].ToString()
                        });
                    }
                }
            }
            return olista;
        }
        public void GenerarReporteHTMLSalidas(string filtroTipo, string filtroValor, string recurso, string fechaInicio = null, string fechaFin = null)
        {
            // Obtener los datos de salidas
            List<clase_salidas> salidas = Logica_reportes.Instancia.Listar_salidas(filtroTipo, filtroValor, fechaInicio, fechaFin);

            if (salidas != null && salidas.Count > 0)
            {
                // Leer el archivo HTML de la plantilla desde los recursos
                string htmlTemplate = ObtenerRecursoHTML(recurso);

                // Formatear los datos de las salidas en filas de la tabla
                string salidaRows = "";
                foreach (var salida in salidas)
                {
                    salidaRows += $"<tr>" +
                        $"<td>{salida.cedula}</td>" +
                        $"<td>{salida.nombre}</td>" +
                        $"<td>{salida.telefono}</td>" +
                        $"<td>{salida.direccion}</td>" +
                        $"<td>{salida.patologia}</td>" +
                        $"<td>{salida.fecha_nacimiento}</td>" +
                        $"<td>{salida.edad}</td>" +
                        $"<td>{salida.nombre_medicamento}</td>" +
                        $"<td>{salida.cantidad}</td>" +
                        $"<td>{salida.fecha_retiro}</td>" +
                        $"</tr>";
                }

                // Reemplazar los marcadores de posición con los datos de las salidas
                string htmlContent = htmlTemplate
                    .Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"))
                    .Replace("@Categoria", filtroTipo)
                    .Replace("@html", salidaRows);

                // Guardar el archivo HTML actualizado
                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reporte_salidas.html");
                File.WriteAllText(htmlPath, htmlContent);

                // Abrir el archivo HTML en el navegador predeterminado
                Process.Start(new ProcessStartInfo(htmlPath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("No se encontraron registros para generar el reporte.");
            }
        }


        public List<clase_salidas> medicamentosList3()
        {
            List<clase_salidas> ocombo = new List<clase_salidas>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT DISTINCT nombre_medicamento FROM salidas";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new clase_salidas()
                        {
                            nombre_medicamento = dr["nombre_medicamento"].ToString(),

                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_categoria); }
            return ocombo;
        }



    }
}
