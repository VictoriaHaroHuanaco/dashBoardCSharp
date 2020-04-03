using System;

namespace Utilerias
{
    public static class Log
    {
        private static string mensaje = string.Empty;

        /// <summary>
        /// Se guarda el log en la base de datos
        /// </summary>
        /// <param name="ex"></param>
        public static void GuardarError(Exception ex)
        {
            //Que ha sucedido
            mensaje = "Error message: " + ex.Message;

            //Información sobre la excepcion interna
            if (ex.InnerException != null)
            {
                mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
            }

            //Donde ha sucedido
            mensaje = mensaje + " Stack trace: " + ex.StackTrace;

            //Guardar Log

            //TODO crear sp en la base de datos para guardar el log
            //  Log(mensaje);
        }
    }
}