using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using ASIC.Modelo;
using System.Collections;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;


namespace ASIC.Logica
{
    public class medicamentos_logica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static medicamentos_logica _intancia = null;

        public medicamentos_logica()
        {

        }
        public static medicamentos_logica Instancia
        {
            get {
                if (_intancia == null)
                {
                    _intancia = new medicamentos_logica();
                }
                return _intancia;
            }

        }


        public bool guardar(MedicamentoCompleto obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                // Verificar si el registro ya existe
                string queryVerificar = "SELECT count(1) FROM medicamentos WHERE codigo = @codigo";
                SQLiteCommand cmdVerificar = new SQLiteCommand(queryVerificar, conexion);
                cmdVerificar.Parameters.Add(new SQLiteParameter("@codigo", obj.Codigo));
                int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (count == 0)
                {
                    // Si no existe, insertar el nuevo registro
                    string queryInsertar = "INSERT INTO medicamentos(codigo, nombre_medicamento, cantidad, medida, nombre_generico, numero_de_lote, en_stock, categoria, presentacion) " +
                                           "VALUES(@codigo, @nombre_medicamento, @cantidad, @medida, @nombre_generico, @numero_de_lote, @en_stock, @categoria, @presentacion)";
                    SQLiteCommand cmdInsertar = new SQLiteCommand(queryInsertar, conexion);

                    cmdInsertar.Parameters.Add(new SQLiteParameter("@codigo", obj.Codigo));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@nombre_medicamento", obj.Nombre_Medicamento));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@cantidad", obj.Composicion));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@medida", obj.Medida));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@nombre_generico", obj.Nombre_Generico));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@numero_de_lote", obj.Numero_De_Lote));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@en_stock", obj.En_Stock));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@categoria", obj.Categoria));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@presentacion", obj.Presentacion));

                    cmdInsertar.CommandType = System.Data.CommandType.Text;

                    cmdInsertar.ExecuteNonQuery();
                    MessageBox.Show("El medicamento fue registrado existosamente.");
                }
                else
                {
                    respuesta = false;
                    MessageBox.Show("El medicamento ya fue registrado antes.");
                }
            }

            return respuesta;
        }

        public bool guardarL(Clase_lotes obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                // Verificar si el lote ya existe
                string queryVerificar = "SELECT count(1) FROM lote WHERE id_lote = @id_lote";
                SQLiteCommand cmdVerificar = new SQLiteCommand(queryVerificar, conexion);
                cmdVerificar.Parameters.Add(new SQLiteParameter("@id_lote", obj.id_L));
                int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (count == 0)
                {
                    // Si no existe, insertar el nuevo registro
                    string queryInsertar = "INSERT INTO lote(id_lote, fecha_adquisicion, fecha_caducidad) " +
                                           "VALUES(@id_lote, @fecha_adquisicion, @fecha_caducidad)";
                    SQLiteCommand cmdInsertar = new SQLiteCommand(queryInsertar, conexion);

                    cmdInsertar.Parameters.Add(new SQLiteParameter("@id_lote", obj.id_L));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@fecha_adquisicion", obj.fecha_elaboracion));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@fecha_caducidad", obj.fecha_caducidad));

                    cmdInsertar.CommandType = System.Data.CommandType.Text;

                    cmdInsertar.ExecuteNonQuery();
                }
                else
                {
                    respuesta = false;
                    MessageBox.Show("El lote ya fue registrado antes.");
                }
            }

            return respuesta;
        }




        public bool guardar_elementos(string nombre_tabla, string nombre_elemento, string column)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = $"insert into {nombre_tabla}({column}) values (@{column})";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@id_lote", nombre_elemento));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }






        public List<MedicamentoCompleto> Listar()
        {
            List<MedicamentoCompleto> olista = new List<MedicamentoCompleto>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open(); string query = "SELECT codigo,nombre_medicamento,cantidad,medida,nombre_principio_activo," +
                    "en_stock,nombre_categoria,nombre_presentacion,numero_de_lote,fecha_adquisicion, fecha_caducidad " +
                    "from medicamentos M INNER join lote L on M.numero_de_lote = L.id_lote " +
                    "INNER JOIN nombre_genericos NG on M.nombre_generico = NG.id_nombre_generico " +
                    "INNER join categorias C on M.categoria = C.id_categoria " +
                    "INNER JOIN presentaciones P on M.presentacion = P.id_presentacion";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
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
                            En_Stock = int.Parse(dr["en_stock"].ToString()),
                            Categoria = dr["nombre_categoria"].ToString(),
                            Presentacion = dr["nombre_presentacion"].ToString(),
                            Numero_De_Lote = dr["numero_de_lote"].ToString(),
                            Fecha_Elaboracion = dr["fecha_adquisicion"].ToString(),
                            Fecha_Caducidad = dr["fecha_caducidad"].ToString(),
                        });
                    }
                }
            } return olista;
        }

        // mas
        public List<clase_categorias> ComboList()
        {
            List<clase_categorias> ocombo = new List<clase_categorias>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT (nombre_categoria) from categorias";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new clase_categorias()
                        {


                            //Codigo = int.Parse(dr["codigo"].ToString()),
                            nombre_categoria = dr["nombre_categoria"].ToString(),

                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_categoria); }
            return ocombo;
        }

        public List<clase_presentaciones> ComboList_Presentacion()
        {
            List<clase_presentaciones> ocombo = new List<clase_presentaciones>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT (nombre_presentacion) from presentaciones";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new clase_presentaciones()
                        {
                            //Codigo = int.Parse(dr["codigo"].ToString()),
                            nombre_presentacion = dr["nombre_presentacion"].ToString(),
                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_presentacion); }
            return ocombo;
        }

        public List<clase_nombres_genericos> ComboList_Nombres_Genericos()
        {
            List<clase_nombres_genericos> ocombo = new List<clase_nombres_genericos>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT (nombre_principio_activo) from nombre_genericos";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ocombo.Add(new clase_nombres_genericos()
                        {
                            //Codigo = int.Parse(dr["codigo"].ToString()),
                            nombre_principio_activo = dr["nombre_principio_activo"].ToString(),
                        });

                    }
                }
            }
            //foreach (var item in ocombo) { MessageBox.Show(item.nombre_presentacion); }
            return ocombo;
        }



        public void LimpiarControles(Form formularios)
        {
            foreach (Control control in formularios.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        public bool verificar_Todo_correto(Form formulario, int numero)
        {
            int contador = 0;
            foreach (Control control in formulario.Controls)
            {

                if (control is TextBox)
                { // Verificar si el TextBox está vacío
                    if (string.IsNullOrWhiteSpace(((TextBox)control).Text))
                    {
                        contador++;
                    }
                } else if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex == 0)
                    {
                        contador++;
                    }
                }

            }

            return contador == 0;

        }













        public bool verificar_combo_Categoria(string nombre_tabla, string nombre_column, string nombre_del_elemento)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = $"SELECT count(1) from {nombre_tabla} WHERE {nombre_column} = @{nombre_del_elemento}";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter($"@{nombre_del_elemento}", nombre_del_elemento.ToLower()));
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {

                    query = $"insert into {nombre_tabla} ({nombre_column}) values (@{nombre_del_elemento})";
                    cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue($"@{nombre_del_elemento}", nombre_del_elemento.ToLower());
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    respuesta = false;
                    MessageBox.Show("Ese elemento ya existe");
                }
            }

            return respuesta;
        }


        public bool eliminar_registro(MedicamentoCompleto obj, int codigo_medicamneto, string numero_lote)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                SQLiteTransaction transaction = conexion.BeginTransaction();

                try
                {
                    string queryMedicamentos = "DELETE FROM medicamentos WHERE codigo = @codigo; " +
                                               "DELETE FROM lote WHERE id_lote = @id_lote;";

                    using (SQLiteCommand cmdEliminar = new SQLiteCommand(queryMedicamentos, conexion, transaction))
                    {
                        // Asegúrate de que los nombres de los parámetros coincidan con los utilizados en la consulta SQL
                        cmdEliminar.Parameters.Add(new SQLiteParameter("@codigo", codigo_medicamneto));
                        cmdEliminar.Parameters.Add(new SQLiteParameter("@id_lote", numero_lote));

                        cmdEliminar.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Registros eliminados exitosamente.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool CargarDatos(MedicamentoCompleto obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                // Ajustar la consulta para obtener datos de todas las tablas necesarias
                string query = @"
            SELECT codigo, nombre_medicamento, cantidad, medida, nombre_principio_activo, en_stock, nombre_categoria, nombre_presentacion, numero_de_lote, fecha_adquisicion, fecha_caducidad 
                               FROM medicamentos M INNER JOIN lote L ON M.numero_de_lote = L.id_lote 
                               INNER JOIN nombre_genericos NG ON M.nombre_generico = NG.id_nombre_generico 
                               INNER JOIN categorias C ON M.categoria = C.id_categoria  
                               INNER JOIN presentaciones P ON M.presentacion = P.id_presentacion  
                               WHERE M.codigo = @codigo AND L.id_lote = @id_lote;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("@id_lote", obj.Numero_De_Lote);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            obj.Nombre_Medicamento = reader["nombre_medicamento"].ToString();
                            obj.Composicion = int.Parse(reader["cantidad"].ToString());
                            obj.Medida = reader["medida"].ToString();
                            obj.Nombre_Generico = reader["nombre_principio_activo"].ToString();
                            obj.En_Stock = int.Parse(reader["en_stock"].ToString());
                            obj.Categoria = reader["nombre_categoria"].ToString();
                            obj.Presentacion = reader["nombre_presentacion"].ToString();
                            obj.Fecha_Elaboracion = reader["fecha_adquisicion"].ToString();
                            obj.Fecha_Caducidad = reader["fecha_caducidad"].ToString();
                        }
                        else
                        {
                            respuesta = false;
                        }
                    }
                }
            }

            return respuesta;
        }



        public bool actualizar(MedicamentoCompleto obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                // Verificar si el registro ya existe
                string queryVerificar = "SELECT count(1) FROM medicamentos WHERE codigo = @codigo";
                SQLiteCommand cmdVerificar = new SQLiteCommand(queryVerificar, conexion);
                cmdVerificar.Parameters.Add(new SQLiteParameter("@codigo", obj.Codigo));
                int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (count > 0)
                {

                    string queryActualizar = "UPDATE medicamentos SET " +
                                             "nombre_medicamento = @nombre_medicamento, " +
                                             "cantidad = @cantidad, " +
                                             "medida = @medida, " +
                                             "nombre_generico = @nombre_generico, " +
                                             "numero_de_lote = @numero_de_lote, " +
                                             "en_stock = @en_stock, " +
                                             "categoria = @categoria, " +
                                             "presentacion = @presentacion " +
                                             "WHERE codigo = @codigo";
                    SQLiteCommand cmdActualizar = new SQLiteCommand(queryActualizar, conexion);

                    cmdActualizar.Parameters.Add(new SQLiteParameter("@codigo", obj.Codigo));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@nombre_medicamento", obj.Nombre_Medicamento));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@cantidad", obj.Composicion));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@medida", obj.Medida));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@nombre_generico", obj.Nombre_Generico));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@numero_de_lote", obj.Numero_De_Lote));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@en_stock", obj.En_Stock));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@categoria", obj.Categoria));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@presentacion", obj.Presentacion));

                    cmdActualizar.CommandType = System.Data.CommandType.Text;

                    cmdActualizar.ExecuteNonQuery();
                    //MessageBox.Show("El medicamento fue actualizado exitosamente.");
                }
                else
                {
                    respuesta = false;
                    MessageBox.Show("El medicamento no existe en la base de datos.");
                }
            }

            return respuesta;
        }








        public bool guardarOActualizarLote(Clase_lotes obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                // Verificar si el lote ya existe
                string queryVerificar = "SELECT count(1) FROM lote WHERE id_lote = @id_lote";
                SQLiteCommand cmdVerificar = new SQLiteCommand(queryVerificar, conexion);
                cmdVerificar.Parameters.Add(new SQLiteParameter("@id_lote", obj.id_L));
                int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (count > 0)
                {
                    // Si existe, actualizar el registro
                    string queryActualizar = "UPDATE lote SET " +
                                             "fecha_adquisicion = @fecha_adquisicion, " +
                                             "fecha_caducidad = @fecha_caducidad " +
                                             "WHERE id_lote = @id_lote";
                    SQLiteCommand cmdActualizar = new SQLiteCommand(queryActualizar, conexion);

                    cmdActualizar.Parameters.Add(new SQLiteParameter("@id_lote", obj.id_L));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@fecha_adquisicion", obj.fecha_elaboracion));
                    cmdActualizar.Parameters.Add(new SQLiteParameter("@fecha_caducidad", obj.fecha_caducidad));

                    cmdActualizar.CommandType = System.Data.CommandType.Text;

                    cmdActualizar.ExecuteNonQuery();
                    MessageBox.Show("El lote fue actualizado exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar.");
                }
            }

            return respuesta;
        }




        public List<MedicamentoCompleto> Filtrar(string nombreMedicamento)
        {
            List<MedicamentoCompleto> olista = new List<MedicamentoCompleto>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"SELECT codigo, nombre_medicamento, cantidad, medida, nombre_principio_activo, en_stock, nombre_categoria, nombre_presentacion, numero_de_lote, fecha_adquisicion, fecha_caducidad 
                    FROM medicamentos M INNER JOIN lote L ON M.numero_de_lote = L.id_lote 
                    INNER JOIN nombre_genericos NG ON M.nombre_generico = NG.id_nombre_generico 
                    INNER JOIN categorias C ON M.categoria = C.id_categoria  
                    INNER JOIN presentaciones P ON M.presentacion = P.id_presentacion  
                    WHERE M.nombre_medicamento like @nombre_medicamento";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre_medicamento", "%" + nombreMedicamento + "%"));
                cmd.CommandType = System.Data.CommandType.Text;


                using (SQLiteDataReader dr = cmd.ExecuteReader())
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
                            En_Stock = int.Parse(dr["en_stock"].ToString()),
                            Categoria = dr["nombre_categoria"].ToString(),
                            Presentacion = dr["nombre_presentacion"].ToString(),
                            Numero_De_Lote = dr["numero_de_lote"].ToString(),
                            Fecha_Elaboracion = dr["fecha_adquisicion"].ToString(),
                            Fecha_Caducidad = dr["fecha_caducidad"].ToString(),
                        });
                    }
                }
            }
            return olista;
        }


        public int Alerta_stock()
        {
            int count = 0;
            int alertaStock = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                // Obtener el valor de alerta_stock de la tabla configuracion
                string queryObtenerAlerta = "SELECT alerta_stock FROM configuracion LIMIT 1";
                using (SQLiteCommand cmdObtenerAlerta = new SQLiteCommand(queryObtenerAlerta, conexion))
                {
                    alertaStock = Convert.ToInt32(cmdObtenerAlerta.ExecuteScalar());
                }

                // Verificar los medicamentos en base al valor de alerta_stock
                string queryVerificar = "SELECT COUNT(*) FROM medicamentos M " +
                                        "INNER JOIN lote L ON M.numero_de_lote = L.id_lote " +
                                        "INNER JOIN nombre_genericos NG ON M.nombre_generico = NG.id_nombre_generico " +
                                        "INNER JOIN categorias C ON M.categoria = C.id_categoria " +
                                        "INNER JOIN presentaciones P ON M.presentacion = P.id_presentacion " +
                                        "WHERE M.en_stock <= @en_stock";

                using (SQLiteCommand cmdVerificar = new SQLiteCommand(queryVerificar, conexion))
                {
                    cmdVerificar.Parameters.Add(new SQLiteParameter("@en_stock", alertaStock));
                    count = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                }
            }

            return count;
        }
        public List<MedicamentoCompleto> mostrar_medicamentos_alerta()
        {
            List<MedicamentoCompleto> olista = new List<MedicamentoCompleto>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                // Obtener el valor de alerta_stock desde la tabla configuracion
                string queryObtenerAlerta = "SELECT alerta_stock FROM configuracion LIMIT 1";
                int alertaStock = 0;

                using (SQLiteCommand cmdObtenerAlerta = new SQLiteCommand(queryObtenerAlerta, conexion))
                {
                    alertaStock = Convert.ToInt32(cmdObtenerAlerta.ExecuteScalar());
                }

                string query = @"
                SELECT codigo, nombre_medicamento, cantidad, medida, nombre_principio_activo, en_stock, nombre_categoria, nombre_presentacion, numero_de_lote, fecha_adquisicion, fecha_caducidad 
                FROM medicamentos M 
                INNER JOIN lote L ON M.numero_de_lote = L.id_lote 
                INNER JOIN nombre_genericos NG ON M.nombre_generico = NG.id_nombre_generico 
                INNER JOIN categorias C ON M.categoria = C.id_categoria  
                INNER JOIN presentaciones P ON M.presentacion = P.id_presentacion  
                WHERE M.en_stock <= @en_stock";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@en_stock", alertaStock));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
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
                                En_Stock = int.Parse(dr["en_stock"].ToString()),
                                Categoria = dr["nombre_categoria"].ToString(),
                                Presentacion = dr["nombre_presentacion"].ToString(),
                                Numero_De_Lote = dr["numero_de_lote"].ToString(),    
                                Fecha_Elaboracion = dr["fecha_adquisicion"].ToString(),
                                Fecha_Caducidad = dr["fecha_caducidad"].ToString(),
                            });
                        };

                    }
                }
            }
                return olista;
        }

    }
}











