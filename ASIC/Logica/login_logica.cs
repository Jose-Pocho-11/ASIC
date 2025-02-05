using ASIC.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ASIC.Logica
{
    internal class login_logica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static login_logica _intancia = null;

        public login_logica()
        {

        }
        public static login_logica Instancia
        {
            get
            {
                if (_intancia == null)
                {
                    _intancia = new login_logica();
                }
                return _intancia;
            }
        }


        public bool verificar_usuario(clase_login obj, out string cargo)
        {
            bool respuesta = false;
            cargo = string.Empty;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT cargo FROM login WHERE usuario = @usuario AND contraseña = @contraseña ";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@usuario", obj.usuario));
                cmd.Parameters.Add(new SQLiteParameter("@contraseña", obj.contraseña));
                cmd.CommandType = System.Data.CommandType.Text;
                //MessageBox.Show("Credenciales válidas. Acceso concedido.", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (SQLiteDataReader reader= cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        respuesta = true;
                        cargo = reader["cargo"].ToString();
                    }
                }
                    

            }

            return respuesta;
        }


















    }//hasta aqui
}
