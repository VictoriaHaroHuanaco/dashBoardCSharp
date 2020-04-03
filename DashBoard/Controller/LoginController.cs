using DashBoard.Constantes;
using MetroFramework;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DashBoard.Controller
{
    internal class LoginController
    {
        /// <summary>
        /// Login del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        public bool IngresaLogin(string usuario, string clave)
        {
            string query = $"SELECT COUNT(nombre) Total FROM Usuarios WITH(NOLOCK) WHERE login = '{usuario}' AND clave = '{clave}'";
            bool respuesta = false;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, Conexiones.Connection.getConexion(constBasesDatos.DashBoard))
                {
                    CommandType = CommandType.Text
                };

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        if ((int)sqlDataReader["Total"] > 0)
                        {
                            respuesta = true;
                        }
                    }
                    sqlDataReader.Close();
                }
            }
            catch (Exception ex)
            {
                RegistrarErrorController.RegistrarError("LoginController.cs", "IngresaLogin", ex);
                throw;
            }

            return respuesta;
        }
    }
}