using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DATA;

namespace SDC.BLL.Interfaces
{
    public interface IEstudiante
    {
        List<DAL.Estudiante> ListaEstudiante();
        void RegistroEstudiante(Estudiante estudiante);
        void ActualizarEstudiante(DATA.Estudiante estudiante);
        void EliminarEstudiante(DATA.Estudiante estudiante);
        DATA.Estudiante SeleccionarEstudianteCedula(int cedula);
        List<DAL.Sede> ListaSede();
    }
}
