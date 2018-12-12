using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.DATA
{
    public class Curso
    {
        public string NombreCurso { get; set; }
        public string CodigoCurso { get; set; }
        public string Duracion { get; set; }
        public string ObjetivoCurso { get; set; }
        public string MaterialDidactico { get; set; }
        public string Certificacion { get; set; }
        public string Inversion { get; set; }
        public Boolean Estado { get; set; }
        public string Metodologia { get; set; }
        public int IdSede { get; set; }
    }
}
