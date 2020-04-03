using System;
using System.Data.SqlClient;
using System.Security;
using Utilerias;

namespace Conexion
{
    public static class Conecction
    {
        /// <summary>
        /// Obtenemos la conexion para la base de datos
        /// </summary>
        /// <param name="baseDatos"></param>
        /// <returns></returns>
        public static SqlConnection obtenerConexion(string baseDatos)
        {
            try
            {
                SqlConnection connection;
                SecureString secure = new SecureString();

                string servidor = "LAPTOP-KVLAOOP7\\SQLEXPRESS";
                string user = "rootRaiz";
                connection = new SqlConnection($"Server= {servidor.ToUpper()};Database={baseDatos.ToUpper()};MultipleActiveResultSets=True;");

                string password = "H4YK11UH1N4T4K4G3Y4M4";
                int num = 0;
                while (true)
                {
                    if (num >= password.Length)
                    {
                        SecureString securePassword = secure;
                        secure.MakeReadOnly();
                        connection.Credential = new SqlCredential(user, securePassword);
                        connection.Open();
                        return connection;
                    }
                    char c = password[num];
                    secure.AppendChar(c);
                    num++;
                }
            }
            catch (Exception ex)
            {
                Log.GuardarError(ex);
                throw;
            }
        }
    }
}