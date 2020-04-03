using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.Model
{
    internal class UsuariosModel
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string login { get; set; }
        public string clave { get; set; }
        public string rol { get; set; }
        public string imagen { get; set; }
        public int condicion { get; set; }
    }
}