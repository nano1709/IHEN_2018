using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DATA;

namespace SDC.DAL.Interfaces
{
    public interface IEstudiante
    {
        List<DAL.Estudiante> ListaEstudiante();
        void RegistroEstudiante(DATA.Estudiante estudiante);
        void ActualizarEstudiante(DATA.Estudiante estudiante);
        void EliminarEstudiante(DATA.Estudiante estudiante);
        DATA.Estudiante SeleccionarEstudianteCedula(int cedula);
        List<DAL.Sede> ListaSede();
    }
}
