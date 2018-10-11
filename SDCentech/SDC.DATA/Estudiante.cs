using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.DATA
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public string FechaIngreso { get; set; }
        public string CarreraTecnica { get; set; }
        public string FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }
        public string TelefonoMovil { get; set; }
        public string TelefonoDomicilio { get; set; }
        public string CorreoElectronico { get; set; }
        public string ReferenciaPersonal { get; set; }
        public string TelefonoReferencia { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string DomicilioExacto { get; set; }
        public string LugarTrabajo { get; set; }
        public string Cargo { get; set; }
        public string TelefonoTrabajo { get; set; }
        public string DireccionTrabajo { get; set; }
        public string GradoAcademico { get; set; }
        public string Institucion { get; set; }
        public byte Estado { get; set; }
    }
}
