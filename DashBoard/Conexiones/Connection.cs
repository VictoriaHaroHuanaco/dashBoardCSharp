using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;

namespace DashBoard.Conexiones
{
    public static class Connection
    {
        /// <summary>
        /// Obtenemos la conexion a la base de datos
        /// </summary>
        /// <param name="baseDatos"></param>
        /// <returns></returns>
        public static SqlConnection getConexion(string baseDatos)
        {
            return Conecction.obtenerConexion(baseDatos);
        }
    }
}