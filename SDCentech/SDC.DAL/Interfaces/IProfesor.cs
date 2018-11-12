using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DATA;

namespace SDC.DAL.Interfaces
{
    public interface IProfesor
    {
        List<DAL.Profesor> ListaProfesor();
        void RegistroProfesor(DATA.Profesor profesor);
        void ActualizarProfesor(DATA.Profesor profesor);
        void EliminarProfesor(DATA.Profesor profesor);
        DATA.Profesor SeleccionarProfesorCedula(int cedula);
        List<DAL.Sede> ListaSede();

    }
}
