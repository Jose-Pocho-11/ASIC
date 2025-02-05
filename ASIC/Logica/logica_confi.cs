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
    internal class logica_confi
    {



        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static logica_confi _intancia = null;

        public logica_confi()
        {

        }
        public static logica_confi Instancia
        {
            get
            {
                if (_intancia == null)
                {
                    _intancia = new logica_confi();
                }
                return _intancia;
            }

        }

        public int ObtenerAlertaStock()
        {
            int alertaStock = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT alerta_stock FROM configuracion LIMIT 1";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        alertaStock = Convert.ToInt32(result);
                    }
                }
            }

            return alertaStock;
        }

        public void ActualizarAlertaStock(int nuevoValor)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "UPDATE configuracion SET alerta_stock = @nuevoValor";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Valor de alerta_stock actualizado con éxito.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public string ObtenerPreguntaSeguridad1(string usuario)
        {
            string pregunta1="";

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT Pregunta_1 FROM login WHERE usuario = @usuario";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pregunta1 = reader["Pregunta_1"].ToString();
                        }
                    }
                }
            }

            return pregunta1;
        }

        public string ObtenerPreguntaSeguridad2(string usuario)
        {
            string pregunta2 = "";

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT Pregunta_2 FROM login WHERE usuario = @usuario";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pregunta2 = reader["Pregunta_2"].ToString();
                        }
                    }
                }
            }

            return pregunta2;
        }





        public string RecuperarContraseña(string usuario, string respuesta1, string respuesta2)
        {
            string contraseña = "";

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"
                    SELECT contraseña 
                    FROM login 
                    WHERE usuario = @usuario 
                      AND Respuesta_1 = @respuesta1 
                      AND Respuesta_2 = @respuesta2";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@respuesta1", respuesta1);
                    cmd.Parameters.AddWithValue("@respuesta2", respuesta2);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contraseña = reader["contraseña"].ToString();
                        }
                    }
                }
            }

            return contraseña;
        }















    }
}
