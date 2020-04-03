using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.Controller
{
    public class RegistrarErrorController
    {
        /// <summary>
        /// Almacena el error generado en la Base de Datos
        /// </summary>
        /// <param name="controlador"></param>
        /// <param name="metodo"></param>
        /// <param name="ex"></param>
        public static void RegistrarError(string clase, string metodo, Exception ex)
        {
            var ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList.First(f => f.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
            try
            {
                //SqlCommand command = new SqlCommand("SP_TREDM0312_ErrorLog", ClaseEstatica.ConexionEstatica);
                //command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("@UsuarioSo", Environment.UserName.ToString());
                //command.Parameters.AddWithValue("@So", Environment.OSVersion.ToString());
                //command.Parameters.AddWithValue("@Ip", ip);
                //command.Parameters.AddWithValue("@Usuario", ClaseEstatica.Usuario != null ? ClaseEstatica.Usuario.Usser : "");
                //command.Parameters.AddWithValue("@Acceso", ClaseEstatica.Usuario != null ? ClaseEstatica.Usuario.Acceso : "");
                //command.Parameters.AddWithValue("@Sucursal", ClaseEstatica.Usuario != null ? ClaseEstatica.Usuario.Sucursal : 0);
                //command.Parameters.AddWithValue("@Estacion", ClaseEstatica.WorkStation != 0 ? ClaseEstatica.WorkStation : 0);
                //command.Parameters.AddWithValue("@Metodo", metodo);
                //command.Parameters.AddWithValue("@Clase", clase);
                //command.Parameters.AddWithValue("@MensajeError", ex.Message);
                //command.Parameters.AddWithValue("@TipoError", ex.GetType().ToString());
                //command.Parameters.AddWithValue("@StackTrace", ex.StackTrace);
                //command.Parameters.AddWithValue("@Sourse", ex.Source);
                //command.Parameters.AddWithValue("@Fecha", DateTime.Now);
                //command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
            }
        }
    }
}