using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.DATA
{
    public class Usuario
    {
        public int NombreUsuario { get; set; }
        public int Rol { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string code { get; set; }
        public Boolean Estado { get; set; }
    }
}
