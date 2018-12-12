using SDC.BLL.Interfaces;
using System.Collections.Generic;

namespace SDC.BLL.Metodos
{
    public class MProfesor : MDB, IProfesor
    {
        public List<DAL.Sede> ListaSede()
        {
            return sed.ListaSede();
        }

        public void ActualizarProfesor(DATA.Profesor profesor)
        {
            profe.ActualizarProfesor(profesor);
        }

        public void EliminarProfesor(DATA.Profesor profesor)
        {
            profe.EliminarProfesor(profesor);
        }

        public List<DAL.Profesor> ListaProfesor()
        {
            return profe.ListaProfesor();
        }

        public void RegistroProfesor(DATA.Profesor profesor)
        {
            profe.RegistroProfesor(profesor);
        }

        public DATA.Profesor SeleccionarProfesorCedula(int cedula)
        {
            return profe.SeleccionarProfesorCedula(cedula);
        }
    }
}
