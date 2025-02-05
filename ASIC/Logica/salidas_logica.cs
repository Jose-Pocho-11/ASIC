using ASIC.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASIC.Logica
{
    internal class salidas_logica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static salidas_logica _intancia = null;

        public salidas_logica()
        {

        }
        public static salidas_logica Instancia
        {
            get
            {
                if (_intancia == null)
                {
                    _intancia = new salidas_logica();
                }
                return _intancia;
            }

        }


        public bool guardar_salidas(clase_salidas obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                    
                
                    // Si no existe, insertar el nuevo registro
                    string queryInsertar = "INSERT INTO salidas(cedula,nombre,telefono,direccion,patologia,fecha_nacimiento,edad,nombre_medicamento,cantidad,fecha_retiro) " +
                                           "VALUES(@cedula, @nombre, @telefono, @direccion, @patologia, @fecha_nacimiento, @edad, @nombre_medicamento, @cantidad,@fecha_retiro)";
                    SQLiteCommand cmdInsertar = new SQLiteCommand(queryInsertar, conexion);

                    cmdInsertar.Parameters.Add(new SQLiteParameter("@cedula", obj.cedula));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@nombre", obj.nombre));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@telefono", obj.telefono));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@direccion", obj.direccion));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@patologia", obj.patologia));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@fecha_nacimiento", obj.fecha_nacimiento));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@edad", obj.edad));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@nombre_medicamento", obj.nombre_medicamento));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@cantidad", obj.cantidad));
                    cmdInsertar.Parameters.Add(new SQLiteParameter("@fecha_retiro", obj.fecha_retiro));

                    cmdInsertar.CommandType = System.Data.CommandType.Text;

                    cmdInsertar.ExecuteNonQuery();
                    MessageBox.Show("El usuario ya fue registrado.");
               
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
                string query = @" SELECT en_stock from medicamentosWHERE codigo = @codigo" ;

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@codigo", obj.Codigo);
                    

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                           
                            obj.En_Stock = int.Parse(reader["en_stock"].ToString());
                            
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


        public bool actualizar_cantidad_del_medicamento(MedicamentoCompleto obj, int cantidadARestar)
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
                    // Obtener la cantidad actual en stock
                    string queryObtenerStock = "SELECT en_stock FROM medicamentos WHERE codigo = @codigo";
                    SQLiteCommand cmdObtenerStock = new SQLiteCommand(queryObtenerStock, conexion);
                    cmdObtenerStock.Parameters.Add(new SQLiteParameter("@codigo", obj.Codigo));

                    int enStockActual = Convert.ToInt32(cmdObtenerStock.ExecuteScalar());

                    // Calcular la nueva cantidad en stock
                    int nuevoEnStock = enStockActual - cantidadARestar;

                    if (nuevoEnStock < 0)
                    {
                        // Si la cantidad en stock sería negativa, mostrar un mensaje de error
                        respuesta = false;
                        MessageBox.Show("No hay suficiente stock para realizar esta operación.");
                    }
                    else
                    {
                        // Actualizar la cantidad en stock
                        string queryActualizar = "UPDATE medicamentos SET " +
                                                 "en_stock = @en_stock " +
                                                 "WHERE codigo = @codigo";
                        SQLiteCommand cmdActualizar = new SQLiteCommand(queryActualizar, conexion);

                        cmdActualizar.Parameters.Add(new SQLiteParameter("@codigo", obj.Codigo));
                        cmdActualizar.Parameters.Add(new SQLiteParameter("@en_stock", nuevoEnStock));

                        cmdActualizar.CommandType = System.Data.CommandType.Text;

                        cmdActualizar.ExecuteNonQuery();
                        //MessageBox.Show("El medicamento fue actualizado exitosamente.");
                    }
                }
                else
                {
                    respuesta = false;
                    MessageBox.Show("El medicamento no existe en la base de datos.");
                }
            }

            return respuesta;
        }

        public bool verificar_stock(MedicamentoCompleto obj, int cantidadARestar)
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
                    // Obtener la cantidad actual en stock
                    string queryObtenerStock = "SELECT en_stock FROM medicamentos WHERE codigo = @codigo";
                    SQLiteCommand cmdObtenerStock = new SQLiteCommand(queryObtenerStock, conexion);
                    cmdObtenerStock.Parameters.Add(new SQLiteParameter("@codigo", obj.Codigo));

                    int enStockActual = Convert.ToInt32(cmdObtenerStock.ExecuteScalar());

                    // Calcular la nueva cantidad en stock
                    int nuevoEnStock = enStockActual - cantidadARestar;

                    if (nuevoEnStock < 0)
                    {
                        // Si la cantidad en stock sería negativa, mostrar un mensaje de error
                        respuesta = false;
                        MessageBox.Show("No hay suficiente stock para realizar esta operación.");
                    }
                    
                }
                else
                {
                    respuesta = false;
                    MessageBox.Show("El medicamento no existe en la base de datos.");
                }
            }

            return respuesta;
        }
        public bool CargarDatos_de_Personas(clase_salidas obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                // Ajustar la consulta para obtener datos de todas las tablas necesarias
                string query = @" SELECT nombre,telefono,direccion,patologia,fecha_nacimiento from salidas WHERE cedula = @cedula";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@cedula", obj.cedula);


                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            obj.nombre = reader["nombre"].ToString();
                            obj.telefono = reader["telefono"].ToString();
                            obj.direccion = reader["direccion"].ToString();
                            obj.patologia = reader["patologia"].ToString();
                            obj.fecha_nacimiento = reader["fecha_nacimiento"].ToString();
             
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





        public List<pacinetes> Listar_salidas_unicas()
        {
            List<pacinetes> olista = new List<pacinetes>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"SELECT cedula, nombre, telefono, direccion, patologia, fecha_nacimiento, edad
                         FROM salidas                      ";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new pacinetes()
                        {
                            cedula = dr["cedula"].ToString(),
                            nombre = dr["nombre"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            patologia = dr["patologia"].ToString(),
                            fecha_nacimiento = dr["fecha_nacimiento"].ToString(),
                            edad = int.Parse(dr["edad"].ToString()),
                        });
                    }
                }
            }
            return olista;
        }






    }//hasta aqui
}
