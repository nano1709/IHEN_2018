using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using SDC.DATA;

namespace SDC.BLL.Metodos
{
    public class MEstudiante : MDB, IEstudiante
    {
        public List<DAL.Sede> ListaSede()
        {
            return sed.ListaSede();
        }

        public List<DAL.Estudiante> ListaEstudiante()
        {
            return estu.ListaEstudiante();
        }

        public void RegistroEstudiante(Estudiante estudiante)
        {
            estu.RegistroEstudiante(estudiante);
        }

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            estu.ActualizarEstudiante(estudiante);
        }

        public void EliminarEstudiante(Estudiante estudiante)
        {
            estu.EliminarEstudiante(estudiante);
        }

        public DATA.Estudiante SeleccionarEstudianteCedula(int cedula)
        {
            return estu.SeleccionarEstudianteCedula(cedula);
        }
    }
}
